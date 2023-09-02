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
        private static string email;
        private static Boolean isAdmin;
        private static int id;

        public static int getID()
        {
            return id;
        }

        public static string getEmail()
        {
            return email;
        }

        public static void setEmail(string mail)
        {
            email = mail;
        }

        public static void setUsername(string name)
        {
            username = name;
        }

        public static void setPassword(string pass)
        {
            password = pass;
        }

        public static void setID(int num)
        {
            id = num;
        }

        public static void setAdmin(Boolean value)
        {
            isAdmin = value;
        }

        public static Boolean getAdmin()
        {
            return isAdmin;
        }
    }
}
