using CadastroDeAcoesDaBolsaDeValores.Model;
using System;
using System.Linq;

namespace CadastroDeAcoesDaBolsaDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ExibirMenu();

                try
                {
                    int opcao = int.Parse(Console.ReadLine());
                    if (opcao == 0) break;

                    ExecutarAcao(opcao);
                    Console.WriteLine("Enter para continuar...");
                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Opção inválida. Por favor digite uma opção válida!");
                    Console.WriteLine("Enter para continuar...");
                    Console.ReadLine();
                }
            } while (true);
        }
        
        private static void ExecutarAcao(int opcao)
        {
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    {
                        BolsaDeValores bolsa = new BolsaDeValores();                        
                        bolsa.CadastroAcao();
                    }
                    break;
                case 2:
                    {
                        BolsaDeValores bolsa = new BolsaDeValores();
                        bolsa.PesquisaAcao();
                    }
                    break;
             
                case 3:
                    {
                        BolsaDeValores bolsa = new BolsaDeValores();
                        bolsa.VisualizarCarteiraAcao();
                    }
                    break;
      
                default:
                    break;
            }
        }
        private static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("******* Bolsa de Valores *******");
            Console.Write("");

            Console.WriteLine("1 - Cadastrar Ação");
            Console.WriteLine("2 - Pesquisar por Ação");
            Console.WriteLine("3 - Visualizar Carteira de Açôes");
            Console.WriteLine("0 - Sair");

            Console.Write("Digite uma opção: ");
        }

    }
}
