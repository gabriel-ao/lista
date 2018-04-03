using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraForm
{
    class Operacoes
    {
         public double x { get; private set; }
         public double y { get; private set; }
         private double  resultado;
        
        public Operacoes(double valor1, double valor2)
        {
            this.x = valor1;
            this.y = valor2;
        }

        public double SetSoma()
        {
            this.resultado = (x + y);
            return this.resultado;
        }


        public double SetMultiplicacao()
        {
            this.resultado = (x * y);
            return this.resultado;
        }

        public double SetDivisao()
        {
            this.resultado = (x / y);
            return this.resultado;
        }

        public double SetSubtracao()
        {
            this.resultado = (x - y);
            return this.resultado;
        }

        public int setPotenciacao() {
            // x é o numero multiplicado
            // y é o quantidade de vezes multiplicada
            double aux = x;
            for (int i = 1; i < y; i++) {
                aux = aux * x;
            }

            return Convert.ToInt32(aux);
        }
    }
}
