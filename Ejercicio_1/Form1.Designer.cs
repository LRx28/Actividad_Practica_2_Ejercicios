namespace Ejercicio_1
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
            btn_VerMensaje = new Button();
            lbl_Mensaje = new Label();
            SuspendLayout();
            // 
            // btn_VerMensaje
            // 
            btn_VerMensaje.BackColor = SystemColors.Info;
            btn_VerMensaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VerMensaje.Location = new Point(299, 48);
            btn_VerMensaje.Name = "btn_VerMensaje";
            btn_VerMensaje.Size = new Size(148, 47);
            btn_VerMensaje.TabIndex = 0;
            btn_VerMensaje.Text = "Ver mensaje\r\n";
            btn_VerMensaje.UseVisualStyleBackColor = false;
            btn_VerMensaje.Click += btn_VerMensaje_Click;
            // 
            // lbl_Mensaje
            // 
            lbl_Mensaje.AutoSize = true;
            lbl_Mensaje.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Mensaje.Location = new Point(90, 152);
            lbl_Mensaje.Name = "lbl_Mensaje";
            lbl_Mensaje.Size = new Size(0, 31);
            lbl_Mensaje.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Mensaje);
            Controls.Add(btn_VerMensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_VerMensaje;
        private Label lbl_Mensaje;
    }
}
