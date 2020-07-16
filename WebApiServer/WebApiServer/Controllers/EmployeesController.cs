using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiServer.Models;
using System.Web.Http.Cors;

namespace WebApiServer.Controllers
{
    [EnableCors(origins: "http://localhost:49279", headers: "*", methods: "*" )]
    public class EmployeesController : ApiController
    {
        public List<Employee> Get()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Employee> emps = db.Employees.ToList();
            return emps;
        }
    }
}


