﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class GuestResponse
    {
        public int Id { get; set; }
        public string Login { get; set;}
        public string Password { get;set; }
        public string Email { get; set; }
    }
}