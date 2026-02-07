namespace Ejercicio_9
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Validar_Click(object sender, EventArgs e)
        {
            string valorTexbox = txt_Valor.Text;
            if (int.TryParse(valorTexbox, out int numero))

                lbl_Valor.Text = $"El valor ingresado es numerico. El valor ingresado es: {valorTexbox}";

            else
                lbl_Valor.Text = $"-- ERROR -- : valor ingresado no es numerico";

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Valor.Clear();
            lbl_Valor.Text = string.Empty;  

        }
    }
}
