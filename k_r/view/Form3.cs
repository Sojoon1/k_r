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

namespace k_r
{
    public partial class SlushForms : Form
    {
        Model1 db = new Model1();
        public SlushForms()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AutotizationsForms f1 = new AutotizationsForms();

            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCoursForm f1 = new MyCoursForm();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoursForm cou = new CoursForm();
            cou.Show();
            this.Hide();
        }
    }
}
