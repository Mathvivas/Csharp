﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;      // tipo de valor
            object caixa = numero;      // boxing

            try {
                int unboxed = (int)caixa;

                System.Console.WriteLine("Unboxing OK.");

            } catch (System.InvalidCastException e) {
                System.Console.WriteLine($"{e} Erro: Unboxing Incorreto.");
            }
        }
    }
}
