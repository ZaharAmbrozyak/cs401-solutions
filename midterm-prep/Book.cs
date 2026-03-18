namespace midterm_prep;

public class Book : IMaterial
{
    private string name;
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
    
    private string author;
    public string Author
    {
        get => author;
        init
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Author name cannot be empty!");
            }

            author = value;
        }
    }
    
    private string description;
    public string Description
    {
        get => description;
        init
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Description cannot be empty!");
            }

            description = value;
        }
    }
    
    private int year;
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

    public string Show()
    {
        return $"Book '{name}', author {author}, year published {year}. {description}";
    }
}