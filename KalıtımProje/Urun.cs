using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProje
{
    public class Urun :  BaseClass
    {
        public string  marka   { get; set; }
        public  string model  { get; set; }

        private decimal _alısFiyatı;
        public decimal alısFiyat 
        { 
            get { return _alısFiyatı; } 
            set 
            {
                if (0 > alısFiyat)
                    Console.WriteLine("alış fiyatı 0dan büyük olmalıdır");
                else
                    _alısFiyatı = value; 
            } 
        }
        private decimal _satısFiyatı;
        public decimal satısFiyat 
        { 
            get 
            {
                return _satısFiyatı;
            } 
            set 
            {
                if (alısFiyat > value)
                    Console.WriteLine("alıs fiyat satıştan büyük olmaz");
                else
                     _satısFiyatı = value;
            } 
        }
        private decimal _kanpanyaFiyat;
        public decimal kanpanyaFiyat 
        { 
            get 
            {
                return _kanpanyaFiyat;
            } 
            set
            {
                if (kanpanyaFiyat < 0)
                    Console.WriteLine("fiyat 0'dan kücük olmaz");
                else
                    _kanpanyaFiyat = value;

            } 
        }
    }
}
