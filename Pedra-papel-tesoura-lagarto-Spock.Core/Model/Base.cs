using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedra_papel_tesoura_lagarto_Spock.Core.Model
{
    public abstract class Base
    {
        public string Jogador1 { get; internal set; }
        public string Jogador2 { get; internal set; }
    }
}
