namespace prep3;

public class Transaction
{
    private int amount;

    private TransactionType type;

    public Transaction(int amount, TransactionType type)
    {
        this.amount = amount;
        this.type = type;
    }

    public int GetAmount() => amount;

    public TransactionType GetType() => type;
}

public enum TransactionType
{
    Spending, Deposit
}