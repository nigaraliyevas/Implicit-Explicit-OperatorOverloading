namespace Implicit_Explicit_OperatorOverloading.Service.Interfaces
{
    public interface IEmployeeServices
    {
        public int GetCountFilterByBirthdayAndSalary(DateTime startDate, DateTime endDate, double salary);
    }
}
