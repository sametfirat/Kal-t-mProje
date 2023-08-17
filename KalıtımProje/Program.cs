using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar b1 = new Bilgisayar
            {
                marka = "Lenova",
                model = "Z50",
                islemci = "ı5",
                alısFiyat = 1500M,
                satısFiyat = 1600M,
                kanpanyaFiyat = 1000M,
                barKod = "1234567890"
            };
            sanalDataBase.ekle(b1);
            Bilgisayar b2 = new Bilgisayar
            {
                marka = "Lenova",
                model = "Z50",
                islemci = "ı5",
                alısFiyat = 1500M,
                satısFiyat = 1600M,
                kanpanyaFiyat = 1000M,
                barKod = "1234567890"
            };
            sanalDataBase.ekle(b2 );
            
        }
    }
}
