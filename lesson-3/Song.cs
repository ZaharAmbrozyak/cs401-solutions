namespace lesson_3;

public class Song
{
    private string title;
    
    public string Title
    {
        get => title;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Song title cannot be null or empty");
            }

            title = value;
        }
    }
    
    public string Artist { get; }

    public int DurationSeconds { get; }

    public string FormattedDuration
    {
        get
        {
            int minutes = DurationSeconds / 60;
            int seconds = DurationSeconds - minutes * 60;
            string zero = "";
            if (seconds < 10)
            {
                zero = "0";
            }
            string output = minutes + ":" + zero + seconds;

            return output;
        }
    }
    public Song(string title, string artist, int durationSeconds)
    {
        if (durationSeconds <= 0)
        {
            throw new ArgumentException("Song duration should be positive");
        }
        if (string.IsNullOrEmpty(artist))
        {
            throw new ArgumentException("Artist name cannot be null or empty");
        }
        
        Title = title;
        Artist = artist;
        DurationSeconds = durationSeconds;
    }
}