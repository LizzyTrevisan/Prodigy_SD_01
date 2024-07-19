using System;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxTempType.SelectedIndex = 0; // Set default selection to Celsius
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double inputTemp = Double.Parse(textBoxInputTemp.Text);
                double temp1 = 0, temp2 = 0;
                string output1 = "", output2 = "";

                switch (comboBoxTempType.SelectedItem.ToString())//fucntions to verify which choice user selects
                {
                    case "Celsius":
                        temp1 = ConvertCToF(inputTemp);
                        temp2 = ConvertCToK(inputTemp);
                        output1 = temp1.ToString("F2") + " (F)";
                        output2 = temp2.ToString("F2") + " (K)";
                        break;
                    case "Fahrenheit":
                        temp1 = ConvertFToC(inputTemp);
                        temp2 = ConvertFToK(inputTemp);
                        output1 = temp1.ToString("F2") + " (C)";
                        output2 = temp2.ToString("F2") + " (K)";
                        break;
                    case "Kelvin":
                        temp1 = ConvertKToC(inputTemp);
                        temp2 = ConvertKToF(inputTemp);
                        output1 = temp1.ToString("F2") + " (C)";
                        output2 = temp2.ToString("F2") + " (F)";
                        break;
                }

                textBoxOutput1.Text = output1; //output for F
                textBoxOutput2.Text = output2; //output for K
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number."); //to catch the user's error entry
            }
        }

        private double ConvertCToF(double celsius) //conversion from C to F
        {
            return (9.0 / 5.0) * celsius + 32;
        }

        private double ConvertCToK(double celsius) //conversion from C to K
        {
            return celsius + 273.15;
        }

        private double ConvertFToC(double fahrenheit) //conversion from F to C
        {
            return (fahrenheit - 32) * 5.0 / 9.0;
        }

        private double ConvertFToK(double fahrenheit) //conversion from F to K
        {
            return (fahrenheit + 459.67) * 5.0 / 9.0;
        }

        private double ConvertKToC(double kelvin) //conversion from K to C
        {
            return kelvin - 273.15;
        }

        private double ConvertKToF(double kelvin) //conversion from K to F
        {
            return kelvin * 9.0 / 5.0 - 459.67;
        }

        private void labelInput_Click(object sender, EventArgs e) // lavbel created
        {

        }
    }
}
