namespace proyectoArquitecto
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
            lblCodigo = new Label();
            lblNombre = new Label();
            lblCondiciondeContrato = new Label();
            lblTipodeActividad = new Label();
            lblTipodeAfiliación = new Label();
            lblEspecialidad = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            cboTipodeAfiliacion = new ComboBox();
            cboTipodeActividad = new ComboBox();
            cboCondiciondeContrato = new ComboBox();
            cboEspecialidad = new ComboBox();
            txtResultados = new TextBox();
            btnCalcular = new Button();
            btnMostrarResultados = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(45, 29);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(185, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblCondiciondeContrato
            // 
            lblCondiciondeContrato.AutoSize = true;
            lblCondiciondeContrato.Location = new Point(66, 120);
            lblCondiciondeContrato.Name = "lblCondiciondeContrato";
            lblCondiciondeContrato.Size = new Size(159, 20);
            lblCondiciondeContrato.TabIndex = 2;
            lblCondiciondeContrato.Text = "Condicion de Contrato";
            // 
            // lblTipodeActividad
            // 
            lblTipodeActividad.AutoSize = true;
            lblTipodeActividad.Location = new Point(598, 29);
            lblTipodeActividad.Name = "lblTipodeActividad";
            lblTipodeActividad.Size = new Size(127, 20);
            lblTipodeActividad.TabIndex = 3;
            lblTipodeActividad.Text = "Tipo de Actividad";
            // 
            // lblTipodeAfiliación
            // 
            lblTipodeAfiliación.AutoSize = true;
            lblTipodeAfiliación.Location = new Point(349, 29);
            lblTipodeAfiliación.Name = "lblTipodeAfiliación";
            lblTipodeAfiliación.Size = new Size(127, 20);
            lblTipodeAfiliación.TabIndex = 4;
            lblTipodeAfiliación.Text = "Tipo de Afiliacion";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(480, 129);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(93, 20);
            lblEspecialidad.TabIndex = 5;
            lblEspecialidad.Text = "Especialidad";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 61);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 6;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // cboTipodeAfiliacion
            // 
            cboTipodeAfiliacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipodeAfiliacion.FormattingEnabled = true;
            cboTipodeAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            cboTipodeAfiliacion.Location = new Point(339, 61);
            cboTipodeAfiliacion.Name = "cboTipodeAfiliacion";
            cboTipodeAfiliacion.Size = new Size(151, 28);
            cboTipodeAfiliacion.TabIndex = 8;
            cboTipodeAfiliacion.SelectedIndexChanged += cboTipodeAfiliacion_SelectedIndexChanged;
            // 
            // cboTipodeActividad
            // 
            cboTipodeActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipodeActividad.FormattingEnabled = true;
            cboTipodeActividad.Items.AddRange(new object[] { "OBRAS", "VIAS" });
            cboTipodeActividad.Location = new Point(574, 61);
            cboTipodeActividad.Name = "cboTipodeActividad";
            cboTipodeActividad.Size = new Size(151, 28);
            cboTipodeActividad.TabIndex = 9;
            // 
            // cboCondiciondeContrato
            // 
            cboCondiciondeContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondiciondeContrato.FormattingEnabled = true;
            cboCondiciondeContrato.Items.AddRange(new object[] { "ESTABLE", "CONTRATADO" });
            cboCondiciondeContrato.Location = new Point(66, 143);
            cboCondiciondeContrato.Name = "cboCondiciondeContrato";
            cboCondiciondeContrato.Size = new Size(151, 28);
            cboCondiciondeContrato.TabIndex = 10;
            cboCondiciondeContrato.SelectedIndexChanged += cboCondiciondeContrato_SelectedIndexChanged;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "ESTRUCTURAS", "RECURSOS HIDRICOS" });
            cboEspecialidad.Location = new Point(450, 152);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(151, 28);
            cboEspecialidad.TabIndex = 11;
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(12, 186);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.ReadOnly = true;
            txtResultados.Size = new Size(776, 214);
            txtResultados.TabIndex = 12;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(80, 411);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnMostrarResultados
            // 
            btnMostrarResultados.Location = new Point(252, 409);
            btnMostrarResultados.Name = "btnMostrarResultados";
            btnMostrarResultados.Size = new Size(213, 29);
            btnMostrarResultados.TabIndex = 14;
            btnMostrarResultados.Text = "MOSTRAR RESULTADOS";
            btnMostrarResultados.UseVisualStyleBackColor = true;
            btnMostrarResultados.Click += btnMostrarResultados_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(540, 411);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(677, 411);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrarResultados);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultados);
            Controls.Add(cboEspecialidad);
            Controls.Add(cboCondiciondeContrato);
            Controls.Add(cboTipodeActividad);
            Controls.Add(cboTipodeAfiliacion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblTipodeAfiliación);
            Controls.Add(lblTipodeActividad);
            Controls.Add(lblCondiciondeContrato);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblCondiciondeContrato;
        private Label lblTipodeActividad;
        private Label lblTipodeAfiliación;
        private Label lblEspecialidad;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private ComboBox cboTipodeAfiliacion;
        private ComboBox cboTipodeActividad;
        private ComboBox cboCondiciondeContrato;
        private ComboBox cboEspecialidad;
        private TextBox txtResultados;
        private Button btnCalcular;
        private Button btnMostrarResultados;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
