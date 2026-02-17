namespace prep3;

public class BankAccount
{
    private int currentAmount;

    private int totalSpent;

    private int totalDeposits;

    public int GetTotalDeposits() => totalDeposits;

    public int GetTotalSpents() => totalSpent;

    public int GetCurrentAmount() => currentAmount;
    
    public void Deposit(int amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount should be positive.");
        }

        totalDeposits += amount;
        currentAmount += amount;
    }

    public void Spend(int amount)
    {
        if (amount > currentAmount)
        {
            throw new ArgumentException($"Can not spend ${amount} while having ${currentAmount}.");
        }

        totalSpent += amount;
        currentAmount -= amount;
    }

    public BankAccount(int currentAmount = 0)
    {
        this.currentAmount = currentAmount;
    }
}