using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("722831657750326",
                "user_groups", "friends_checkins", "friends_events", "friends_likes", "friends_photos",
                "friends_status", "friends_videos");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }
    }
}
