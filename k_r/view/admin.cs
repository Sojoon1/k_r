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
    public partial class adminForms : Form
    {
        Model1 db = new Model1();
        public adminForms()
        {
            InitializeComponent();
        }

        private void butListener_Click_Click(object sender, EventArgs e)
        {
            MedForms listener = new MedForms();
            listener.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupForm groupF = new GroupForm();
            groupF.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RaspisForms f4 = new RaspisForms();
            f4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserForm usF = new UserForm();
            usF.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CoursForm cou = new CoursForm();
            cou.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AuForm auf = new AuForm();
            auf.Show();
            this.Hide();
        }
    }
}
