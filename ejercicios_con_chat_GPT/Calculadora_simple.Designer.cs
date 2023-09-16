namespace ejercicios_con_google
{
    partial class Calculadora_simple
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
            this.txtPrimerNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtnDividir = new System.Windows.Forms.RadioButton();
            this.rdbtnMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdbtnRestar = new System.Windows.Forms.RadioButton();
            this.rdbtnSumar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSegundoNumero = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrimerNumero
            // 
            this.txtPrimerNumero.Location = new System.Drawing.Point(29, 72);
            this.txtPrimerNumero.Name = "txtPrimerNumero";
            this.txtPrimerNumero.Size = new System.Drawing.Size(125, 27);
            this.txtPrimerNumero.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResultado);
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdbtnDividir);
            this.groupBox1.Controls.Add(this.rdbtnMultiplicar);
            this.groupBox1.Controls.Add(this.rdbtnRestar);
            this.groupBox1.Controls.Add(this.rdbtnSumar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSegundoNumero);
            this.groupBox1.Controls.Add(this.txtPrimerNumero);
            this.groupBox1.Location = new System.Drawing.Point(48, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora simple";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(205, 230);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(94, 29);
            this.btnResultado.TabIndex = 10;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(53, 224);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 31);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado:";
            // 
            // rdbtnDividir
            // 
            this.rdbtnDividir.AutoSize = true;
            this.rdbtnDividir.Location = new System.Drawing.Point(229, 187);
            this.rdbtnDividir.Name = "rdbtnDividir";
            this.rdbtnDividir.Size = new System.Drawing.Size(74, 24);
            this.rdbtnDividir.TabIndex = 7;
            this.rdbtnDividir.Text = "Dividir";
            this.rdbtnDividir.UseVisualStyleBackColor = true;
            this.rdbtnDividir.CheckedChanged += new System.EventHandler(this.rdbtnDividir_CheckedChanged);
            // 
            // rdbtnMultiplicar
            // 
            this.rdbtnMultiplicar.AutoSize = true;
            this.rdbtnMultiplicar.Location = new System.Drawing.Point(229, 139);
            this.rdbtnMultiplicar.Name = "rdbtnMultiplicar";
            this.rdbtnMultiplicar.Size = new System.Drawing.Size(101, 24);
            this.rdbtnMultiplicar.TabIndex = 6;
            this.rdbtnMultiplicar.Text = "Multiplicar";
            this.rdbtnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbtnRestar
            // 
            this.rdbtnRestar.AutoSize = true;
            this.rdbtnRestar.Location = new System.Drawing.Point(229, 91);
            this.rdbtnRestar.Name = "rdbtnRestar";
            this.rdbtnRestar.Size = new System.Drawing.Size(71, 24);
            this.rdbtnRestar.TabIndex = 5;
            this.rdbtnRestar.Text = "Restar";
            this.rdbtnRestar.UseVisualStyleBackColor = true;
            // 
            // rdbtnSumar
            // 
            this.rdbtnSumar.AutoSize = true;
            this.rdbtnSumar.Location = new System.Drawing.Point(229, 45);
            this.rdbtnSumar.Name = "rdbtnSumar";
            this.rdbtnSumar.Size = new System.Drawing.Size(72, 24);
            this.rdbtnSumar.TabIndex = 4;
            this.rdbtnSumar.Text = "Sumar";
            this.rdbtnSumar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seg.Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pr.Numero";
            // 
            // txtSegundoNumero
            // 
            this.txtSegundoNumero.Location = new System.Drawing.Point(29, 139);
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.Size = new System.Drawing.Size(125, 27);
            this.txtSegundoNumero.TabIndex = 1;
            // 
            // Calculadora_simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 358);
            this.Controls.Add(this.groupBox1);
            this.Name = "Calculadora_simple";
            this.Text = "Calculadora_simple";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtPrimerNumero;
        private GroupBox groupBox1;
        private RadioButton rdbtnDividir;
        private RadioButton rdbtnMultiplicar;
        private RadioButton rdbtnRestar;
        private RadioButton rdbtnSumar;
        private Label label2;
        private Label label1;
        private TextBox txtSegundoNumero;
        private Label lblResultado;
        private Label label3;
        private Button btnResultado;
    }
}