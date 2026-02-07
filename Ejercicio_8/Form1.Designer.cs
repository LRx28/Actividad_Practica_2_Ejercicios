namespace Ejercicio_8
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
            btn_Precionar = new Button();
            lbl_Contador = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Precionar
            // 
            btn_Precionar.BackColor = SystemColors.ScrollBar;
            btn_Precionar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Precionar.Location = new Point(433, 130);
            btn_Precionar.Name = "btn_Precionar";
            btn_Precionar.Size = new Size(123, 56);
            btn_Precionar.TabIndex = 0;
            btn_Precionar.Text = "Precionar";
            btn_Precionar.UseVisualStyleBackColor = false;
            btn_Precionar.Click += btn_Precionar_Click;
            // 
            // lbl_Contador
            // 
            lbl_Contador.AutoSize = true;
            lbl_Contador.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Contador.Location = new Point(215, 147);
            lbl_Contador.Name = "lbl_Contador";
            lbl_Contador.Size = new Size(97, 23);
            lbl_Contador.TabIndex = 1;
            lbl_Contador.Text = "Contador:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 50);
            label1.Name = "label1";
            label1.Size = new Size(394, 28);
            label1.TabIndex = 2;
            label1.Text = "Precione el boton para empezar el conteo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbl_Contador);
            Controls.Add(btn_Precionar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Precionar;
        private Label lbl_Contador;
        private Label label1;
    }
}
