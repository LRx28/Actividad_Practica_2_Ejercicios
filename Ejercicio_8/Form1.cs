namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador = 0;
        private void btn_Precionar_Click(object sender, EventArgs e)
        {
            contador++;
            lbl_Contador.Text = "Contador: " + contador.ToString();

        }
    }
}
