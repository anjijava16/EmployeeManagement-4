
using Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class RepositoryFactory : Domain.Models.IRepositoryFactory
    {
        public BaseDao<Department, int> GetDepartmentRepository()
        {
            return new BaseDao<Department, int>();
        }

        public BaseDao<Employee, int> GetEmployeeRepository()
        {
            return new BaseDao<Employee, int>();
        }


    }
}
