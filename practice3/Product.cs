namespace practice3;

public class Product
{
    private string name;
    
    public string Name
    {
        get => name;
        set
        {
            if (value == null)
            {
                throw new ArgumentException("Name cannot be empty");
            }

            name = value;
        }
    }

    private decimal price;

    public decimal Price
    {
        get => price;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price must be positive");
            }
            price = value;
        }
    }

    private int stockLevel;

    public int StockLevel
    {
        get => stockLevel;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Stock level cannot be negative");
            }

            stockLevel = value;
        }
    }

    public bool IsInStock
    {
        get => StockLevel > 0;
    }

    public Product(string name, decimal price, int initialStock)
    {
        Name = name;
        Price = price;
        StockLevel = initialStock;
    }

    public void Restock(int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity can not be less or equal than zero.");
        }

        StockLevel += quantity;
        Console.WriteLine($"New total stock: {stockLevel}");
    }

    public void Sell(int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity can not be less or equal than zero");
        }

        if (quantity > stockLevel)
        {
            throw new ArgumentException($"Cannot sell {quantity} items while having only {stockLevel} items remaining");
        }

        stockLevel -= quantity;
        Console.WriteLine($"Sold {quantity} of {Name}");
    }
}