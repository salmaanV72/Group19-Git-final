using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDIAN
{
    public partial class Form1 : Form
    {
        public int userN;
        public int[] numbers;
        public Form1()
        {
            InitializeComponent();
            userN = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userN = Convert.ToInt16(textBox1.Text);
            numbers = new int[userN];
            Random rand = new Random();
            for (int i = 0; i < userN; i++)
            {
                numbers[i] = rand.Next(1, 20);
            }
            decimal median = calcMin(numbers);
            MessageBox.Show("MEDIAN value is: " + median.ToString());
        }
        public decimal calcMin(int[] nums)
        {
            for (int i = 0; i < numbers.Length ; i++)
            {
                label3.Text += " " + numbers[i].ToString();
            }

            Array.Sort(numbers);

            int count = numbers.Length;
            if (count % 2 == 0)
            {
                // count is even, average two middle elements
                int a = numbers[count / 2 - 1];
                int b = numbers[count / 2];
                return (a + b) / 2m;
            }
            else
            {
                // count is odd, return the middle element
                return numbers[count / 2];
            }
            //    
        }
    }
}
