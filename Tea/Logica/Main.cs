using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea.Logica
{
    public class Menu
    {
         static void Main(string[] args)
        {
            ImprimeNome nome = new ImprimeNome();

            Console.WriteLine("========MENU=======");
            Console.WriteLine("1- Padrão 1");
            Console.WriteLine("2- Padrão 2");
            Console.WriteLine("3- Padrão 3");
            Console.WriteLine("4- Padrão 4");
            int i = int.Parse(Console.ReadLine());



            if (i == 1)
            {
                nome.imprimeNome();
            }

            Console.ReadKey();
                
        }
    }
}
