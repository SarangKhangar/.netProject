using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EmployeeModel
    {
        

        public string EMPName { get; set; }

        public int EMPId { get; set; }

        public string Dept { get; set; }

        public int Experiance { get; set; }

        public EmployeeModel()
        {

        }

        public EmployeeModel(string EMPName, int EMPId, string Dept, int Experiance)
        {
            this.EMPName = EMPName;
            this.EMPId = EMPId;
            this.Dept = Dept;
            this.Experiance = Experiance;
        }
    }
}