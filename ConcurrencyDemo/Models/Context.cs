using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConcurrencyDemo.Models
{
    public class Context : DbContext
    {
        public Context()
            : base()
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}