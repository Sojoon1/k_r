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

namespace k_r
{
    public partial class RaspisForms : Form
    {
        Model1 db = new Model1();
        public RaspisForms()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            scheduleBindingSource.DataSource = db.Schedule.ToList();
            groupBindingSource.DataSource = db.Groups.ToList();
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

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ManagerForm manager = new ManagerForm();
            manager.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
