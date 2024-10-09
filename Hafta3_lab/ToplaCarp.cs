using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_lab
{
    internal class ToplaCarp
    {
        public void Topla_Carp(ref int a, ref int b, out int add, out int mult)
        {
            
            add = a + b;
            mult = a * b;
            Console.WriteLine("Toplam : {0} ", add);
            Console.WriteLine("Carpim : {0}", mult);


        }
    }
}
