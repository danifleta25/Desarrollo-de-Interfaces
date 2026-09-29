namespace Laberinto
{
    public partial class Form1 : Form
    {
        // Se lanza un sonido cuando un usuario toca un muro
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\ding.wav");

        // Se lanza un sonido cuando un usuario llega a la meta
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Chimes.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void label54_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            //Muestra un mensaje de felicitacion al participante por llegar a la meta
            MessageBox.Show("¡Felicidades! Has llegado a la meta.");
            Close();
        }

        /// <summary>
        /// Mueve el cursor a la posición inicial del laberinto 
        /// </summary>
        private void MoveToStart()
        {
            startSoundPlayer.Play();

            Point startingPoint = panel1.Location;
            startingPoint.Offset(50, 10);

            Cursor.Position = PointToScreen(startingPoint);

        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
