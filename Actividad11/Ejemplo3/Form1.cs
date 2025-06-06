namespace Ejemplo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] numeros = new double[100];
        int contador = 0;
        double acumulador = 0;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            numeros[contador] = Convert.ToDouble(tbValor.Text);
            contador++;

            for (int n = 0; n < contador; n++) { 
                acumulador += numeros[n];
            }

            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;

            txResultado.Text = $@"Promedio:
            {promedio,10:f2}";
        }
    }
}
