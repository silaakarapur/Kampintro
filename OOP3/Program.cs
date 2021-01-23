using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyackredimanager = new IhtiyacKrediManager();
     
            TasıtKrediManager tasıtkredimanager = new TasıtKrediManager();
           
            IKrediManager konutkredimanager = new KonutKrediManager();

            IloggerService databaseloggerservice = new DatabaseLoggerService();
            IloggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasıtkredimanager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
