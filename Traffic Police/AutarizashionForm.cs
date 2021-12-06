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
    public partial class Autharizathion : Form
    {
        Model1 db = new Model1();
        public static Users USER { get; set; }
        public static Autharizathion FORMA { get; set; }
        public Autharizathion()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(181, 213, 202);
            LoginButton.BackColor = Color.FromArgb(255, 252, 214);
            LeaveButton.BackColor = Color.FromArgb(224, 169, 175);
            panel1.BackColor = Color.FromArgb(209, 238, 252);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " || textBox2.Text == " ")
            {
                MessageBox.Show(" Нужно задать логин и пароль! ");
                return;
            }

            Users usr = db.Users.Find(textBox1.Text);

            if ((usr != null) && (usr.password == textBox2.Text))
            {
                USER = usr;
                FORMA = this;
                if (usr.role == "Inspector ")
                {
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(" Пользователя с таким логином и паролем нет! ");
                return;
            }
        }
    }
}
