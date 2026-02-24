namespace prep3;

class Program
{
    class BankAccount
    {
        private int currentAmount;
        public BankAccount(int initialAmount = 0)
        {
            currentAmount = initialAmount;
        }
        public void Deposit(int amount)
        {
            if (amount <= 0) throw new Exception("Amount should be positive");
            currentAmount += amount;
        }
        public int GetCurrentAmount() => currentAmount;
    }

   
    static void Main(string[] args)
    {
        
        var acc = new BankAccount(100);
        acc.Deposit(60);
        acc.Deposit(15);
        Console.WriteLine(acc.GetCurrentAmount());

    }
}