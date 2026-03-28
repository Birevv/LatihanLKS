using CoWorkingSpaceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoWorkingSpaceApp.Helpers
{
    public static class SessionHelper
    {
        public static users CurrentUser { get; set; }
        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
