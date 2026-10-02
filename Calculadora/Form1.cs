using System.Reflection.Metadata;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        string lastOperator;


        int num1;
        int num2;


        public Form1()
        {
            InitializeComponent();
        }

    


        private void get_Number(object sender, EventArgs e)
        {
            if (sender is Control c && int.TryParse(c.Text, out int value))
            {
                if (num1 == 0)
                {
                    num1 = value;
                    txtBoxResultado.Text = c.Text;
                }
                else
                {
                    num2 = value;
                    txtBoxResultado.Text += c.Text;
                }
            }
        }
    }
}
