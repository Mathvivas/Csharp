using System;

namespace Banco
{
    public class Conta
    {
        private TipoConta tipoConta { get; set; }

        private double saldo { get; set; }

        private double credito { get; set; }
        private string nome { get; set; }

        public Conta (TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.nome = nome;
            this.saldo = saldo;
            this.credito = credito;
            this.tipoConta = tipoConta;
        }

        public bool sacar (double valorSaque)
        {
            // Validação de saldo suficiente
            if ( this.saldo - valorSaque < (this.credito * -1) )
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }

            this.saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.nome, this.saldo);

            return true;
        }

        public void depositar (double valorDeposito)
        {
            this.saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.nome, this.saldo);
        }

        public void transferir (double valorTransferencia, Conta contaDestino)
        {
            if ( this.sacar(valorTransferencia) )
            {
                contaDestino.depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta: " + this.tipoConta + "\n";
            retorno += "Nome: " + this.nome + "\n";
            retorno += "Saldo: " + this.saldo + "\n";
            retorno += "Crédito: " + this.credito;
            return retorno;
        }
    }
}