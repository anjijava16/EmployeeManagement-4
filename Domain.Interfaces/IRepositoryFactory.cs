using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
  public  interface IRepositoryFactory
    {
        BaseVo<Domain.Models.Entities.Department> GetDepartmentReporsitory();
        BaseVo<Domain.Models.Entities.Employee> GetEmployeeRepository();
    }
}
