using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace kalendar_with_marks
{
    public partial class Start : Form
    {         
        public Start()
        {
            InitializeComponent();
            DateObserver dateObserver = new DateObserver();
            dateObserver.Show();
            dateObserver.Visible = false;
            string[] categories = Common.GetCategoryList(Common.Path);
            Common.RenderFromFile(categories, pnCategories);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.Visible = false;
            DateObserver dateObs = (DateObserver)Application.OpenForms["DateObserver"];
            dateObs.Visible = true;
<<<<<<< HEAD
            //dateObs.RenderTasks(e.End);
            //ablac
=======
            dateObs.RenderTasks(e.End);
>>>>>>> origin/master
        }

        private void btnAddCateg_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            AddCateg addCateg = new AddCateg();
            addCateg.Show();
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            DeleteCat delCat = new DeleteCat();
            delCat.Show();
        }

        public void Otrisovwik(string[] risCat)
        {
            Panel pn = ((Panel)this.Controls["pnCategories"]);
            Common.RenderFromFile(risCat, pn);
            pnCategories.Refresh();
        }
    }
}
