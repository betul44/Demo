using System;

namespace ClassMMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Betül";
            musteri1.Soyadi = "Biradlı";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Oğuzhan";
            musteri2.Soyadi = "Baykara";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Muaz";
            musteri3.Soyadi = "Baykara";



            Musteri[] musteriler = new Musteri[] { musteri1,musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi+ musteri.Soyadi);
            
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri1);

            musteriManager.Sil(musteri3);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri3);

        }
    }
}
