using System;

namespace Banco.Classes
{
    public class Menu
    {
        public void run ()
        {
            string op;
            do 
            {
                Console.WriteLine("\n|========| Menu |========|");
                Console.WriteLine("|");
                Console.WriteLine("| 1 - Listar Contas");
                Console.WriteLine("|");
                Console.WriteLine("| 2 - Inserir Nova Conta");
                Console.WriteLine("|");
                Console.WriteLine("| 3 - Transferir");
                Console.WriteLine("|");
                Console.WriteLine("| 4 - Sacar");
                Console.WriteLine("|");
                Console.WriteLine("| 5 - Depositar");
                Console.WriteLine("|");
                Console.WriteLine("| 6 - Limpar Tela");
                Console.WriteLine("|");
                Console.WriteLine("| 0 - Sair");
                Console.WriteLine("|");
                Console.WriteLine("|==========================|");

                Console.WriteLine("\nDigite a opção desejada: ");
                op = Console.ReadLine();

            } while ( op != "0" );
        }
    }
}