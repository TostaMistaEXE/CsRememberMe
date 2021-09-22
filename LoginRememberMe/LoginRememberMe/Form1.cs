using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRememberMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_user.Text = Properties.Settings.Default.User;
            tb_password.Text = Properties.Settings.Default.Password;
            if(Properties.Settings.Default.Remember == true)
                cb_remember.Checked = true;
            else
                cb_remember.Checked = false;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tb_user.Text) == true || String.IsNullOrEmpty(tb_password.Text) == true)
            {
                MessageBox.Show("fill all fields");
                return;
            }
                if (cb_remember.Checked == true)
                { 
                    Properties.Settings.Default.User = tb_user.Text;
                    Properties.Settings.Default.Password = tb_password.Text;
                    Properties.Settings.Default.Remember = true;
                    Properties.Settings.Default.Save();
                }
                else
                { 
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.Save();
                }
            MessageBox.Show("Successfully logged in");
            Application.Exit();
        }
    }
}
