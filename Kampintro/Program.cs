using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double DolarBugun = 7.45;
            if (dolarDun > DolarBugun)
            {
                Console.WriteLine("azalıs butonu");
            }
            else if (dolarDun<dolarDun)
            {
                Console.WriteLine("artış butonu");

            }
            else
            {
                Console.WriteLine("değişmedi butonu");

            }



            if (sistemeGirisYapmisMi== true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
