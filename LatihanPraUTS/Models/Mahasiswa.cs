namespace LatihanPraUTS.Models
{
    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string Prodi { get; set; }

        public Mahasiswa(string nim, string nama, string prodi)
        {
            Nim = nim;
            Nama = nama;
            Prodi = prodi;
        }
    }
}
