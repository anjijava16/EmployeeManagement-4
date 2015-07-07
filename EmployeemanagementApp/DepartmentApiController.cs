using EmployeemanagementApp.EmpMgmtSvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeemanagementApp
{
    public class DepartmentApiController : ApiController
    {
        // GET api/<controller>
        public List<Department> Get()
        {
            List<Department> deptcoll = null;
            using (EmpMgmtSvc.EmployeeMgmtServiceClient svc = new EmpMgmtSvc.EmployeeMgmtServiceClient())
            {
                deptcoll = svc.GetAllDepartments();
            }
            return deptcoll;
        }

        // GET api/<controller>/5
      
        public Department Get(int id)
        {
            Department dept=null;
            using (EmpMgmtSvc.EmployeeMgmtServiceClient svc = new EmpMgmtSvc.EmployeeMgmtServiceClient())
            {
               dept= svc.ReadDepartment(id);
            }
            return dept;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
           if(!(string.IsNullOrWhiteSpace(value)))
           {
            using (EmpMgmtSvc.EmployeeMgmtServiceClient svc = new EmpMgmtSvc.EmployeeMgmtServiceClient())
            {
                 svc.CreateDepartment(value);
            }
           }
           
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Department value)
        {
            using (EmpMgmtSvc.EmployeeMgmtServiceClient svc = new EmpMgmtSvc.EmployeeMgmtServiceClient())
            {
                svc.UpdateDepartment(value);
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            
            using (EmpMgmtSvc.EmployeeMgmtServiceClient svc = new EmpMgmtSvc.EmployeeMgmtServiceClient())
            {
                 svc.DeleteDepartment(id);
            }

        }
    }
}