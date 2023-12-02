using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Explicit_OperatorOverloading.Service.Interfaces
{
    public interface IEmployeeServices
    {
        public int GetCountFilterByBirthdayAndSalary(DateTime startDate, DateTime endDate, double salary);
    }
}
