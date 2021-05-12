using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // Global Variables
        string userInput = "";
        string firstImp = "";
        string secondImp = "";
        char action;
        double result = 0.0;

        private Rectangle CalculatorDisplay_Original;
        private Rectangle num1_Original;
        private Rectangle num2_Original;
        private Rectangle num3_Original;
        private Rectangle num4_Original;
        private Rectangle num5_Original;
        private Rectangle num6_Original;
        private Rectangle num7_Original;
        private Rectangle num8_Original;
        private Rectangle num9_Original;
        private Rectangle ZeroButton_Original;
        private Rectangle DecimalButton_Original;
        private Rectangle AddButton_Original;
        private Rectangle MinusButton_Original;
        private Rectangle MultiplyButton_Original;
        private Rectangle DivideButton_Original;
        private Rectangle EnterButton_Original;
        private Rectangle ClearButton_Original;

        private Size FormSize_Original;

        public Form1()
        {
            InitializeComponent();
        }



        private void num1_Click(object sender, EventArgs e)
        {
            // Clears display
            CalculatorDisplay.Text = "";
            userInput += "1";
            CalculatorDisplay.Text += userInput;

        }

        private void num2_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "2";
            CalculatorDisplay.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "3";
            CalculatorDisplay.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "4";
            CalculatorDisplay.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "5";
            CalculatorDisplay.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "6";
            CalculatorDisplay.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "7";
            CalculatorDisplay.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "8";
            CalculatorDisplay.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "9";
            CalculatorDisplay.Text += userInput;
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "0";
            CalculatorDisplay.Text += userInput;
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += ".";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            action = '+';
            firstImp = userInput;
            userInput = "";

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            action = '-';
            firstImp = userInput;
            userInput = "";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            action = '*';
            firstImp = userInput;
            userInput = "";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            action = '/';
            firstImp = userInput;
            userInput = "";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            secondImp = userInput;
            double fstNum, secNum;

            // Convert String to double
            fstNum = Convert.ToDouble(firstImp);
            secNum = Convert.ToDouble(secondImp);

            // Addition
            if (action == '+')
            {
                result = fstNum + secNum;
                CalculatorDisplay.Text = result.ToString();
            }
            // Subtraction
            else if (action == '-')
            {
                result = fstNum - secNum;
                CalculatorDisplay.Text = result.ToString();
            }
            // Multiplication
            else if (action == '*')
            {
                result = fstNum * secNum;
                CalculatorDisplay.Text = result.ToString();
            }
            // Division
            else if (action == '/')
            {
                if (secNum == 0)
                {
                    CalculatorDisplay.Text = "Divide by zero error";
                }
                else
                {
                    result = fstNum / secNum;
                    CalculatorDisplay.Text = result.ToString();
                }
            }
            // Resets calculator so you don't have to press clear as often
            firstImp = "";
            secondImp = "";
            userInput = "";
            result = 0.0;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstImp = "";
            secondImp = "";
            userInput = "";
            result = 0.0;
            CalculatorDisplay.Text = "0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FormSize_Original = this.Size;

            CalculatorDisplay_Original = new Rectangle(CalculatorDisplay.Location.X, CalculatorDisplay.Location.Y, CalculatorDisplay.Width, CalculatorDisplay.Height);
            num1_Original = new Rectangle(num1.Location.X, num1.Location.Y, num1.Width, num1.Height);
            num2_Original = new Rectangle(num2.Location.X, num2.Location.Y, num2.Width, num2.Height);
            num3_Original = new Rectangle(num3.Location.X, num3.Location.Y, num3.Width, num3.Height);
            num4_Original = new Rectangle(num4.Location.X, num4.Location.Y, num4.Width, num4.Height);
            num5_Original = new Rectangle(num5.Location.X, num5.Location.Y, num5.Width, num5.Height);
            num6_Original = new Rectangle(num6.Location.X, num6.Location.Y, num6.Width, num6.Height);
            num7_Original = new Rectangle(num7.Location.X, num7.Location.Y, num7.Width, num7.Height);
            num8_Original = new Rectangle(num8.Location.X, num8.Location.Y, num8.Width, num8.Height);
            num9_Original = new Rectangle(num9.Location.X, num9.Location.Y, num9.Width, num9.Height);
            ZeroButton_Original = new Rectangle(ZeroButton.Location.X, ZeroButton.Location.Y, ZeroButton.Width, ZeroButton.Height);
            DecimalButton_Original = new Rectangle(DecimalButton.Location.X, DecimalButton.Location.Y, DecimalButton.Width, DecimalButton.Height);
            AddButton_Original = new Rectangle(AddButton.Location.X, AddButton.Location.Y, AddButton.Width, AddButton.Height);
            MinusButton_Original = new Rectangle(MinusButton.Location.X, MinusButton.Location.Y, MinusButton.Width, MinusButton.Height);
            MultiplyButton_Original = new Rectangle(MultiplyButton.Location.X, MultiplyButton.Location.Y, MultiplyButton.Width, MultiplyButton.Height);
            DivideButton_Original = new Rectangle(DivideButton.Location.X, DivideButton.Location.Y, DivideButton.Width, DivideButton.Height);
            EnterButton_Original = new Rectangle(EnterButton.Location.X, EnterButton.Location.Y, EnterButton.Width, EnterButton.Height);
            ClearButton_Original = new Rectangle(ClearButton.Location.X, ClearButton.Location.Y, ClearButton.Width, ClearButton.Height);
        }

        // Calling resizing control function
        private void ResizeControlChildren()
        {
            ResizeControl(CalculatorDisplay_Original, CalculatorDisplay);
            ResizeControl(num1_Original, num1);
            ResizeControl(num2_Original, num2);
            ResizeControl(num3_Original, num3);
            ResizeControl(num4_Original, num4);
            ResizeControl(num5_Original, num5);
            ResizeControl(num6_Original, num6);
            ResizeControl(num7_Original, num7);
            ResizeControl(num8_Original, num8);
            ResizeControl(num9_Original, num9);
            ResizeControl(ZeroButton_Original, ZeroButton);
            ResizeControl(DecimalButton_Original, DecimalButton);
            ResizeControl(AddButton_Original, AddButton);
            ResizeControl(MinusButton_Original, MinusButton);
            ResizeControl(MultiplyButton_Original, MultiplyButton);
            ResizeControl(DivideButton_Original, DivideButton);
            ResizeControl(EnterButton_Original, EnterButton);
            ResizeControl(ClearButton_Original, ClearButton);

        }

        // Math for resizing elements
        private void ResizeControl(Rectangle OriginalControl, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(FormSize_Original.Width);
            float yRatio = (float)this.Height / (float)(FormSize_Original.Height);

            int newX = (int)(OriginalControl.X * xRatio);
            int newY = (int)(OriginalControl.Y * yRatio);
            int newWidth = (int)(OriginalControl.Width * xRatio);
            int newHeight = (int)(OriginalControl.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        // Function called to resize when user resizes
        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeControlChildren();
        }
    }
}
