using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Model.Statistics
{
    class StatisticsComputingService
    {
        private readonly StatisticsLogic m_Logic;

        public StatisticsComputingService(List<User> i_UsersList)
        {
            m_Logic = new StatisticsLogic(i_UsersList);
        }

        public List<StatisticsUser> GetUserTopPhotosLikersList()
        {
            List<StatisticsUser> resultList = m_Logic.ComputeTopPhotosLikes();
            return resultList;
        }

        public List<StatisticsUser> GetUserTopPostsLikersList()
        {
            List<StatisticsUser> resultList = m_Logic.ComputeTopPostsLikes();
            return resultList;
        }

        public List<StatisticsUser> GetUserTopPhotosAndPostsLikersList()
        {
            List<StatisticsUser> resultList = GetUserTopPostsLikersList();
            resultList = GetUserTopPhotosLikersList();
            return resultList;
        }

        public List<StatisticsUser> SortResultList()
        {
            return m_Logic.sortStatisticsUsersListByLikes();
        }
    }
}
