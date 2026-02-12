namespace Ejercicio_13
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
            components = new System.ComponentModel.Container();
            btn_Iniciar = new Button();
            btn_Detener = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_Iniciar
            // 
            btn_Iniciar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Iniciar.Location = new Point(169, 110);
            btn_Iniciar.Name = "btn_Iniciar";
            btn_Iniciar.Size = new Size(131, 42);
            btn_Iniciar.TabIndex = 0;
            btn_Iniciar.Text = "Iniciar";
            btn_Iniciar.UseVisualStyleBackColor = true;
            btn_Iniciar.Click += btn_Iniciar_Click;
            // 
            // btn_Detener
            // 
            btn_Detener.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Detener.Location = new Point(435, 110);
            btn_Detener.Name = "btn_Detener";
            btn_Detener.Size = new Size(131, 42);
            btn_Detener.TabIndex = 1;
            btn_Detener.Text = "Detener";
            btn_Detener.UseVisualStyleBackColor = true;
            btn_Detener.Click += btn_Detener_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(67, 215);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(645, 56);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(btn_Detener);
            Controls.Add(btn_Iniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Iniciar;
        private Button btn_Detener;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
