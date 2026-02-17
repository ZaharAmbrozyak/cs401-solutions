namespace prep3;

public class BankAccount
{
    private int currentAmount;

    private int totalSpent;

    private int totalDeposits;

    private List<Transaction> transactions = new();
    public int GetTotalDeposits() => totalDeposits;

    public int GetTotalSpents() => totalSpent;

    public int GetCurrentAmount() => currentAmount;
    
    public void Deposit(int amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount should be positive.");
        }

        transactions.Add(new Transaction(amount, TransactionType.Deposit));
        totalDeposits += amount;
        currentAmount += amount;
    }

    public void Spend(int amount)
    {
        if (amount > currentAmount)
        {
            throw new ArgumentException($"Can not spend ${amount} while having ${currentAmount}.");
        }
        
        transactions.Add(new Transaction(amount, TransactionType.Spending));
        totalSpent += amount;
        currentAmount -= amount;
    }

    public BankAccount(int currentAmount = 0)
    {
        this.currentAmount = currentAmount;
    }
}