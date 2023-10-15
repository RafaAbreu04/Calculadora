using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Ex
{
    public static class Calculadora
    {
        public static int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        public static int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        public static int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }

        public static int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }
}
