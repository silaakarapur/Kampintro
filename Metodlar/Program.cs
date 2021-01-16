using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi ="elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "amasyaelmasi";


            Urun urun2 = new Urun();
            urun2.Adi ="karpuz";
            urun2.Fiyat = 80;
            urun2.Adi = "diyarbkir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }
            Console.WriteLine("---------Metotlar-----");

            SepetManager SepetManager = new SepetManager();
            //encapsulation-kapsülleme

            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);

            //-------------------------------------------

            SepetManager.Ekle2("armut", "yeşil armut", 12);
            SepetManager.Ekle2("elma", "yeşil elma", 12);
            SepetManager.Ekle2("karpuz ", "Diyarbakır Karpuzu", 12);
        }
    }
}
