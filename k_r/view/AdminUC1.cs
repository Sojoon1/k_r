using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k_r.view;

namespace k_r.view
{
    public partial class AdminUC1 : UserControl
    {
        
        public AdminUC1()
        {
            InitializeComponent();
        }
        public void GenerateDataToAdminUC1Card(Listener lst)
        {

            label1.Text = lst.ID.ToString();
            label2.Text = lst.ФИО;
            label3.Text = lst.Курс.ToString();
            label4.Text = lst.ID_Группа.ToString();
            label5.Text = lst.ID_Роль.ToString();

        }
        public void AdminUC1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
