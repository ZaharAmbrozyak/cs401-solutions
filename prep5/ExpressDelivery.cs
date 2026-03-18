namespace prep5;

public class ExpressDelivery(string clientName, double distance, double weight) : IDeliverable
{
    public string ClientName { get; } = clientName;
    public double Distance { get; } = distance;
    
    public double Weight { get; } = weight;
    
    public decimal CalculateCost()
    {
        return (decimal)((Weight * 0.8) + (Distance * 0.2) + 50);
    }
}