namespace prep5;

internal static class Program
{
    private static void Main()
    {
        var orders = new List<IDeliverable>();

        const double distance = 2;
        const double weight = 2.9;
        
        var order1 = new DroneDelivery("Zakhar", distance, weight);
        var order2 = new StandardDelivery("Nazar", distance, weight);
        var order3 = new ExpressDelivery("Ivan", distance, weight);
        
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        foreach (var order in orders)
        {
            Console.WriteLine($"{order.ClientName}'s order cost is ${order.CalculateCost()}");
        }
    }
}