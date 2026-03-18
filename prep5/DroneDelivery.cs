namespace prep5;

public class DroneDelivery : IDeliverable
{
    public string ClientName { get; }
    public double Distance { get; }
    public double Weight { get; }

    public DroneDelivery(string clientName, double distance, double weight)
    {
        if (weight > 3)
        {
            throw new ArgumentException($"Weight is too big: {weight}kg. Maximum weight allowed = 3kg");
        }

        ClientName = clientName;
        Distance = distance;
        Weight = weight;
    }

    public decimal CalculateCost()
    {
        return (decimal)((Distance * 0.5) + 30);
    }
}