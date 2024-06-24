using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_76
{
    class Jogo
    {
        public string nome;
        public string genero;
        public int anoLancamento;

        public Jogo(string nomeJogo, string generoJogo, int anoLancamentoJogo)
        {
            nome = nomeJogo;
            genero = generoJogo;
            anoLancamento = anoLancamentoJogo;
        }
    }
}
