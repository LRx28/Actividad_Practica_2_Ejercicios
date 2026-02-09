namespace Ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int grados_Celsius, grados_Fahrenheit;
                grados_Celsius = Convert.ToInt32(txb_Grados.Text);
                grados_Fahrenheit = (grados_Celsius * 9 / 5) + 32;
                lbl_Resultado.Text = grados_Fahrenheit.ToString();
            }
            catch (Exception x)
            {

                MessageBox.Show("Error: Ingresa valores numericos: " + x);
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txb_Grados.Clear();
            lbl_Resultado.Text = string.Empty;
        }
    }
}
    