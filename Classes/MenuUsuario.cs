using System;
using RegSeries.Interfaces;
using System.Collections.Generic;

namespace RegSeries
{

    public class MenuUsuario
    { 

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

        public string AdicionarTitulo()
        {
            Console.Write("Título: ");
            string entradaTitulo = Console.ReadLine();
            return entradaTitulo;
        }

        public int AdicionarAno()
        {
            Console.Write("Ano: ");
            int entradaAno = int.Parse(Console.ReadLine());
            return entradaAno;
        }

        public string AdicionarPais()
        {
            Console.Write("País: ");
            string entradaPais = Console.ReadLine();
            return entradaPais;
        }
    }
}