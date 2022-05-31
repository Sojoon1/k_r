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
    public partial class GroupUC1 : UserControl
    {
        public GroupUC1()
        {
            InitializeComponent();
        }

        public void GenerateDataToGroupUC1Card(Group group)
        {
            label1.Text = group.ID.ToString();
            label2.Text = group.НазваниеГруппы;
            label3.Text = group.КоличествоСлушателей;
            label4.Text = group.Преподаватель;
            label5.Text = group.ID_Курса.ToString();
            label6.Text = group.Кабинет.ToString();
            label7.Text = group.ID_Расписания.ToString();
        }

        

        private void GroupUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
