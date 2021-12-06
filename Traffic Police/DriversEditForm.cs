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
    public partial class DriversEditForm : Form
    {
        public Model1 db { get; set; }
        public Drivers dv { get; set; } = null;
        public DriversEditForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(181, 213, 202);
            LeaveButton.BackColor = Color.FromArgb(224, 169, 175);
        }

        private void DriversEditForm_Load(object sender, EventArgs e)
        {
            if (dv == null)
            {
                driversBindingSource.AddNew();
                this.Text = "Добавление новой записи";
            }
            else
            {
                driversBindingSource.Add(dv);
                iDTextBox.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dv == null)
            {
                dv = (Drivers)driversBindingSource.Current;
                db.Drivers.Add(dv);
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }
        }

    }
}
