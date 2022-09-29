namespace EjercicioInmobiliaria
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMts = new System.Windows.Forms.TextBox();
            this.txtVentanas = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.lblVentana = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.rbtnPiso = new System.Windows.Forms.RadioButton();
            this.rbtnLocal = new System.Windows.Forms.RadioButton();
            this.cBoxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(149, 342);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metros Cuadrados";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(149, 50);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtMts
            // 
            this.txtMts.Location = new System.Drawing.Point(149, 90);
            this.txtMts.Name = "txtMts";
            this.txtMts.Size = new System.Drawing.Size(100, 20);
            this.txtMts.TabIndex = 4;
            // 
            // txtVentanas
            // 
            this.txtVentanas.Location = new System.Drawing.Point(149, 183);
            this.txtVentanas.Name = "txtVentanas";
            this.txtVentanas.Size = new System.Drawing.Size(100, 20);
            this.txtVentanas.TabIndex = 8;
            this.txtVentanas.Visible = false;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(149, 183);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 20);
            this.txtPiso.TabIndex = 7;
            this.txtPiso.Visible = false;
            // 
            // lblVentana
            // 
            this.lblVentana.AutoSize = true;
            this.lblVentana.Location = new System.Drawing.Point(37, 179);
            this.lblVentana.Name = "lblVentana";
            this.lblVentana.Size = new System.Drawing.Size(96, 13);
            this.lblVentana.TabIndex = 6;
            this.lblVentana.Text = "Cantidad ventanas";
            this.lblVentana.Visible = false;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(37, 186);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(66, 13);
            this.lblPiso.TabIndex = 5;
            this.lblPiso.Text = "Numero piso";
            this.lblPiso.Visible = false;
            // 
            // rbtnPiso
            // 
            this.rbtnPiso.AutoSize = true;
            this.rbtnPiso.Location = new System.Drawing.Point(112, 137);
            this.rbtnPiso.Name = "rbtnPiso";
            this.rbtnPiso.Size = new System.Drawing.Size(45, 17);
            this.rbtnPiso.TabIndex = 9;
            this.rbtnPiso.TabStop = true;
            this.rbtnPiso.Text = "Piso";
            this.rbtnPiso.UseVisualStyleBackColor = true;
            this.rbtnPiso.CheckedChanged += new System.EventHandler(this.rbtnPiso_CheckedChanged);
            // 
            // rbtnLocal
            // 
            this.rbtnLocal.AutoSize = true;
            this.rbtnLocal.Location = new System.Drawing.Point(209, 137);
            this.rbtnLocal.Name = "rbtnLocal";
            this.rbtnLocal.Size = new System.Drawing.Size(51, 17);
            this.rbtnLocal.TabIndex = 10;
            this.rbtnLocal.TabStop = true;
            this.rbtnLocal.Text = "Local";
            this.rbtnLocal.UseVisualStyleBackColor = true;
            this.rbtnLocal.CheckedChanged += new System.EventHandler(this.rbtnLocal_CheckedChanged);
            // 
            // cBoxEstado
            // 
            this.cBoxEstado.FormattingEnabled = true;
            this.cBoxEstado.Items.AddRange(new object[] {
            "Nuevo",
            "Segunda Mano"});
            this.cBoxEstado.Location = new System.Drawing.Point(149, 243);
            this.cBoxEstado.Name = "cBoxEstado";
            this.cBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.cBoxEstado.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(62, 251);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(65, 303);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(149, 303);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(359, 164);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 13);
            this.lblMostrar.TabIndex = 15;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(149, 389);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblCalcular
            // 
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.Location = new System.Drawing.Point(169, 425);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(0, 13);
            this.lblCalcular.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCalcular);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cBoxEstado);
            this.Controls.Add(this.rbtnLocal);
            this.Controls.Add(this.rbtnPiso);
            this.Controls.Add(this.txtVentanas);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.lblVentana);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.txtMts);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMts;
        private System.Windows.Forms.TextBox txtVentanas;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label lblVentana;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.RadioButton rbtnPiso;
        private System.Windows.Forms.RadioButton rbtnLocal;
        private System.Windows.Forms.ComboBox cBoxEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblCalcular;
    }
}

