namespace Prueba_Matemática
{
    public partial class Form1 : Form
    {
        // Create a Random object to generate random numbers
        Random randomizer = new Random();

        // Creamos los numeros que vamos a usar para los problemas
        int num1;
        int num2;
        int resta1;
        int resta2;
        int mult1;
        int mult2;
        int div1;
        int div2;

        // Int para definir la cuenta atras
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        public void startTheQuiz()
        {
            //Numeros aleatorios suma
            num1 = randomizer.Next(51);
            num2 = randomizer.Next(51);

            //Numeros aleatorios resta
            resta1 = randomizer.Next(1, 51);
            resta2 = randomizer.Next(1, resta1 + 1);

            //Numeros aleatorios multiplicacion
            mult1 = randomizer.Next(2, 11);
            mult2 = randomizer.Next(2, 11);

            //Numeros aleatorios division
            div1 = randomizer.Next(20, 50);
            div2 = randomizer.Next(2, 11);

            //Asignar los numeros a los labels
            plusLeftLabel.Text = num1.ToString();
            plusRightLabel.Text = num2.ToString();

            dividedLeftLabel.Text = div1.ToString();
            dividedRightLabel.Text = div2.ToString();

            minusLeftLabel.Text = resta1.ToString();
            minusRightLabel.Text = resta2.ToString();

            timesLeftLabel.Text = mult1.ToString();
            timesRightLabel.Text = mult2.ToString();

            dividedLeftLabel.Text = div1.ToString();
            dividedRightLabel.Text = div2.ToString();

            suma.Value = 0;
            diferencia.Value = 0;
            producto.Value = 0;
            cociente.Value = 0;

            // Comenzar la cuenta atras
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        public bool checkTheAnswer()
        {
            if ((num1 + num2 == suma.Value) && (resta1 - resta2 == diferencia.Value)
                && (mult1 * mult2 == producto.Value) && (div1 / div2 == cociente.Value)) 
                return true;
            else
                return false;
        }

        private void startButton_MouseClick(object sender, MouseEventArgs e)
        {
            startButton.Enabled = false;
            startTheQuiz();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Felicidades!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("No has acabado a tiempo");
                suma.Value = num1 + num2;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
