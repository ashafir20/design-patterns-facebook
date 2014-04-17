using System;
using System.Windows.Forms;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Controllers.Abstract;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Helpers.Facebook;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Json;
using FacebookWrapper.ObjectModel;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Forms
{
    public partial class FactForm : Form
    {
        private IWebController m_WebController;
        private readonly FacebookHelper m_FacebookFetcher = new FacebookHelper();
        private const string k_UrlGetFactByDatePath = "https://numbersapi.p.mashape.com/";
        private const string k_GetFactByDateParams = "/date?fragment=true&json=true";

        public FactForm(IWebController i_WebController)
        {
            m_WebController = i_WebController;
            InitializeComponent();
            m_FacebookFetcher.m_FetchedFriendsCompletedInvoker += onFetchedFriendsCompleted;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_FacebookFetcher.FetchFriendsAsync();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void buttonGetBirthdayFact_Click(object sender, EventArgs e)
        {
            string date = birthdayLabel2.Text;
            if (!string.IsNullOrEmpty(date))
            {
                TimeJson timeJson = parseTime(date);
                var factJson = m_WebController.DownloadWebData<FactJson>(
                    new Uri(k_UrlGetFactByDatePath + timeJson.Month + "/" + timeJson.Day + k_GetFactByDateParams));
                textBoxFact.Clear();
                textBoxFact.AppendText(factJson.text);
                textBoxFact.AppendText(Environment.NewLine);
                textBoxFact.AppendText("Fact Date : "
                    + timeJson.Month + "/" + timeJson.Day + " Event Year : " + factJson.year);
            }
        }

        private static TimeJson parseTime(string date)
        {
            string[] dateArr = date.Split('/');
            return new TimeJson { Day = int.Parse(dateArr[1]), Month = int.Parse(dateArr[0]) };
        }

        private void onFetchedFriendsCompleted(FacebookObjectCollection<User> friends)
        {
            listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = friends));
        }

        private void buttonPostFact_Click(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedIndex > 0)
            {
                User friend = listBoxFriends.SelectedItem as User;
                friend.PostStatus(textBoxFact.Text);
                MessageBox.Show(
                    "The post was published to your friend's facebook wall successfuly!",
                    "Confirmation",
                    MessageBoxButtons.OK);
            }
        }
    }
}
