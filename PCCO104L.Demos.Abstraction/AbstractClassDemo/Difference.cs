namespace PCCO104L.Demos.Abstraction
{
    public class Difference : BasicMath
    {
        public override void Calculate(double num1, double num2)
        {
            Console.WriteLine($"Difference of {num1} and {num2} is {num1 - num2}");
        }
    }
}
