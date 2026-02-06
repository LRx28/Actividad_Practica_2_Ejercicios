namespace Ejercicio_4
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
            txt_Valor1 = new TextBox();
            txt_Valor2 = new TextBox();
            btn_Calcular = new Button();
            label1 = new Label();
            label2 = new Label();
            lbl_Resultado = new Label();
            btn_Limpiar = new Button();
            SuspendLayout();
            // 
            // txt_Valor1
            // 
            txt_Valor1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Valor1.Location = new Point(208, 109);
            txt_Valor1.Name = "txt_Valor1";
            txt_Valor1.Size = new Size(125, 34);
            txt_Valor1.TabIndex = 0;
            // 
            // txt_Valor2
            // 
            txt_Valor2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Valor2.Location = new Point(412, 109);
            txt_Valor2.Name = "txt_Valor2";
            txt_Valor2.Size = new Size(125, 34);
            txt_Valor2.TabIndex = 1;
            // 
            // btn_Calcular
            // 
            btn_Calcular.BackColor = SystemColors.Info;
            btn_Calcular.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calcular.Location = new Point(299, 182);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(140, 59);
            btn_Calcular.TabIndex = 2;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = false;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 105);
            label1.Name = "label1";
            label1.Size = new Size(26, 28);
            label1.TabIndex = 3;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(561, 112);
            label2.Name = "label2";
            label2.Size = new Size(26, 28);
            label2.TabIndex = 4;
            label2.Text = "=";
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.AutoSize = true;
            lbl_Resultado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Resultado.Location = new Point(608, 112);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(0, 28);
            lbl_Resultado.TabIndex = 5;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = SystemColors.Info;
            btn_Limpiar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Limpiar.Location = new Point(561, 195);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(114, 32);
            btn_Limpiar.TabIndex = 6;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Limpiar);
            Controls.Add(lbl_Resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Calcular);
            Controls.Add(txt_Valor2);
            Controls.Add(txt_Valor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Valor1;
        private TextBox txt_Valor2;
        private Button btn_Calcular;
        private Label label1;
        private Label label2;
        private Label lbl_Resultado;
        private Button btn_Limpiar;
    }
}
