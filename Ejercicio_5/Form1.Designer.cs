namespace Ejercicio_5
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
            rdb_Opcion1 = new RadioButton();
            rdb_Opcion2 = new RadioButton();
            rdb_Opcion3 = new RadioButton();
            btn_Aceptar = new Button();
            lbl_Texto = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // rdb_Opcion1
            // 
            rdb_Opcion1.AutoSize = true;
            rdb_Opcion1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdb_Opcion1.Location = new Point(68, 96);
            rdb_Opcion1.Name = "rdb_Opcion1";
            rdb_Opcion1.Size = new Size(112, 32);
            rdb_Opcion1.TabIndex = 0;
            rdb_Opcion1.TabStop = true;
            rdb_Opcion1.Text = "Opcion 1";
            rdb_Opcion1.UseVisualStyleBackColor = true;
            rdb_Opcion1.CheckedChanged += rdb_Opcion1_CheckedChanged;
            // 
            // rdb_Opcion2
            // 
            rdb_Opcion2.AutoSize = true;
            rdb_Opcion2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdb_Opcion2.Location = new Point(265, 96);
            rdb_Opcion2.Name = "rdb_Opcion2";
            rdb_Opcion2.Size = new Size(115, 32);
            rdb_Opcion2.TabIndex = 1;
            rdb_Opcion2.TabStop = true;
            rdb_Opcion2.Text = "Opcion 2";
            rdb_Opcion2.UseVisualStyleBackColor = true;
            rdb_Opcion2.CheckedChanged += rdb_Opcion2_CheckedChanged;
            // 
            // rdb_Opcion3
            // 
            rdb_Opcion3.AutoSize = true;
            rdb_Opcion3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdb_Opcion3.Location = new Point(429, 96);
            rdb_Opcion3.Name = "rdb_Opcion3";
            rdb_Opcion3.Size = new Size(115, 32);
            rdb_Opcion3.TabIndex = 2;
            rdb_Opcion3.TabStop = true;
            rdb_Opcion3.Text = "Opcion 3";
            rdb_Opcion3.UseVisualStyleBackColor = true;
            rdb_Opcion3.CheckedChanged += rdb_Opcion3_CheckedChanged;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackColor = SystemColors.Info;
            btn_Aceptar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Aceptar.Location = new Point(594, 96);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(135, 49);
            btn_Aceptar.TabIndex = 3;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // lbl_Texto
            // 
            lbl_Texto.AutoSize = true;
            lbl_Texto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Texto.Location = new Point(250, 205);
            lbl_Texto.Name = "lbl_Texto";
            lbl_Texto.Size = new Size(0, 28);
            lbl_Texto.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 35);
            label1.Name = "label1";
            label1.Size = new Size(228, 28);
            label1.TabIndex = 5;
            label1.Text = "Selecciona una opcion:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbl_Texto);
            Controls.Add(btn_Aceptar);
            Controls.Add(rdb_Opcion3);
            Controls.Add(rdb_Opcion2);
            Controls.Add(rdb_Opcion1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdb_Opcion1;
        private RadioButton rdb_Opcion2;
        private RadioButton rdb_Opcion3;
        private Button btn_Aceptar;
        private Label lbl_Texto;
        private Label label1;
    }
}
