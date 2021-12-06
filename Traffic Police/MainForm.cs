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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(181, 213, 202);
            DriversButton.BackColor = Color.FromArgb(255, 252, 214);
            LeaveButton.BackColor = Color.FromArgb(224, 169, 175);
            panel1.BackColor = Color.FromArgb(209, 238, 252);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        { 
            DriversForm frm = new DriversForm();
            frm.Show();
            this.Hide();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            Autharizathion frm = new Autharizathion();
            frm.Show();
            this.Hide();
        }
    }
}
