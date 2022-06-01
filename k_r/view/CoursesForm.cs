using k_r.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace k_r.view
{
    
    public partial class CoursesForm : Form
    {

        Model1 db = new Model1();
        public List<Cours> cours = new List<Cours>(DatabaseContext.db.Courses);

        public static List<UserControl> coursUC = new List<UserControl>();
        public CoursesForm()
        {
            InitializeComponent();
            GenerateCoursesUCcsCardList(cours);
        }

        private void GenerateCoursesUCcsCardList(List<Cours> cours)
        {
            foreach (var a in cours)
            {

                CoursesUCcs card = new CoursesUCcs();
                card.GenerateDataToCoursesUCcsCard(a);
                flowLayoutPanel1.Controls.Add(card);

                card.Click += new System.EventHandler(this.Card_Click);
                card.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {

        }
        private void Card_DoubleClick(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
