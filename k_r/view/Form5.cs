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

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            //listener.ID_Группа= iD_ГруппаComboBox.SelectedIndex+1;
            //listener.ID_Роль=iD_РольComboBox.SelectedIndex+1;
            
            //listener.ДатаРождения = датаРожденияDateTimePicker.Text;
            //listener.Курс = курсComboBox.Text;
            //listener.Почта = почтаTextBox.Text;
            //listener.Телефон = телефонTextBox.Text;
            //listener.ФИО = фИОTextBox.Text;

            DatabaseContext.db.Listener.Add(listener);

            try
            {
                DatabaseContext.db.SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
               foreach(System.Data.Entity.Validation.DbEntityValidationResult validationError in ex.EntityValidationErrors)
                    
                {
                    MessageBox.Show("Object: " + validationError.Entry.Entity.ToString());
                    MessageBox.Show(" ");
                    foreach (System.Data.Entity.Validation.DbValidationError err in validationError.ValidationErrors)
                    {
                        MessageBox.Show(err.ErrorMessage + " ");
                    }
                }
                //MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
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
            //    photoPictureBox.Image = Image.FromFile(file);
                
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
