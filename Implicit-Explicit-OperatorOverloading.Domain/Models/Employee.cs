namespace Implicit_Explicit_OperatorOverloading.Domain.Models
{
    public class Employee
    {
        public int Id { get; set; }
        private static int _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public double Salary { get; set; }
        public Employee()
        {
            
        }
        public Employee(DateTime birthdayTime, double salary)
        {
            Id = ++_id;
            Birthday = birthdayTime;
            Salary = salary;
        }
        public Employee[] EmployeesInfo()
        {
            Employee employee1 = new(new DateTime(2002, 10, 04), 350);
            Employee employee2 = new(new DateTime(1999, 06, 07), 500);
            Employee employee3 = new(new DateTime(2000, 10, 15), 1500);
            Employee employee4 = new(new DateTime(1998, 11, 06), 1200);
            Employee[] employees = { employee1, employee2, employee3, employee4 };
            return employees;
        }
        public void GetCount(double minSalary, double maxSalary, DateTime minDate, DateTime maxDate)
        {
            Employee[] employeeArr = EmployeesInfo();
            int countEmployee = default;
            foreach (var employee in employeeArr)
            {
                if (employee.Salary > minSalary && employee.Salary < maxSalary && employee.Birthday > minDate && employee.Birthday < maxDate)
                {
                    countEmployee++;
                }
            }
            Console.WriteLine(countEmployee);
        }

    }
}
