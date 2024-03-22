using System;
using System.Collections;

class MusicCD
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public Hashtable songs = new Hashtable();

    public MusicCD(string title, string artist)
    {
        Title = title;
        Artist = artist;
    }

    public void AddSong(string title, string artist, double duration)
    {
        Song song = new Song(title, artist, duration);
        songs.Add(title, song);
    }

    public void RemoveSong(string title)
    {
        songs.Remove(title);
    }

    public void DisplaySongs()
{
    Console.WriteLine($"Songs on CD '{Title}':");
    foreach (DictionaryEntry entry in songs)
    {
        if (entry.Value is Song song)
        {
            Console.WriteLine($"   {song.Title} by {song.Artist}: {song.Duration} minutes");
        }
        else
        {
            Console.WriteLine("- Invalid song entry");
        }
    }
}

}
