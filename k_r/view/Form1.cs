using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_r
{
    public partial class AutotizationsForms : Form
    {
        public static Autotization UFN { get; set; }
        public static AutotizationsForms ATH { get; set; }

        Model1 db = new Model1();
        public AutotizationsForms()
        {
            InitializeComponent();

            

        }

        private void pictureBoxGlaz_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            { textBoxPassword.UseSystemPasswordChar = true; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(label5.Text))
            //    label5.Text = "Введите значение";
            //else
            //    label5.Text = "";
            //if (string.IsNullOrWhiteSpace(label6.Text))
            //    label6.Text = "Введите значение";
            //else
            //    label6.Text = "";
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            Autotization UsersFind = db.Autotizations.Find(textBoxLogin.Text);
            if ((UsersFind != null) && (UsersFind.Пароль == textBoxPassword.Text))
            {
                UFN = UsersFind;
                ATH = this;
                if (UFN.User.ID_Роль == 1)
                {
                    SlushForms f3 = new SlushForms();
                    f3.Show();
                    this.Hide();
                }
                else if (UFN.User.ID_Роль == 2)
                {
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Show();
                    this.Hide();
                }
                else if (UFN.User.ID_Роль == 3)
                {
                    adminForms adm = new adminForms();
                    adm.Show();
                    this.Hide();

                }
            }
            
        }
        //Application.Exit();
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
