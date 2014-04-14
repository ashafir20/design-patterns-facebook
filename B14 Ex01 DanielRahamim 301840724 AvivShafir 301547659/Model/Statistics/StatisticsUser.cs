using FacebookWrapper.ObjectModel;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Statistics
{
    public class StatisticsUser
    {
        private User m_User;

        public int PhotosLikesPressed { get; set; }

        public int PostsLikesPressed { get; set; }

        public StatisticsUser(User i_User)
        {
            m_User = i_User;
            PhotosLikesPressed = 0;
            PostsLikesPressed = 0;
        }

        public User user
        {
            get { return m_User; }
        }
    }
}
