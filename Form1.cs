using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double celsius = 0;
        double fahrenheit = 0;
        double kelvin = 0;
        double tempval = 0;

        String str_celsius = "";
        String str_fahrenheit = "";
        String str_kelvin = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_celsius.Text != str_celsius)
            {
                // typing in celsius text box
                tempval = double.Parse(textBox_celsius.Text);
                fahrenheit = (tempval * 9 / 5) + 32;
                textBox_fahrenheit.Text = fahrenheit.ToString();
                str_fahrenheit = fahrenheit.ToString();
                kelvin = (tempval + 273.15);
                textBox_kelvin.Text = kelvin.ToString();
                str_kelvin = kelvin.ToString();
                str_celsius = textBox_celsius.Text;
            }
            if (textBox_fahrenheit.Text != str_fahrenheit)
            {
                // typing in farenheit text box
                tempval = double.Parse(textBox_fahrenheit.Text);
                celsius = (tempval - 32) * 5 / 9;
                textBox_celsius.Text = celsius.ToString();
                str_celsius = celsius.ToString();
                kelvin = (tempval - 32) * 5 / 9 + 273.15;
                textBox_kelvin.Text = kelvin.ToString();
                str_kelvin = kelvin.ToString();
                str_fahrenheit = textBox_fahrenheit.Text;
            }
            if(textBox_kelvin.Text != str_kelvin)
            {
                // typing in kelvin text box
                tempval = double.Parse(textBox_kelvin.Text);
                celsius = tempval - 273.15;
                textBox_celsius.Text = celsius.ToString();
                str_celsius = celsius.ToString();
                fahrenheit = (tempval - 273.15) * 9 / 5 + 32;
                textBox_fahrenheit.Text = fahrenheit.ToString();
                str_fahrenheit = fahrenheit.ToString();
                str_kelvin = textBox_kelvin.Text;
            }
 
        }

        
    }
}
