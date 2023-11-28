namespace Implicit_Explicit_OperatorOverloading.Domain.Models
{
    public class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273);
        }
    }
}
