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
    public partial class MyCoursForm : Form
    {
        Model1 db = new Model1();
        public MyCoursForm()
        {
            InitializeComponent();
        }

        private void MyCoursForm_Load(object sender, EventArgs e)
        {
            listenerBindingSource.DataSource = db.Listener.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            SlushForms slr = new SlushForms();
            slr.Show();
            this.Hide();
        }
    }
}
