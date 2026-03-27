using ComplexStringApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        ComplexNumber num1;
        ComplexNumber num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = new ComplexNumber(textBox1.Text);
            num2 = new ComplexNumber(textBox2.Text);

            label1.Text = "Числа створені";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (num1.IsEqual(num2))
                label1.Text = "Числа рівні";
            else
                label1.Text = "Числа не рівні";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComplexNumber res = num1.Add(num2);

            label1.Text = "Сума: " + res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ComplexNumber res = num1.Multiply(num2);

            label1.Text = "Добуток: " + res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber[] arr = new ComplexNumber[6];

                arr[0] = new ComplexNumber("2+3i");
                arr[1] = new ComplexNumber("1+1i");
                arr[2] = new ComplexNumber("4-2i");

                arr[3] = (ComplexNumber)arr[0].Clone();
                arr[4] = (ComplexNumber)arr[1].Clone();
                arr[5] = (ComplexNumber)arr[2].Clone();

                string result = "Масив до сортування:\n";

                for (int i = 0; i < arr.Length; i++)
                {
                    result += arr[i].ToString() + "\n";
                }

                Array.Sort(arr);

                result += "\nМасив після сортування:\n";

                for (int i = 0; i < arr.Length; i++)
                {
                    result += arr[i].ToString() + "\n";
                }

                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
 }

