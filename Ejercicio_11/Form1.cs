namespace Ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            DateTime Fecha = dtp_Fecha.Value;
            lbl_FechaHora.Text = "La fecha guardada es: "+ Fecha.ToString("dd/mm/yyyy");
        }
    }
}
