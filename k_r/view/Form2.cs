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

namespace k_r
{
    public partial class MedForms : Form
    {
        Model1 db = new Model1();
        Listener lst2 = new Listener();
        public List<Listener> lst = new List<Listener>(DatabaseContext.db.Listener);
        public static List<UserControl> selUC = new List<UserControl>();
        public MedForms()
        {
            InitializeComponent();
            GenerateAdminUC1CardList(lst);
        }
        private void GenerateAdminUC1CardList(List<Listener> lst)
        {
            foreach (var a in lst )
            {

                AdminUC1 card = new AdminUC1();
                card.GenerateDataToAdminUC1Card(a);
                flowLayoutPanel1.Controls.Add(card);

                
                card.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {

        }
        private void Card_DoubleClick(object sender, EventArgs e)
        {
            EddDelF eddDel = new EddDelF();
            eddDel.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            RaspisForms f4 = new RaspisForms();

            f4.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listenerBindingSource.DataSource = db.Listener.ToList();
            
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
            AddForm  addfrm =new AddForm();
            addfrm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //AddForm add = new AddForm();
            //add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listener lich = (Listener)listenerBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить данные? " + lich.ID.ToString(),
                "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Listener.Remove(lich);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                listenerBindingSource.DataSource = db.Listener.ToList();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            GroupForm groupF= new GroupForm();

            groupF.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
