using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class Miembro
    {
        public string Nombre { get; set; }
        public int NumeroMiembro { get; set; }
        public List<string> HistorialPrestamos { get; set; } = new List<string>();

        public Miembro(string nombre, int numeroMiembro)
        {
            Nombre = nombre;
            NumeroMiembro = numeroMiembro;
        }
    }
}


