using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Emp_WebApplication.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public short DeptNo { get; set; }
        public class EmpDBContext : DbContext
        {
            public EmpDBContext()
            { }
            public DbSet<Employee> Employees { get; set; }
        }
    }
}