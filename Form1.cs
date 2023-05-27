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
            int fila = dgvDue�os.Rows.Add();
            string Nombre = Convert.ToString(txtbox_nombre.Text).ToUpper();
            string Correo = Convert.ToString(txtbox_correo.Text).ToUpper();
            string Telefono = Convert.ToString(txtbox_telefono.Text).ToUpper();
            dgvDue�os.Rows[fila].Cells[0].Value = Nombre;
            dgvDue�os.Rows[fila].Cells[1].Value = Correo;
            dgvDue�os.Rows[fila].Cells[2].Value = Telefono;
            List<string> listDue�os = new List<string>();
            listDue�os.Add(Nombre);
            cbox_due�o.Items.AddRange(listDue�os.ToArray());
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
            int fila = dgvMascotas.Rows.Add();
            string Nombre = Convert.ToString(txt_nombreM.Text).ToUpper();
            string Edad = Convert.ToString(txt_edadM.Text).ToUpper();
            string Raza = Convert.ToString(txt_razaM.Text).ToUpper();
            string Due�o = cbox_due�o.SelectedItem.ToString();
            dgvMascotas.Rows[fila].Cells[0].Value = Nombre;
            dgvMascotas.Rows[fila].Cells[1].Value = Edad;
            dgvMascotas.Rows[fila].Cells[2].Value = Raza;
            dgvMascotas.Rows[fila].Cells[3].Value = Due�o;
        }
    }
}