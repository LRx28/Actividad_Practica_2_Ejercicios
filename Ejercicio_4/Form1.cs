namespace Ejercicio_4
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
                int valor1, valor2, Resultado;

                valor1 = int.Parse(txt_Valor1.Text);
                valor2 = int.Parse(txt_Valor2.Text);
                Resultado = valor1 + valor2;
                lbl_Resultado.Text = Resultado.ToString();

            }
            catch (Exception x)
            {

                MessageBox.Show($"{x}");
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Valor1.Clear();
            txt_Valor2.Clear();
            lbl_Resultado.Text = "";
        }
    }
}