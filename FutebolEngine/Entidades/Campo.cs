using FutebolEngine.Campo.Area.Particao;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutebolEngine.Entidades
{
    public class Campo: Objeto
    {
        public Alto Alto { get; set; }
        public Meio Meio { get; set; }
        public Baixo Baixo { get; set; }
    }
}
