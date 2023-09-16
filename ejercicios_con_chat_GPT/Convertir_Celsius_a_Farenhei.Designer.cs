namespace ejercicios_con_google
{
    partial class Convertir_Celsius_a_Farenhei
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGrados1 = new System.Windows.Forms.Label();
            this.lblGrados2 = new System.Windows.Forms.Label();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.lblResultadoGrados = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnFahaCel = new System.Windows.Forms.RadioButton();
            this.rdbtnCelaFah = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrados1
            // 
            this.lblGrados1.AutoSize = true;
            this.lblGrados1.Location = new System.Drawing.Point(59, 45);
            this.lblGrados1.Name = "lblGrados1";
            this.lblGrados1.Size = new System.Drawing.Size(105, 20);
            this.lblGrados1.TabIndex = 0;
            this.lblGrados1.Text = "Grados Celsius";
            // 
            // lblGrados2
            // 
            this.lblGrados2.AutoSize = true;
            this.lblGrados2.Location = new System.Drawing.Point(203, 45);
            this.lblGrados2.Name = "lblGrados2";
            this.lblGrados2.Size = new System.Drawing.Size(128, 20);
            this.lblGrados2.TabIndex = 1;
            this.lblGrados2.Text = "Grados Fahrenheit";
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(59, 91);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(105, 27);
            this.txtGrados.TabIndex = 2;
            this.txtGrados.TextChanged += new System.EventHandler(this.txtGrados_TextChanged);
            // 
            // lblResultadoGrados
            // 
            this.lblResultadoGrados.AutoSize = true;
            this.lblResultadoGrados.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoGrados.Location = new System.Drawing.Point(258, 91);
            this.lblResultadoGrados.Name = "lblResultadoGrados";
            this.lblResultadoGrados.Size = new System.Drawing.Size(26, 31);
            this.lblResultadoGrados.TabIndex = 3;
            this.lblResultadoGrados.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnFahaCel);
            this.groupBox1.Controls.Add(this.rdbtnCelaFah);
            this.groupBox1.Location = new System.Drawing.Point(37, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convertir de:";
            // 
            // rdbtnFahaCel
            // 
            this.rdbtnFahaCel.AutoSize = true;
            this.rdbtnFahaCel.Location = new System.Drawing.Point(21, 66);
            this.rdbtnFahaCel.Name = "rdbtnFahaCel";
            this.rdbtnFahaCel.Size = new System.Drawing.Size(159, 24);
            this.rdbtnFahaCel.TabIndex = 1;
            this.rdbtnFahaCel.Text = "Fahrenheit a Celsius";
            this.rdbtnFahaCel.UseVisualStyleBackColor = true;
            // 
            // rdbtnCelaFah
            // 
            this.rdbtnCelaFah.AutoSize = true;
            this.rdbtnCelaFah.Checked = true;
            this.rdbtnCelaFah.Location = new System.Drawing.Point(21, 36);
            this.rdbtnCelaFah.Name = "rdbtnCelaFah";
            this.rdbtnCelaFah.Size = new System.Drawing.Size(159, 24);
            this.rdbtnCelaFah.TabIndex = 0;
            this.rdbtnCelaFah.TabStop = true;
            this.rdbtnCelaFah.Text = "Celsius a Fahrenheit";
            this.rdbtnCelaFah.UseVisualStyleBackColor = true;
            this.rdbtnCelaFah.CheckedChanged += new System.EventHandler(this.rdbtnCelaFah_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(272, 179);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 60);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(229, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "°";
            // 
            // Convertir_Celsius_a_Farenhei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultadoGrados);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.lblGrados2);
            this.Controls.Add(this.lblGrados1);
            this.Name = "Convertir_Celsius_a_Farenhei";
            this.Text = "Convertidor de temperatura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGrados1;
        private Label lblGrados2;
        private TextBox txtGrados;
        private Label lblResultadoGrados;
        private GroupBox groupBox1;
        private RadioButton rdbtnFahaCel;
        private RadioButton rdbtnCelaFah;
        private Button btnCalcular;
        private Label label1;
    }
}