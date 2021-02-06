using System;

namespace CrescimentoPopulacional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de cidades: ");
            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                Console.WriteLine("Digite a PopA, PopB, CrescA, CrescB (separados por espaço): ");
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                Console.WriteLine("pa = " + pa);
                pb = int.Parse(valores[1]);
                Console.WriteLine("pb = " + pb);

               //declare as variaveis corretamente
                cpa = double.Parse(valores[2]);
                Console.WriteLine("cpa = " + cpa);
                cpb = double.Parse(valores[3]);
                Console.WriteLine("cpb = " + cpb);

                while (pa <= pb)
                {
                   //complete o while
                   pa = (int)((pa * cpa / 100) + pa);
                   pb = (int)((pb * cpb / 100) + pb);
                   anos++;

                    if (anos > 100)
                    {
                       Console.WriteLine("Mais de 1 seculo.");
                       break;
                    }
                }

                if (anos <= 100)
                {
                   //complete a condicional
                   Console.WriteLine($"{anos} anos.");
                }

            }
        }

    }

}