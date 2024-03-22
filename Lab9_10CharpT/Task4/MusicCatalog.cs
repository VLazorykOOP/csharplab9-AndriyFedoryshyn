using System;
using System.Collections;

class MusicCatalog
{
    private Hashtable musicCDs = new Hashtable();

    public void AddMusicCD(string title, string artist)
    {
        musicCDs.Add(title, new MusicCD(title, artist));
    }

    public void RemoveMusicCD(string title)
    {
        musicCDs.Remove(title);
    }

    public void AddSong(string cdTitle, string songTitle, string artist, double duration)
    {
        if (musicCDs.ContainsKey(cdTitle))
        {
            if (musicCDs[cdTitle] is MusicCD cd)
            {
                cd.AddSong(songTitle, artist, duration);
            }
            else
            {
                Console.WriteLine($"Unexpected type found for CD '{cdTitle}'.");
            }
        }
        else
        {
            Console.WriteLine($"CD '{cdTitle}' not found.");
        }
    }


    public void RemoveSong(string cdTitle, string songTitle)
    {
        if (musicCDs.ContainsKey(cdTitle))
        {
            if (musicCDs[cdTitle] is MusicCD cd)
            {
                cd.RemoveSong(songTitle);
            }
            else
            {
                Console.WriteLine($"Unexpected type found for CD '{cdTitle}'.");
            }
        }
        else
        {
            Console.WriteLine($"CD '{cdTitle}' not found.");
        }
    }


    public void DisplayCatalog()
    {
        Console.WriteLine("\n---Music Catalog:");
        foreach (DictionaryEntry entry in musicCDs)
        {
            if (entry.Value is MusicCD cd)
            {
                cd.DisplaySongs();
            }
            else
            {
                Console.WriteLine("Invalid entry found in catalog.");
            }
        }
    }


    public void SearchByArtist(string artist)
    {
        Console.WriteLine($"\n---Songs by artist '{artist}':");
        foreach (DictionaryEntry entry in musicCDs)
        {
            if (entry.Value is MusicCD cd)
            {
                foreach (DictionaryEntry songEntry in cd.songs)
                {
                    if (songEntry.Value is Song song && song.Artist == artist)
                    {
                        Console.WriteLine($"   on CD '{cd.Title}', {song.Title}: {song.Duration} minutes");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid entry found in catalog.");
            }
        }
    }

}