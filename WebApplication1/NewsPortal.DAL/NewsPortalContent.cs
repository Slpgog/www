using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using NewsPortal.DAL.Entites;

namespace NewsPortal.DAL
{
    public class NewsPortalContext : System.Data.Entity.DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
