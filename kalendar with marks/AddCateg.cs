using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalendar_with_marks
{
    public partial class AddCateg : Form
    {
        public AddCateg()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNameCateg.Text))
                this.Close();
            
            List<string> categories = Common.GetCategoryList(Common.Path);
            if (categories != null)
            {
                //List<string> addCateg = new List<string>(categories.Count + 1);
                //for (int i = 0; i < categories.Count; i++)
                //{
                //    addCateg[i] = categories[i];
                //}
                //addCateg.Add(tbNameCateg.Text);

                categories.Add(tbNameCateg.Text);

                Common.SetCategoryList(categories, Common.Path);
                ((Start)Application.OpenForms["Start"]).Otrisovwik(categories);
                this.Close();
            }
        }
    }
}
