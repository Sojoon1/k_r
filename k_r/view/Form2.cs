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

namespace k_r
{
    public partial class MedForms : Form
    {
        Model1 db = new Model1();
        public List<Listener> lst = new List<Listener>(DatabaseContext.db.Listeners);
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

                card.Click += new System.EventHandler(this.Card_Click);
                card.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {

        }
        private void Card_DoubleClick(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            RaspisForms f4 = new RaspisForms();

            f4.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listenerBindingSource.DataSource = db.Listeners.ToList();
            
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
            AddForm add = new AddForm();
            add.db = db;
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                listenerBindingSource.DataSource = db.Listeners.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm f5 = new AddForm();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listener lich = (Listener)listenerBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить данные? " + lich.ID.ToString(),
                "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Listeners.Remove(lich);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                listenerBindingSource.DataSource = db.Listeners.ToList();
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
