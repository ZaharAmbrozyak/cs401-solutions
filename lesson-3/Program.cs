namespace lesson_3;

class Program
{
    static void Main(string[] args)
    {
        var playlist = new Playlist("Road Trip");

        // testPlaylist = new Playlist(""); - Playlist name cannot be empty;

        Song song1 = new Song("Bohemian Rhapsody", "Queen", 354);
        Song song2 = new Song("Hotel California", "Eagles", 391);

        // Song song3 = new Song("", "Test artist", 391); - Song title cannot be empty;
        // Song song4 = new Song("Test song", "", 391); - Artist name cannot be empty;
        // Song song5 = new Song("Test song", "Test Artist", -2); - Song duration should be positive;

        playlist.AddSong(song1);
        playlist.AddSong(song2);

        Console.WriteLine(playlist.SongCount); // 2
        Console.WriteLine(playlist.TotalDuration); // 745

        var found = playlist.FindSongByArtist("Queen");
        var found2 = playlist.FindSongByArtist("Test song");

        Console.WriteLine(found?.FormattedDuration); // 5:54
        Console.WriteLine(found2?.FormattedDuration);
    }
}