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

            using (FileStream fs = File.Create(Path))
            {
                AddText(fs, "1 - " + chbPhysEx.Checked.ToString());
                AddText(fs, "\n2 - " + chbClean.Checked.ToString());
                AddText(fs, "\n3 - " + chbProg.Checked.ToString());
                AddText(fs, "\n4 - " + chbMeal.Checked.ToString());
                AddText(fs, "\n5 - " + chbGame.Checked.ToString());
                AddText(fs, "\n6 - " + chbEng.Checked.ToString());
            }
            MessageBox.Show("Успешно сохранено", "Сохранение...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string[] values = null;
            if (File.Exists(Path))
            {
                using (FileStream rd = new FileStream(Path, FileMode.Open))
                {
                    values = Reader(rd);

                    chbPhysEx.Checked = bool.Parse(values[0]);
                    chbClean.Checked = bool.Parse(values[1]);
                    chbProg.Checked = bool.Parse(values[2]);
                    chbMeal.Checked = bool.Parse(values[3]);
                    chbGame.Checked = bool.Parse(values[4]);
                    chbEng.Checked = bool.Parse(values[5]);
                }
            }
            else
            {
                chbPhysEx.Checked = false;
                chbClean.Checked = false;
                chbProg.Checked = false;
                chbGame.Checked = false;
                chbEng.Checked = false;
                chbMeal.Checked = false;
            }
        }               

        //считывает файл и возвращает массив со значениями
        private static string[] Reader(FileStream fs)
        {
            string tasks = string.Empty;
            using (fs)
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    tasks = sr.ReadToEnd();
                }
                string[] taskARRAY = tasks.Split('\n');
                for (int i = 0; i < taskARRAY.Length; i++)
                {
                    taskARRAY[i] = taskARRAY[i].Substring(taskARRAY[i].IndexOf('-') + 1).Trim();
                }
                return taskARRAY;
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

