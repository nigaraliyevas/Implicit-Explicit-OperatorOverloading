using Implicit_Explicit_OperatorOverloading.Domain.Models.Common;

namespace Implicit_Explicit_OperatorOverloading.Domain.Models
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public double Salary { get; set; }
        public Employee()
        {
            
        }
        public Employee(DateTime birthdayDate)
        {
            Birthday = birthdayDate;
        }
    }
}
