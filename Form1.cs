using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
   //Relingga Aditya
   //103022300107
    public partial class Form1: Form
    {
        string angka1;
        string number;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
             angka1 = textBox1.Text;
            number = "";
        
            Console.WriteLine(angka1);
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
     
            number =number+ "1";
            textBox1.Text = number;
            textBox1.Show();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            number = number + "2";
            textBox1.Text = number;
            textBox1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            number = number + "3";
            //int result = Int32.Parse(number);
            //textBox1.Text = result.ToString();
            textBox1.Text = number;
            textBox1.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            number = number + "7";
            textBox1.Text = number;
            textBox1.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            number = number + "5";
            textBox1.Text = number;
            textBox1.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            number = number + "4";
         
            textBox1.Text = number;
            textBox1.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            number = number + "6";
            textBox1.Text = number;
            textBox1.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            number = number + "8";
            textBox1.Text = number;
            textBox1.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            number = number + "9";
            textBox1.Text = number;
            textBox1.Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int a1 =Int32.Parse(angka1);

            int result = Int32.Parse(number);
            int hasil = a1 + result;
            textBox1.Text = hasil.ToString();
        }
        private void button12_Click(object sender, EventArgs e)
        {
             number = number + "0";
            textBox1.Text = number; ;
            textBox1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
