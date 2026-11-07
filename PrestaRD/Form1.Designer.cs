namespace PrestaRD
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
            txtCliente = new TextBox();
            lblCliente = new Label();
            nudEdad = new NumericUpDown();
            lblIngresos = new Label();
            lblEdad = new Label();
            nudIngresos = new NumericUpDown();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            nudMonto = new NumericUpDown();
            lblMonto = new Label();
            nudPlazo = new NumericUpDown();
            lblPlazo = new Label();
            chkAtrasos = new CheckBox();
            nudPago = new NumericUpDown();
            lblPago = new Label();
            btnEvaluar = new Button();
            btnTabla = new Button();
            btnSimularPago = new Button();
            btnRegistrar = new Button();
            btnCartera = new Button();
            lblResultado = new Label();
            lblResumen = new Label();
            lstSalida = new ListBox();
            lstPrestamos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIngresos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPlazo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPago).BeginInit();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(74, 12);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(22, 9);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(74, 53);
            nudEdad.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(120, 23);
            nudEdad.TabIndex = 2;
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(15, 93);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(51, 15);
            lblIngresos.TabIndex = 3;
            lblIngresos.Text = "Ingresos";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(22, 53);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // nudIngresos
            // 
            nudIngresos.Location = new Point(72, 93);
            nudIngresos.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudIngresos.Name = "nudIngresos";
            nudIngresos.Size = new Size(120, 23);
            nudIngresos.TabIndex = 5;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(74, 128);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 6;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(22, 131);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo";
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(74, 171);
            nudMonto.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(120, 23);
            nudMonto.TabIndex = 8;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(22, 171);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 9;
            lblMonto.Text = "Monto";
            // 
            // nudPlazo
            // 
            nudPlazo.Location = new Point(74, 213);
            nudPlazo.Maximum = new decimal(new int[] { 240, 0, 0, 0 });
            nudPlazo.Name = "nudPlazo";
            nudPlazo.Size = new Size(120, 23);
            nudPlazo.TabIndex = 10;
            // 
            // lblPlazo
            // 
            lblPlazo.AutoSize = true;
            lblPlazo.Location = new Point(22, 215);
            lblPlazo.Name = "lblPlazo";
            lblPlazo.Size = new Size(35, 15);
            lblPlazo.TabIndex = 11;
            lblPlazo.Text = "Plazo";
            // 
            // chkAtrasos
            // 
            chkAtrasos.AutoSize = true;
            chkAtrasos.Location = new Point(68, 293);
            chkAtrasos.Name = "chkAtrasos";
            chkAtrasos.Size = new Size(199, 19);
            chkAtrasos.TabIndex = 12;
            chkAtrasos.Text = "Tiene atrasos en otros préstamos";
            chkAtrasos.UseVisualStyleBackColor = true;
            // 
            // nudPago
            // 
            nudPago.Location = new Point(74, 253);
            nudPago.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPago.Name = "nudPago";
            nudPago.Size = new Size(120, 23);
            nudPago.TabIndex = 13;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(21, 261);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(34, 15);
            lblPago.TabIndex = 14;
            lblPago.Text = "Pago";
            // 
            // btnEvaluar
            // 
            btnEvaluar.Location = new Point(61, 350);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(75, 23);
            btnEvaluar.TabIndex = 15;
            btnEvaluar.Text = "Evaluar";
            btnEvaluar.UseVisualStyleBackColor = true;
            // 
            // btnTabla
            // 
            btnTabla.Location = new Point(192, 350);
            btnTabla.Name = "btnTabla";
            btnTabla.Size = new Size(75, 23);
            btnTabla.TabIndex = 16;
            btnTabla.Text = "Tabla";
            btnTabla.UseVisualStyleBackColor = true;
            // 
            // btnSimularPago
            // 
            btnSimularPago.Location = new Point(310, 350);
            btnSimularPago.Name = "btnSimularPago";
            btnSimularPago.Size = new Size(99, 23);
            btnSimularPago.TabIndex = 17;
            btnSimularPago.Text = "Simular pago";
            btnSimularPago.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(470, 350);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCartera
            // 
            btnCartera.Location = new Point(626, 350);
            btnCartera.Name = "btnCartera";
            btnCartera.Size = new Size(75, 23);
            btnCartera.TabIndex = 19;
            btnCartera.Text = "Cartera";
            btnCartera.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(266, 57);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(100, 25);
            lblResultado.TabIndex = 21;
            lblResultado.Text = "Resultado";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(266, 190);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(56, 15);
            lblResumen.TabIndex = 22;
            lblResumen.Text = "Resumen";
            // 
            // lstSalida
            // 
            lstSalida.FormattingEnabled = true;
            lstSalida.Location = new Point(417, 57);
            lstSalida.Name = "lstSalida";
            lstSalida.Size = new Size(128, 214);
            lstSalida.TabIndex = 23;
            // 
            // lstPrestamos
            // 
            lstPrestamos.FormattingEnabled = true;
            lstPrestamos.Location = new Point(571, 57);
            lstPrestamos.Name = "lstPrestamos";
            lstPrestamos.Size = new Size(130, 214);
            lstPrestamos.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPrestamos);
            Controls.Add(lstSalida);
            Controls.Add(lblResumen);
            Controls.Add(lblResultado);
            Controls.Add(btnCartera);
            Controls.Add(btnRegistrar);
            Controls.Add(btnSimularPago);
            Controls.Add(btnTabla);
            Controls.Add(btnEvaluar);
            Controls.Add(lblPago);
            Controls.Add(nudPago);
            Controls.Add(chkAtrasos);
            Controls.Add(lblPlazo);
            Controls.Add(nudPlazo);
            Controls.Add(lblMonto);
            Controls.Add(nudMonto);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(nudIngresos);
            Controls.Add(lblEdad);
            Controls.Add(lblIngresos);
            Controls.Add(nudEdad);
            Controls.Add(lblCliente);
            Controls.Add(txtCliente);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIngresos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPlazo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private Label lblCliente;
        private NumericUpDown nudEdad;
        private Label lblIngresos;
        private Label lblEdad;
        private NumericUpDown nudIngresos;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private NumericUpDown nudMonto;
        private Label label1;
        private Label lblMonto;
        private NumericUpDown nudPlazo;
        private Label lblPlazo;
        private CheckBox chkAtrasos;
        private NumericUpDown nudPago;
        private Label lblPago;
        private Button btnEvaluar;
        private Button btnTabla;
        private Button btnSimularPago;
        private Button btnRegistrar;
        private Button btnCartera;
        private Label lblResultado;
        private Label lblResumen;
        private ListBox lstSalida;
        private ListBox lstPrestamos;
    }
}
