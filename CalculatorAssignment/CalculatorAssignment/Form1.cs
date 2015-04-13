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
            if (textResult.Text == "0")
                textResult.Text = button.Text;
            else
                textResult.Text = textResult.Text + button.Text;
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

        }

        private void clearClick(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void clearEverythingClick(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void backspaceClick(object sender, EventArgs e)
        {
            int size = textResult.Text.Length - 1;
            if(size > 0)
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
            {}
        }

        private void inverseClick(object sender, EventArgs e)
        {

        }
    }
}
