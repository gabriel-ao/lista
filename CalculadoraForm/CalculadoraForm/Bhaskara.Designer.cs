namespace CalculadoraForm {
    partial class Bhaskara {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ButtonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelValor1 = new System.Windows.Forms.Label();
            this.labelValor2 = new System.Windows.Forms.Label();
            this.labelValor3 = new System.Windows.Forms.Label();
            this.textBoxValor1 = new System.Windows.Forms.TextBox();
            this.textBoxValor2 = new System.Windows.Forms.TextBox();
            this.textBoxValor3 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCalcular
            // 
            this.ButtonCalcular.Location = new System.Drawing.Point(179, 47);
            this.ButtonCalcular.Name = "ButtonCalcular";
            this.ButtonCalcular.Size = new System.Drawing.Size(75, 23);
            this.ButtonCalcular.TabIndex = 0;
            this.ButtonCalcular.Text = "Calcular";
            this.ButtonCalcular.UseVisualStyleBackColor = true;
            this.ButtonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(179, 79);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 1;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(179, 147);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelValor1
            // 
            this.labelValor1.AutoSize = true;
            this.labelValor1.Location = new System.Drawing.Point(16, 47);
            this.labelValor1.Name = "labelValor1";
            this.labelValor1.Size = new System.Drawing.Size(41, 13);
            this.labelValor1.TabIndex = 3;
            this.labelValor1.Text = "Valor A";
            // 
            // labelValor2
            // 
            this.labelValor2.AutoSize = true;
            this.labelValor2.Location = new System.Drawing.Point(16, 79);
            this.labelValor2.Name = "labelValor2";
            this.labelValor2.Size = new System.Drawing.Size(41, 13);
            this.labelValor2.TabIndex = 4;
            this.labelValor2.Text = "Valor B";
            // 
            // labelValor3
            // 
            this.labelValor3.AutoSize = true;
            this.labelValor3.Location = new System.Drawing.Point(15, 112);
            this.labelValor3.Name = "labelValor3";
            this.labelValor3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelValor3.Size = new System.Drawing.Size(41, 13);
            this.labelValor3.TabIndex = 5;
            this.labelValor3.Text = "Valor C";
            // 
            // textBoxValor1
            // 
            this.textBoxValor1.Location = new System.Drawing.Point(61, 47);
            this.textBoxValor1.Name = "textBoxValor1";
            this.textBoxValor1.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor1.TabIndex = 6;
            // 
            // textBoxValor2
            // 
            this.textBoxValor2.Location = new System.Drawing.Point(61, 79);
            this.textBoxValor2.Name = "textBoxValor2";
            this.textBoxValor2.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor2.TabIndex = 7;
            // 
            // textBoxValor3
            // 
            this.textBoxValor3.Location = new System.Drawing.Point(61, 112);
            this.textBoxValor3.Name = "textBoxValor3";
            this.textBoxValor3.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor3.TabIndex = 8;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(61, 149);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 9;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(16, 149);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(21, 13);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "x1 ";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(16, 188);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(18, 13);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "x2";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(61, 188);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 20);
            this.textBoxX2.TabIndex = 12;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(179, 112);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 13;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // Bhaskara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.textBoxValor3);
            this.Controls.Add(this.textBoxValor2);
            this.Controls.Add(this.textBoxValor1);
            this.Controls.Add(this.labelValor3);
            this.Controls.Add(this.labelValor2);
            this.Controls.Add(this.labelValor1);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.ButtonCalcular);
            this.Name = "Bhaskara";
            this.Text = "Baskara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCalcular;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelValor1;
        private System.Windows.Forms.Label labelValor2;
        private System.Windows.Forms.Label labelValor3;
        private System.Windows.Forms.TextBox textBoxValor1;
        private System.Windows.Forms.TextBox textBoxValor2;
        private System.Windows.Forms.TextBox textBoxValor3;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Button buttonFechar;
    }
}