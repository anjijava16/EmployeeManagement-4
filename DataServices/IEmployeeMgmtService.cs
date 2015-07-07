using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
namespace DataServices
{
    [ServiceContract]
    interface IEmployeeMgmtService
    {
        [WebInvoke(UriTemplate = "Department/Add", Method = "POST")]
        [OperationContract]
        int CreateDepartment(Domain.Interfaces.IDepartment dept);

        [OperationContract]
        [WebInvoke(UriTemplate = "Employee/Add", Method = "POST")]
        int CreateEmployee(Domain.Interfaces.IEmployee emp);

        [OperationContract]
        [WebInvoke(UriTemplate = "Department/Delete/{id}", Method = "DELETE")]
        void DeleteDepartment(int id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Employee/Delete/{id}", Method = "DELETE")]
        void DeleteEmployee(int id);

        [WebGet(UriTemplate = "Department/GetAll")]
        [OperationContract]
        IList<Domain.Interfaces.IDepartment> GetAllDepartments();

        [WebGet(UriTemplate = "Department/{id}")]
        [OperationContract]
        Domain.Interfaces.IDepartment ReadDepartment(int id);

        [WebGet(UriTemplate = "Employee/GetAll")]
        [OperationContract]
        IList<Domain.Interfaces.IEmployee> GetAllEmployees();

        [OperationContract]
        [WebGet(UriTemplate = "Employee/{id}")]
        Domain.Interfaces.IEmployee ReadEmployee(int id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Department/Update", Method= "PUT") ]
        void UpdateDepartment(Domain.Interfaces.IDepartment dept);

        [OperationContract]
        [WebInvoke(UriTemplate = "Employee/Update", Method = "PUT")]
        void UpdateEmployee(Domain.Interfaces.IEmployee emp);
    }
}
