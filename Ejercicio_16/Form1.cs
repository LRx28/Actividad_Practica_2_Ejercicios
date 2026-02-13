namespace Ejercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string operador = "";
        double num_1 = 0;
        double num_2 = 0;
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Contenido.Text = "0";
            num_1 = 0;
            num_2 = 0;
            operador = "";

        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            if (txt_Contenido.Text.Length == 1) 
            {
                txt_Contenido.Text = "0";
            }
            else
            {
                txt_Contenido.Text = txt_Contenido.Text.Substring(0, txt_Contenido.Text.Length - 1);
            }
        }
    }
}
