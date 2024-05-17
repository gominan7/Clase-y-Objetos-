namespace proyectojefecito
{
    public partial class Form1 : Form
    {
        Jefe jefe;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNombres_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCargo.SelectedIndex = 0;
            cboArea.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            string dni = txtDNI.Text;
            string cargo = cboCargo.Text;
            string area = cboArea.Text;
            int antiguedad = int.Parse(txtAñosdeAntiguedad.Text);

            jefe = new Jefe(nombre, dni, cargo, area, antiguedad);
            MessageBox.Show("OBJETO CREADO");
        }

        private void btnMostrarInformacion_Click(object sender, EventArgs e)
        {
            // Calculamos los valores una vez y los almacenamos en variables locales
            double sueldoBase = jefe.CalcularSueldoBase();
            double bonificacion = jefe.CalcularBonificacion();

            // Mostramos la información
            txtResultados.AppendText("DNI: " + jefe.Dni + Environment.NewLine);
            txtResultados.AppendText("Nombre: " + jefe.Nombres + Environment.NewLine);
            txtResultados.AppendText("Cargo: " + jefe.Cargo + Environment.NewLine);
            txtResultados.AppendText("Area: " + jefe.Area + Environment.NewLine);
            txtResultados.AppendText("Años de Antiguedad: " + jefe.AnosAntiguedad + Environment.NewLine);
            txtResultados.AppendText("Sueldo Base: " + sueldoBase + Environment.NewLine); // Mostramos la variable local
            txtResultados.AppendText("Bonificacion: " + bonificacion + Environment.NewLine); // Mostramos la variable local
            txtResultados.AppendText("Movilidad : " + jefe.AsignarMontoMovilidad() + Environment.NewLine);
            txtResultados.AppendText("Sueldo Final: " + jefe.CalcularSueldoFinal() + Environment.NewLine);
        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void txtAñosdeAntiguedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombres.Clear();
            txtAñosdeAntiguedad.Clear();
            txtResultados.Clear();

            cboArea.SelectedIndex = -1;
            cboCargo.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
