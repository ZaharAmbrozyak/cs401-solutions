namespace lesson_3;

public class Playlist
{
    public string Name
    {
        get;
        private set;
    }

    public int SongCount
    {
        get => playlist.Count;
    }

    public int TotalDuration
    {
        get
        {
            int totalSeconds = 0;
            foreach (var song in playlist)
            {
                totalSeconds += song.DurationSeconds;
            }

            return totalSeconds;
        }
    }
    
    private List<Song> playlist = new List<Song>();

    public void AddSong(Song song)
    {
        playlist.Add(song);
    }

    public Song? FindSongByArtist(string artist)
    {
        foreach (var song in playlist)
        {
            if (song.Artist == artist)
            {
                return song;
            }
        }

        return null;
    }

    public Playlist(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Playlist name cannot be null or empty");
        }
        Name = name;
    }
}