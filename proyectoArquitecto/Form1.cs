namespace proyectoArquitecto
{
    public partial class Form1 : Form
    {
        Arquitecto Arquitecto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTipodeAfiliacion.SelectedIndex = 0;
            cboTipodeActividad.SelectedIndex = 0;
            cboCondiciondeContrato.SelectedIndex = 0;
            cboEspecialidad.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombres = txtNombre.Text;
            string condicionContrato = cboCondiciondeContrato.Text.Trim().ToLower();
            string especialidad = cboEspecialidad.Text.Trim().ToLower();
            string tipoactividad = cboTipodeActividad.Text.Trim().ToLower();
            string tipoafiliado = cboTipodeAfiliacion.Text.Trim().ToLower();

            Arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoactividad, tipoafiliado);
            MessageBox.Show("OBJETO CREADO");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtResultados.Clear();

            cboCondiciondeContrato.SelectedIndex = -1;
            cboEspecialidad.SelectedIndex = -1;
            cboTipodeActividad.SelectedIndex = -1;
            cboTipodeAfiliacion.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboCondiciondeContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            txtResultados.AppendText("Codigo: " + Arquitecto.Codigo + Environment.NewLine);
            txtResultados.AppendText("Nombres: " + Arquitecto.Nombre + Environment.NewLine);
            txtResultados.AppendText("Condicion de contrato : " + Arquitecto.CondicionContrato + Environment.NewLine);
            txtResultados.AppendText("Especialidad: " + Arquitecto.Especialidad + Environment.NewLine);
            txtResultados.AppendText("Tipo de Actividad: " + Arquitecto.TipoActividad + Environment.NewLine);
            txtResultados.AppendText("Tipo de Afiliacion: " + Arquitecto.TipoAfiliado + Environment.NewLine);
            txtResultados.AppendText("Sueldo Base: " + Arquitecto.CalcularSueldoBase() + Environment.NewLine);
            txtResultados.AppendText("Bonificacion: " + Arquitecto.CalcularBonificacion() + Environment.NewLine);
            txtResultados.AppendText("Monto de Descuento: " + Arquitecto.CalcularDescuento() + Environment.NewLine);
            txtResultados.AppendText("Sueldo Bruto: " + Arquitecto.CalcularSueldoBruto() + Environment.NewLine);
            txtResultados.AppendText("Sueldo Neto: " + Arquitecto.CalcularSueldoNeto() + Environment.NewLine);
        }

        private void cboTipodeAfiliacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

