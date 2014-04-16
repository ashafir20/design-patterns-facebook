using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Session
{
    public class UserSingleton : User
    {
        private const string k_AppID = "1441993139370754";
        private static readonly string[] r_FaceboookPermissions = 
                    { 
                       "user_status", "friends_birthday", "read_stream", "publish_stream", "user_photos", "publish_actions"
                    };

        private static UserSingleton _mUserSingleton;
        public User LoggedInUser { get; private set; } 
        private UserSingleton() { }
        public static UserSingleton Instance
        {
            get
            {
                if (_mUserSingleton == null)
                {
                    LoginResult result = FacebookService.Login(k_AppID, r_FaceboookPermissions);
                    if (result != null && result.LoggedInUser != null)
                    {
                        _mUserSingleton = new UserSingleton();
                        _mUserSingleton.LoggedInUser = result.LoggedInUser;
                    }
                }
                return _mUserSingleton;
            }
        }
    }
}
