namespace PCCO104L.Demos.Abstraction
{
    internal partial class Program
    {
        interface IInterface2 : IInterface1
        {
            int Property2 { get; set; }
            void Method2();
        }
    }
}
