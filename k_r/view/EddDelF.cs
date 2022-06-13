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
    public partial class EddDelF : Form
    {
        public EddDelF()
        {
            InitializeComponent();
        }

        private void EddDelF_Load(object sender, EventArgs e)
        {
            listenerBindingSource.DataSource = DatabaseContext.db.Listener.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listener usr = (Listener)listenerBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить учетную запись" + usr.ID + "?", "Удаление учетной записи", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DatabaseContext.db.Listener.Remove(usr);
                try
                {
                    DatabaseContext.db.SaveChanges();
                    MessageBox.Show("Данные о пользователе удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
