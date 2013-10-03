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
    public partial class DateObserver : Form
    {
        //конструктор
        public DateObserver()           
        {
            InitializeComponent();
            Common.RenderCheckBox(pnCategories);
        }

        //поле с выбранной датой
        public DateTime ChosenDate { get; set; }        

        //путь к файлу
        public string Path { get; set; }        

        //действие при сохранении
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }

            Panel panel = (Panel)this.Controls["pnCategories"];
            if (panel != null)
            {
                List<string> categories = Common.GetCategoryList(Common.Path);
                if (categories != null)
                {
                    using (FileStream fs = File.Create(Path))
                    {
                        foreach (string categoryItem in categories)
                        {
                            CheckBox chBox = (CheckBox)panel.Controls[categoryItem];
                            if (chBox != null)
                                AddText(fs, string.Format("{0}+{1};", categoryItem, chBox.Checked.ToString()));
                        }
                    }

                }
                MessageBox.Show("Успешно сохранено", "Сохранение...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }      

        /// <summary>
        /// считывание информации по дате и ее отображение
        /// </summary>
        /// <param name="chosenDate"></param>
        public void RenderTasks(DateTime chosenDate)
        {
            ChosenDate = chosenDate;
            lblDate.Text = ChosenDate.ToShortDateString();
            Path = string.Format(@"f:\C#files\KalendarSaved{0}.txt", ChosenDate.ToShortDateString());
            Dictionary<string, bool> checkBoxesValues = null;
            if (File.Exists(Path))
            {
                using (FileStream rd = new FileStream(Path, FileMode.Open))
                {
                    checkBoxesValues = Reader(rd);
                    if (checkBoxesValues != null)
                        Common.RenderCheckBoxesWithValues(pnCategories, checkBoxesValues);
                }
            }
            else
                Common.RenderCheckBox(pnCategories);
        }               

        //считывает файл и возвращает массив со значениями
        private static Dictionary<string, bool> Reader(FileStream fs)
        {
            string tasks = string.Empty;
            Dictionary<string, bool> chbValues = new Dictionary<string, bool>();
            using (fs)
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    tasks = sr.ReadToEnd();
                }

                string[] taskArray = tasks.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < taskArray.Length; i++)
                {
                    string[] keyValuePair = taskArray[i].Split('+');
                    if (keyValuePair != null && keyValuePair.Length == 2)
                        chbValues[keyValuePair[0]] = bool.Parse(keyValuePair[1]);
                }

                return chbValues;
            }
        }           

        //добавление текста в файл
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }                       

        //возвращает на первую форму
        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms["DateObserver"].Visible = false;
            Application.OpenForms["Start"].Visible = true;
        }

    }
}

