namespace Ejemplo2
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
            tbxValor = new TextBox();
            btnRegistrar = new Button();
            btnCalcularPromedio = new Button();
            lbValor = new Label();
            lbResultado = new Label();
            txbResultado = new TextBox();
            SuspendLayout();
            // 
            // tbxValor
            // 
            tbxValor.Location = new Point(214, 65);
            tbxValor.Name = "tbxValor";
            tbxValor.Size = new Size(184, 23);
            tbxValor.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(404, 65);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(87, 23);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(416, 135);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(75, 44);
            btnCalcularPromedio.TabIndex = 2;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(146, 68);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(36, 15);
            lbValor.TabIndex = 3;
            lbValor.Text = "Valor:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(120, 150);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(62, 15);
            lbResultado.TabIndex = 4;
            lbResultado.Text = "Resultado:";
            // 
            // txbResultado
            // 
            txbResultado.Location = new Point(214, 135);
            txbResultado.Multiline = true;
            txbResultado.Name = "txbResultado";
            txbResultado.Size = new Size(184, 44);
            txbResultado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 256);
            Controls.Add(txbResultado);
            Controls.Add(lbResultado);
            Controls.Add(lbValor);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(tbxValor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxValor;
        private Button btnRegistrar;
        private Button btnCalcularPromedio;
        private Label lbValor;
        private Label lbResultado;
        private TextBox txbResultado;
    }
}
