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

namespace k_r
{
    public partial class GroupUC1 : UserControl
    {
        public GroupUC1()
        {
            InitializeComponent();
        }

        public void GenerateDataToGroupUC1Card(Groups group)
        {
            label1.Text = group.ID_Группы.ToString();
            label2.Text = group.Название;
            label3.Text = group.КолисествоСлушателей.ToString();
            
         
        }

        

        private void GroupUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
