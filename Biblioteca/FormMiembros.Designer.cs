namespace Biblioteca
{
    partial class FormMiembros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtNumeroMiembro = new TextBox();
            lblNombre = new Label();
            lblNumeroMiembro = new Label();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dataGridViewMiembros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMiembros).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(242, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(309, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtNumeroMiembro
            // 
            txtNumeroMiembro.Location = new Point(242, 74);
            txtNumeroMiembro.Name = "txtNumeroMiembro";
            txtNumeroMiembro.Size = new Size(309, 23);
            txtNumeroMiembro.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(111, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblNumeroMiembro
            // 
            lblNumeroMiembro.AutoSize = true;
            lblNumeroMiembro.Location = new Point(111, 77);
            lblNumeroMiembro.Name = "lblNumeroMiembro";
            lblNumeroMiembro.Size = new Size(122, 15);
            lblNumeroMiembro.TabIndex = 3;
            lblNumeroMiembro.Text = "Número de Miembro:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(603, 34);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(603, 74);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnModificar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(603, 114);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridViewMiembros
            // 
            dataGridViewMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMiembros.Location = new Point(111, 189);
            dataGridViewMiembros.Name = "dataGridViewMiembros";
            dataGridViewMiembros.Size = new Size(567, 230);
            dataGridViewMiembros.TabIndex = 7;
            // 
            // FormMiembros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewMiembros);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(lblNumeroMiembro);
            Controls.Add(lblNombre);
            Controls.Add(txtNumeroMiembro);
            Controls.Add(txtNombre);
            Name = "FormMiembros";
            Text = "FormMiembros";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMiembros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtNumeroMiembro;
        private Label lblNombre;
        private Label lblNumeroMiembro;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dataGridViewMiembros;
    }
}