using System;

namespace Biblioteca.Clases
{
    public class Prestamo
    {
        public Libro LibroPrestado { get; set; }
        public Miembro Miembro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }

        public Prestamo(Libro libro, Miembro miembro, DateTime fechaPrestamo)
        {
            LibroPrestado = libro;
            Miembro = miembro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = null;
        }

        public virtual void RealizarPrestamo()
        {
            if (LibroPrestado.EstaPrestado) 
            {
                throw new InvalidOperationException("El libro ya ha sido prestado.");
            }

            // Marca el libro como prestado
            LibroPrestado.EstaPrestado = true;
            FechaDevolucion = null; 

            // Implementación específica para libros físicos o electrónicos...
            Console.WriteLine($"El libro '{LibroPrestado.Titulo}' ha sido prestado.");
        }

        public void DevolverLibro()
        {
            if (FechaDevolucion != null)
            {
                throw new InvalidOperationException("El libro ya ha sido devuelto.");
            }

            FechaDevolucion = DateTime.Now; 

            // Marca el libro como no prestado
            LibroPrestado.EstaPrestado = false;

            Console.WriteLine($"El libro '{LibroPrestado.Titulo}' ha sido devuelto.");
        }
    }

}