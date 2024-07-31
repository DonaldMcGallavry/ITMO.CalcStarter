using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class EngeneerForm : Form
    {
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";
        private static string stringAnswer;
        private static double firstNumber;
        private static double secondNumber;
        public EngeneerForm()
        {
            InitializeComponent();

            OutputDisplay.Text = "0";
        }
        public static string CalcNumber(string KeyNumber)
        {
            stringAnswer = stringAnswer + KeyNumber;
            return (stringAnswer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
            Application.Exit();
        }
        private void KeyPower_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.ePower);
        }

        private void KeySqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(OutputDisplay.Text);
                if (number >= 0)
                {
                    double result = Math.Sqrt(number);
                    OutputDisplay.Text = result.ToString();
                }
                else
                {
                    OutputDisplay.Text = "Invalid input";
                }
            }
            catch (FormatException)
            {
                OutputDisplay.Text = "Invalid input";
            }
            CalcEngine.CalcReset();
        }

        private void keyInverse_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(OutputDisplay.Text);
                if (number >= 0)
                {
                    double result = 1 / number;
                    OutputDisplay.Text = result.ToString();
                }
                else
                {
                    OutputDisplay.Text = "Invalid input";
                }
            }
            catch (FormatException)
            {
                OutputDisplay.Text = "Invalid input";
            }
            CalcEngine.CalcReset();

        }

        private void keySquare_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(OutputDisplay.Text);
                if (number >= 0)
                {
                    double result = number * number;
                    OutputDisplay.Text = result.ToString();
                }
                else
                {
                    OutputDisplay.Text = "Invalid input";
                }
            }
            catch (FormatException)
            {
                OutputDisplay.Text = "Invalid input";
            }
            CalcEngine.CalcReset();
        }

        private void KeyOne_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
        }

        private void KeyTwo_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
        }

        private void KeyThree_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
        }

        private void KeyFour_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
        }

        private void KeyFive_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
        }

        private void KeySix_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
        }

        private void KeySeven_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
        }

        private void KeyEight_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
        }

        private void KeyNine_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
        }

        private void KeyZero_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
        }

        private void KeyPoint_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcDecimal();
        }

        private void KeySign_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSign();
        }

        private void KeyClear_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
        }

        private void KeyExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KeyEqual_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        private void EngeneerForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EngineerModeMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StandardModeMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalcUI StandardForm = new CalcUI();
            StandardForm.Show();
          
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
