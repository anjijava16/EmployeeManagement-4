using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using Domain.Interfaces;
using Domain.Models.Entities;
namespace DataServices
{
    [ServiceContract]
    interface IEmployeeMgmtService
    {
        [WebInvoke(UriTemplate = "Department/Add", Method = "POST")]
        [OperationContract]
        int CreateDepartment(string dept);

        [OperationContract]
        [WebInvoke(UriTemplate = "Employee/Add", Method = "POST")]
        int CreateEmployee(Employee emp);

        [OperationContract]
        [WebInvoke(UriTemplate = "Department/Delete/{id}", Method = "DELETE")]
        void DeleteDepartment(int id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Employee/Delete/{id}", Method = "DELETE")]
        void DeleteEmployee(int id);

        [WebGet(UriTemplate = "Department/GetAll")]
        [OperationContract]
        List<Department> GetAllDepartments();

        [WebGet(UriTemplate = "Department/{id}")]
        [OperationContract]
        Department ReadDepartment(int id);

        [WebGet(UriTemplate = "Employee/GetAll")]
        [OperationContract]
        List<Employee> GetAllEmployees();

        [OperationContract]
        [WebGet(UriTemplate = "Employee/{id}")]
        Employee ReadEmployee(int id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Department/Update", Method= "PUT") ]
        void UpdateDepartment(Department dept);

        [OperationContract]
        [WebInvoke(UriTemplate = "Employee/Update", Method = "PUT")]
        void UpdateEmployee(Employee emp);
    }
}
