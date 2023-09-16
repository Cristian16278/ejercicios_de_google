namespace ejercicios_con_google
{
    partial class adivinar_el_numero
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
            label1 = new Label();
            button1 = new Button();
            lblNumerooMensaje = new Label();
            txtNumero = new TextBox();
            label2 = new Label();
            lblIntentos = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 72);
            label1.Name = "label1";
            label1.Size = new Size(149, 23);
            label1.TabIndex = 0;
            label1.Text = "Adivina el numero";
            // 
            // button1
            // 
            button1.Location = new Point(202, 223);
            button1.Name = "button1";
            button1.Size = new Size(180, 33);
            button1.TabIndex = 1;
            button1.Text = "Adivinar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblNumerooMensaje
            // 
            lblNumerooMensaje.AutoSize = true;
            lblNumerooMensaje.Location = new Point(111, 112);
            lblNumerooMensaje.Name = "lblNumerooMensaje";
            lblNumerooMensaje.Size = new Size(0, 23);
            lblNumerooMensaje.TabIndex = 2;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(223, 170);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(140, 30);
            txtNumero.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 25);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 4;
            label2.Text = "Intentos:";
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Location = new Point(61, 62);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(19, 23);
            lblIntentos.TabIndex = 5;
            lblIntentos.Text = "0";
            // 
            // adivinar_el_numero
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 315);
            Controls.Add(lblIntentos);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(lblNumerooMensaje);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "adivinar_el_numero";
            Text = "adivinar_el_numero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label lblNumerooMensaje;
        private TextBox txtNumero;
        private Label label2;
        private Label lblIntentos;
    }
}