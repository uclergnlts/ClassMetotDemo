using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(); //instance
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Üçler";
            musteri1.MusteriSoyadi = "Gönültaş";
            musteri1.TelNo = "00000000000";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Üçler2";
            musteri2.MusteriSoyadi = "Gönültaş2";
            musteri2.TelNo = "11111111111";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler) //musteriler arrayında döner. musteri her müşterinin takma ismidir.
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.TelNo);
                Console.WriteLine("----------------------");
            }

            MusteriManager musteriManager = new MusteriManager(); //instance
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Listele(musteriler);
            musteriManager.Sil(musteri1);
        }
    }
}
