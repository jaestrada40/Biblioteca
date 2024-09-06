using System.Collections.Generic;
using Biblioteca.Clases; 

namespace Biblioteca
{
    public static class DataStore
    {
        public static List<Libro> Libros { get; } = new List<Libro>();
        public static List<Miembro> Miembros { get; } = new List<Miembro>();
    }
}
