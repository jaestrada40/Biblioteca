using System.Collections.Generic;
using System.ComponentModel;
using Biblioteca.Clases; 

namespace Biblioteca
{
    public static class DataStore
    {
        public static List<Libro> Libros { get; } = new List<Libro>();
        public static List<Miembro> Miembros { get; } = new List<Miembro>();

        public static List<Prestamo> Prestamos { get; } = new List<Prestamo>();

    }
}
