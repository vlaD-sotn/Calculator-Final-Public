using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        static Handler handler;
        bool hasChanged = true;
        bool focus1 = false;
        bool focus2 = false;

        public Form1()
        {
            InitializeComponent();
            handler = new Handler();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
        }

        private void factBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "!";
        }

        private void sqrtTwoBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Sqrt(2)";
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Sqrt()";
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Log";
        }

        private void medianaBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Mediana";
        }

        private void powBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Pow(2)";
        }

        private void powCertBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Pow()";
        }

        private void EQUAL_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            if (hasChanged)
            {
                handler.GetArgument(textBox2.Text);
                handler.RecognizeArray(textBox1.Text);
                handler.CreateInvoker();
            }

            handler.RecognizeOperations(label1.Text);
            

            string result = String.Empty;

            foreach (var b in handler.Result())
            {
                result += " " + b.ToString();
            }

            textBox3.Text += label1.Text + "(" + textBox2.Text + ")" + ": " + result + "\n";

            hasChanged = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            string fileContent = String.Empty;
            using (openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog1.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog1.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            string[] arr = fileContent.Split(',');

            if (fileContent.Split(',').Length > 5)
            {               
                for (int i = 0; i < 5; i++)
                {
                    if (i != 4)
                        textBox1.Text += arr[i] + ",";
                    else
                        textBox1.Text += arr[i];
                }
            }

            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i != arr.Length - 1)
                        textBox1.Text += arr[i] + ",";
                    else
                        textBox1.Text += arr[i];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(focus1)
                textBox1.Text += "1";
            else if(focus2)
                textBox2.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += "2";
            else if (focus2)
                textBox2.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += "3";
            else if (focus2)
                textBox2.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += "4";
            else if (focus2)
                textBox2.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += "5";
            else if (focus2)
                textBox2.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += "6";
            else if (focus2)
                textBox2.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += "7";
            else if (focus2)
                textBox2.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += "8";
            else if (focus2)
                textBox2.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += "9";
            else if (focus2)
                textBox2.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += "0";
            else if (focus2)
                textBox2.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += ",";
            else if (focus2)
                textBox2.Text += ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (focus1)
                textBox1.Text += ".";
            else if (focus2)
                textBox2.Text += ".";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            focus1 = true;
            focus2 = false;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            focus1 = false;
            focus2 = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            hasChanged = true;
        }

        private void ResultTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
