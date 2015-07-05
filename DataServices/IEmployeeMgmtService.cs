using System;
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
        void DeleteDepartment(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Employee/Delete/{id}", Method = "DELETE")]
        void DeleteEmployee(string id);

        [WebGet(UriTemplate = "Department/{id}")]
        [OperationContract]
        Domain.Interfaces.IDepartment ReadDepartment(string id);

        [OperationContract]
        [WebGet(UriTemplate = "Employee/{id}")]
        Domain.Interfaces.IEmployee ReadEmployee(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "Department/Update", Method= "PUT") ]
        void UpdateDepartment(Domain.Interfaces.IDepartment dept);

        [OperationContract]
        [WebInvoke(UriTemplate = "Employee/Update", Method = "PUT")]
        void UpdateEmployee(Domain.Interfaces.IEmployee emp);
    }
}
