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

namespace k_r
{
    public partial class GroupForm : Form
    {
        Model1 db = new Model1();
        public List<Group> group = new List<Group>(DatabaseContext.db.Groups);
        public static List<UserControl> selUC = new List<UserControl>();
        public GroupForm()
        {
            InitializeComponent();
            GenerateGroupUC1CardList(group);
        }

        private void GenerateGroupUC1CardList(List<Group> group)
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
            MedForms f2 = new MedForms();
            f2.Show();
            this.Hide();
        }
    }
}
