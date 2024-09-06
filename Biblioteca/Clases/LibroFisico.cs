using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class LibroFisico : Libro
    {
        public string Ubicacion { get; set; }

        public LibroFisico(string titulo, string autor, int anioPublicacion, string ubicacion)
            : base(titulo, autor, anioPublicacion)
        {
            this.Ubicacion = ubicacion;
        }
    }
}
