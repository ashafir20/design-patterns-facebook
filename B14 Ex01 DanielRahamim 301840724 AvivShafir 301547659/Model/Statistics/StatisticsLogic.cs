using System.Collections.Generic;
using B14_Ex01_Daniel_301840724_Aviv_301547659.Session;
using FacebookWrapper.ObjectModel;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Statistics
{
    public class StatisticsLogic
    {
        private List<StatisticsUser> m_StatisticsUsersList;

        public StatisticsLogic(List<User> i_UsersList)
        {
            m_StatisticsUsersList = new List<StatisticsUser>();
            foreach (User user in i_UsersList)
            {
                m_StatisticsUsersList.Add(new StatisticsUser(user));
            }
        }

        public List<StatisticsUser> ComputeTopPhotosLikes()
        {
            FacebookObjectCollection<Album> userAlbums = UserSingleton.Instance.Albums;
            foreach (Album album in userAlbums)
            {
                foreach (Photo photo in album.Photos)
                {
                    FacebookObjectCollection<User> PhotoLikeUsersList = photo.LikedBy;
                    foreach (StatisticsUser StatisticUser in m_StatisticsUsersList)
                    {
                        foreach (User LikedPhotoUser in PhotoLikeUsersList)
                        {
                            if (LikedPhotoUser.Id == StatisticUser.user.Id)
                            {
                                StatisticUser.photosLikesPressed = ++StatisticUser.photosLikesPressed;
                            }
                        }
                    }
                }
            }    

            return m_StatisticsUsersList;
        }
        
        public List<StatisticsUser> ComputeTopPostsLikes()
        {
            FacebookObjectCollection<Post> userPosts = UserSingleton.Instance.Posts;
            foreach (Post post in userPosts)
            {
                FacebookObjectCollection<User> postLikedByUsersList = post.LikedBy;
                foreach (StatisticsUser statisticUser in m_StatisticsUsersList)
                {
                    foreach (User LikedPostUser in postLikedByUsersList)
                    {
                        if (LikedPostUser.Id == statisticUser.user.Id)
                        {
                            statisticUser.postsLikesPressed = ++statisticUser.postsLikesPressed;
                        }
                    }
                }
            }

            return m_StatisticsUsersList;
        }

        public List<StatisticsUser> sortStatisticsUsersListByLikes()
        {
            if (m_StatisticsUsersList != null)
            {
                m_StatisticsUsersList.Sort((user1, user2) =>
                {
                    if (user1.photosLikesPressed + user1.postsLikesPressed > user2.photosLikesPressed
                        + user2.postsLikesPressed)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                });
                return m_StatisticsUsersList;
            }
            else
            {
                return null;
            }
        }
    }
}
