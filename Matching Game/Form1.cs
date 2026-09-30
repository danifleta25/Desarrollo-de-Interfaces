namespace Matching_Game
{
    public partial class Form1 : Form
    {

        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        Label firstClicked = null;
        Label secondClicked = null;




        public Form1()
        {
            InitializeComponent();

            AssignIconsToSquares();

        }


        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Si el label ya esta visible, no hacer nada
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                //Comprobar si ha ganado el jugador
                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                    timer1.Start();
            }
        }


        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null && iconLabel.ForeColor == iconLabel.BackColor)
                    return;
            }       

            MessageBox.Show("¡Has encontrado todos los iconos!", "Felicidades");
            Close();

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            // Ocultar los iconos si no coinciden
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reiniciar los labels
            firstClicked = null;
            secondClicked = null;
        }
    }
}
