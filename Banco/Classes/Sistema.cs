using System.Collections.Generic;
using System;

namespace Banco
{
    public class Sistema
    {
        static List<Conta> listContas = new List<Conta>();
        
        public void run()
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

        private static void inserirConta()
        {
            Console.WriteLine("\n|===| Inserir Nova Conta |===|");

            Console.WriteLine("\nDigite 1 para Conta Física ou 2 para Conta Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("\nDigite o Saldo Inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                                    saldo: entradaSaldo, 
                                                    credito: entradaCredito,
                                                    nome: entradaNome);

            listContas.Add(novaConta);
        }

        private static void listarContas() 
        {
            Console.WriteLine("\n|===| Listar Contas |===|");

            if ( listContas.Count == 0 )
            {
                Console.WriteLine("\nNenhuma conta cadastrada!");
                return;
            }

            for ( int i = 0; i < listContas.Count; i++ ) 
            {
                Conta conta = listContas[i];
                Console.WriteLine("\n#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        private static void sacar() 
        {
            Console.Write("\nDigite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].sacar(valorSaque);
        }

        private static void depositar()
        {
            Console.Write("\nDigite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].depositar(valorDeposito);
        }
    }
}