﻿using System;
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
            string[] categories = Common.GetCategoryList(Common.Path);
            if (this.Controls != null)
            {
                string[] newList = new string[0];
                Panel panel = (Panel)this.Controls["pnDelCat"];
                if (pnDelCat != null)
                {
                    for (int i = 0; i < categories.Length; i++)
                    {
                        CheckBox chBox = ((CheckBox)panel.Controls[categories[i]]);

                        if (chBox != null && chBox.Checked == false)
                        {
                            string[] newAddList = new string[newList.Length + 1];
                            newAddList[newAddList.Length - 1] = chBox.Name;
                            for (int x = 0; x < newList.Length; x++)
                            {
                                newAddList[x] = newList[x];
                            }
                            newList = newAddList;
                        }
                    }
                }
                Common.SetCategoryList(newList, Common.Path);
                Common.RenderCheckBox(pnDelCat);
                ((Start)Application.OpenForms["Start"]).Otrisovwik(newList);
                ((DateObserver)Application.OpenForms["DateObserver"]).Otrisovwik(newList);
                
            }
        }
    }
}
