namespace prep4;

public class Stove : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Stove is turning on!");
    }

    public void TurnOff()
    {
        Console.WriteLine("Stove is turning off...");
    }
}