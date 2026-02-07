namespace ejercicio_7
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string texto = txt_Texto.Text;
            if (!string.IsNullOrEmpty(texto))
            {
                listBox1.Items.Add(texto);
                txt_Texto.Clear();
            }

        }
    }
}
