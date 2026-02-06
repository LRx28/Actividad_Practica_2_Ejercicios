namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdb_Opcion1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_Opcion2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_Opcion3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (rdb_Opcion1.Checked)
            {
                lbl_Texto.Text = "Ha seleccionado la opción 1";
            }
            else if (rdb_Opcion2.Checked)
            {
                lbl_Texto.Text = "Ha seleccionado la opción 2";
            }
            else if (rdb_Opcion3.Checked)
            {
                lbl_Texto.Text = "Ha seleccionado la opción 3";
            }
            else
            {
                lbl_Texto.Text = "No ha seleccionado ninguna opción";
            }
        }
    }
}
