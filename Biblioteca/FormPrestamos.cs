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
        private BindingList<Prestamo> prestamos = new BindingList<Prestamo>();
        public FormPrestamos()
        {
            InitializeComponent();
            CargarDatos();
            dataGridViewPrestamos.DataSource = prestamos;
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
                Libro libroSeleccionado = comboBoxLibros.SelectedItem as Libro;
                Miembro miembroSeleccionado = comboBoxMiembros.SelectedItem as Miembro;

                if (libroSeleccionado == null || miembroSeleccionado == null)
                {
                    MessageBox.Show("Por favor, seleccione un libro y un miembro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Prestamo prestamo = new Prestamo(libroSeleccionado, miembroSeleccionado, DateTime.Now);
                prestamo.RealizarPrestamo();

                prestamos.Add(prestamo); // Actualiza automáticamente el DataGridView

                DataStore.Prestamos.Add(prestamo); // Asegúrate de que también se actualice en DataStore si lo usas en otros lugares
                MessageBox.Show("El préstamo se ha realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDevolverLibro_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrestamos.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPrestamos.SelectedRows[0];
                var prestamoSeleccionado = selectedRow.DataBoundItem as Prestamo;

                if (prestamoSeleccionado != null)
                {
                    try
                    {
                        prestamoSeleccionado.DevolverLibro();
                        MessageBox.Show("El libro ha sido devuelto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //private void ActualizarListaPrestamos()
        //{
        //    // Actualiza el DataGridView con la lista de préstamos
        //    dataGridViewPrestamos.Rows.Clear();
        //    foreach (var prestamo in DataStore.Prestamos)
        //    {
        //        dataGridViewPrestamos.Rows.Add(prestamo.LibroPrestado.Titulo, prestamo.Miembro.Nombre, prestamo.FechaPrestamo.ToShortDateString(), prestamo.FechaDevolucion?.ToShortDateString() ?? "No devuelto");
        //    }
        //}
    }
}
