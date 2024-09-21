namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            libroToolStripMenuItem = new ToolStripMenuItem();
            miembroToolStripMenuItem = new ToolStripMenuItem();
            alquilerToolStripMenuItem = new ToolStripMenuItem();
            btnAdminLibros = new PictureBox();
            btnAdminMiembros = new PictureBox();
            label1 = new Label();
            btnRealizarPrestamo = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdminLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminMiembros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRealizarPrestamo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { libroToolStripMenuItem, miembroToolStripMenuItem, alquilerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // libroToolStripMenuItem
            // 
            libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            libroToolStripMenuItem.Size = new Size(57, 24);
            libroToolStripMenuItem.Text = "Libro";
            libroToolStripMenuItem.Click += libroToolStripMenuItem_Click;
            // 
            // miembroToolStripMenuItem
            // 
            miembroToolStripMenuItem.Name = "miembroToolStripMenuItem";
            miembroToolStripMenuItem.Size = new Size(84, 24);
            miembroToolStripMenuItem.Text = "Miembro";
            miembroToolStripMenuItem.Click += miembroToolStripMenuItem_Click;
            // 
            // alquilerToolStripMenuItem
            // 
            alquilerToolStripMenuItem.Name = "alquilerToolStripMenuItem";
            alquilerToolStripMenuItem.Size = new Size(75, 24);
            alquilerToolStripMenuItem.Text = "Alquiler";
            alquilerToolStripMenuItem.Click += alquilerToolStripMenuItem_Click;
            // 
            // btnAdminLibros
            // 
            btnAdminLibros.Image = Properties.Resources.books_5432699__1_;
            btnAdminLibros.Location = new Point(302, 140);
            btnAdminLibros.Name = "btnAdminLibros";
            btnAdminLibros.Size = new Size(134, 138);
            btnAdminLibros.TabIndex = 1;
            btnAdminLibros.TabStop = false;
            btnAdminLibros.Click += btnAdminLibros_Click;
            // 
            // btnAdminMiembros
            // 
            btnAdminMiembros.Image = Properties.Resources.membership_7548040;
            btnAdminMiembros.Location = new Point(94, 140);
            btnAdminMiembros.Name = "btnAdminMiembros";
            btnAdminMiembros.Size = new Size(134, 138);
            btnAdminMiembros.TabIndex = 2;
            btnAdminMiembros.TabStop = false;
            btnAdminMiembros.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 74);
            label1.Name = "label1";
            label1.Size = new Size(414, 27);
            label1.TabIndex = 3;
            label1.Text = "Seleccione una opción para comenzar:";
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.Image = Properties.Resources.books_3145871;
            btnRealizarPrestamo.Location = new Point(507, 140);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Size = new Size(132, 138);
            btnRealizarPrestamo.TabIndex = 4;
            btnRealizarPrestamo.TabStop = false;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 289);
            label2.Name = "label2";
            label2.Size = new Size(133, 51);
            label2.TabIndex = 5;
            label2.Text = "Administración de Miembros";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 289);
            label3.Name = "label3";
            label3.Size = new Size(133, 51);
            label3.TabIndex = 6;
            label3.Text = "Administración de Libros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(506, 289);
            label4.Name = "label4";
            label4.Size = new Size(133, 51);
            label4.TabIndex = 7;
            label4.Text = "Realizar Préstamo";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 391);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRealizarPrestamo);
            Controls.Add(label1);
            Controls.Add(btnAdminMiembros);
            Controls.Add(btnAdminLibros);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Menú";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAdminLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminMiembros).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRealizarPrestamo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem libroToolStripMenuItem;
        private ToolStripMenuItem miembroToolStripMenuItem;
        private ToolStripMenuItem alquilerToolStripMenuItem;
        private PictureBox btnAdminLibros;
        private PictureBox btnAdminMiembros;
        private Label label1;
        private PictureBox btnRealizarPrestamo;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
