using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming Convention- isimlendirmeKuralı
        public void Ekle(Urun urun)//Class..
        {
            Console.WriteLine("Tebrikler....Sepete eklendi:" + urun.Adi);

        }
        
        public void Ekle2(string urunAdi , string aciklama , double fiyat)//class değil...
        {
            Console.WriteLine("Tebrikler....Sepete eklendi:" + urunAdi);
        }
    }
}
