using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Domain.Models;
using System.Web;
using Domain.Interfaces;
using Domain.Models.Entities;

namespace DataServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)] 
    public class EmployeeMgmtService : IEmployeeMgmtService 
    {
        private IRepositoryFactory _repo;
        public IRepositoryFactory Repo
        {
            get
            {
                if (_repo == null)
                {
                    _repo = new RepositoryFactory();
                }
                return _repo;
            }
        }

        public int CreateEmployee(IEmployee emp)
        {
            return Repo.GetEmployeeRepository().Create((Employee)emp);
        }

        public IEmployee ReadEmployee(string empid)
        {
            return Repo.GetEmployeeRepository().LoadById(Convert.ToInt32(empid));
        }

        public void UpdateEmployee(IEmployee emp)
        {
             Repo.GetEmployeeRepository().SaveOrUpdate((Employee)emp);
        }

        public void DeleteEmployee(string id)
        {
            Repo.GetEmployeeRepository().DeleteById(Convert.ToInt32(id));
        }

        public int CreateDepartment(IDepartment dept)
        {
            return Repo.GetDepartmentRepository().Create((Department)dept);
        }

        public IDepartment ReadDepartment(string id)
        {
            return Repo.GetDepartmentRepository().LoadById(Convert.ToInt32(id));
        }

        public void UpdateDepartment(IDepartment dept)
        {
             Repo.GetDepartmentRepository().SaveOrUpdate((Department)dept);
        }

        public void DeleteDepartment(string id)
        {
            Repo.GetDepartmentRepository().DeleteById(Convert.ToInt32(id));
        }

    }
}
