using System;
using System.Collections.Generic;

namespace OOP___Soyutlama
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasitKredisi = new TasitKredisiManager();
            IKrediManager ihtiyacKredisi = new IhtiyacKredisiManager();
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKredisi);

            List<IKrediManager> krediler = new List<IKrediManager> { tasitKredisi, ihtiyacKredisi };
            basvuruManager.Karsilastirma(krediler);
        }
    }
}
