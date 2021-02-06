using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta (TipoConta.PessoaFisica, 500, 0, "Matheus");

            Console.WriteLine(conta.ToString());
        }
    }
}
