using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora");

            Console.WriteLine("Digite o primeiro numero para calcular");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite as seguntes opções+ " +
                "1 - soma" +
                "2 - multiplicação " +
                "3 - divisao" +
                "4 - subtração" +
                "5 - Sair");

            Console.WriteLine("Digite o segundo numero para calcular");
            int y = Convert.ToInt32(Console.ReadLine());

        }
    }
}
