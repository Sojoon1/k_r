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
    public partial class AddForm : Form
    {
        public Model1 db { get; set; }
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "") 
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }
            Listener lich = new Listener();
            lich.ID = Convert.ToInt32(textBox1.Text);
            lich.ФИО = textBox2.Text;
            lich.Курс = Convert.ToInt32(textBox3.Text);
            lich.ID_Группа = Convert.ToInt32(textBox4.Text);
            lich.ID_Роль = Convert.ToInt32(textBox5.Text);


            db.Listeners.Add(lich);
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
