using System;
using System.Collections.Generic;
using System.Text;
using FutebolEngine.Entidades.Atributos;
using FutebolEngine.Types;

namespace FutebolEngine.Entidades
{
    public class Jogador : Pessoa
    {
        public Avancado Ataque { get; set; }
        public Meio Meio { get; set; }
        public Defesa Defesa { get; set; }

        public JogadorPosicao Posicao { get; set; }
    }
}
