using System;

namespace RegSeries
{
    class Program
    {
        static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        static SerieRepositorio repositorioSerie = new SerieRepositorio();

        static void Main(string[] args)
        {

            MenuUsuario menu = new MenuUsuario();
            string opcaoUsuario = menu.MostraMenuInicialDeOpcoes();

            while (opcaoUsuario != "X")
            {
                if (opcaoUsuario == "1")
                {
                    string opcaoFilme = menu.MostraMenuFilmes();
                    while (opcaoFilme != "X")
                    {
                        switch (opcaoFilme)
                        {
                            case "1":
                                ListaFilmes();
                                break;
                            case "2":
                                AdicionaFilme(menu);
                                break;
                            case "3":
                                AtualizaFilme(menu);
                                break;
                            case "E":
                                ExcluiFilme(); 
                                break;
                            case "C":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Informe um valor válido.");
                                break;
                        }
                        opcaoFilme = menu.MostraMenuFilmes();
                    }

                }

                if (opcaoUsuario == "2")
                {
                    string opcaoSerie = menu.MostraMenuSeries();
                    while (opcaoSerie != "X")
                    {
                        switch (opcaoSerie)
                        {
                            case "1":
                                ListaSerie();
                                break;
                            case "2":
                                AdicionaSerie(menu);
                                break;
                            case "3":
                                AtualizaSerie(menu);
                                break;
                            case "E":
                                ExcluiSerie();
                                break;
                            case "C":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Informe um valor válido.");
                                break;
                        }
                        opcaoSerie = menu.MostraMenuSeries();
                    }
                }
                opcaoUsuario = menu.MostraMenuInicialDeOpcoes();
            }
        }


        private static void ListaFilmes()
        {
            Console.WriteLine("Listando...");
            var lista = repositorioFilme.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }
            foreach (var item in lista)
            {
                var excluido = item.RetornaExcluido();
                if (!excluido)
                {
                    Console.WriteLine("ID: {0} - {1} - {2} - {3}", item.RetornaId(),
                                                                   item.RetornaTitulo(),
                                                                   item.RetornaAno(),
                                                                   item.RetornaPais());
                }
            }
        }

        private static void AdicionaFilme(MenuUsuario menu)
        {
            var titulo = menu.AdicionarTitulo();
            var ano = menu.AdicionarAno();
            var pais = menu.AdicionarPais();
            Filme novoFilme = new Filme(titulo, ano, pais);
            repositorioFilme.Insere(novoFilme);
            Console.WriteLine("Adicionando...");
        }

        private static void AtualizaFilme(MenuUsuario menu)
        {
            Console.Write("Digite o id para atualizar ");
            int indice = int.Parse(Console.ReadLine());
            var titulo = menu.AdicionarTitulo();
            var ano = menu.AdicionarAno();
            var pais = menu.AdicionarPais();
            repositorioFilme.Atualiza(indice, titulo, ano, pais);
            Console.WriteLine("Atualizando...");
        }

        private static void ExcluiFilme()
        {
            Console.Write("Digite o id para excluir: ");
            int indice = int.Parse(Console.ReadLine());
            repositorioFilme.Exclui(indice);
            Console.WriteLine("Excluindo...");
        }

        private static void ListaSerie()
        {
            Console.WriteLine("Listando...");
            var lista = repositorioSerie.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach (var item in lista)
            {
                var excluido = item.RetornaExcluido();
                if (!excluido)
                {
                    Console.WriteLine("ID: {0} - {1} - {2} - {3}", item.RetornaId(),
                                                                   item.RetornaTitulo(),
                                                                   item.RetornaAno(),
                                                                   item.RetornaPais());
                }
            }
        }

        private static void AdicionaSerie(MenuUsuario menu)
        {
            var titulo = menu.AdicionarTitulo();
            var ano = menu.AdicionarAno();
            var pais = menu.AdicionarPais();
            Serie novaSerie = new Serie(titulo, ano, pais);
            repositorioSerie.Insere(novaSerie);
            Console.WriteLine("Adicionando...");
        }

        private static void AtualizaSerie(MenuUsuario menu)
        {
            Console.Write("Digite o id para atualizar ");
            int indice = int.Parse(Console.ReadLine());
            var titulo = menu.AdicionarTitulo();
            var ano = menu.AdicionarAno();
            var pais = menu.AdicionarPais();
            repositorioSerie.Atualiza(indice, titulo, ano, pais);
            Console.WriteLine("Atualizando...");
        }

        private static void ExcluiSerie()
        {
            Console.Write("Digite o id para excluir: ");
            int indice = int.Parse(Console.ReadLine());
            repositorioSerie.Exclui(indice);
            Console.WriteLine("Excluindo...");
        }


    }
}
