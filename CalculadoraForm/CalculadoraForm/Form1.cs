using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm {
    public partial class Form_Calculadora : Form {
        Operacoes calcular;
        double x = 0, y = 0, resultado;

        public Form_Calculadora() {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e) {
            x = Convert.ToDouble(textBoxValor1.Text);
            y = Convert.ToDouble(textBoxValor2.Text);
            calcular = new Operacoes(x, y);
            resultado = calcular.SetSoma();
            textBoxResultado.Text = (Convert.ToString(resultado));
        }

        private void buttonSubtracao_Click(object sender, EventArgs e) {
            x = Convert.ToDouble(textBoxValor1.Text);
            y = Convert.ToDouble(textBoxValor2.Text);
            calcular = new Operacoes(x, y);
            resultado = calcular.SetSubtracao();
            textBoxResultado.Text = (Convert.ToString(resultado));
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e) {
            x = Convert.ToDouble(textBoxValor1.Text);
            y = Convert.ToDouble(textBoxValor2.Text);
            calcular = new Operacoes(x, y);
            resultado = calcular.SetMultiplicacao();
            textBoxResultado.Text = (Convert.ToString(resultado));
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e) {
            textBoxValor1.Clear();
            textBoxValor2.Clear();
            textBoxResultado.Clear();
        }

        private void ButtonDivisao_Click(object sender, EventArgs e) {
            x = Convert.ToDouble(textBoxValor1.Text);
            y = Convert.ToDouble(textBoxValor2.Text);
            calcular = new Operacoes(x, y);
            resultado = calcular.SetDivisao();
            textBoxResultado.Text = (Convert.ToString(resultado));
        }


        private void buttonSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }
}
