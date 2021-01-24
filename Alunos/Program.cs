using System;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indice = 0;

            string opcao;
            do
            {
                opcao = Menu();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nInforme o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        
                        Console.WriteLine("\nInforme a nota do aluno: ");
                        if ( decimal.TryParse(Console.ReadLine(), out decimal nota )) {
                            aluno.Nota = nota;

                        } else {
                            throw new ArgumentException("\nValor da nota deve ser decimal!");
                        }

                        alunos[indice] = aluno;
                        indice++;
                        break;

                    case "2":
                        foreach( Aluno aluno1 in alunos ) {

                            if ( aluno1.Nome != null ) {     // !string .IsNullOrEmpty(aluno1.Nome)
                                Console.WriteLine($"\nALUNO: {aluno1.Nome} \nNOTA: {aluno1.Nota} \n_________________");
                            }
                        }
                        break;

                    case "3":
                        decimal total = 0;
                        int numAlu = 0;

                        for ( int i = 0; i < alunos.Length; i++ ) {
                            if ( alunos[i].Nome != null ) {
                                total += alunos[i].Nota;
                                numAlu++; 
                            }
                        }

                        decimal media = total / numAlu;
                        Conceito conceito = 0;

                        switch (media) 
                        {
                            case < 2:
                                conceito = Conceito.E;
                                break;

                            case < 4:
                                conceito = Conceito.D;
                                break;

                            case < 6:
                                conceito = Conceito.C;
                                break;

                            case < 8:
                                conceito = Conceito.B;
                                break;

                            case <= 10:
                                conceito = Conceito.A;
                                break;
                        }

                        Console.WriteLine($"\nMÉDIA: {media} \nCONCEITO: {conceito}");
                        break;

                    case "0":
                        Console.WriteLine("FIM");
                        break;

                    default:
                        Console.WriteLine("\nOpção não existe! Tente outra vez!");    // Não para a execução
                        //throw new ArgumentOutOfRangeException();                  // Para a execução
                        break;
                }

            } while ( opcao != "0" );

        }


        private static string Menu()
        {
            string opcao;
            
            Console.WriteLine("\n|__________________________|");
            Console.WriteLine("| 1 - Inserir Novo Aluno");
            Console.WriteLine("|");
            Console.WriteLine("| 2 - Listar Alunos");
            Console.WriteLine("|");
            Console.WriteLine("| 3 - Calcular Média Geral");
            Console.WriteLine("|");
            Console.WriteLine("| 0 - Sair");
            Console.WriteLine("|__________________________|\n");

            Console.WriteLine("Informe a opção desejada: ");
            opcao = Console.ReadLine();

            return opcao;
        }
    }
}
