namespace prep3;

public class Person
{
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (value == null)
            {
                throw new ArgumentException("Name can not be null");
            }

            name = value;
        }
    }

    public int Age { get; }
    public Person(string name)
    {
        Name = name;
    }
    
}