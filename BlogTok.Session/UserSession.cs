using BlogTok.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTok.Session
{
    public static class UserSession
    {
        public static User CurrentUser { get; set; }
    }
}
