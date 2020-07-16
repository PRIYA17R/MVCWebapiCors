using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiServer.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
    }

    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("data source=localhost\\sqlexpress; user id=sa; password=123; initial catalog=company")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}


