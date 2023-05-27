namespace Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            int fila = dgvDueños.Rows.Add();
            string Nombre = Convert.ToString(txtbox_nombre.Text).ToUpper();
            string Correo = Convert.ToString(txtbox_correo.Text).ToUpper();
            string Telefono = Convert.ToString(txtbox_telefono.Text).ToUpper();
            dgvDueños.Rows[fila].Cells[0].Value = Nombre;
            dgvDueños.Rows[fila].Cells[1].Value = Correo;
            dgvDueños.Rows[fila].Cells[2].Value = Telefono;
        }

        private void txtbox_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtbox_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_agregarM_Click(object sender, EventArgs e)
        {

        }
    }
}