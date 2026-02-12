namespace Ejercicio_15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Abrir = new Button();
            btn_Guardar = new Button();
            openFileDialog1 = new OpenFileDialog();
            txt_Contenido = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // btn_Abrir
            // 
            btn_Abrir.BackColor = SystemColors.Info;
            btn_Abrir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Abrir.Location = new Point(209, 80);
            btn_Abrir.Name = "btn_Abrir";
            btn_Abrir.Size = new Size(125, 51);
            btn_Abrir.TabIndex = 0;
            btn_Abrir.Text = "Abrir";
            btn_Abrir.UseVisualStyleBackColor = false;
            btn_Abrir.Click += btn_Abrir_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = SystemColors.Info;
            btn_Guardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Guardar.Location = new Point(418, 80);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(127, 51);
            btn_Guardar.TabIndex = 1;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_Contenido
            // 
            txt_Contenido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Contenido.Location = new Point(12, 184);
            txt_Contenido.Name = "txt_Contenido";
            txt_Contenido.Size = new Size(776, 27);
            txt_Contenido.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Contenido);
            Controls.Add(btn_Guardar);
            Controls.Add(btn_Abrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Abrir;
        private Button btn_Guardar;
        private OpenFileDialog openFileDialog1;
        private TextBox txt_Contenido;
        private SaveFileDialog saveFileDialog1;
    }
}
