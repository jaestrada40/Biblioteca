using Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormPrestamos : Form
    {
        private List<Prestamo> prestamos = new List<Prestamo>();
        public FormPrestamos()
        {
            InitializeComponent();
            CargarDatos();
        }

        // Configura el formulario con datos iniciales
        private void CargarDatos()
        {
            // Cargar libros y miembros en los ComboBoxes
            CargarLibros();
            CargarMiembros();
        }

        private void CargarLibros()
        {
            // Ejemplo de carga de libros en un ComboBox
            comboBoxLibros.Items.Clear();
            foreach (var libro in DataStore.Libros)
            {
                comboBoxLibros.Items.Add(libro);
            }
            comboBoxLibros.DisplayMember = "Titulo";
        }

        private void CargarMiembros()
        {
            // Ejemplo de carga de miembros en un ComboBox
            comboBoxMiembros.Items.Clear();
            foreach (var miembro in DataStore.Miembros)
            {
                comboBoxMiembros.Items.Add(miembro);
            }
            comboBoxMiembros.DisplayMember = "Nombre";
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener libro y miembro seleccionados desde los ComboBoxes
                Libro libroSeleccionado = comboBoxLibros.SelectedItem as Libro;
                Miembro miembroSeleccionado = comboBoxMiembros.SelectedItem as Miembro;

                if (libroSeleccionado == null || miembroSeleccionado == null)
                {
                    MessageBox.Show("Por favor, seleccione un libro y un miembro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear un nuevo préstamo con la fecha actual
                Prestamo prestamo = new Prestamo(libroSeleccionado, miembroSeleccionado, DateTime.Now);
                prestamo.RealizarPrestamo();

                prestamos.Add(prestamo); // Agregar el préstamo a la lista
                MessageBox.Show("El préstamo se ha realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListaPrestamos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevolverLibro_Click(object sender, EventArgs e)
        {
            // Ejemplo simple de devolución de libro
            if (dataGridViewPrestamos.SelectedRows.Count > 0)
            {
                // Obtener el préstamo seleccionado
                var selectedRow = dataGridViewPrestamos.SelectedRows[0];
                var prestamoSeleccionado = selectedRow.DataBoundItem as Prestamo;

                if (prestamoSeleccionado != null)
                {
                    try
                    {
                        prestamoSeleccionado.DevolverLibro();
                        MessageBox.Show("El libro ha sido devuelto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarListaPrestamos();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para devolver el libro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarListaPrestamos()
        {
            // Actualiza el DataGridView con la lista de préstamos
            dataGridViewPrestamos.Rows.Clear();
            foreach (var prestamo in prestamos)
            {
                dataGridViewPrestamos.Rows.Add(prestamo.LibroPrestado.Titulo, prestamo.Miembro.Nombre, prestamo.FechaPrestamo.ToShortDateString(), prestamo.FechaDevolucion?.ToShortDateString() ?? "No devuelto");
            }
        }
    }
}
