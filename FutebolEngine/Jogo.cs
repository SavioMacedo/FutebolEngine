using FutebolEngine.Entidades;
using FutebolEngine.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutebolEngine
{
    public class Jogo
    {
        public Entidades.Campo Campo { get; set; }

        public Jogo()
        {
            this.Campo = new Entidades.Campo();
        }



        public void AdicionarJogador(Jogador jogador)
        {
            switch(jogador.Posicao)
            {
                case JogadorPosicao.Atacante:
                    this.AdicionarJogadorAtaque(jogador);
                    break;
                case JogadorPosicao.Volante:
                    this.AdicionarJogadorMeioCampo(jogador);
                    break;
                case JogadorPosicao.MeioCampo:
                    this.AdicionarJogadorMeioCampo(jogador);
                    break;
                case JogadorPosicao.MeioAtacante:
                    this.AdicionarJogadorMeioCampo(jogador);
                    break;
                case JogadorPosicao.Goleiro:
                    this.AdicionarJogadorDefesa(jogador);
                    break;
                case JogadorPosicao.Zagueiro:
                    this.AdicionarJogadorDefesa(jogador);
                    break;
                case JogadorPosicao.LateralEsquerdo:
                    this.AdicionarJogadorDefesa(jogador);
                    break;
                case JogadorPosicao.LateralDireito:
                    this.AdicionarJogadorDefesa(jogador);
                    break;
                default:
                    throw new Exception("Posição do jogador não existente.");

            }
        }

        private void AdicionarJogadorAtaque(Jogador jogador)
        {
            this.Campo.Alto.Jogadores.Add(jogador);
        }

        private void AdicionarJogadorMeioCampo(Jogador jogador)
        {
            this.Campo.Meio.Jogadores.Add(jogador);
        }

        private void AdicionarJogadorDefesa(Jogador jogador)
        {
            this.Campo.Baixo.Jogadores.Add(jogador);
        }
    }
}
