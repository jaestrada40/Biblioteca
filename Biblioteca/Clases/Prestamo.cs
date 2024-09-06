using System;

namespace Biblioteca.Clases
{
    public class Prestamo
    {
        public Libro LibroPrestado { get; set; }
        public Miembro Miembro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }

        // Constructor que acepta todos los parámetros necesarios
        public Prestamo(Libro libro, Miembro miembro, DateTime fechaPrestamo)
        {
            LibroPrestado = libro;
            Miembro = miembro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = null; // Inicialmente, no se ha devuelto el libro
        }

        public virtual void RealizarPrestamo()
        {
            // Verifica si el libro ya ha sido prestado
            if (FechaDevolucion == null)
            {
                throw new InvalidOperationException("El libro ya ha sido prestado.");
            }

            // Lógica común para todos los libros
            FechaDevolucion = null; // Marca el libro como prestado (sin fecha de devolución aún)

            // Implementación específica para libros físicos
            if (LibroPrestado is LibroFisico libroFisico)
            {
                // Lógica adicional específica para libros físicos
                // Puedes actualizar la ubicación del libro si es necesario
                // Ejemplo: libroFisico.Ubicacion = "En préstamo"; // Si necesitas actualizar la ubicación
                Console.WriteLine($"El libro físico '{libroFisico.Titulo}' ha sido prestado.");
            }
            // Implementación específica para libros electrónicos
            else if (LibroPrestado is LibroElectronico libroElectronico)
            {
                // Lógica adicional específica para libros electrónicos
                // No es necesario actualizar la ubicación, pero puedes registrar detalles adicionales si lo deseas
                Console.WriteLine($"El libro electrónico '{libroElectronico.Titulo}' ha sido prestado.");
            }
        }

        public void DevolverLibro()
        {
            if (FechaDevolucion != null)
            {
                throw new InvalidOperationException("El libro ya ha sido devuelto.");
            }

            FechaDevolucion = DateTime.Now; // Marca el libro como devuelto con la fecha actual

            // Lógica adicional al devolver el libro si es necesario
            Console.WriteLine($"El libro '{LibroPrestado.Titulo}' ha sido devuelto.");
        }
    }
}