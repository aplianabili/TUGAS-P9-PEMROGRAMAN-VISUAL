public class Buku
{
    public int Id { get; set; }
    public string Judul { get; set; }
    public string Penulis { get; set; }
    public string Penerbit { get; set; }
    public string Tahun { get; set; }
    public string Status { get; set; }

    // Constructor dengan status
    public Buku(string judul, string penulis, string penerbit, string tahun, int id, string status)
    {
        Judul = judul;
        Penulis = penulis;
        Penerbit = penerbit;
        Tahun = tahun;
        Id = id;
        Status = status;
    }
}
