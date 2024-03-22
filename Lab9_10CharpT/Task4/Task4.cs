using System;
using System.Collections;

class Program4
{
    public static void Task4()
    {
        MusicCatalog catalog = new MusicCatalog();

        catalog.AddMusicCD("CD1", "Different Artists");
        catalog.AddMusicCD("CD2", "Artist 1");

        catalog.AddSong("CD1", "Song 1", "Artist 1", 3.5);
        catalog.AddSong("CD1", "Song 2", "Artist 2", 4.2);
        catalog.AddSong("CD1", "Song 11", "Artist 1", 4.0);
        catalog.AddSong("CD2", "Song 3", "Artist 1", 5.0);

        catalog.DisplayCatalog();

        catalog.RemoveSong("CD1", "Song 11");
        Console.WriteLine("\nAfter removing Song 11 from CD1:");
        catalog.DisplayCatalog();

        catalog.SearchByArtist("Artist 1");
    }
}







