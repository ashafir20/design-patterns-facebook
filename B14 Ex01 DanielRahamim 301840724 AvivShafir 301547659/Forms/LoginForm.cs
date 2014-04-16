using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Model;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Session;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void login()
        {
            if (UserSingleton.Instance != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed To Login", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
