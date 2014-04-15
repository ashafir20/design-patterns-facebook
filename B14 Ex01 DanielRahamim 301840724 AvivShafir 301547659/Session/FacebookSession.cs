using System;
using FacebookWrapper.ObjectModel;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Session
{
    public class FacebookSession
    {
        private User m_FacebookUser;
        private static readonly FacebookSession sr_FacebookSession = new FacebookSession();

        public static FacebookSession Instance
        {
            get { return sr_FacebookSession; }
        }

        private FacebookSession() { }

        public User User
        {
            get { return m_FacebookUser; }
            set
            {
                if (m_FacebookUser != null)
                {
                    throw new Exception("User was already set!");
                }
                m_FacebookUser = value;
            }
        }
    }
}
