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
using k_r.view;

namespace k_r.view
{
    public partial class CoursForm : Form
    {
        Model1 db = new Model1();
        public CoursForm()
        {
            InitializeComponent();
        }

        private void CoursForm_Load(object sender, EventArgs e)
        {
            coursesBindingSource.DataSource = db.Сourses.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerForm manager = new ManagerForm();
            manager.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCoursForm addCours = new addCoursForm();
            addCours.ShowDialog();
        }
    }
}
