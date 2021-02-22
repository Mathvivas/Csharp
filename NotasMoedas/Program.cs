using System;

namespace NotasMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int inteiro, auxNotas, auxMoedas;

            Console.WriteLine("Digite um valor qualquer: ");
            valor = Convert.ToDouble(Console.ReadLine());

            inteiro = (int)valor;
            valor *= 100;
            auxMoedas = (int)valor;


            Console.WriteLine("\nNOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", inteiro/100);
            auxNotas = (inteiro % 100);
            //complete o código
            Console.WriteLine("{0} nota(s) de R$ 50.00", auxNotas/50);
            auxNotas = (auxNotas % 50);
            Console.WriteLine("{0} nota(s) de R$ 20.00", auxNotas/20);
            auxNotas = (auxNotas % 20);
            Console.WriteLine("{0} nota(s) de R$ 10.00", auxNotas/10);
            auxNotas = (auxNotas % 10);
            Console.WriteLine("{0} nota(s) de R$ 5.00", auxNotas/5);
            auxNotas = (auxNotas % 5);
            Console.WriteLine("{0} nota(s) de R$ 2.00", auxNotas/2);
            auxNotas = (auxNotas % 2);
            

            Console.WriteLine("\nMOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", auxNotas / 1);
            auxMoedas %= 100;
            //complete o codigo
            Console.WriteLine("{0} moeda(s) de R$ 0.50", auxMoedas / 0.5);
            auxMoedas %= 50;
            Console.WriteLine("{0} moeda(s) de R$ 0.25", auxMoedas / 0.25);
            auxMoedas %= 25;
            Console.WriteLine("{0} moeda(s) de R$ 0.10", auxMoedas / 0.1);
            auxMoedas %= 10;
            Console.WriteLine("{0} moeda(s) de R$ 0.05", auxMoedas / 0.05);
            auxMoedas %= 5;
            Console.WriteLine("{0} moeda(s) de R$ 0.01", auxMoedas / 0.01);

        }
    }
}
