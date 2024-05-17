namespace proyectojefecito
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
            lblDNI = new Label();
            lblNombres = new Label();
            lblAñosdeAntiguedad = new Label();
            lblCargo = new Label();
            lblArea = new Label();
            txtDNI = new TextBox();
            txtNombres = new TextBox();
            txtAñosdeAntiguedad = new TextBox();
            cboCargo = new ComboBox();
            cboArea = new ComboBox();
            txtResultados = new TextBox();
            btnCrear = new Button();
            btnMostrarInformacion = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(47, 24);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(35, 20);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(197, 24);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 1;
            lblNombres.Text = "Nombres";
            lblNombres.Click += lblNombres_Click;
            // 
            // lblAñosdeAntiguedad
            // 
            lblAñosdeAntiguedad.AutoSize = true;
            lblAñosdeAntiguedad.Location = new Point(334, 24);
            lblAñosdeAntiguedad.Name = "lblAñosdeAntiguedad";
            lblAñosdeAntiguedad.Size = new Size(145, 20);
            lblAñosdeAntiguedad.TabIndex = 2;
            lblAñosdeAntiguedad.Text = "Años de Antiguedad";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(552, 24);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(49, 20);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(727, 24);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(40, 20);
            lblArea.TabIndex = 4;
            lblArea.Text = "Area";
            lblArea.Click += lblArea_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(12, 59);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(125, 27);
            txtDNI.TabIndex = 5;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(165, 59);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(125, 27);
            txtNombres.TabIndex = 6;
            // 
            // txtAñosdeAntiguedad
            // 
            txtAñosdeAntiguedad.Location = new Point(343, 59);
            txtAñosdeAntiguedad.Name = "txtAñosdeAntiguedad";
            txtAñosdeAntiguedad.Size = new Size(125, 27);
            txtAñosdeAntiguedad.TabIndex = 7;
            txtAñosdeAntiguedad.TextChanged += txtAñosdeAntiguedad_TextChanged;
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "GERENTE", "SUBGERENTE" });
            cboCargo.Location = new Point(495, 58);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(151, 28);
            cboCargo.TabIndex = 8;
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "CONTABILIDAD", "PLANIFICACION" });
            cboArea.Location = new Point(668, 59);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(151, 28);
            cboArea.TabIndex = 9;
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(2, 125);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.ReadOnly = true;
            txtResultados.Size = new Size(842, 276);
            txtResultados.TabIndex = 10;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(32, 407);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 40);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "CREAR";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrarInformacion
            // 
            btnMostrarInformacion.Location = new Point(173, 407);
            btnMostrarInformacion.Name = "btnMostrarInformacion";
            btnMostrarInformacion.Size = new Size(201, 40);
            btnMostrarInformacion.TabIndex = 12;
            btnMostrarInformacion.Text = "MOSTRAR INFORMACION";
            btnMostrarInformacion.UseVisualStyleBackColor = true;
            btnMostrarInformacion.Click += btnMostrarInformacion_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(577, 407);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 40);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(714, 407);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 40);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrarInformacion);
            Controls.Add(btnCrear);
            Controls.Add(txtResultados);
            Controls.Add(cboArea);
            Controls.Add(cboCargo);
            Controls.Add(txtAñosdeAntiguedad);
            Controls.Add(txtNombres);
            Controls.Add(txtDNI);
            Controls.Add(lblArea);
            Controls.Add(lblCargo);
            Controls.Add(lblAñosdeAntiguedad);
            Controls.Add(lblNombres);
            Controls.Add(lblDNI);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDNI;
        private Label lblNombres;
        private Label lblAñosdeAntiguedad;
        private Label lblCargo;
        private Label lblArea;
        private TextBox txtDNI;
        private TextBox txtNombres;
        private TextBox txtAñosdeAntiguedad;
        private ComboBox cboCargo;
        private ComboBox cboArea;
        private TextBox txtResultados;
        private Button btnCrear;
        private Button btnMostrarInformacion;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
