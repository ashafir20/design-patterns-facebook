using System.Threading;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Session;
using FacebookWrapper.ObjectModel;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Helpers.Facebook
{
    public delegate void FriendsFetchedCompleted(FacebookObjectCollection<User> friends);
    public class FacebookHelper
    {
        public event FriendsFetchedCompleted m_FetchedFriendsCompletedInvoker;

        public void FetchFriendsAsync()
        {
            new Thread(() =>
            {
                var friends = UserSingleton.Instance.LoggedInUser.Friends;
                if (m_FetchedFriendsCompletedInvoker != null)
                {
                    m_FetchedFriendsCompletedInvoker.Invoke(friends);
                }
            }).Start();
        }
    }
}
