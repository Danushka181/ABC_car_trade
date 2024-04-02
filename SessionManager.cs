using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_car_trade
{
    internal class SessionManager
    {
        private static string loggedInUser;
        private static string userId;

        // logged in users property set
        public static string LoggedInUser
        {
            get { return loggedInUser; }
            set { loggedInUser = value; }
        }

        public static string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        // check user already logged in function
        public static bool IsUserLoggedIn()
        {
            return !string.IsNullOrEmpty(loggedInUser);
        }

        // Method to set the logged in user
        public static void SetLoggedInUser(string userName, string id)
        {
            loggedInUser = userName;
            userId = id;
        }

        // Method to clear session
        public static void ClearSession()
        {
            loggedInUser = null;
        }
    }
}
