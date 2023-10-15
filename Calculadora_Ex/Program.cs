using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Ex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculadora\n");

            while()
            Console.Write("Insira o primeiro número da operação: ");

            string strNum1 = Console.ReadLine();
            if (!int.TryParse(strNum1, out int num1))
            {
                Console.WriteLine("Número inválido, insira um número inteiro!");
                //while pra caso a pessoa erre
                Environment.Exit(-1);
            }

            Console.Write("Insira o segundo número da operação: \n");
            string strNum2 = Console.ReadLine();
            if (!int.TryParse(strNum2, out int num2))
            {
                Console.WriteLine("Número inválido, insira um número inteiro!");
                //while pra caso a pessoa erre
                Environment.Exit(-1);
            }

            Console.WriteLine("Escolha a operação que deseja realizar: \n");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");

            string opcao = Console.ReadLine();
            opcao.ToLower();
            if (opcao.Equals("1") || opcao.Equals("soma") || opcao.Equals("+"))             
            {
                Console.WriteLine($"Resultado: {Calculadora.Somar(num1, num2)}");
            }
            else if (opcao.Equals("2") || opcao.Equals("subtrair") || opcao.Equals("-"))
            {
                Console.WriteLine($"Resultado: {Calculadora.Subtrair(num1, num2)}");
            }
            else if (opcao.Equals("3") || opcao.Equals("multiplicar") || opcao.Equals("*"))
            {
                Console.WriteLine($"Resultado: {Calculadora.Multiplicar(num1, num2)}");
            }
            else if (opcao.Equals("4") || opcao.Equals("dividir") || opcao.Equals("/"))
            {
                Console.WriteLine($"Resultado: {Calculadora.Dividir(num1, num2)}");
            }


            Console.ReadLine();
        }
    }
}
