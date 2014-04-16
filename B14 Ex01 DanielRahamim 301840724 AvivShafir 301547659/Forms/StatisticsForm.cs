using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Helpers.Facebook;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Statistics;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Session;
using FacebookWrapper.ObjectModel;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Forms
{
    public partial class StatisticsForm : Form
    {
        private const int k_MaxProgressBar = 10000;
        private StatisticsComputingService m_StatisticsService;
        private List<StatisticsUser> m_ResultList;
        private FacebookHelper m_FacebookFetcher = new FacebookHelper();

        public StatisticsForm()
        {
            InitializeComponent();
            m_FacebookFetcher.m_FetchedFriendsCompletedInvoker += onFetchedFriendsCompleted;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            listBoxFriends.DisplayMember = "Name";
            listBoxPickedFriends.DisplayMember = "Name";
            initListViewResults();
            progressBar.Maximum = k_MaxProgressBar;
            progressBar.Step = 4;
            m_FacebookFetcher.FetchFriendsAsync();
        }

        private void initListViewResults()
        {
            listViewResults.Columns.Add("Name");
            listViewResults.Columns.Add("Photos Likes");
            listViewResults.Columns.Add("Posts Likes");
            listViewResults.Columns.Add("Total Likes");
        }

        private void onFetchedFriendsCompleted(FacebookObjectCollection<User> friends)
        {
            foreach (User friend in friends)
            {
               listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
            }
        }

        private void buttonPickFriend_Click(object sender, EventArgs e)
        {
            User SelectedFriend = listBoxFriends.SelectedItem as User;
            if (buttonGetLikesStatistics.Enabled == false)
            {
                buttonGetLikesStatistics.Enabled = true;
            }

            if (SelectedFriend != null && listBoxPickedFriends.FindString(SelectedFriend.Name) == -1)
            {
                listBoxPickedFriends.Items.Add(SelectedFriend);
                int counter = listBoxPickedFriends.Items.Count;
                labelPickedFriendsCounter.Text = "You Picked " + counter + " Friends";
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User SelectedFriend = listBoxFriends.SelectedItem as User;
            if (SelectedFriend.PictureNormalURL != null)
            {
                PictureBoxUserFriend.LoadAsync(SelectedFriend.PictureNormalURL);
            }
        }

        private void listBoxPickedFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User SelectedFriend = listBoxPickedFriends.SelectedItem as User;
            if (SelectedFriend != null && SelectedFriend.PictureNormalURL != null)
            {
                pictureBoxPickedFriends.LoadAsync(SelectedFriend.PictureNormalURL);
            }
        }

        private void buttonRemoveFriend_Click(object sender, EventArgs e)
        {
            int counter = 0;
            User friendToRemove = listBoxPickedFriends.SelectedItem as User;
            if (friendToRemove != null)
            {
                listBoxPickedFriends.Items.Remove(friendToRemove);
                counter = listBoxPickedFriends.Items.Count;
                labelPickedFriendsCounter.Text = "You Picked " + counter + " Friends";
            }

            if (listBoxPickedFriends.Items.Count == 0)
            {
                buttonGetLikesStatistics.Enabled = false;
            }
        }

        private void buttonGetLikesStatistics_Click(object sender, EventArgs e)
        {
            initStatisticsComputingService();
            clearListViewResults();
            Thread computeThread = createComputeThread();
            Thread ProgressBarThread = createProgressBarThread(computeThread);
            computeThread.Start();
            ProgressBarThread.Start();
        }

        private Thread createComputeThread()
        {
            Thread computeThread = new Thread(() =>
            {
                if (radioButtonPhotos.Checked == true)
                {
                    m_ResultList = m_StatisticsService.GetUserTopPhotosLikersList();
                }
                else if (radioButtonPosts.Checked == true)
                {
                    m_ResultList = m_StatisticsService.GetUserTopPostsLikersList();
                }
                else
                {
                    m_ResultList = m_StatisticsService.GetUserTopPhotosAndPostsLikersList();
                }
            });
            return computeThread;
        }

        private Thread createProgressBarThread(Thread i_ComputeThread)
        {
            Thread progressBarThread = new Thread(() =>
            {
                while (i_ComputeThread.IsAlive == true)
                {
                    progressBar.Invoke(new Action(() =>
                    {
                        progressBar.PerformStep();
                        if (progressBar.Value == k_MaxProgressBar)
                        {
                            progressBar.Value = 0;
                        }
                    }));
                }

                listViewResults.Invoke(new Action(() =>
                    {
                        showLikesResults();
                        buttonSortList.Enabled = true;
                        progressBar.Value = 0;
                    }));
            });
            return progressBarThread;
        }

        private void initStatisticsComputingService()
        {
            List<User> selectedUserFriends = new List<User>();
            foreach (User user in listBoxPickedFriends.Items)
            {
                selectedUserFriends.Add(user);
            }

            m_StatisticsService = new StatisticsComputingService(selectedUserFriends);
        }

        private void clearListViewResults()
        {
            foreach (ListViewItem item in listViewResults.Items)
            {
                listViewResults.Items.Remove(item);
            }
        }

        private void showLikesResults()
        {
            foreach (StatisticsUser statisticsUser in m_ResultList)
            {
                int photosLikes = statisticsUser.photosLikesPressed;
                int postsLikes = statisticsUser.postsLikesPressed;
                ListViewItem item = new ListViewItem(new[] { statisticsUser.user.Name, photosLikes.ToString(), postsLikes.ToString(), (photosLikes + postsLikes).ToString() });
                listViewResults.Items.Add(item);
            }

            listViewResults.View = View.Details;
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            foreach (User user in listBoxFriends.Items)
            {
                if (listBoxPickedFriends.FindString(user.Name) == -1)
                {
                    listBoxPickedFriends.Items.Add(user);
                    int counter = listBoxPickedFriends.Items.Count;
                    labelPickedFriendsCounter.Text = "You Picked " + counter + " Friends";
                }
            }

            this.buttonGetLikesStatistics.Enabled = true;
        }

        private void buttonSortList_Click(object sender, EventArgs e)
        {
            m_ResultList = m_StatisticsService.SortResultList();
            listViewResults.Items.Clear();
            showLikesResults();

        }
    }
}
