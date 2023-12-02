using Implicit_Explicit_OperatorOverloading.Domain.Models;
using Implicit_Explicit_OperatorOverloading.Service.Interfaces;
using Implicit_Explicit_OperatorOverloading.Service.Services;
#region task-1
//Kelvin ve Celsius(selsi) adli iki temperaturu gosteren klasslarimiz var ve 
//Degree adli property-leri var. Celcius uchun implicit operatorunu yazin: (0C = 273K)

/*Console.WriteLine("<==========Kelvin To Celsius==========>");
Kelvin kelvin = new(500);
Celsius celsius = kelvin;
Console.WriteLine(celsius.Degree);
Console.WriteLine("<==========Celsius To Kelvin==========>");
Celsius celsius2 = new(35);
Kelvin kelvin2 = celsius2;
Console.WriteLine(kelvin2.Degree);*/
#endregion
#region task-2
/* Employee tipinden ibaret arrayiniz olacaq. Employee classinin icinde Name, Surname, Birthday, 
Salary propertileri olacaq. Employelerin icinden metoda iki ferqli tarix ve salary gelir. 
Dogum gunu hemin tarixler arasinda olan ve maashi 2000 - den boyuk olan ishcilerin sayini 
gosteren method yazin. Employeelerin dogum gunu tarixlerini constructordan gonderin. */
#endregion
IEmployeeServices employeeServices = new EmployeeServices();
var startDate = new DateTime(1995, 01, 01);
var endDate = new DateTime(1999, 01, 01);
var res=employeeServices.GetCountFilterByBirthdayAndSalary(startDate,endDate,1000);
Console.WriteLine(res);
