namespace ejercicios_con_google
{
    partial class conversor_longitud
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
            this.txtObtenerMedida = new System.Windows.Forms.TextBox();
            this.cobxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtConvertir = new System.Windows.Forms.TextBox();
            this.cobxUnidadMedida2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtObtenerMedida
            // 
            this.txtObtenerMedida.Location = new System.Drawing.Point(143, 111);
            this.txtObtenerMedida.Name = "txtObtenerMedida";
            this.txtObtenerMedida.Size = new System.Drawing.Size(125, 27);
            this.txtObtenerMedida.TabIndex = 0;
            // 
            // cobxUnidadMedida
            // 
            this.cobxUnidadMedida.FormattingEnabled = true;
            this.cobxUnidadMedida.Items.AddRange(new object[] {
            "Metros",
            "Pies",
            "Pulgadas",
            "Yardas"});
            this.cobxUnidadMedida.Location = new System.Drawing.Point(142, 156);
            this.cobxUnidadMedida.Name = "cobxUnidadMedida";
            this.cobxUnidadMedida.Size = new System.Drawing.Size(126, 28);
            this.cobxUnidadMedida.TabIndex = 1;
            // 
            // txtConvertir
            // 
            this.txtConvertir.Enabled = false;
            this.txtConvertir.Location = new System.Drawing.Point(375, 111);
            this.txtConvertir.Name = "txtConvertir";
            this.txtConvertir.Size = new System.Drawing.Size(125, 27);
            this.txtConvertir.TabIndex = 2;
            // 
            // cobxUnidadMedida2
            // 
            this.cobxUnidadMedida2.FormattingEnabled = true;
            this.cobxUnidadMedida2.Items.AddRange(new object[] {
            "Metros",
            "Pies",
            "Pulgadas",
            "Yardas"});
            this.cobxUnidadMedida2.Location = new System.Drawing.Point(375, 156);
            this.cobxUnidadMedida2.Name = "cobxUnidadMedida2";
            this.cobxUnidadMedida2.Size = new System.Drawing.Size(126, 28);
            this.cobxUnidadMedida2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "convertir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "U.Medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "U.Medida";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(275, 239);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(94, 29);
            this.btnConvertir.TabIndex = 8;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // conversor_longitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 349);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cobxUnidadMedida2);
            this.Controls.Add(this.txtConvertir);
            this.Controls.Add(this.cobxUnidadMedida);
            this.Controls.Add(this.txtObtenerMedida);
            this.Name = "conversor_longitud";
            this.Text = "conversor_longitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtObtenerMedida;
        private ComboBox cobxUnidadMedida;
        private TextBox txtConvertir;
        private ComboBox cobxUnidadMedida2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConvertir;
    }
}