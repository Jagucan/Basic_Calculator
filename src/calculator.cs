using System.Security.Policy;

namespace Calculator
{

    public partial class calculator : Form
    {

        public calculator()
        {
            InitializeComponent();
        }

        string calcOperator = "";
        double num1 = 0;
        double num2 = 0;

        /**
         * Method that is executed when the "btnClear (CE)" button is clicked.
         * Resets the content to "0". 
         */
        private void btnClear_Click(object sender, EventArgs e)
        {
            displayBox.Text = "0";
            calcOperator = "";
            num1 = 0;
            num2 = 0;
        }

        /**
         * Method that is executed when the "btnBack (BA)" button is clicked.
         * remove number from screen one at a time
         */
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (displayBox.TextLength == 1)
            {
                displayBox.Text = "0";
            }
            displayBox.Text = displayBox.Text[..^1];
        }

        /**
         * Method that is executed when the "btnAdd" button is clicked.
         * Sets the calculation operator to addition (" + ").
         * Converts the content of the text box and saves it in the variable.
         * Resets the content to "0" and prepare for the next input number.
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            calcOperator = "+";
            num1 = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
        }

        /**
         * Method that is executed when the "btnSub" button is clicked.
         * Sets the calculation operator to subtration (" - ").
         * Converts the content of the text box and saves it in the variable.
         * Resets the content to "0" and prepare for the next input number.
         */
        private void btnSub_Click(object sender, EventArgs e)
        {
            calcOperator = "-";
            num1 = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
        }

        /**
         * Method that is executed when the "btnMult" button is clicked.
         * Sets the calculation operator to multiplication (" * ").
         * Converts the content of the text box and saves it in the variable.
         * Resets the content to "0" and prepare for the next input number.
         */
        private void btnMult_Click(object sender, EventArgs e)
        {
            calcOperator = "*";
            num1 = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
        }

        /**
         * Method that is executed when the "btnDiv" button is clicked.
         * Sets the calculation operator to division (" / ").
         * Converts the content of the text box and saves it in the variable.
         * Resets the content to "0" and prepare for the next input number.
         */
        private void btnDiv_Click(object sender, EventArgs e)
        {
            calcOperator = "/";
            num1 = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
        }

        private void displayBox_TextChanged(object sender, EventArgs e)
        {
        }

        /**
         * Method that is executed when the "btnNum0 ( 0 )" button is clicked.
         * Shows the number 0 on the screen.
         */
        private void btnNum0_Click(object sender, EventArgs e)
        {
            displayBox.Text += "0";
        }

        /**
         * Method that is executed when the "btnNum1 ( 1 )" button is clicked.
         * Shows the number 1 on the screen.
         */
        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text += "1";
        }

        /**
         * Method that is executed when the "btnNum2 ( 2 )" button is clicked.
         * Shows the number 2 on the screen.
         */
        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text += "2";
        }

        /**
         * Method that is executed when the "btnNum3 ( 3 )" button is clicked.
         * Shows the number 3 on the screen.
         */
        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text += "3";
        }

        /**
         * Method that is executed when the "btnNum4 ( 4 )" button is clicked.
         * Shows the number 4 on the screen.
         */
        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text += "4";
        }

        /**
         * Method that is executed when the "btnNum5 ( 5 )" button is clicked.
         * Shows the number 5 on the screen.
         */
        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text += "5";
        }

        /**
         * Method that is executed when the "btnNum7 ( 7 )" button is clicked.
         * Shows the number 7 on the screen.
         */
        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text += "6";
        }

        /**
         * Method that is executed when the "btnNum7 ( 7 )" button is clicked.
         * Shows the number 7 on the screen.
         */
        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text += "7";
        }

        /**
         * Method that is executed when the "btnNum8 ( 8 )" button is clicked.
         * Shows the number 8 on the screen.
         */
        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text += "8";
        }

        /**
         * Method that is executed when the "btnNum9 ( 9 )" button is clicked.
         * Shows the number 9 on the screen.
         */
        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text += "9";
        }

        /**
         * Method that is executed when the "btnPoint ( . )" button is clicked.
         * Shows the number 0 on the screen.
         */
        private void btnPoint_Click(object sender, EventArgs e)
        {
            displayBox.Text += ",";
        }

        /**
         * Method that is executed when the "btnEqual ( = )" button is clicked.
         * Converts the content of the text box and saves it in the variable.
         * Select the operation for the corresponding operator.
         * Shows the result of the corresponding operationto perform.
         */
        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(displayBox.Text);

            switch (calcOperator)
            {
                case "+":
                    displayBox.Text = $"{num1 + num2}";
                    break;
                case "-":
                    displayBox.Text = $"{num1 - num2}";
                    break;
                case "*":
                    displayBox.Text = $"{num1 * num2}";
                    break;
                case "/":
                    displayBox.Text = $"{num1 / num2}";
                    break;
            }
        }
    }
}