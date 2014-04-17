using System;
using System.Windows.Forms;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers.Abstract;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Helpers;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Helpers.Facebook;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Helpers.Static;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Json;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Session;
using FacebookWrapper.ObjectModel;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Forms
{
    public partial class CatForm : Form
    {
        private const string k_UrlGetRandomCat = "https://nijikokun-random-cats.p.mashape.com/random/kitten";
        private IWebController m_WebController;
        private readonly FacebookHelper m_FacebookFetcher = new FacebookHelper();

        public CatForm(IWebController i_WebController)
        {
            m_WebController = i_WebController;
            InitializeComponent();
            m_FacebookFetcher.m_FetchedFriendsCompletedInvoker += onFetchedFriendsCompleted;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            buttonGetCat_Click(null, null);
            m_FacebookFetcher.FetchFriendsAsync();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        private void onFetchedFriendsCompleted(FacebookObjectCollection<User> friends)
        {
            listBox2Friends.Invoke(new Action(() => userBindingSource.DataSource = friends));
        }

        private void buttonGetCat_Click(object sender, EventArgs e)
        {
            CatJson catJson = m_WebController.DownloadWebData<CatJson>(new Uri(k_UrlGetRandomCat));
            pictureBoxCat.LoadAsync(catJson.source);
        }

        private void buttonPostToWallCat_Click(object sender, EventArgs e)
        {
            if (listBox2Friends.SelectedIndex > 0)
            {
                User friend = listBox2Friends.SelectedItem as User;
                friend.PostPhoto(RageImageHelper.GetJpegByteStream(pictureBoxCat.Image), richTextBox1.Text);
                MessageBox.Show(
                    "The post was published to your friend's facebook wall successfuly!",
                    "Confirmation",
                    MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSingleton.Instance.LoggedInUser.PostPhoto(RageImageHelper.GetJpegByteStream(pictureBoxCat.Image), richTextBox1.Text);
            MessageBox.Show(
                "The post was published to your friend's facebook wall successfuly!",
                "Confirmation",
                MessageBoxButtons.OK);
        }
    }
}
