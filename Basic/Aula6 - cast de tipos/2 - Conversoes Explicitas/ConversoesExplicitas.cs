using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            double divida = 1_234_567_890.123;
            // long copia = divida;

            double salario = 1_237.89;
            long copiaSalario = (long)salario;
            System.Console.WriteLine(copiaSalario);     // Perda de Precisão

            Animal animal = new Gato();
            Gato gato = (Gato)animal;
            System.Console.WriteLine(gato.GetType());
        }
    }
}
