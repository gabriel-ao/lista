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
    public partial class Bhaskara : Form {

        public Bhaskara() {
            InitializeComponent();
        }

        Operacoes bhaskara;
        double A=0, B=0, C=0, resultado1, resultado2;

        private void buttonFechar_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void ButtonCalcular_Click(object sender, EventArgs e) {
            A = Convert.ToDouble(textBoxValor1.Text);
            B = Convert.ToDouble(textBoxValor2.Text);
            C = Convert.ToDouble(textBoxValor3.Text);
            bhaskara = new Operacoes(A, B, C);
            resultado1 = bhaskara.x1();
            resultado2 = bhaskara.x2();
            textBoxX1.Text = Convert.ToString(resultado1);
            textBoxX2.Text = Convert.ToString(resultado2);
        }

        private void buttonSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void buttonLimpar_Click(object sender, EventArgs e) {
            textBoxValor1.Clear();
            textBoxValor2.Clear();
            textBoxValor3.Clear();
            textBoxX1.Clear();
            textBoxX2.Clear();
        }
    }
}
