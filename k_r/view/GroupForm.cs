using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k_r;
using k_r.EF;
using k_r.view;

namespace k_r
{
    public partial class GroupForm : Form
    {
        Model1 db = new Model1();
        public List<Groups> group = new List<Groups>(DatabaseContext.db.Groups);
        public static List<UserControl> selUC = new List<UserControl>();
        public GroupForm()
        {
            InitializeComponent();
            GenerateGroupUC1CardList(group);
        }

        private void GenerateGroupUC1CardList(List<Groups> group)
        {
            foreach (var a in group)
            {

                GroupUC1 card = new GroupUC1();
                card.GenerateDataToGroupUC1Card(a);
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
        private void GroupForm_Load(object sender, EventArgs e)
        {

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
            addGroupForm addGroup = new addGroupForm();
            addGroup.ShowDialog();
        }
    }
}
