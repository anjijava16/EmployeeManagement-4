using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Models.Entities
{
    public class Department : BaseVo<int>
    {
        public virtual int Id { get; set; }
        public virtual string DepartmentName { get; set; }
    }
}
