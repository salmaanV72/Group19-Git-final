using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEAN
{
    public partial class Form1 : Form
    {
        //initialization
        public int userN;
        public int[] numbers;
        public Form1()
        {
            InitializeComponent();
            userN = 0;// set user equal to 0
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Describes what should happen when the button is clicked
            userN = Convert.ToInt16(textBox1.Text);//stores the entered value as an integer to user
            numbers = new int[userN];//initializes to save userN the number entered as the numbers array
            Random rand = new Random();//generates random numbers
            for (int i = 0; i < userN; i++)// for loop that determines which values to use
            {
                numbers[i] = rand.Next(1, 20);//line to actually generate the random numbers
            }
            calcMin(numbers);//calls method that calculates mean 
        }
        public void calcMin(int[] nums)
        {
            //program to calculate mean
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                label3.Text += " " + numbers[i].ToString();
            }
            MessageBox.Show("MEAN value is: " + numbers.Average());//messagebox to display mean
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
