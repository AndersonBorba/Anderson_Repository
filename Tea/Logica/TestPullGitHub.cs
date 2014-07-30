using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tea.Logica
{
    class TestPullGitHub
    {
        public void imprimeNumeroDe1a100()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

        }

        public void imprimeAsterisco1ParaImpar2ParaPar()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("*");
                }
            }

        }

        public void imprimePIParaMultipolsDeQuatro()
        {
            int soma4mais4 = 4;

            for (int i = 1; i <= 100; i++)
            {
                if (i == soma4mais4)
                {
                    Console.WriteLine("PI");
                    soma4mais4 += 4;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }

        public void serieDeFibonacci()
        {
            int numeroAnterior = 0;
            int numeroSeguinte = 1;
            int somaDoisNumerosAnteriorComPosterior = 0;

            for (int i = 1; i <= 50; i++)
            {
                somaDoisNumerosAnteriorComPosterior = numeroAnterior + numeroSeguinte;

                Console.WriteLine(somaDoisNumerosAnteriorComPosterior);

                numeroAnterior = numeroSeguinte;
                numeroSeguinte = somaDoisNumerosAnteriorComPosterior;
            }
        }
    }
}
