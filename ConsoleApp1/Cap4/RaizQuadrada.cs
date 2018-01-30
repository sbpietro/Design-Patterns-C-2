using ConsoleApp1.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cap4
{
    class RaizQuadrada : IExpressao
    {
        public IExpressao Expressao { get; private set; }

        public RaizQuadrada(IExpressao e)
        {
            this.Expressao = e;
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(Expressao.Avalia());
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeRaiz(this);
        }
    }
}
