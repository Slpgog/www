﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsPortal.DAL.Entites
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
