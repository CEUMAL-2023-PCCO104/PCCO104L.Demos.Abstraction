namespace PCCO104L.Demos.Abstraction
{
    public class Sum : BasicMath
    {
        public override void Calculate(double num1, double num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
    }
}
