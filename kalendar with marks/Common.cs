using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace kalendar_with_marks
{
    public static class Common
    {
        public const string Path = "D:\\C#files\\Categories.txt";
        //считывает файл категорий в массив
        public static string[] GetCategoryList(string path)
        {
            string[] categories = null;
            string info = string.Empty;
            DirectoryInfo di = new DirectoryInfo("D:\\C#files");
            if (!di.Exists)
                di.Create();

            FileInfo fi = new FileInfo(path);
            if (!fi.Exists)
                fi.Create();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    info = sr.ReadToEnd();
                }
            }
            if (!string.IsNullOrEmpty(info))
                categories = info.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            else
                categories = new string[0];
            return categories;
        }
        //Записывает категории из массива в строку, а потом в файл
        public static void SetCategoryList(string[] categories, string path)
        {
            if (categories != null && categories.Length > 0)
            {
                string categoriesInLine = string.Empty;
                for (int i = 0; i < categories.Length; i++)
                {
                    categoriesInLine += categories[i] + ";";
                }
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(categoriesInLine);
                    }
                }
            }
        }

        public static void RenderFromFile(string[] categories, Panel pnCategories)
        {
            int yStep = 25;
            int xPrimaryLocation = 10;
            int yPrimaryLocation = 10;

            if (categories != null && categories.Length > 0)
            {
                if (pnCategories != null)
                    pnCategories.Controls.Clear();

                for (int i = 0; i < categories.Length; i++)
                {
                    Label lb = new Label();
                    lb.Name = categories[i];
                    lb.Text = string.Format("{0}. {1}", (i + 1).ToString(), categories[i]);
                    lb.Width = categories[i].Length * 20;
                    lb.Location = new Point(xPrimaryLocation, yPrimaryLocation);
                    yPrimaryLocation += yStep;

                    pnCategories.Controls.Add(lb);
                }
            }
        }

        public static void RenderCheckBox(Panel pnDelCat)
        {
            string[] categories = Common.GetCategoryList(Common.Path);
            int yStep = 25;
            int xPrimaryLocation = 10;
            int yPrimaryLocation = 10;

            if (categories != null && categories.Length > 0)
            {
                if (pnDelCat != null)
                {
                    pnDelCat.Controls.Clear();
                }
                for (int i = 0; i < categories.Length; i++)
                {
                    CheckBox chb = new CheckBox();
                    chb.Name = categories[i];
                    chb.Text = string.Format("{0}. {1}", (i + 1).ToString(), categories[i]);
                    chb.Width = categories[i].Length * 20;
                    chb.Location = new Point(xPrimaryLocation, yPrimaryLocation);
                    yPrimaryLocation += yStep;

                    pnDelCat.Controls.Add(chb);
                    pnDelCat.Refresh();
                }
            }
        }
    }
}
