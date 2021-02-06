using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            string op;

            do
            {
                op = menu.run();

                switch (op)
                {
                    case "1":
                        listarContas();
                        break;

                    case "2":
                        inserirConta();
                        break;

                    case "3":
                        transferir();
                        break;
                    
                    case "4":
                        sacar();
                        break;
                    
                    case "5":
                        depositar();
                        break;
                    
                    case "6":
                        Console.Clear();
                        break;

                    case "0":
                        Console.WriteLine("Obrigado! Até logo!");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida! Tente Novamente!");
                        break;
                }

            } while ( op != "0" );
        }
    }
}
