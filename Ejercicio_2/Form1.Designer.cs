namespace Ejercicio_2
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
            lbl_Texto = new Label();
            btn_Aceptar = new Button();
            SuspendLayout();
            // 
            // lbl_Texto
            // 
            lbl_Texto.AutoSize = true;
            lbl_Texto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Texto.Location = new Point(34, 194);
            lbl_Texto.Name = "lbl_Texto";
            lbl_Texto.Size = new Size(412, 28);
            lbl_Texto.TabIndex = 0;
            lbl_Texto.Text = "Este texto debe cambiar al precionar el boton.";
            lbl_Texto.Click += label1_Click;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackColor = Color.FromArgb(255, 255, 192);
            btn_Aceptar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Aceptar.Location = new Point(540, 171);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(168, 78);
            btn_Aceptar.TabIndex = 1;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Aceptar);
            Controls.Add(lbl_Texto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Texto;
        private Button btn_Aceptar;
    }
}
