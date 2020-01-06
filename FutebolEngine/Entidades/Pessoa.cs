using System;
using System.Collections.Generic;
using System.Text;

namespace FutebolEngine.Entidades
{
    public class Pessoa : Objeto
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
    }
}
