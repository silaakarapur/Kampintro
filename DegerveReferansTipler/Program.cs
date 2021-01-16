using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int Sayi2 = 30;
            sayi1 = Sayi2;
            Sayi2 = 65;


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
             

        }
    }
}
