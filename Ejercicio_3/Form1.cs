namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            string texto = txt_Texto.Text;
            lbl_Texto.Text = texto;
            txt_Texto.Clear();
        }
    }
}
