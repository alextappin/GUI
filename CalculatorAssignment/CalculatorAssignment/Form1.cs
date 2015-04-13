//Alexander Tappin
//Gui Spring 2015
//Calculator in Windows Forms
//April 12, 2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAssignment
{
    public partial class TappinCalculator : Form
    {
        public double storedNumber = 0;
        public bool eventBool = false;

        public MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
        public TappinCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Holds the button click functionality for the numbers. Adds them to the text box
        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textResult.Text == "0" || eventBool)
                textResult.Text = button.Text;
            else
                textResult.Text = textResult.Text + button.Text;
            eventBool = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void plusOrMinus_Click(object sender, EventArgs e)
        {
            //puts the plus or minus, whatever is missing
            if (textResult.Text != "0")
            {
                if (textResult.Text[0] == '-')
                    textResult.Text = textResult.Text.Substring(1, textResult.Text.Length - 1);
                else
                    textResult.Text = "-" + textResult.Text;
            }
        }

        private void clearClick(object sender, EventArgs e)
        {
            //deletes it
            textResult.Text = "0";
        }

        private void clearEverythingClick(object sender, EventArgs e)
        {
            //deletes all memory
            textResult.Text = "0";
            storedNumber = 0;
            eventBool = false;
        }

        private void backspaceClick(object sender, EventArgs e)
        {
            //returns a substring
            int size = textResult.Text.Length - 1;
            if (size > 0)
                textResult.Text = textResult.Text.Substring(0, size);
        }

        private void equalClick(object sender, EventArgs e)
        {
            //microsoft control script that uses VB or Any scripting language
            //decided to use VBscript
            sc.Language = "VBScript";
            string expression = textResult.Text;
            //if it is not a valid expression
            try
            {
                object result = sc.Eval(expression);
                textResult.Text = result.ToString();
            }
            catch (System.Runtime.InteropServices.COMException)
            { }
            catch (DivideByZeroException)
            { }
        }

        private void inverseClick(object sender, EventArgs e)
        {
            eventBool = true;
            //evaluates the entire 1/expression
            sc.Language = "VBScript";
            string expression = textResult.Text;
            if (sc.Eval(expression).ToString() != "0")
            {
                expression = "1 / (" + expression + ")";
                object results = sc.Eval(expression);
                textResult.Text = results.ToString();
            }
            else
                textResult.Text = "0";
        }

        private void keyboardPressText(object sender, KeyPressEventArgs e)
        {
            //sends the buttons text to the text field
            //Button button = (Button)sender;
            //if (textResult.Text == "0" || eventBool)
            //    textResult.Text = button.Text;
            //else
            //    textResult.Text = textResult.Text + button.Text;
        }

        private void sqrtButton(object sender, EventArgs e)
        {
            //sqrts of the current input. Doesnt do 0
            if (textResult.Text != "0")
                textResult.Text = Math.Sqrt(Double.Parse(textResult.Text)).ToString();
        }

        private void storeExpression(object sender, EventArgs e)
        {
            eventBool = true;
            sc.Language = "VBScript";
            string expression = textResult.Text;
            try
            {
                storedNumber = sc.Eval(expression);
            }
            catch (System.Runtime.InteropServices.COMException)
            { }
            catch (DivideByZeroException)
            { }
        }

        private void clearMemory(object sender, EventArgs e)
        {
            storedNumber = 0;
        }

        private void retrieveMemory(object sender, EventArgs e)
        {
            
            textResult.Text = storedNumber.ToString();
        }

        private void memoryPlus(object sender, EventArgs e)
        {
            eventBool = true;
            sc.Language = "VBScript";
            string expression = storedNumber.ToString() + "+" + textResult.Text;
            try
            {
                storedNumber = sc.Eval(expression);
            }
            catch (System.Runtime.InteropServices.COMException)
            { }
            catch (DivideByZeroException)
            { }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator: Alexander Tappin, April 2015");
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implemented
        }

        private void digitGroupingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //didnt implement.
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textResult.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textResult.Text = System.Windows.Forms.Clipboard.GetText();
        }

        private void keyboardPressNum(object sender, KeyEventArgs e)
        {
            //sends the buttons text to the text field
            Button button = (Button)sender;
            if (textResult.Text == "0")
                textResult.Text = button.Text;
            else
                textResult.Text = textResult.Text + button.Text;
        }
    }
}
