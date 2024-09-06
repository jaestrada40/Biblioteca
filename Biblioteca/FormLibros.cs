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
    public partial class FormLibros : Form
    {
        private List<Libro> libros = new List<Libro>();
        private int indiceEdicion = -1;
        private bool modoEdicion = false;

        public FormLibros()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ActualizarListaLibros();
        }

        private void FormLibros_Load(object sender, EventArgs e)
        {

        }

        // Configurar columnas del DataGridView
        private void ConfigurarDataGridView()
        {
            dataGridViewLibros.ColumnCount = 7; 
            dataGridViewLibros.Columns[0].Name = "Título";
            dataGridViewLibros.Columns[1].Name = "Autor";
            dataGridViewLibros.Columns[2].Name = "Año Publicación";
            dataGridViewLibros.Columns[3].Name = "Ubicación";
            dataGridViewLibros.Columns[4].Name = "Tamaño";
            dataGridViewLibros.Columns[5].Name = "Formato";
            dataGridViewLibros.Columns[6].Name = "Tipo"; 
        }

        // Botón Agregar
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (modoEdicion)
                    {
                        // Si estamos en modo edición, actualizamos el libro seleccionado
                        Libro libroSeleccionado = DataStore.Libros[indiceEdicion];
                        libroSeleccionado.Titulo = txtTitulo.Text;
                        libroSeleccionado.Autor = txtAutor.Text;
                        libroSeleccionado.AnioPublicacion = int.Parse(txtAnio.Text);

                        if (libroSeleccionado is LibroFisico libroFisico)
                        {
                            libroFisico.Ubicacion = txtUbicacion.Text;
                        }
                        else if (libroSeleccionado is LibroElectronico libroElectronico)
                        {
                            libroElectronico.TamanoArchivo = double.Parse(txtTamano.Text);
                            libroElectronico.Formato = txtFormato.Text;
                        }
                        ActualizarListaLibros();
                        MessageBox.Show("Libro editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        modoEdicion = false;  
                        btnAgregar.Text = "Agregar";  
                    }
                    else
                    {
                        // Si no estamos en modo edición, agregamos un nuevo libro
                        if (rbFisico.Checked)
                        {
                            var libroFisico = new LibroFisico(txtTitulo.Text, txtAutor.Text, int.Parse(txtAnio.Text), txtUbicacion.Text);
                            DataStore.Libros.Add(libroFisico);
                        }
                        else if (rbElectronico.Checked)
                        {
                            var libroElectronico = new LibroElectronico(txtTitulo.Text, txtAutor.Text, int.Parse(txtAnio.Text), double.Parse(txtTamano.Text), txtFormato.Text);
                            DataStore.Libros.Add(libroElectronico);
                        }
                        ActualizarListaLibros();
                        MessageBox.Show("Libro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ActualizarListaLibros();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en los formatos de datos. Verifica que los campos numéricos sean correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewLibros.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int selectedIndex = dataGridViewLibros.SelectedRows[0].Index;

                // Verificar que el índice esté dentro del rango
                if (selectedIndex >= 0 && selectedIndex < DataStore.Libros.Count)
                {
                    // Eliminar el libro de la lista
                    DataStore.Libros.RemoveAt(selectedIndex);

                    // Actualizar el DataGridView
                    ActualizarListaLibros();

                    // Limpiar los campos
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Índice de fila seleccionado no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibros.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewLibros.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < DataStore.Libros.Count)
                {
                    Libro libroSeleccionado = DataStore.Libros[selectedIndex];
                    txtTitulo.Text = libroSeleccionado.Titulo;
                    txtAutor.Text = libroSeleccionado.Autor;
                    txtAnio.Text = libroSeleccionado.AnioPublicacion.ToString();

                    if (libroSeleccionado is LibroFisico libroFisico)
                    {
                        txtUbicacion.Text = libroFisico.Ubicacion;
                        txtTamano.Clear();
                        txtFormato.Clear();
                        rbFisico.Checked = true;
                    }
                    else if (libroSeleccionado is LibroElectronico libroElectronico)
                    {
                        txtTamano.Text = libroElectronico.TamanoArchivo.ToString();
                        txtFormato.Text = libroElectronico.Formato;
                        txtUbicacion.Clear();
                        rbElectronico.Checked = true;
                    }

                    // Configurar para edición
                    indiceEdicion = selectedIndex;
                    modoEdicion = true;
                    btnAgregar.Text = "Guardar";
                }
                else
                {
                    MessageBox.Show("Índice de fila seleccionado no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para cargar los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Actualiza los datos del DataGridView
        private void ActualizarListaLibros()
        {
            dataGridViewLibros.Rows.Clear();

            foreach (var libro in DataStore.Libros)  
            {
                if (libro is LibroFisico libroFisico)
                {
                    dataGridViewLibros.Rows.Add(libro.Titulo, libro.Autor, libro.AnioPublicacion, libroFisico.Ubicacion, "", "", "Físico");
                }
                else if (libro is LibroElectronico libroElectronico)
                {
                    dataGridViewLibros.Rows.Add(libro.Titulo, libro.Autor, libro.AnioPublicacion, "", libroElectronico.TamanoArchivo, libroElectronico.Formato, "Electrónico");
                }
            }
        }

        // Limpiar campos del formulario
        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
            txtUbicacion.Clear();
            txtTamano.Clear();
            txtFormato.Clear();
            rbFisico.Checked = true; 
            indiceEdicion = -1;
        }

        // Validar campos del formulario
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtAnio.Text) ||
                (rbFisico.Checked && string.IsNullOrWhiteSpace(txtUbicacion.Text)) ||
                (rbElectronico.Checked && (string.IsNullOrWhiteSpace(txtTamano.Text) || string.IsNullOrWhiteSpace(txtFormato.Text))))
            {
                return false;
            }

            // Validar que el año de publicación sea un número
            if (!int.TryParse(txtAnio.Text, out _))
            {
                return false;
            }

            // Validar que el tamaño del archivo sea un número
            if (rbElectronico.Checked && !double.TryParse(txtTamano.Text, out _))
            {
                return false;
            }

            return true;
        }

        private void rbFisico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFisico.Checked)
            {
                txtUbicacion.Enabled = true;
                txtTamano.Enabled = false;
                txtFormato.Enabled = false;
            }
        }

        private void rbElectronico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbElectronico.Checked)
            {
                txtUbicacion.Enabled = false;
                txtTamano.Enabled = true;
                txtFormato.Enabled = true;
            }
        }
    }
}
