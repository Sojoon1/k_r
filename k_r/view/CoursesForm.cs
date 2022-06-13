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
using k_r.EF;


namespace k_r.view
{
    
    public partial class CoursesForm : Form
    {

        Model1 db = new Model1();
        public List<Сourses> cours = new List<Сourses>(DatabaseContext.db.Сourses);

        public static List<UserControl> coursUC = new List<UserControl>();
        public CoursesForm()
        {
            InitializeComponent();
            GenerateCoursesUCcsCardList(cours);
        }

        private void GenerateCoursesUCcsCardList(List<Сourses> cours)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerForm manager = new ManagerForm();
            manager.Show();
            this.Hide();
        }
    }
}
