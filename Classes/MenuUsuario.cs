using System;

namespace RegSeries
{

    public class MenuUsuario
    { 
        static SerieRepositorio repositorioSerie = new SerieRepositorio();
        static FilmeRepositorio repositorioFilme = new FilmeRepositorio();

        public string MostraMenuInicialDeOpcoes()
        {
            Console.WriteLine();
            Console.WriteLine("Qual repositório dejesa acessar? (Digitar o número equivalente)");

            Console.WriteLine("1 - Filmes");
            Console.WriteLine("2 - Séries");
            Console.WriteLine("X - Sair");

            string opcaoEscolhida = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoEscolhida;
        }

        public string MostraMenuFilmes()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Listar filmes");
            Console.WriteLine("2 - Adicionar um filme");
            Console.WriteLine("3 - Atualizar um filme");
            Console.WriteLine("E - Excluir um filme");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.Write("Opção: ");

            string opcaoEscolhida = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoEscolhida;
        }

        public string MostraMenuSeries()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Adicionar uma série");
            Console.WriteLine("3 - Atualizar uma série");
            Console.WriteLine("E - Excluir uma série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.Write("Opção: ");

            string opcaoEscolhida = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoEscolhida;
        } 

        public void InserirSerie()
        {
			Console.Write("Título: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o ano: ");
			int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite o país de origem: ");
            string entradaPais = Console.ReadLine();

        

			Serie novaSerie = new Serie(id: repositorioSerie.ProximoId(),
										titulo: entradaTitulo,
										ano: entradaAno,
                                        pais: entradaPais);

			repositorioSerie.Insere(novaSerie);
        }
        
        public static void ListarSeries()
        {
            var lista = repositorioSerie.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach(var serie in lista)
            {
                var excluido = serie.RetornaExcluido();
                if(!excluido)
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.RetornaId(), serie.RetornaTitulo());
                }
                
            }
        }

        public static void ExcluirSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorioSerie.Exclui(indiceSerie);
		}

        public static void VisualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorioSerie.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

        public static void AtualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			Console.Write("Título: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o ano: ");
			int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite o país de origem: ");
            string entradaPais = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
										titulo: entradaTitulo,
										ano: entradaAno,
                                        pais: entradaPais);

			repositorioSerie.Atualiza(indiceSerie, atualizaSerie);
		}

    }
}