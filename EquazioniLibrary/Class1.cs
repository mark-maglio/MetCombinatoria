using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Class1
    {
        public static long Fattoriale(int n)
        {
            long fatt = 1;
            for (int i =n;i >= 1; i--)
            {
                fatt = fatt * i;
            }
            return fatt;
        }
    }
}
