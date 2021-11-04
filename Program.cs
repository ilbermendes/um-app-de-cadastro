using System;

namespace RegSeries
{
    class Program
    {
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
                                Console.WriteLine("Listando...");
                                break;
                            case "2":
                                Console.WriteLine("Adicionando...");
                                break;
                            case "3":
                                Console.WriteLine("Atualizando...");
                                break;
                            case "E":
                                Console.WriteLine("Excluindo...");
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
                                Console.WriteLine("Listando...");
                                break;
                            case "2":
                                Console.WriteLine("Adicionando...");
                                break;
                            case "3":
                                Console.WriteLine("Atualizando...");
                                break;
                            case "E":
                                Console.WriteLine("Excluindo...");
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
    }
}
