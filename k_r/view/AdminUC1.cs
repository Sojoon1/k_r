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
using k_r.EF;

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
            label2.Text = lst.Фамилия;
            label3.Text = lst.Имя;
            label4.Text = lst.Отчество;
            label5.Text = lst.ДатаРождения;
            label6.Text = lst.Телефон;
            label7.Text = lst.Почта;
           

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
