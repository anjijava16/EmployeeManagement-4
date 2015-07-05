using System;
namespace Domain.Models
{
   public interface IRepositoryFactory
    {
        BaseDao<Domain.Models.Entities.Department, int> GetDepartmentRepository();
        BaseDao<Domain.Models.Entities.Employee, int> GetEmployeeRepository();
    }
}
