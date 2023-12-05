using Implicit_Explicit_OperatorOverloading.Domain.Models;
using Implicit_Explicit_OperatorOverloading.Service.Interfaces;

namespace Implicit_Explicit_OperatorOverloading.Service.Services
{
    public class EmployeeServices:IEmployeeServices
    {
        private Employee[] EmployeesInfo()
        {
            Employee employee1 = new(new DateTime(2002, 10, 04));
            employee1.Name = "Name1";
            employee1.Salary = 2000;

            Employee employee2 = new(new DateTime(1999, 06, 07));
            employee2.Name = "Name2";
            employee2.Salary = 1000;

            Employee employee3 = new(new DateTime(2000, 10, 15));
            employee3.Name = "Name3";
            employee3.Salary = 2500;

            Employee employee4 = new(new DateTime(1998, 11, 06));
            employee4.Name = "Name4";
            employee4.Salary = 1200;

            Employee[] employees = { employee1, employee2, employee3, employee4 };
            return employees;
        }
        public int GetCountFilterByBirthdayAndSalary(DateTime startDate, DateTime endDate, double salary)
        {
            int countEmployee = default;
            foreach (var employee in EmployeesInfo())
            {
                if (employee.Birthday > startDate && employee.Birthday < endDate && employee.Salary > salary)
                {
                    countEmployee++;
                }
            }
            return countEmployee;
        }
    }

}
