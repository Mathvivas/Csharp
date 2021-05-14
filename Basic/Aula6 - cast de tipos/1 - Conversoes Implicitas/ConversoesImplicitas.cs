using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_123_456_789;
            long inteiroLongo = inteiro;
            System.Console.WriteLine(inteiroLongo);

            //inteiro = inteiroLongo;   // Erro

            Gato gato = new Gato();
            Animal animal = gato;
            System.Console.WriteLine(animal.GetType());
            IAnimal ianimal = gato;
            System.Console.WriteLine(ianimal.GetType());
        }
    }
}

// TABELA DE CONVERSÕES NUMÉRICAS IMPLÍCITAS
// =========================================

// DE           PARA
// =======================================================
// sbyte        short, int, long, float, double, decimal
// byte         short, ushort, int, uint, long, ulong, float, double, decimal
// short        int, long, float, double, decimal
// ushort       int, uint, long, ulong, float, decimal, double
// int          long, float, double, decimal
// uint         long, ulong, float, double, decimal
// long         float, double, decimal
// char         ushort, int, uint, long, ulong, float, double, decimal 
// float        double
// ulong        float, double, decimal
// double       (nenhum)
// decimal      (nenhum)