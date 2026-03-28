namespace midterm_prep;

public class Book : BaseMaterial
{
    
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

    public override string Show()
    {
        return $"Book '{name}', author {author}, year published {year}. {description}";
    }
}