namespace Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todoa los archivos (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string contenido = File.ReadAllText(openFileDialog1.FileName);
                txt_Contenido.Text = contenido;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "Guardar archivo de texto";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txt_Contenido.Text);
                MessageBox.Show("Archivo guardado");
            }
        }
    }
}
