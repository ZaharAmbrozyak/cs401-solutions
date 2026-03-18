namespace prep4;

public class Mixer : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Mixer is turning on!");
    }

    public void TurnOff()
    {
        Console.WriteLine("Mixer is turning off...");
    }
}