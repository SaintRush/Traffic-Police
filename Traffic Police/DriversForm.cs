using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Police
{
    public partial class DriversForm : Form
    {
        Model1 db = new Model1();
        public DriversForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(181, 213, 202);
            LeaveButton.BackColor = Color.FromArgb(224, 169, 175);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DriversEditForm frm = new DriversEditForm();
            frm.db = db;
            frm.dv = null;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                driversBindingSource.DataSource = null;
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Drivers dv = (Drivers)driversBindingSource.Current;
            DriversEditForm frm = new DriversEditForm();
            frm.db = db;
            frm.dv = dv;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                driversBindingSource.DataSource = null;
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Drivers dv = (Drivers)driversBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить " + dv.LastName + " " + dv.FirstName + " " + dv.MiddleName + "?", "Удаление",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Drivers.Remove(dv);
                try
                {
                    db.SaveChanges();
                    driversBindingSource.DataSource = db.Drivers.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = db.Drivers.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void driversDataGridView_CursorChanged(object sender, EventArgs e)
        {
            Drivers drivers = (Drivers)driversBindingSource.Current;
            try
            {
                if (drivers == null) return;
                if (drivers.Photo != "")
                {
                    string str = drivers.Photo.Substring(1);
                    pictureBox1.Image = Image.FromFile(str);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("image\\picture.png");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
