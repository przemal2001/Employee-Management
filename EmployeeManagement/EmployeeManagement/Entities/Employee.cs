using EmployeeManagement.Entities.Enums;

namespace EmployeeManagement.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public JobPosition JobPosition { get; set; }
        public float Salary { get; set; }
        public virtual List<Duty> Duties { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
