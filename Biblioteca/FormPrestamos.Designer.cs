namespace Biblioteca
{
    partial class FormPrestamos
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
            comboBoxLibros = new ComboBox();
            comboBoxMiembros = new ComboBox();
            lblLibros = new Label();
            lblMiembros = new Label();
            btnRealizarPrestamo = new Button();
            btnDevolverLibro = new Button();
            dataGridViewPrestamos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamos).BeginInit();
            SuspendLayout();
            // 
            // comboBoxLibros
            // 
            comboBoxLibros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLibros.FormattingEnabled = true;
            comboBoxLibros.Location = new Point(208, 36);
            comboBoxLibros.Name = "comboBoxLibros";
            comboBoxLibros.Size = new Size(198, 23);
            comboBoxLibros.TabIndex = 0;
            // 
            // comboBoxMiembros
            // 
            comboBoxMiembros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiembros.FormattingEnabled = true;
            comboBoxMiembros.Location = new Point(208, 78);
            comboBoxMiembros.Name = "comboBoxMiembros";
            comboBoxMiembros.Size = new Size(198, 23);
            comboBoxMiembros.TabIndex = 1;
            // 
            // lblLibros
            // 
            lblLibros.AutoSize = true;
            lblLibros.Location = new Point(74, 43);
            lblLibros.Name = "lblLibros";
            lblLibros.Size = new Size(42, 15);
            lblLibros.TabIndex = 2;
            lblLibros.Text = "Libros:";
            // 
            // lblMiembros
            // 
            lblMiembros.AutoSize = true;
            lblMiembros.Location = new Point(74, 81);
            lblMiembros.Name = "lblMiembros";
            lblMiembros.Size = new Size(64, 15);
            lblMiembros.TabIndex = 3;
            lblMiembros.Text = "Miembros:";
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.Location = new Point(496, 38);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Size = new Size(138, 23);
            btnRealizarPrestamo.TabIndex = 4;
            btnRealizarPrestamo.Text = "Realizar Préstamo";
            btnRealizarPrestamo.UseVisualStyleBackColor = true;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // btnDevolverLibro
            // 
            btnDevolverLibro.Location = new Point(496, 77);
            btnDevolverLibro.Name = "btnDevolverLibro";
            btnDevolverLibro.Size = new Size(138, 23);
            btnDevolverLibro.TabIndex = 5;
            btnDevolverLibro.Text = "Devolver Libro";
            btnDevolverLibro.UseVisualStyleBackColor = true;
            btnDevolverLibro.Click += btnDevolverLibro_Click;
            // 
            // dataGridViewPrestamos
            // 
            dataGridViewPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrestamos.Location = new Point(113, 175);
            dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            dataGridViewPrestamos.Size = new Size(521, 188);
            dataGridViewPrestamos.TabIndex = 6;
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewPrestamos);
            Controls.Add(btnDevolverLibro);
            Controls.Add(btnRealizarPrestamo);
            Controls.Add(lblMiembros);
            Controls.Add(lblLibros);
            Controls.Add(comboBoxMiembros);
            Controls.Add(comboBoxLibros);
            Name = "FormPrestamos";
            Text = "FormPrestamos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxLibros;
        private ComboBox comboBoxMiembros;
        private Label lblLibros;
        private Label lblMiembros;
        private Button btnRealizarPrestamo;
        private Button btnDevolverLibro;
        private DataGridView dataGridViewPrestamos;
    }
}