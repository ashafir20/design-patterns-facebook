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
            FacebookObjectCollection<Album> userAlbums = FacebookSession.Instance.User.Albums;
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
                                StatisticUser.PhotosLikesPressed = ++StatisticUser.PhotosLikesPressed;
                            }
                        }
                    }
                }
            }    

            sortStatisticsUsersListByLikes();
            return m_StatisticsUsersList;
        }
        
        public List<StatisticsUser> ComputeTopPostsLikes()
        {
            FacebookObjectCollection<Post> userPosts = FacebookSession.Instance.User.Posts;
            foreach (Post post in userPosts)
            {
                FacebookObjectCollection<User> postLikedByUsersList = post.LikedBy;
                foreach (StatisticsUser statisticUser in m_StatisticsUsersList)
                {
                    foreach (User LikedPostUser in postLikedByUsersList)
                    {
                        if (LikedPostUser.Id == statisticUser.user.Id)
                        {
                            statisticUser.PostsLikesPressed = ++statisticUser.PostsLikesPressed;
                        }
                    }
                }
            }

            sortStatisticsUsersListByLikes();
            return m_StatisticsUsersList;
        }

        private void sortStatisticsUsersListByLikes()
        {
            m_StatisticsUsersList.Sort((user1, user2) =>
                {
                    if (user1.PhotosLikesPressed + user1.PostsLikesPressed > user2.PhotosLikesPressed
                        + user2.PostsLikesPressed)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                });
        }
    }
}
