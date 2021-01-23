using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "123456789";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.ID = 2;
            musteri2.MusteriNo = "546878";
            musteri2.SirketAdi = "Deer";
            musteri2.VergiNo = "123456777789";

            Musteri musteri3 = new GercekMusteri();// new bellekteki bir referans no
            Musteri musteri4 = new TuzelMusteri();

                   
        }

    }
}
