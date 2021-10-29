﻿using Pedra_papel_tesoura_lagarto_Spock.Core.Interface;
using Pedra_papel_tesoura_lagarto_Spock.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedra_papel_tesoura_lagarto_Spock.Core
{
    public sealed class Pedra : Base, IVerificaEscolha
    {
        public Pedra(string jogador1, string jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
        }

        public string Verify(TiposEnum escolha)
        {
            switch (escolha)
            {
                case TiposEnum.Pedra:
                    return "Jogo deu Empate!";
                case TiposEnum.Papel:
                    return ($"{Jogador1} Perdeu!, {Jogador2} Venceu");
                case TiposEnum.Tesoura:
                    return ($"{Jogador1} Venceu!, {Jogador2} Perdeu");
                case TiposEnum.Lagarto:
                    return ($"{Jogador1} Venceu!, {Jogador2} Perdeu");
                case TiposEnum.Spock:
                    return ($"{Jogador1} Perdeu!, {Jogador2} Venceu");
                default:
                    throw new NotImplementedException("Erro");
            }
        }
    }
}
