using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDelegate
{
    class Program
    {
        public delegate int Funcao(int n1, int n2);

        static void Main(string[] args)
        {
            Funcao funcao = new Funcao(Operacoes.Soma);
            int resultado = funcao(1, 3);

            decimal x = 7 / 5;
            Console.WriteLine(x);


            Console.WriteLine($"Soma: {resultado}");

            funcao = new Funcao(Operacoes.Subtracao);
            resultado = funcao(2, 1);

            Console.WriteLine($"Subtração: {resultado}");

            funcao = new Funcao(Operacoes.Divisao);
            resultado = funcao(10, 5);

            Console.WriteLine($"Divisão: {resultado}");

            funcao = new Funcao(Operacoes.Multiplicacao);
            resultado = funcao(8, 8);

            Console.WriteLine($"Multiplicação: {resultado}");

            Console.ReadLine();
        }
    }
}
