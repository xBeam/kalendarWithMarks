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
        //public const string Path = "F:\\C#files\\Categories.txt";
        public static readonly string DirectoryPath = Application.StartupPath;
        public static readonly string Path = string.Format("{0}\\{1}", DirectoryPath, "Categories.txt");
        //считывает файл категорий в массив
        public static List<string> GetCategoryList(string path)
        {
            List<string> categories = null;
            string info = string.Empty;
            DirectoryInfo di = new DirectoryInfo(DirectoryPath);
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
            {
                string[] tempCategories = info.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                categories = tempCategories.ToList<string>();
            }
            else
                categories = new List<string>();
            return categories;
        }
        //Записывает категории из массива в строку, а потом в файл
        public static void SetCategoryList(List<string> categories, string path)
        {
            if (categories != null && categories.Count > 0)
            {
                string categoriesInLine = string.Empty;
                //for (int i = 0; i < categories.Count; i++)
                //{
                //    categoriesInLine += categories[i] + ";";
                //}

                foreach (string categoryItem in categories)
                {
                    categoriesInLine += categoryItem + ";";
                    //categoriesInLine = string.Format("{0};{1}", categoriesInLine, categoryItem);
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

        public static void RenderFromFile(List<string> categories, Panel pnCategories)
        {
            int yStep = 25;
            int xPrimaryLocation = 10;
            int yPrimaryLocation = 10;

            if (categories != null && categories.Count > 0)
            {
                if (pnCategories != null)
                    pnCategories.Controls.Clear();

                for (int i = 0; i < categories.Count; i++)
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
            List<string> categories = Common.GetCategoryList(Common.Path);
            int yStep = 25;
            int xPrimaryLocation = 10;
            int yPrimaryLocation = 10;

            if (categories != null && categories.Count > 0)
            {
                if (pnDelCat != null)
                {
                    pnDelCat.Controls.Clear();
                }
                for (int i = 0; i < categories.Count; i++)
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

        public static void RenderCheckBoxesWithValues(Panel pnCategories, Dictionary<string, bool> checkBoxValueList)
        {
            int yStep = 25;
            int xPrimaryLocation = 10;
            int yPrimaryLocation = 10;

            if (checkBoxValueList != null && checkBoxValueList.Count > 0)
            {
                if (pnCategories != null)
                    pnCategories.Controls.Clear();

                int rowNumber = 1;
                foreach (var checkBoxValue in checkBoxValueList)
                {
                    CheckBox chb = new CheckBox();
                    chb.Name = checkBoxValue.Key;
                    chb.Text = string.Format("{0}. {1}", rowNumber.ToString(), checkBoxValue.Key);
                    chb.Width = checkBoxValue.Key.Length * 20;
                    chb.Location = new Point(xPrimaryLocation, yPrimaryLocation);
                    chb.Checked = checkBoxValue.Value;
                    yPrimaryLocation += yStep;

                    pnCategories.Controls.Add(chb);
                    pnCategories.Refresh();
                    rowNumber++;
                }
            }
        }
    }
}
