using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedra_papel_tesoura_lagarto_Spock.Core.Model
{
    public sealed class Jogo
    {
        public string Jogador { get; set; }
        public TiposEnum Escolhas { get; set; }
    }
}
