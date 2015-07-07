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

        public int CreateEmployee(Employee emp)
        {
            return Repo.GetEmployeeRepository().Create(emp);
        }

        public Employee ReadEmployee(int empid)
        {
            return Repo.GetEmployeeRepository().LoadById(empid);
        }

        public void UpdateEmployee(Employee emp)
        {
             Repo.GetEmployeeRepository().SaveOrUpdate(emp);
        }

        public void DeleteEmployee(int id)
        {
            Repo.GetEmployeeRepository().DeleteById(id);
        }

        public int CreateDepartment(string deptName)
        {
            return Repo.GetDepartmentRepository().Create(new Department() {  DepartmentName =deptName});
        }

        public Department ReadDepartment(int id)
        {
            return Repo.GetDepartmentRepository().LoadById(id);
        }

        public void UpdateDepartment(Department dept)
        {
             Repo.GetDepartmentRepository().SaveOrUpdate(dept);
        }

        public void DeleteDepartment(int id)
        {
            Repo.GetDepartmentRepository().DeleteById(id);
        }



        public List<Department> GetAllDepartments()
        {
            return Repo.GetDepartmentRepository().LoadAll().ToList();
            
        }

        public List<Employee> GetAllEmployees()
        {
            return Repo.GetEmployeeRepository().LoadAll().ToList();
        }
    }
}
