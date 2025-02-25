public class AlbumMuzyczny
{
    public string Artysta { get; set; }
    public int LiczbaUtworow { get; set; }
    public int Rok { get; set; }
    public int LiczbaPobran { get; set; }
    public string Album { get; set; }
   

    public AlbumMuzyczny(string artysta, string album, int liczbaUtworow, int rok, int liczbaPobran)
    {
        Artysta = artysta;
        Album = album;
        LiczbaUtworow = liczbaUtworow;
        Rok = rok;
        LiczbaPobran = liczbaPobran;
    }
}
