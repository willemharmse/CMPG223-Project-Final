using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPG223_Final
{
    public static class User
    {
        private static string username;
        private static string password;
        private static Boolean isAdmin;
        private static int id;

        public static int getID()
        {
            return id;
        }
    }
}
