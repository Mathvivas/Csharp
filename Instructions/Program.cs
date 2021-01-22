using System;

namespace Instructions
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            //int b = 2, c = 5;
            //const double d = 8.5;
            string loop = "sim";

            do 
            {

                Console.WriteLine("Digite seu nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Digite sua idade: ");
                idade = Convert.ToInt16(Console.ReadLine());

                if ( name.Length == 0 ) 
                {
                    Console.WriteLine("\nNome não foi informado!");

                } else {
                    Console.WriteLine($"{name} possui {idade} anos");
                }

                Console.WriteLine("\n\nDeseja reinformar os valores: ");
                loop = Console.ReadLine().ToLower();


            } while (loop == "sim");

        }
    }
}
