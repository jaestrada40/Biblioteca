namespace Biblioteca
{
    public partial class Form1 : Form
    {
        private FormLibros formLibros;
        private FormMiembros formMiembros;
        private FormPrestamos formPrestamos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLibros == null || formLibros.IsDisposed)
            {
                formLibros = new FormLibros();
                formLibros.FormClosed += (s, args) => formLibros = null;
            }
            formLibros.Show();
            formLibros.BringToFront();
        }

        private void miembroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formMiembros == null || formMiembros.IsDisposed)
            {
                formMiembros = new FormMiembros();
                formMiembros.FormClosed += (s, args) => formMiembros = null;
            }
            formMiembros.Show();
            formMiembros.BringToFront();
        }

        private void alquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formPrestamos == null || formPrestamos.IsDisposed)
            {
                formPrestamos = new FormPrestamos();
                formPrestamos.FormClosed += (s, args) => formLibros = null;
            }
            formPrestamos.Show();
            formPrestamos.BringToFront();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (formMiembros == null || formMiembros.IsDisposed)
            {
                formMiembros = new FormMiembros();
                formMiembros.FormClosed += (s, args) => formMiembros = null;
            }
            formMiembros.Show();
            formMiembros.BringToFront();

        }

        private void btnAdminLibros_Click(object sender, EventArgs e)
        {
            if (formLibros == null || formLibros.IsDisposed)
            {
                formLibros = new FormLibros();
                formLibros.FormClosed += (s, args) => formLibros = null;
            }
            formLibros.Show();
            formLibros.BringToFront();

        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            if (formPrestamos == null || formPrestamos.IsDisposed)
            {
                formPrestamos = new FormPrestamos();
                formPrestamos.FormClosed += (s, args) => formLibros = null;
            }
            formPrestamos.Show();
            formPrestamos.BringToFront();

        }
    }
}
