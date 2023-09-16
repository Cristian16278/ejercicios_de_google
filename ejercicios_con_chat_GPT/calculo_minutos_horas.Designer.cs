namespace ejercicios_de_google
{
    partial class calculo_minutos_horas
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
            txtDuracion = new TextBox();
            txtCantidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtDuracion
            // 
            txtDuracion.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuracion.Location = new Point(36, 136);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(146, 43);
            txtDuracion.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(274, 136);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 43);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 95);
            label1.Name = "label1";
            label1.Size = new Size(135, 38);
            label1.TabIndex = 2;
            label1.Text = "Duracion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(274, 95);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 3;
            label2.Text = "Cantidad:";
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(159, 254);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(141, 59);
            BtnCalcular.TabIndex = 4;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(394, 275);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(55, 23);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "label3";
            // 
            // calculo_minutos_horas
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 450);
            Controls.Add(lblResultado);
            Controls.Add(BtnCalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(txtDuracion);
            Name = "calculo_minutos_horas";
            Text = "calculo_minutos_horas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDuracion;
        private TextBox txtCantidad;
        private Label label1;
        private Label label2;
        private Button BtnCalcular;
        private Label lblResultado;
    }
}