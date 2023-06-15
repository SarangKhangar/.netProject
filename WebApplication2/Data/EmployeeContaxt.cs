using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class EmployeeContaxt : DbContext
    {
        public EmployeeContaxt() : base()
        {

        }

        public DbSet<EmployeeModel> Employees { get; set; }
       

    }
}