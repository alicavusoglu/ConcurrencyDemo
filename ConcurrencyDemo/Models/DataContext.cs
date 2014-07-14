using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConcurrencyDemo.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base()
        {

        }
    }
}