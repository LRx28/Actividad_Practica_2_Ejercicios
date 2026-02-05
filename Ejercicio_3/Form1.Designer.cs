namespace Ejercicio_3
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
            btn_Aceptar = new Button();
            txt_Texto = new TextBox();
            lbl_Texto = new Label();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Aceptar.Location = new Point(480, 126);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(121, 57);
            btn_Aceptar.TabIndex = 0;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // txt_Texto
            // 
            txt_Texto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Texto.Location = new Point(126, 137);
            txt_Texto.Name = "txt_Texto";
            txt_Texto.Size = new Size(307, 31);
            txt_Texto.TabIndex = 1;
            // 
            // lbl_Texto
            // 
            lbl_Texto.AutoSize = true;
            lbl_Texto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Texto.Location = new Point(126, 230);
            lbl_Texto.Name = "lbl_Texto";
            lbl_Texto.Size = new Size(0, 23);
            lbl_Texto.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Texto);
            Controls.Add(txt_Texto);
            Controls.Add(btn_Aceptar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Aceptar;
        private TextBox txt_Texto;
        private Label lbl_Texto;
    }
}
