using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProje
{
    public class BaseClass
    {
        public static int sayac = 1;
        public BaseClass()
        {
            _ıd = sayac;
            sayac++;
        }
        
        
        private int _ıd;
        public int  ıd
        {
            get
            {
                return _ıd;
            }
            private   set
            {
                
             }

        }
        private string _barKod;
        public string barKod { 
            get { return _barKod; } 
            set 
            {
                bool kontrol = sanalDataBase.barkotKontrol(value);
                if (kontrol)
                    Console.WriteLine("bu değer bulunuyor");
                else 
                    _barKod= value;

           
                
            } 
        }

        public DateTime olusturmaTarihi  { get; set; }
        public int olusturanKulanıcı { get; set; }
        
        public DateTime guncelemeTarihi { get; set; }
        public  int  gunceleyenKulanıcı { get; set; }

        public bool silindi { get; set; }
        

    }
}
