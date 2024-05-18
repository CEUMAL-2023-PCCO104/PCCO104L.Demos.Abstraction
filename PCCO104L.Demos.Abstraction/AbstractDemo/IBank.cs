namespace PCCO104L.Demos.Abstraction
{
    internal interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();
    }
}
