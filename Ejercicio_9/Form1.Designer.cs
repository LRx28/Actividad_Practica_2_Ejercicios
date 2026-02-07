namespace Ejercicio_9
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
            txt_Valor = new TextBox();
            btn_Validar = new Button();
            label1 = new Label();
            lbl_Valor = new Label();
            SuspendLayout();
            // 
            // txt_Valor
            // 
            txt_Valor.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Valor.Location = new Point(158, 147);
            txt_Valor.Name = "txt_Valor";
            txt_Valor.Size = new Size(202, 31);
            txt_Valor.TabIndex = 0;
            // 
            // btn_Validar
            // 
            btn_Validar.BackColor = SystemColors.InactiveCaption;
            btn_Validar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Validar.Location = new Point(425, 129);
            btn_Validar.Name = "btn_Validar";
            btn_Validar.Size = new Size(122, 59);
            btn_Validar.TabIndex = 1;
            btn_Validar.Text = "Validar";
            btn_Validar.UseVisualStyleBackColor = false;
            btn_Validar.Click += btn_Validar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 40);
            label1.Name = "label1";
            label1.Size = new Size(470, 28);
            label1.TabIndex = 2;
            label1.Text = "Ingresa solamente un valor o caracter numerico:";
            label1.Click += label1_Click;
            // 
            // lbl_Valor
            // 
            lbl_Valor.AutoSize = true;
            lbl_Valor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Valor.Location = new Point(155, 267);
            lbl_Valor.Name = "lbl_Valor";
            lbl_Valor.Size = new Size(0, 28);
            lbl_Valor.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Valor);
            Controls.Add(label1);
            Controls.Add(btn_Validar);
            Controls.Add(txt_Valor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Valor;
        private Button btn_Validar;
        private Label label1;
        private Label lbl_Valor;
    }
}
