using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Models.Entities
{
 public   class Department : IDepartment
    {
        public virtual int Id { get; set; }
        public virtual string DepartmentName { get; set; }
    }
}
