using System.Security.Cryptography;

namespace Week4Assignment4._1._2
{
    public partial class Calculator : Form
    {
        double firstNum = 0;
        double secondNum = 0;
        string operation;
        bool newNum = true;
        bool clearPressed = false;

        IOperations operations = new Operations();
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (newNum)
            {
                txtDisplay.Text = button.Text;
                newNum = false;
            }
            else
            {
                txtDisplay.Text += button.Text;
            }
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            double currentNumber = double.Parse(txtDisplay.Text);

            if (operation == "")
            {
                firstNum = currentNumber;
            }
            else if (!newNum)
            {
                try
                {
                    firstNum = operations.Calculate(firstNum, currentNumber, operation);
                    txtDisplay.Text = firstNum.ToString();
                }
                catch (DivideByZeroException)
                {
                    txtDisplay.Text = "ERROR";
                    return;
                }
            }
            operation = button.Text;
            newNum = true;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(txtDisplay.Text);
            try
            {
                double result = operations.Calculate(firstNum, secondNum, operation);
                txtDisplay.Text = result.ToString();
                firstNum = result;
                operation = "";
                newNum = true;
            }
            catch (DivideByZeroException)
            {
                txtDisplay.Text = "ERROR";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!clearPressed)
            {
                txtDisplay.Text = string.Empty;
                newNum = true;
                clearPressed = true;
            }
            else
            {
                txtDisplay.Text = string.Empty;
                firstNum = 0;
                secondNum = 0;
                operation = "";
                newNum = true;
                clearPressed = false;
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double number))
            {
                number *= -1;
                txtDisplay.Text = number.ToString();
            }
        }
    }
}
