namespace prep5;

public interface IDeliverable
{
    string ClientName { get; }
    double Weight { get; }
    double Distance { get; }
    decimal CalculateCost();
}