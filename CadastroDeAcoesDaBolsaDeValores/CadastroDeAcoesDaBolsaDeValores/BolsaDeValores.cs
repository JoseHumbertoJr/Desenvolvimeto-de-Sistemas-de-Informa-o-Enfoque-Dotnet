
using CadastroDeAcoesDaBolsaDeValores.Model;
using System;
using System.Collections.Generic;


namespace CadastroDeAcoesDaBolsaDeValores
{
    class BolsaDeValores
    {
        public static List<Acoes> listaAcoes = new List<Acoes>();

        public void CadastroAcao()
        {
            Console.WriteLine("Cadastro Ação");
            Console.Write("Digite o Código da Ação: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de ações ");
            String qtdAcoes = Console.ReadLine();
           
            BolsaDeValores.listaAcoes.Add(new Acoes(codigo, qtdAcoes));
                
            



        }
        public void PesquisaAcao()
        {
            Console.WriteLine("Pesquisar Ação");
            Console.Write("Digite o código da Ação: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado da Pesquisa:");

            for (int i = 0; i < listaAcoes.Count; i++)
            {
                if (listaAcoes[i].Codigo == codigo)
                {
                    Console.Write("#Código da Ação: "+listaAcoes[i].Codigo+" -> ");
                    Console.WriteLine("Quantidade de Ações("+listaAcoes[i].QtdAcao+")");
                }
            }
        }
        public void VisualizarCarteiraAcao()
        {
            Console.WriteLine("**************Carteira de Ações****************");
            for (int i = 0; i < listaAcoes.Count; i++)
            {
                Console.Write("#Código da Ação: " + listaAcoes[i].Codigo + " -> ");
                Console.WriteLine("Quantidade de Ações("+listaAcoes[i].QtdAcao+")");

            }
        }

    }
}
