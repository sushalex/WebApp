using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class azure_db : DbContext
    {
        public DbSet<User> Users { get; set; } 
    }

    public class User { public int UserId { get; set; } }
}