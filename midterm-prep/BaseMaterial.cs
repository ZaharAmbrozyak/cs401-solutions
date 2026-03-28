namespace midterm_prep;

public abstract class BaseMaterial : IShowable
{
    protected string name;
    public string Name
    {
        get => name;
        init
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }

            name = value;
        }
    }
    
    protected int year;
    public int Year
    {
        get => year;
        init
        {
            if (value < 0)
            {
                throw new ArgumentException("Year should be positive!");
            }

            year = value;
        }
    }

    public abstract string Show();
}