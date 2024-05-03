using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_car_trade
{
    internal class DatabaseConnection
    {
        /**
         * Return connection string 
         * @return String
         * 
         */
        public static string GetConnectionString()
        { 
            return "Server=localhost;Database=abcCarTrade;Uid=superAdmin;Pwd=superAdmin@2023;";
        }
    }

    
}
