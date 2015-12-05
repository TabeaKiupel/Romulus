using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace romulus
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void textBox_romanNumber_TextChanged(object sender, EventArgs e)
        {
            // textBox_romanNumber should only be enabled if it has a content
            if (textBox_romanNumber.Text == "")
            {
                textBox_romanNumber.Enabled = false;
                textBox_romanNumber.AcceptsTab = false;
            }
            else
            {
                textBox_romanNumber.Enabled = true;
                textBox_romanNumber.AcceptsTab = true;
            }
        }
        private void textBox_decimalNumber_TextChanged(object sender, EventArgs e)
        {
            preventInputOver4Chars();  // max valid number is 3999, so no need for larger input. Also this code prevents input over the size of int32
            String input = textBox_decimalNumber.Text;
            ErrorHandler errorMessager = new ErrorHandler();
            InputChecker inputCheck = new InputChecker();
            if (inputCheck.isSuccessful(input))
            { 
                toolStripStatusLabel_errorMessage.Text = "";
                setColoursIfDesired(true);
                RomanNumeralConverter converter = new RomanNumeralConverter(input);
                String romanNumberal = converter.getRomanNumeral();
                textBox_romanNumber.Text = romanNumberal;
                addRomanNumberToClipboardIfDesired();
                converter = null;
                trackBar1.Value = Convert.ToInt32(input);
            }
            else
            {
                int errorCode = inputCheck.getErrorCode();
                toolStripStatusLabel_errorMessage.Text = errorMessager.getErrorMessage(errorCode);
                setColoursIfDesired(false);
                textBox_romanNumber.Clear();
            }
            errorMessager = null;
            inputCheck = null;
            System.GC.Collect();
        }
        private void textbox_roman_click(object sender, EventArgs e)
        {
            textBox_romanNumber.SelectAll();
        }
        private void textbox_decimal_click(object sender, EventArgs e)
        {
            textBox_decimalNumber.SelectAll();
        }
        private void preventInputOver4Chars()
        {
            if (textBox_decimalNumber.Text.Length > 4)
            {
                textBox_decimalNumber.Text = textBox_decimalNumber.Text.Remove(4, 1);
                textBox_decimalNumber.Select(textBox_decimalNumber.Text.Length, 0);
                SystemSounds.Beep.Play();
                return;
            }
        }
        private void textBox_romanNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                textBox_decimalNumber.SelectAll();
            }
        }
        private void textBox_decimal_Enter(object sender, EventArgs e)
        {
            textBox_decimalNumber.SelectAll();
        }
        private void checkBox_colours_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_colours.Checked == true)
            {
                InputChecker inputCheck = new InputChecker();
                String input = textBox_decimalNumber.Text;
                if (inputCheck.isSuccessful(input))
                {
                    textBox_decimalNumber.BackColor = Color.FromArgb(46, 204, 113);
                }
                else if (textBox_decimalNumber.Text == "")
                {
                    textBox_decimalNumber.BackColor = Color.White;
                }
                else
                {
                    textBox_decimalNumber.BackColor = Color.FromArgb(231, 76, 60);
                }
                inputCheck = null;
                System.GC.Collect();
            }
            else
            {
                textBox_decimalNumber.BackColor = Color.White;
            }
        }
        private void setColoursIfDesired(bool inputCheckSuccessful)
        {
            if (checkBox_colours.Checked)
            {
                if (inputCheckSuccessful)
                {
                    textBox_decimalNumber.BackColor = Color.FromArgb(46, 204, 113);
                }
                else if (!inputCheckSuccessful && textBox_decimalNumber.Text == "")
                {
                    textBox_decimalNumber.BackColor = Color.White;
                }
                else
                {
                    textBox_decimalNumber.BackColor = Color.FromArgb(231, 76, 60);
                }
            }
        }
        private void addRomanNumberToClipboardIfDesired()
        {
            if (checkBox_autoCopy.Checked)
            {
                Clipboard.SetText(textBox_romanNumber.Text);
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            if (value == 0)
            {
                textBox_decimalNumber.Text = "";
            }
            else
            {
                textBox_decimalNumber.Text = Convert.ToString(value);
            }
        }
    }
}
