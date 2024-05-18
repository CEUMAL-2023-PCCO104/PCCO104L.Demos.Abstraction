namespace PCCO104L.Demos.Abstraction
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            #region Non Abstract Demo
            Console.WriteLine("Transaction doing BDO Bank");
            BDO bdo1 = new BDO();
            bdo1.ValidateCard();
            bdo1.WithdrawMoney();
            bdo1.CheckBalanace();
            bdo1.BankTransfer();
            bdo1.MiniStatement();

            Console.WriteLine("\nTransaction doing BPI Bank");
            BPI bpi1 = new BPI();
            bpi1.ValidateCard();
            bpi1.WithdrawMoney();
            bpi1.CheckBalanace();
            bpi1.BankTransfer();
            bpi1.MiniStatement();
            #endregion

            #region Abstract Demo
            //Console.WriteLine("Transaction doing BDO Bank");
            //IBank bdo2 = new BDO();
            //bdo2.ValidateCard();
            //bdo2.WithdrawMoney();
            //bdo2.CheckBalanace();
            //bdo2.BankTransfer();
            //bdo2.MiniStatement();

            //Console.WriteLine("\nTransaction doing BPI Bank");
            //AbstractBank bpi2 = new BPI();
            //bpi2.ValidateCard();
            //bpi2.WithdrawMoney();
            //bpi2.CheckBalanace();
            //bpi2.BankTransfer();
            //bpi2.MiniStatement();
            #endregion

            #region Abstract Demo Real World
            //BasicMath math;
            //math = new Sum();
            //math.Calculate(5, 5);

            //math = new Difference();
            //math.Calculate(10, 5);
            #endregion

            #region Demo Abstract Class
            /* Instance of a ChildClass */
            //ChildClassOne c1 = new ChildClassOne();
            //c1.AbstractMethod1();
            //c1.AbstractMethod2();
            //c1.NonAbstractMethod1();
            //c1.ChildClassMethod1();

            /* Cannot create ParentAbstractClass */
            // ParentAbstractClass p1 = new ParentAbstractClass();

            /* Reference to ParentAbstractClass */
            //ParentAbstractClass c2 = new ChildClassOne();
            //c2.AbstractMethod1();
            //c2.AbstractMethod2();
            //c2.NonAbstractMethod1();
            #endregion

            #region Demo Interface
            //ChildClassTwo c3 = new ChildClassTwo();
            //c3.Property1 = "Property 1";
            //c3.Property2 = 0;
            //c3.Method1();
            //c3.Method2();

            //IInterface1 c4 = new ChildClassTwo();
            //c4.Property1 = "Property 1";
            //c4.Method1();

            //IInterface2 c5 = new ChildClassTwo();
            //c3.Property1 = "Property 1";
            //c3.Property2 = 0;
            //c3.Method1();
            //c3.Method2();
            #endregion

            #region Real World Implementation of Interface
            //CheckoutSystem checkoutSystem = new CheckoutSystem();
            //IPaymentMethod creditCard = new CreditCardPayment();
            //IPaymentMethod payPal = new PayPalPayment();
            //IPaymentMethod bitcoin = new BitcoinPayment();

            //checkoutSystem.Checkout(creditCard, 99.99M);
            //checkoutSystem.Checkout(payPal, 49.99M);
            //checkoutSystem.Checkout(bitcoin, 29.99M);
            #endregion
        }
    }
}
