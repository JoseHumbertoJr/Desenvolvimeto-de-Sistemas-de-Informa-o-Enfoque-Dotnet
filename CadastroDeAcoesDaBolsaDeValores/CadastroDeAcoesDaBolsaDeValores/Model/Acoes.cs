using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeAcoesDaBolsaDeValores.Model
{
    class Acoes
    {
            public int Codigo { get; }
            public int QtdAcao { get; set; }

            private List<int> acoes;

        public Acoes(int codigo, int qtdAcao)
        {
            Codigo = codigo;
            QtdAcao = qtdAcao;
        }
        public Acoes(int qtdAcao)
        {
            QtdAcao = qtdAcao;
        }

    }
}
