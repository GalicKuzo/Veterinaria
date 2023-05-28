using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    internal class Dueño
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Dueño(string nombre, string correo, string telefono)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }

        public void AgregarFila(DataGridView dgv)
        {
            int fila = dgv.Rows.Add();
            dgv.Rows[fila].Cells[0].Value = Nombre;
            dgv.Rows[fila].Cells[1].Value = Correo;
            dgv.Rows[fila].Cells[2].Value = Telefono;
        }
    }
}
