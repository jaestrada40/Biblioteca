namespace Biblioteca
{
    partial class FormLibros
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
            lblTitulo = new Label();
            lblAutor = new Label();
            lblAnoPublicacion = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtAnio = new TextBox();
            rbFisico = new RadioButton();
            rbElectronico = new RadioButton();
            lblUbicacion = new Label();
            txtUbicacion = new TextBox();
            lblTamanoArchivo = new Label();
            txtTamano = new TextBox();
            txtFormato = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            dataGridViewLibros = new DataGridView();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibros).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(67, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(67, 49);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor:";
            // 
            // lblAnoPublicacion
            // 
            lblAnoPublicacion.AutoSize = true;
            lblAnoPublicacion.Location = new Point(67, 83);
            lblAnoPublicacion.Name = "lblAnoPublicacion";
            lblAnoPublicacion.Size = new Size(113, 15);
            lblAnoPublicacion.TabIndex = 2;
            lblAnoPublicacion.Text = "Año de Publicación:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(221, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(231, 23);
            txtTitulo.TabIndex = 3;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(221, 46);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(231, 23);
            txtAutor.TabIndex = 4;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(221, 80);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(231, 23);
            txtAnio.TabIndex = 5;
            // 
            // rbFisico
            // 
            rbFisico.AutoSize = true;
            rbFisico.Location = new Point(225, 122);
            rbFisico.Name = "rbFisico";
            rbFisico.Size = new Size(58, 19);
            rbFisico.TabIndex = 6;
            rbFisico.TabStop = true;
            rbFisico.Text = "Físico ";
            rbFisico.UseVisualStyleBackColor = true;
            // 
            // rbElectronico
            // 
            rbElectronico.AutoSize = true;
            rbElectronico.Location = new Point(311, 122);
            rbElectronico.Name = "rbElectronico";
            rbElectronico.Size = new Size(84, 19);
            rbElectronico.TabIndex = 7;
            rbElectronico.TabStop = true;
            rbElectronico.Text = "Electrónico";
            rbElectronico.UseVisualStyleBackColor = true;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(67, 152);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(63, 15);
            lblUbicacion.TabIndex = 8;
            lblUbicacion.Text = "Ubicación:";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(221, 149);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(231, 23);
            txtUbicacion.TabIndex = 9;
            // 
            // lblTamanoArchivo
            // 
            lblTamanoArchivo.AutoSize = true;
            lblTamanoArchivo.Location = new Point(67, 193);
            lblTamanoArchivo.Name = "lblTamanoArchivo";
            lblTamanoArchivo.Size = new Size(112, 15);
            lblTamanoArchivo.TabIndex = 10;
            lblTamanoArchivo.Text = "Tamaño de Archivo:";
            // 
            // txtTamano
            // 
            txtTamano.Location = new Point(221, 190);
            txtTamano.Name = "txtTamano";
            txtTamano.Size = new Size(231, 23);
            txtTamano.TabIndex = 11;
            // 
            // txtFormato
            // 
            txtFormato.Location = new Point(221, 233);
            txtFormato.Name = "txtFormato";
            txtFormato.Size = new Size(231, 23);
            txtFormato.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 236);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 13;
            label1.Text = "Formato:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(547, 24);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(547, 83);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // dataGridViewLibros
            // 
            dataGridViewLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLibros.Location = new Point(28, 287);
            dataGridViewLibros.Name = "dataGridViewLibros";
            dataGridViewLibros.Size = new Size(735, 300);
            dataGridViewLibros.TabIndex = 17;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(547, 53);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 18;
            btnCargar.Text = "Editar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(btnCargar);
            Controls.Add(dataGridViewLibros);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(txtFormato);
            Controls.Add(txtTamano);
            Controls.Add(lblTamanoArchivo);
            Controls.Add(txtUbicacion);
            Controls.Add(lblUbicacion);
            Controls.Add(rbElectronico);
            Controls.Add(rbFisico);
            Controls.Add(txtAnio);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblAnoPublicacion);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Name = "FormLibros";
            Text = "FormLibros";
            Load += FormLibros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAutor;
        private Label lblAnoPublicacion;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtAnio;
        private RadioButton rbFisico;
        private RadioButton rbElectronico;
        private Label lblUbicacion;
        private TextBox txtUbicacion;
        private Label lblTamanoArchivo;
        private TextBox txtTamano;
        private TextBox txtFormato;
        private Label label1;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridView dataGridViewLibros;
        private Button btnCargar;
    }
}