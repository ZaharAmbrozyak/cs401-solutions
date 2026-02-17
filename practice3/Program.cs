namespace practice3;

class Program
{
    static void Main(string[] args)
    {
        Product table1 = new Product("IKEA table", 50m, 10);
        Console.WriteLine(table1.IsInStock);
    }
}