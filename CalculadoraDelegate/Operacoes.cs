using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDelegate
{
    class Operacoes
    {
        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Subtracao(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiplicacao(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Divisao(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
