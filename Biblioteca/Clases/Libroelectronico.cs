using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class LibroElectronico : Libro
    {
        public double TamanoArchivo { get; set; } // En MB
        public string Formato { get; set; }

        public LibroElectronico(string titulo, string autor, int anioPublicacion, double tamanoArchivo, string formato)
            : base(titulo, autor, anioPublicacion)
        {
            TamanoArchivo = tamanoArchivo;
            Formato = formato;
        }
    }
}
    

