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
    public partial class FormMiembros : Form
    {
        // private List<Miembro> miembros = new List<Miembro>();
        private int miembroSeleccionadoIndex = -1;
        private int indexMiembroEditado = -1;
        private bool modoEdicion = false;
        public FormMiembros()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ActualizarListaMiembros();
        }

        // Configurar columnas del DataGridView
        private void ConfigurarDataGridView()
        {
            dataGridViewMiembros.ColumnCount = 3;
            dataGridViewMiembros.Columns[0].Name = "Nombre";
            dataGridViewMiembros.Columns[1].Name = "Número de Miembro";
            dataGridViewMiembros.Columns[2].Name = "Historial de Préstamos";
        }

        // Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (modoEdicion && indexMiembroEditado >= 0)
                    {
                        // Actualizar miembro existente en DataStore.Miembros
                        DataStore.Miembros[indexMiembroEditado].Nombre = txtNombre.Text;
                        DataStore.Miembros[indexMiembroEditado].NumeroMiembro = int.Parse(txtNumeroMiembro.Text);
                        ActualizarListaMiembros();
                        MessageBox.Show("Miembro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Salir del modo edición
                        modoEdicion = false;
                        indexMiembroEditado = -1;
                        btnGuardar.Text = "Agregar";
                    }
                    else
                    {
                        // Agregar nuevo miembro a DataStore.Miembros
                        Miembro miembro = new Miembro(txtNombre.Text, int.Parse(txtNumeroMiembro.Text));
                        DataStore.Miembros.Add(miembro);
                        ActualizarListaMiembros();
                        MessageBox.Show("Miembro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Actualizar la lista y limpiar los campos
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en los formatos de datos. Verifica que el número de miembro sea correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Botón Modificar
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewMiembros.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewMiembros.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < DataStore.Miembros.Count) // Usa DataStore.Miembros
                {
                    // Cargar los datos en los TextBox para editar
                    Miembro miembroSeleccionado = DataStore.Miembros[selectedIndex]; // Usa DataStore.Miembros
                    txtNombre.Text = miembroSeleccionado.Nombre;
                    txtNumeroMiembro.Text = miembroSeleccionado.NumeroMiembro.ToString();

                    // Entrar en modo edición
                    modoEdicion = true;
                    indexMiembroEditado = selectedIndex;
                    btnGuardar.Text = "Guardar Cambios";
                }
            }
            else
            {
                MessageBox.Show("Selecciona un miembro de la lista para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMiembros.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int selectedIndex = dataGridViewMiembros.SelectedRows[0].Index;

                // Verifica que el índice sea válido dentro del rango de DataStore.Miembros
                if (selectedIndex >= 0 && selectedIndex < DataStore.Miembros.Count)
                {
                    // Mostrar un cuadro de diálogo de confirmación antes de eliminar
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este miembro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar el miembro de DataStore.Miembros
                        DataStore.Miembros.RemoveAt(selectedIndex);

                        // Actualizar la lista de miembros en el DataGridView
                        ActualizarListaMiembros();
                        LimpiarCampos(); // Limpiar los campos si es necesario

                        MessageBox.Show("Miembro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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



        private void ActualizarListaMiembros()
        {
            dataGridViewMiembros.Rows.Clear();

            foreach (var miembro in DataStore.Miembros)
            {
                string historial = string.Join(", ", miembro.HistorialPrestamos ?? new List<string>());
                dataGridViewMiembros.Rows.Add(miembro.Nombre, miembro.NumeroMiembro, historial);
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtNumeroMiembro.Clear();
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txtNombre.Text) && int.TryParse(txtNumeroMiembro.Text, out _);
        }

        // Cargar datos en los TextBoxes cuando se selecciona una fila en el DataGridView
        private void dataGridViewMiembros_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMiembros.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewMiembros.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < DataStore.Miembros.Count) // Usa DataStore.Miembros
                {
                    Miembro miembroSeleccionado = DataStore.Miembros[selectedIndex]; // Usa DataStore.Miembros
                    txtNombre.Text = miembroSeleccionado.Nombre;
                    txtNumeroMiembro.Text = miembroSeleccionado.NumeroMiembro.ToString();
                }
            }
        }

       
    }
}
