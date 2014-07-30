using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea.Logica
{
    class Piramide
    {
        public void imprimeUmaPiramide()
        {
            Console.WriteLine("  *");
            Console.WriteLine(" * *");
            Console.WriteLine("* * *");

        }

        public void imprimeVariasPiramides()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("  *  ");
                Console.WriteLine(" * * ");
                Console.WriteLine("* * *");
                Console.WriteLine("            ");
            }
         
            
        }

    }
}
