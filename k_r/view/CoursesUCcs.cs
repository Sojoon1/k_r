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
using k_r.view;

namespace k_r.view
{
    public partial class CoursesUCcs : UserControl
    {
        public CoursesUCcs()
        {
            InitializeComponent();
        }

        public void GenerateDataToCoursesUCcsCard(Сourses cours)
        {

            label1.Text = cours.ID.ToString();
            label2.Text = cours.Название;
            label3.Text = cours.Длительность;
            label4.Text = cours.Цена;
        }
            private void CoursesUCcs_Load(object sender, EventArgs e)
        {

        }
    }
}
