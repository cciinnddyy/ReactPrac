using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ReactDotNet.Models;
namespace ReactDotNet.DataContext
{
    public class HumanResource : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}