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

namespace k_r.view
{
    public partial class addCoursForm : Form
    {
        Model1 db = new Model1();
        Сourses courses = new Сourses();
        public addCoursForm()
        {
            InitializeComponent();
        }

        private void addCoursForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            courses.Название = названиеTextBox.Text;
            courses.Длительность = длительностьКурсаTextBox.Text;
            courses.Цена = стоимостьTextBox.Text;
            

            DatabaseContext.db.Сourses.Add(courses);

            try
            {
                DatabaseContext.db.SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (System.Data.Entity.Validation.DbEntityValidationResult validationError in ex.EntityValidationErrors)

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
            this.Hide();
        }
    }
}
