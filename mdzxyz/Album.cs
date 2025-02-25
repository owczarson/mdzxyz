using System;
using System.Collections.Generic;
using System.IO;

public static class Album
{
    private static readonly string filePath = "Data.txt";

    public static List<AlbumMuzyczny> LoadAlbums()
    {
        var albums = new List<AlbumMuzyczny>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Błąd: Plik Data.txt nie istnieje.");
            return albums;
        }

        try
        {
            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i += 5)
            {
                var artist = lines[i].Trim();
                var albumTitle = lines[i + 1].Trim().Trim('"');
                int numberOfTracks = int.Parse(lines[i + 2].Trim());
                int releaseYear = int.Parse(lines[i + 3].Trim());
                int downloads = int.Parse(lines[i + 4].Trim());

                var album = new AlbumMuzyczny(artist, albumTitle, numberOfTracks, releaseYear, downloads);
                albums.Add(album);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Błąd formatu danych: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd wczytywania danych: {ex.Message}");
        }

        return albums;
    }
}
