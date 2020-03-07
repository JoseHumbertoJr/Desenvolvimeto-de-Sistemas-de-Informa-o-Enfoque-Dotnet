using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeAcoesDaBolsaDeValores.Model
{
    class Acoes
    {
            public int Codigo { get; }
            public String QtdAcao { get; }

            private List<int> acoes;

        public Acoes(int codigo, String qtdAcao)
        {
            Codigo = codigo;
            QtdAcao = qtdAcao;
        }
        public Acoes(String qtdAcao)
        {
            QtdAcao = qtdAcao;
        }

    }
}
