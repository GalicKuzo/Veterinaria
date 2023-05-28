namespace Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtbox_correo.Text = "@gmail.com";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //lista de dueños
        List<string> listDueños = new List<string>();
        //Funcion para agregar Dueños
        private void Agregar_Click(object sender, EventArgs e)
        {
            string Nombre = Convert.ToString(txtbox_nombre.Text).ToUpper();
            string Correo = Convert.ToString(txtbox_correo.Text).ToUpper();
            string Telefono = Convert.ToString(txtbox_telefono.Text).ToUpper();
            Dueño dueño = new Dueño(Nombre, Correo, Telefono);
            dueño.AgregarFila(dgvDueños);
            if (!listDueños.Contains(Nombre))
            {
                listDueños.Add(Nombre);
                cbox_dueño.Items.Add(Nombre);
            }
            txtbox_nombre.Text = string.Empty;
            txtbox_correo.Text = "@gmail.com";
            txtbox_telefono.Text = string.Empty;
        }

        private void txtbox_telefono_TextChanged(object sender, EventArgs e)
        {

        }
        //Funcion para solo permitir numeros
        private void txtbox_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        //Funcion para solo permitir letras
        private void txtbox_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        //lista de mascotas
        List<string> listMascotas = new List<string>();
        private void btn_agregarM_Click(object sender, EventArgs e)
        {
            string Nombre = Convert.ToString(txt_nombreM.Text).ToUpper();
            string Edad = Convert.ToString(txt_edadM.Text).ToUpper();
            string Raza = Convert.ToString(txt_razaM.Text).ToUpper();
            string Dueño;
            //Excepcion por si el usuario ingresa un nombre que no esta definido en el ComboBox
            try
            {
                Dueño = cbox_dueño.SelectedItem.ToString();
            } catch
            {
                MessageBox.Show("¡El nombre que intenta seleccionar no existe!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Mascotas mascota = new Mascotas(Nombre, Edad, Raza, Dueño);
            mascota.AgregarFila(dgvMascotas);
            listMascotas.Add(Nombre);
            txt_nombreM.Text = string.Empty;
            txt_edadM.Text = string.Empty;
            txt_razaM.Text = string.Empty;
        }
        //Funcion para buscar un nombre usando el metodo de recursividad
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int i = listMascotas.Count - 1;
            string Nombre = Convert.ToString(txt_nombreB.Text).ToUpper();
            BuscarNombre(Nombre, i);
        }
        // Funcion para buscar el nombre de la mascota usando recursividad y las listas
        private void BuscarNombre(string name, int n)
        {
            if (name == listMascotas[n])
            {
                MessageBox.Show("¡La mascota que ha ingresado si se encuentra registrada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                if (n != 0)
                {
                    BuscarNombre(name, n-1);
                } else
                    MessageBox.Show("¡La mascota que ha ingresado no se encuentra registrada!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Funcion para solo permitir letras
        private void txt_nombreM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        //Funcion para solo permitir numeros
        private void txt_edadM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        //Funcion para solo permitir letras
        private void txt_razaM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        //Funcion para solo permitir numeros
        private void txt_nombreB_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Funcion para solo permitir letras
        private void txt_nombreB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}