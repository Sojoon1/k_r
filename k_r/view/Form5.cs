using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using k_r.view;

namespace k_r
{
    public partial class AddForm : Form
    {
        Model1 db = new Model1();
        Listener listener = new Listener();
        

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            //listenerBindingSource.DataSource = DatabaseContext.db.Listeners.ToList();
            //foreach (Tovar a in SkladFrm.selectedUC)
            //{
            //    listener = DatabaseContext.db.Listeners.First(x => x.Title == a.TitleLbl.Text);
            //    skladBindingSource.DataSource = sklad;
            //    pictureBox1.ImageLocation = .Photo;
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseContext.db.Listeners.Add(listener);
            try
            {
                DatabaseContext.db.SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
            //if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "") 
            //{
            //    MessageBox.Show("Не все поля заполнены!");
            //    return;
            //}
            //Listener lich = new Listener();
            //lich.ID = Convert.ToInt32(textBox1.Text);
            //lich.ФИО = textBox2.Text;
            //lich.Курс = Convert.ToInt32(textBox3.Text);
            //lich.ID_Группа = Convert.ToInt32(textBox4.Text);
            //lich.ID_Роль = Convert.ToInt32(textBox5.Text);


            //db.Listeners.Add(lich);
            //db.SaveChanges();
            //DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.CurrentDirectory + @"\pic\";


            //DialogResult dialogresult = openFileDialog.ShowDialog();

            //if (dialogresult == DialogResult.OK)
            //{
            //    string file = openFileDialog.FileName;
            //    int num = file.IndexOf("pic");
            //    file = file.Substring(num);
            //    pictureBox1.Image = Image.FromFile(file);
            //    sklad.Photo = file;
            //}
        }
    }
}
