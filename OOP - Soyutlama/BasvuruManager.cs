using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___Soyutlama
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            krediManager.Hesapla();
        }

        public void Karsilastirma(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
