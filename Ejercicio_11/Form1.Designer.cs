namespace Ejercicio_11
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
            dtp_Fecha = new DateTimePicker();
            btn_Guardar = new Button();
            lbl_FechaHora = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dtp_Fecha
            // 
            dtp_Fecha.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtp_Fecha.Location = new Point(25, 123);
            dtp_Fecha.Name = "dtp_Fecha";
            dtp_Fecha.Size = new Size(418, 31);
            dtp_Fecha.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = SystemColors.Info;
            btn_Guardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Guardar.Location = new Point(498, 110);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(135, 58);
            btn_Guardar.TabIndex = 1;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // lbl_FechaHora
            // 
            lbl_FechaHora.AutoSize = true;
            lbl_FechaHora.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FechaHora.Location = new Point(221, 244);
            lbl_FechaHora.Name = "lbl_FechaHora";
            lbl_FechaHora.Size = new Size(0, 28);
            lbl_FechaHora.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 37);
            label1.Name = "label1";
            label1.Size = new Size(252, 27);
            label1.TabIndex = 3;
            label1.Text = "Selecciona una fecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbl_FechaHora);
            Controls.Add(btn_Guardar);
            Controls.Add(dtp_Fecha);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_Fecha;
        private Button btn_Guardar;
        private Label lbl_FechaHora;
        private Label label1;
    }
}
