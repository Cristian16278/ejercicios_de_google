namespace ejercicios_con_google
{
    partial class cajeroAutomatico
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
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.txtMontoAretirar = new System.Windows.Forms.TextBox();
            this.btnTransaccion = new System.Windows.Forms.Button();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(84, 68);
            this.txtCuenta.MaxLength = 5;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(125, 27);
            this.txtCuenta.TabIndex = 0;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(84, 155);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(125, 27);
            this.txtSaldoInicial.TabIndex = 1;
            // 
            // txtMontoAretirar
            // 
            this.txtMontoAretirar.Location = new System.Drawing.Point(84, 257);
            this.txtMontoAretirar.Name = "txtMontoAretirar";
            this.txtMontoAretirar.Size = new System.Drawing.Size(125, 27);
            this.txtMontoAretirar.TabIndex = 2;
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.Location = new System.Drawing.Point(252, 318);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(137, 29);
            this.btnTransaccion.TabIndex = 3;
            this.btnTransaccion.Text = "Hacer transaccion";
            this.btnTransaccion.UseVisualStyleBackColor = true;
            this.btnTransaccion.Click += new System.EventHandler(this.btnTransaccion_Click);
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Location = new System.Drawing.Point(323, 209);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(17, 20);
            this.lblSaldoActual.TabIndex = 4;
            this.lblSaldoActual.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "saldo Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto a retirar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "saldo actual:";
            // 
            // cajeroAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 407);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldoActual);
            this.Controls.Add(this.btnTransaccion);
            this.Controls.Add(this.txtMontoAretirar);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.txtCuenta);
            this.Name = "cajeroAutomatico";
            this.Text = "cajeroAutomatico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCuenta;
        private TextBox txtSaldoInicial;
        private TextBox txtMontoAretirar;
        private Button btnTransaccion;
        private Label lblSaldoActual;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}