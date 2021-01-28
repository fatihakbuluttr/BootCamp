using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Fatih";
            musteri1.Soyadi = "Akbulut";
            musteri1.Id = 1111;
            musteri1.MusteriNo = "654321";
            musteri1.TcNo = "123456789";


           TuzelMusteri musteri2 = new TuzelMusteri();
            musteri1.Id = 2222;
            musteri1.MusteriNo = "754321";
            musteri2.SirketAdi = "Yeni Software";            
            musteri2.VergiNo = "112233";


            Musteri musteri3 = new TuzelMusteri();
            Musteri musteri4 = new GercekMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);






        }
    }
}
