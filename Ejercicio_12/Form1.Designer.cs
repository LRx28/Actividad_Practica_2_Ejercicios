namespace Ejercicio_12
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
            lbl_Celsius = new Label();
            lbl_Fahrenheit = new Label();
            btn_Calcular = new Button();
            label1 = new Label();
            txb_Grados = new TextBox();
            lbl_Resultado = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbl_Celsius
            // 
            lbl_Celsius.AutoSize = true;
            lbl_Celsius.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Celsius.Location = new Point(216, 115);
            lbl_Celsius.Name = "lbl_Celsius";
            lbl_Celsius.Size = new Size(91, 31);
            lbl_Celsius.TabIndex = 0;
            lbl_Celsius.Text = " Celsius";
            // 
            // lbl_Fahrenheit
            // 
            lbl_Fahrenheit.AutoSize = true;
            lbl_Fahrenheit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Fahrenheit.Location = new Point(445, 115);
            lbl_Fahrenheit.Name = "lbl_Fahrenheit";
            lbl_Fahrenheit.Size = new Size(123, 31);
            lbl_Fahrenheit.TabIndex = 1;
            lbl_Fahrenheit.Text = "Fahrenheit";
            // 
            // btn_Calcular
            // 
            btn_Calcular.BackColor = SystemColors.Info;
            btn_Calcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calcular.Location = new Point(332, 224);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(143, 65);
            btn_Calcular.TabIndex = 2;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = false;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(379, 117);
            label1.Name = "label1";
            label1.Size = new Size(26, 31);
            label1.TabIndex = 3;
            label1.Text = "a";
            // 
            // txb_Grados
            // 
            txb_Grados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txb_Grados.Location = new Point(201, 166);
            txb_Grados.Name = "txb_Grados";
            txb_Grados.Size = new Size(131, 34);
            txb_Grados.TabIndex = 4;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.AutoSize = true;
            lbl_Resultado.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Resultado.Location = new Point(476, 163);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(0, 31);
            lbl_Resultado.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(232, 9);
            label2.Name = "label2";
            label2.Size = new Size(317, 31);
            label2.TabIndex = 6;
            label2.Text = "Ingresa los grados a calcular:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lbl_Resultado);
            Controls.Add(txb_Grados);
            Controls.Add(label1);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_Fahrenheit);
            Controls.Add(lbl_Celsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Celsius;
        private Label lbl_Fahrenheit;
        private Button btn_Calcular;
        private Label label1;
        private TextBox txb_Grados;
        private Label lbl_Resultado;
        private Label label2;
    }
}
