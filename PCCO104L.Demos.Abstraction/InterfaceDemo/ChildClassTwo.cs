namespace PCCO104L.Demos.Abstraction
{
    internal partial class Program
    {
        public class ChildClassTwo : IInterface1, IInterface2
        {
            public string? Property1 { get; set; }
            public int Property2 { get; set; }

            public void Method1() { }

            public void Method2() { }
        }
    }
}
