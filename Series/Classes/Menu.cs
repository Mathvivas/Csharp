using System;

namespace Series.Classes
{
    public class Menu
    {
        public string run()
        {
            string op;
            Console.WriteLine("\n|========| Menu |========|");
            Console.WriteLine("|");
            Console.WriteLine("| 1 - Listar Séries");
            Console.WriteLine("|");
            Console.WriteLine("| 2 - Inserir Nova Série");
            Console.WriteLine("|");
            Console.WriteLine("| 3 - Atualizar Série");
            Console.WriteLine("|");
            Console.WriteLine("| 4 - Excluir Série");
            Console.WriteLine("|");
            Console.WriteLine("| 5 - Visualizar Série");
            Console.WriteLine("|");
            Console.WriteLine("| 6 - Limpar Tela");
            Console.WriteLine("|");
            Console.WriteLine("| 0 - Sair");
            Console.WriteLine("|");
            Console.WriteLine("|==========================|");

            Console.WriteLine("\nDigite a opção desejada: ");
            op = Console.ReadLine();

            return op;
        }
    }
}