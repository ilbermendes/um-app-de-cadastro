using System;

namespace RegSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static string MostraMenuDeOpcoes()
        {
            Console.WriteLine();
            Console.WriteLine("Informe uma das opções abaixo:");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir uma nova série");
            Console.WriteLine("3 - Atualizar uma série");
            Console.WriteLine("4 - Exibir uma série"); 
            Console.WriteLine("E - Excluir uma série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");

            string opcaoEscolhida = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoEscolhida;
        }
    }
}
