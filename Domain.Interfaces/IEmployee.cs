using System;
namespace Domain.Interfaces
{
   public interface IEmployee
    {
        string Designation { get; set; }
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
        IDepartment Department { get; set; }
    }
}
