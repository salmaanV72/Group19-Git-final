﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAX
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
                numbers[i] = rand.Next(1,20);
            }
            calcMax(numbers);
        }

        public void calcMax (int[] nums)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                label3.Text += " " + numbers[i].ToString();
            }
            MessageBox.Show("MAX value is: " + numbers.Max());
        }
    }
}
