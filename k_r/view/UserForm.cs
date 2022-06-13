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
    public partial class UserForm : Form
    {
        Model1 db = new Model1();
        Users us = new Users();

        public List<Users> use = new List<Users>(DatabaseContext.db.Users);
        public static List<UserControl> usUC = new List<UserControl>();
        public UserForm()
        {
            InitializeComponent();
            GenerateUserUCCardList(use);
        }

        private void GenerateUserUCCardList(List<Users> use)
        {
            foreach (var a in use)
            {

                UserUC card = new UserUC();
                card.GenerateDataToUserUCCard(a);
                flowLayoutPanel1.Controls.Add(card);

                //card.Click += new System.EventHandler(this.Card_Click);
                card.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }
        private void Card_DoubleClick(object sender, EventArgs e)
        {
            EddDelF eddDel = new EddDelF();
            eddDel.Show();
            this.Hide();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void UserForm_Load(object sender, EventArgs e)
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
