using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {



            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "engin demirog";
            kurs1.izlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "java";
            kurs2.egitmen = "Kerem Varış";
            kurs2.izlenmeOrani = 68;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "python";
            kurs3.egitmen = "Berkay Bilgin";
            kurs3.izlenmeOrani = 80;

            //Console.WriteLine(kurs1.kursAdi + " " +kurs1.egitmen);

            kurs[] kurslar = new kurs[] { kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + ":"+ kurs.egitmen);
                

            }
        }
    }

    class kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
