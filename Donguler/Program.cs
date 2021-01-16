using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"yazılım geliştirici kampı", "programlamaya giriş kursu","java","python"};
             
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }


            //foreach dizilere uygulanır... in kurslar kursları dolaş demektir...
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu");

        }
    }
}
