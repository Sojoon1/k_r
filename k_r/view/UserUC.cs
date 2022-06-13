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
    public partial class UserUC : UserControl
    {
        public UserUC()
        {
            InitializeComponent();
        }

        public void GenerateDataToUserUCCard(Users use)
        {

            label1.Text = use.ID_User.ToString();
            label2.Text = use.Фамилия;
            label3.Text = use.Имя;
            label4.Text = use.Отчество;
            label5.Text = use.ID_Role.ToString();
            label6.Text = use.ДатаРождения;
            label7.Text = use.Телефон;
            label8.Text = use.Почта;
            label9.Text = use.Логин;
            label10.Text = use.Пароль;
           

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
