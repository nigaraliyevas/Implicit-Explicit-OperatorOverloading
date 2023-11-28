namespace Implicit_Explicit_OperatorOverloading.Domain.Models
{
    public class Kelvin
    {
        public double Degree { get; set; }
        public Kelvin(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.Degree - 273);
        }
    }
}
