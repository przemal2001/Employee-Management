using EmployeeManagement.Entities.Enums;

namespace EmployeeManagement.Entities
{
    public class Duty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Prioryty Prioryty { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
