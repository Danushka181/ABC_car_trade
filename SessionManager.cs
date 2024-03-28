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

        // logged in users property set
        public static string LoggedInUser
        {
            get { return loggedInUser; }
            set { loggedInUser = value; }
        }

        // check user already logged in function
        public static bool IsUserLoggedIn()
        {
            return !string.IsNullOrEmpty(loggedInUser);
        }

        // Method to set the logged in user
        public static void SetLoggedInUser(string userName)
        {
            loggedInUser = userName;
        }

        // Method to clear session
        public static void ClearSession()
        {
            loggedInUser = null;
        }
    }
}
