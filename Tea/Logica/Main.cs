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
            Numero numero = new Numero();
            Piramide piramide = new Piramide();
            int i = 20;

            try
            {
                while (i != 0)
                {
                    Console.WriteLine("================================================================================");
                    Console.WriteLine("                MENU                               ");
                    Console.WriteLine(" 1 - Imprime Nome                                 1");
                    Console.WriteLine(" 2 - Imprime Numeros de um a cem                  2");
                    Console.WriteLine(" 3 - Imprime 1 asterisco para impar e 2 para par  3");
                    Console.WriteLine(" 4 - Imprime multiplos de                         4");
                    Console.WriteLine(" 5 - Imprime uma piramide                         5");
                    Console.WriteLine(" 6 - Imprime varias piramides                     6");
                    Console.WriteLine(" 7 - Serie de Fibonacci                           7");
                    Console.WriteLine(" Pressione 0 para parar ");
                    Console.WriteLine("================================================================================");

                    i = int.Parse(Console.ReadLine());


                    if (i <= 7 && i >= 0)
                    {
                        if (i == 1)

                            nome.imprimeNome();

                        if (i == 2)

                            numero.imprimeNumeroDe1a100();

                        if (i == 3)

                            numero.imprimeAsterisco1ParaImpar2ParaPar();

                        if (i == 4)

                            numero.imprimePIParaMultipolsDeQuatro();

                        if (i == 5)

                            piramide.imprimeUmaPiramide();

                        if (i == 6)

                            piramide.imprimeVariasPiramides();

                        if (i == 7)

                            numero.serieDeFibonacci();

                    }

                    else

                        Console.WriteLine("Numero invalido");

                }
            }
            catch 
            {

                Console.WriteLine("Um caractere desconhecido foi inserido ou o enter foi pressionado no lugar de um numero");
                Console.ReadKey();
            }
           

        }
    }
}
