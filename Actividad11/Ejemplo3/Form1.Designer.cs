namespace Ejemplo3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegistrar = new Button();
            btnCalcularPromedio = new Button();
            lbValor = new Label();
            lbResultado = new Label();
            tbValor = new TextBox();
            txResultado = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(541, 132);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(541, 198);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(75, 50);
            btnCalcularPromedio.TabIndex = 1;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(357, 135);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(36, 15);
            lbValor.TabIndex = 2;
            lbValor.Text = "Valor:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(331, 216);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(62, 15);
            lbResultado.TabIndex = 3;
            lbResultado.Text = "Resultado:";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(418, 132);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 4;
            // 
            // txResultado
            // 
            txResultado.Location = new Point(418, 198);
            txResultado.Multiline = true;
            txResultado.Name = "txResultado";
            txResultado.Size = new Size(100, 50);
            txResultado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txResultado);
            Controls.Add(tbValor);
            Controls.Add(lbResultado);
            Controls.Add(lbValor);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCalcularPromedio;
        private Label lbValor;
        private Label lbResultado;
        private TextBox tbValor;
        private TextBox txResultado;
    }
}
