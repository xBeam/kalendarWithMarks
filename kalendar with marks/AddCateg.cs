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
            
            string[] categories = Common.GetCategoryList(Common.Path);
            if (categories != null)
            {
                string[] addCateg = new string[categories.Length + 1];
                for (int i = 0; i < categories.Length; i++)
                {
                    addCateg[i] = categories[i];
                }
                addCateg[addCateg.Length - 1] = tbNameCateg.Text;

                Common.SetCategoryList(addCateg, Common.Path);
                ((Start)Application.OpenForms["Start"]).Otrisovwik(addCateg);
                this.Close();
            }
        }
    }
}
