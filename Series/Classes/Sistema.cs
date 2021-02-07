using System;

namespace Series.Classes
{
    public class Sistema
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
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
                        listarSerie();
                        break;

                    case "2":
                        inserirSerie();
                        break;

                    case "3":
                        atualizarSerie();
                        break;
                    
                    case "4":
                        excluirSerie();
                        break;
                    
                    case "5":
                        visualizarSerie();
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

        private static void listarSerie()
        {
            Console.WriteLine("\n|===| Listar Séries |===|");

            var lista = repositorio.lista();

            if ( lista.Count == 0 )
            {
                Console.WriteLine("Nenhuma série cadastrada!");
                return;
            }

            foreach ( var serie in lista )
            {
                Console.WriteLine("#ID {0}: {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }

        private static void inserirSerie()
        {
            Console.WriteLine("\n|===| Inserie Nova Série |===|");

            foreach ( int i in Enum.GetValues(typeof(Genero)) )
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.proximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        descricao: entradaDescricao,
                                        ano: entradaAno);
            
            repositorio.insere(novaSerie);
        }

        private static void atualizarSerie()
        {
            Console.WriteLine("\n|===| Atualizar Série |===|");
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach ( int i in Enum.GetValues(typeof(Genero)) )
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            descricao: entradaDescricao,
                                            ano: entradaAno);

            repositorio.atualiza(indiceSerie, atualizaSerie);
        }

        private static void excluirSerie()
        {
            Console.WriteLine("\n|===| Excluir Série |===|");
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.exclui(indiceSerie);
        }
    }
}