using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace kalendar_with_marks
{
    public partial class DeleteCat : Form
    {
        public DeleteCat()
        {
            InitializeComponent();
            Common.RenderCheckBox(pnDelCat);
        }

        private void btnDelCat_Click(object sender, EventArgs e)
        {
            List<string> categories = Common.GetCategoryList(Common.Path);
        
            if (categories != null)
            {
                //List<string> newList = new List<string>();
                //for (int i = 0; i < categories.Count; i++)
                //{
                //    Panel panel = (Panel)this.Controls["pnDelCat"];
                //    if (panel != null)
                //    {
                //        CheckBox chBox = ((CheckBox)panel.Controls[categories[i]]);
                //        if (chBox != null)
                //        {
                //            if (chBox.Checked == false)
                //            {
                //                List<string> newAddList = new List<string>();
                //                newAddList.Add(chBox.Name);
                //                for (int x = 0; x < newList.Count; x++)
                //                {
                //                    newAddList[x] = newList[x];
                //                }
                //                newList = newAddList;
                //            }
                //        }
                //    }
                //}

                List<string> newList = new List<string>();
                Panel panel = (Panel)this.Controls["pnDelCat"];
                if (panel != null)
                {
                    foreach (string categoryItem in categories)
                    {
                        CheckBox chBox = (CheckBox)panel.Controls[categoryItem];
                        if (chBox != null)
                        {
                            if (!chBox.Checked)
                                newList.Add(chBox.Name);
                        }
                    }
                }
                Common.SetCategoryList(newList, Common.Path);
                Common.RenderCheckBox(pnDelCat);
                ((Start)Application.OpenForms["Start"]).Otrisovwik(newList);
            }
        }
    }
}
