
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controller
{
    public class EmployeeController : ApiController
    {

        List<EmployeeModel> emps = new List<EmployeeModel>
        {
            new EmployeeModel {EMPName ="Bill", Dept = "IT", EMPId = 11, Experiance = 05},
            new EmployeeModel {EMPName = "John", Dept = "Infra", EMPId = 21, Experiance = 03},
            new EmployeeModel {EMPName = "James", Dept = "Admin", EMPId = 31, Experiance = 01}

        };

        



        [HttpGet]
        public List<EmployeeModel> GetAllEmployee()
        {
            return emps;
        }

        [HttpGet]
        public EmployeeModel GetEmployeeByIndex(int id)
        {
            return emps[id];
        }
    }
}

