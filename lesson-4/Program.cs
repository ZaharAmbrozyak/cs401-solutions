namespace lesson_4;

class Program
{
    static void Main(string[] args)
    {
        var books = new List<string>()
        {
            "The Lord of the Rings",
            "Harry Potter"
        };
        List<string> books2 =
        [
            "The Lord of the Rings",
            "Harry Poter"
        ];
        foreach (var book in books)
        {
            Console.WriteLine($"book from list {book}");
        }
        if (books.Count > 0)
            books.RemoveAt(0);

        books.Remove("Harry Potter");
        Console.WriteLine($"books count {books.Count}");
        
        books.AddRange("Harry Potter 1", "Harry Potter 2", "Harry Potter 3");
        books.Add("Harry Potter 4");

        for (var i = 0; i < books.Count; i++)
        {
            Console.WriteLine($"book from list {books[i]}");
        }
        Console.WriteLine(books.IndexOf("Harry Potter 1"));
        Console.WriteLine(books.Contains("Harry Potter 1"));

        var bookPrices = new Dictionary<string, decimal>()
        {
            { "Harry Potter 1", 99.9m },
            { "Harry Potter 2", 199.9m },
        };
        foreach (var (key, value) in bookPrices)
        {
            Console.WriteLine($"Book {key} price is {value}");
        }

        foreach (var kv in bookPrices)
        {
            Console.WriteLine($"Book {kv.Key} price is {kv.Value}");
        }

        bookPrices["Harry Potter 1"] = 105.9m;
        bookPrices["Harry Potter 3"] = 250.9m;

        // bookPrices.Add("Harry Potter 3", 123m);
        var addResult = bookPrices.TryAdd("Harry Potter 3", 250.9m); // true or false
        // Console.WriteLine(bookPrices["Harry Potter 4"]); - error
        if (bookPrices.TryGetValue("Harry Potter 4", out var harryPotter4Price))
        {
            Console.WriteLine($"Harry Potter 4 price is {harryPotter4Price}");
        }

        if (bookPrices.Remove("Harry Potter 3"))
        {
            Console.WriteLine("Harry Potter 3 book was removed");
        }
        bookPrices.Remove("Harry Potter 3", out var harryPotter3Price);
    }
}