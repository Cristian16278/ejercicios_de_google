namespace ejercicios_con_google
{
    partial class par_o_impar
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParOrImpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(165, 55);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(131, 27);
            this.txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el numero:";
            // 
            // btnParOrImpar
            // 
            this.btnParOrImpar.Location = new System.Drawing.Point(173, 104);
            this.btnParOrImpar.Name = "btnParOrImpar";
            this.btnParOrImpar.Size = new System.Drawing.Size(94, 29);
            this.btnParOrImpar.TabIndex = 2;
            this.btnParOrImpar.Text = "Checar";
            this.btnParOrImpar.UseVisualStyleBackColor = true;
            this.btnParOrImpar.Click += new System.EventHandler(this.btnParOrImpar_Click);
            // 
            // par_o_impar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 248);
            this.Controls.Add(this.btnParOrImpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Name = "par_o_impar";
            this.Text = "par_o_impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumero;
        private Label label1;
        private Button btnParOrImpar;
    }
}