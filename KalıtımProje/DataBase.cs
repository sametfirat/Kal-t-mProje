using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProje
{
    public static class sanalDataBase
    {
        private static ArrayList dataBase =new ArrayList() ;

            public static void ekle (BaseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barKod))
                dataBase.Add(data);
        }
        public static bool barkotKontrol(string değer)
        {
            bool flag=false;

            for (int i = 0; i < dataBase.Count; i++) 
            {
                BaseClass empty = (BaseClass)dataBase[i];
                if ( değer == empty.barKod)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
           

    }
}
