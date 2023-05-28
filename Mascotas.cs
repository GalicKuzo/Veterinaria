using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    internal class Mascotas
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Raza { get; set; }
        public string Dueño { get; set; }
        //Constructor
        public Mascotas (string nombre, string edad, string raza, string dueño)
        {
            Nombre = nombre;
            Edad = edad;
            Raza = raza;
            Dueño = dueño;
        }
        //Funion para agregar elemtos a un DataGriedView
        public void AgregarFila(DataGridView dgv)
        {
            int fila = dgv.Rows.Add();
            dgv.Rows[fila].Cells[0].Value = Nombre;
            dgv.Rows[fila].Cells[1].Value = Edad;
            dgv.Rows[fila].Cells[2].Value = Raza;
            dgv.Rows[fila].Cells[3].Value = Dueño;
        }
    }
}
