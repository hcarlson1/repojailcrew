using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.DAL
{
    public class TestDBContext : DbContext
    {
        public TestDBContext() : base("TestConnection")
        {

        }
        //public DbSet<Test> Test { get; set; }
    }
}