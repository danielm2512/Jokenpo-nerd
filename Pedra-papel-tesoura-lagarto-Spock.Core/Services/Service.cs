using Pedra_papel_tesoura_lagarto_Spock.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pedra_papel_tesoura_lagarto_Spock.Core
{
    public class Service
    {
		public async Task<Tuple<string, HttpStatusCode>> ContraComputador(Jogo jogo)
		{
            try
            {
                string resultado = "";
                var escolhacomputador = (TiposEnum)Enum.GetValues(typeof(TiposEnum)).GetValue((new Random().Next(1, 5)));

                switch (jogo.Escolhas)
                {
                    case TiposEnum.Pedra:
                        resultado = new Pedra(jogo.Jogador, "Computador").Verify(escolhacomputador);
                        break;
                    case TiposEnum.Papel:
                        resultado = new Papel(jogo.Jogador, "Computador").Verify(escolhacomputador);
                        break;
                    case TiposEnum.Tesoura:
                        resultado = new Tesoura(jogo.Jogador, "Computador").Verify(escolhacomputador);
                        break;
                    case TiposEnum.Lagarto:
                        resultado = new Largato(jogo.Jogador, "Computador").Verify(escolhacomputador);
                        break;
                    case TiposEnum.Spock:
                        resultado = new Spock(jogo.Jogador, "Computador").Verify(escolhacomputador);
                        break;
                    default:
                        break;
                }

                return new Tuple<string, HttpStatusCode>(resultado, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new Tuple<string, HttpStatusCode>(ex.ToString(), HttpStatusCode.BadRequest);
            }
			
		}

        public async Task<Tuple<string,HttpStatusCode>> JogadorXJogador(List<Jogo> jogo)
        {
            try
            {
                string resultado = "";

                switch (jogo[0].Escolhas)
                {
                    case TiposEnum.Pedra:
                        resultado = new Pedra(jogo[0].Jogador, jogo[1].Jogador).Verify(jogo[1].Escolhas);
                        break;
                    case TiposEnum.Papel:
                        resultado = new Papel(jogo[0].Jogador, jogo[1].Jogador).Verify(jogo[1].Escolhas);
                        break;
                    case TiposEnum.Tesoura:
                        resultado = new Tesoura(jogo[0].Jogador, jogo[1].Jogador).Verify(jogo[1].Escolhas);
                        break;
                    case TiposEnum.Lagarto:
                        resultado = new Largato(jogo[0].Jogador, jogo[1].Jogador).Verify(jogo[1].Escolhas);
                        break;
                    case TiposEnum.Spock:
                        resultado = new Spock(jogo[0].Jogador, jogo[1].Jogador).Verify(jogo[1].Escolhas);
                        break;
                    default:
                        break;
                }

                return new Tuple<string, HttpStatusCode>(resultado, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new Tuple<string, HttpStatusCode>(ex.ToString(), HttpStatusCode.BadRequest);
            }

        }
    }
}
