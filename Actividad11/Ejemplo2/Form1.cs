namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double acumulador = 0;
        int contador = 0;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            acumulador += Convert.ToDouble(tbxValor.Text);
            contador++;

            tbxValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;
            //lbResultado.Text = $"{promedio:f2}";

            txbResultado.Text = $@"Promedio:
            {promedio,10:f2}";
        }
    }
}
