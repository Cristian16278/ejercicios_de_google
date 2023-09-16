namespace ejercicios_con_google
{
    partial class contador_palabras
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
            this.btnContarPalabras = new System.Windows.Forms.Button();
            this.txtLeerPalabras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContarPalabras
            // 
            this.btnContarPalabras.Location = new System.Drawing.Point(423, 180);
            this.btnContarPalabras.Name = "btnContarPalabras";
            this.btnContarPalabras.Size = new System.Drawing.Size(94, 29);
            this.btnContarPalabras.TabIndex = 0;
            this.btnContarPalabras.Text = "Contar";
            this.btnContarPalabras.UseVisualStyleBackColor = true;
            this.btnContarPalabras.Click += new System.EventHandler(this.btnContarPalabras_Click);
            // 
            // txtLeerPalabras
            // 
            this.txtLeerPalabras.Location = new System.Drawing.Point(48, 147);
            this.txtLeerPalabras.Name = "txtLeerPalabras";
            this.txtLeerPalabras.Size = new System.Drawing.Size(469, 27);
            this.txtLeerPalabras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "son:";
            // 
            // contador_palabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeerPalabras);
            this.Controls.Add(this.btnContarPalabras);
            this.Name = "contador_palabras";
            this.Text = "contador_palabras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnContarPalabras;
        private TextBox txtLeerPalabras;
        private Label label1;
    }
}