using System;

namespace Estrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizar BreakPoints para fazer um passo-a-passo.

            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}
