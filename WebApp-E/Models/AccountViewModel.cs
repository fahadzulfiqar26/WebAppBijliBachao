﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_E.Models
{
    public class AccountViewModel
    {
        
    }

    public class LoginViewModel
    {
        public string reqtype { get; set; }
        public string user_name { get; set; }
        public string pass_word { get; set; }
    }

    public class UserInfo
    {
        public string msn { get; set; }
        public string description { get; set; }
        public string full_name { get; set; }
        public DateTime last_login { get; set; }
        public int num_logins { get; set; }
        public int isActive { get; set; }
        public string device_Type { get; set; }
    }

}