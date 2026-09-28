namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Borrar la imagen del PictureBox
            pictureBox1.Image = null;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Permite al usuario seleccionar un archivo de imagen y mostrarlo en el PictureBox
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
            pictureBox1.Load(openFileDialog1.FileName);
            }
             
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //Permite al usuario seleccionar un color de fondo para el PictureBox
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Cierra la aplicacion
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
