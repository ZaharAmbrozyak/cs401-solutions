namespace prep4;

public class Kitchen
{
    private List<IDevice> devices;

    private Lights lights = new Lights();

    public void EndShift()
    {
        foreach (var device in devices)
        {
            device.TurnOff();
        }

        lights.TurnOff();
    }

    public Kitchen(List<IDevice> devices)
    {
        this.devices = devices;
    }
}