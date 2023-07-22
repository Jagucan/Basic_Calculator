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

        // CE Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            displayBox.Text = "0";
            calcOperator = "";
            num1 = 0;
            num2 = 0;
        }

        // BA Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (displayBox.TextLength == 1)
            {
                displayBox.Text = "0";
            }
            displayBox.Text = displayBox.Text.Substring(0, displayBox.Text.Length - 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calcOperator = "+";
            num1 = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            calcOperator = "-";
            num1 = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            calcOperator = "*";
            num1 = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calcOperator = "/";
            num1 = Convert.ToDouble(displayBox.Text);
            displayBox.Text = "0";
        }
        private void displayBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            displayBox.Text = displayBox.Text + "0";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text = displayBox.Text + "1";
        }
        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text = displayBox.Text + "2";
        }
        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text = displayBox.Text + "3";
        }
        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text = displayBox.Text + "4";
        }
        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text = displayBox.Text + "5";
        }
        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text = displayBox.Text + "6";
        }
        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text = displayBox.Text + "7";
        }
        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text = displayBox.Text + "8";
        }
        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = "";
            }
            displayBox.Text = displayBox.Text + "9";
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            displayBox.Text = displayBox.Text + ",";
        }

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