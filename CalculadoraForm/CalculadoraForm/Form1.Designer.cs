﻿namespace CalculadoraForm
{
    partial class Form_Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Calculadora));
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSubtracao = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.ButtonDivisao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValor1 = new System.Windows.Forms.TextBox();
            this.textBoxValor2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSoma
            // 
            resources.ApplyResources(this.buttonSoma, "buttonSoma");
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonSubtracao
            // 
            resources.ApplyResources(this.buttonSubtracao, "buttonSubtracao");
            this.buttonSubtracao.Name = "buttonSubtracao";
            this.buttonSubtracao.UseVisualStyleBackColor = true;
            // 
            // buttonMultiplicacao
            // 
            resources.ApplyResources(this.buttonMultiplicacao, "buttonMultiplicacao");
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // ButtonDivisao
            // 
            resources.ApplyResources(this.ButtonDivisao, "ButtonDivisao");
            this.ButtonDivisao.Name = "ButtonDivisao";
            this.ButtonDivisao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxValor1
            // 
            resources.ApplyResources(this.textBoxValor1, "textBoxValor1");
            this.textBoxValor1.Name = "textBoxValor1";
            // 
            // textBoxValor2
            // 
            resources.ApplyResources(this.textBoxValor2, "textBoxValor2");
            this.textBoxValor2.Name = "textBoxValor2";
            // 
            // Form_Calculadora
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxValor2);
            this.Controls.Add(this.textBoxValor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonDivisao);
            this.Controls.Add(this.buttonMultiplicacao);
            this.Controls.Add(this.buttonSubtracao);
            this.Controls.Add(this.buttonSoma);
            this.Name = "Form_Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonSubtracao;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button ButtonDivisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxValor1;
        private System.Windows.Forms.TextBox textBoxValor2;
    }
}

