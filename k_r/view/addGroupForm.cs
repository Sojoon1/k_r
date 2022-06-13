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

namespace k_r.view
{
    public partial class addGroupForm : Form
    {
        Model1 db = new Model1();
        Groups group = new Groups();
        public addGroupForm()
        {
            InitializeComponent();
        }

        private void addGroupForm_Load(object sender, EventArgs e)
        {
            scheduleBindingSource.DataSource = db.Schedule.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            group.ID_Расписания = iD_РасписанияComboBox.SelectedIndex + 1;
            group.КолисествоСлушателей = количествоСлушателейTextBox.Text;
            group.Название = названиеГруппыTextBox.Text;
           


            DatabaseContext.db.Groups.Add(group);

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
