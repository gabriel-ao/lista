using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraForm {
    class Operacoes {
        // quando eu iniciei esse codigo, eu Deus sabia o que eu estava fazendo
        public double x { get; private set; }
        public double y { get; private set; }
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        private double resultado;
        private double raizFeita;

        // Construtores

        // calculadora simples
        public Operacoes(double valor1, double valor2) {
            this.x = valor1;
            this.y = valor2;
        }

        // Bhaskara - exercicio 7
        public Operacoes(double A, double B, double C) {
            this.A = A;
            this.B = B;
            this.C = C;

            resultado = (B * B) + (-4 * A * C);

            raizFeita = Math.Sqrt(resultado);
        }

        // metodos de operações basicas
        public double SetSoma() {
            this.resultado = (x + y);
            return this.resultado;
        }

        public double SetMultiplicacao() {
            this.resultado = (x * y);
            return this.resultado;
        }

        public double SetDivisao() {
            this.resultado = (x / y);
            return this.resultado;
        }

        public double SetSubtracao() {
            this.resultado = (x - y);
            return this.resultado;
        }


        // EXERCICIO 6
        public int setPotenciacao() {
            // x é o numero multiplicado
            // y é o quantidade de vezes multiplicada
            double aux = x;
            for (int i = 1; i < y; i++) {
                aux = aux * x;
            }
            return Convert.ToInt32(aux);
        }


        //EXERCICIO 7



        public double x1() {
            double valorDeX1 = (-B + raizFeita) / (2 * A);
            return valorDeX1;
        }

        public double x2() {
            double valorDeX2 = (-B - raizFeita) / (2 * A);
            return valorDeX2;
        }

        // agora só Deus sabe


        /*
            5) Crie uma classe chamada Calculadora, que possua métodos para realizar as
            4operações básicas com números do tipo double. Cada um dos quatro métodos da
            classe deve apenas retornar o valor da operação realizada, recebendo apenas
            2números como parâmetros.


            6) Adicione um método na classe Calculadora, que seja capaz de realizar operações
            de potência entre 2 números inteiros.Considerando que o método tome como parâmetro
            X e Y, o resultado deverá ser igual a X elevado a Y. Por exemplo, para X = 2 e Y = 3, o
            resultado será 2 elevados a três, que é o mesmo que 2*2*2.


            7) Adicione um método na classe Calculadora para calcular a fórmula de Báskara,
            tomando como parâmetro, 3 doubles representando a, b e c na fórmula.

         */
    }
}