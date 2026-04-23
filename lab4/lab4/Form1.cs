using ComplexStringApp;
using System;
using System.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = new ComplexNumber(textBox1.Text);
                num2 = new ComplexNumber(textBox2.Text);

                label1.Text = "Числа створені";
            }
            catch (Exception ex)
            {
                label1.Text = "Помилка: " + ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 == null || num2 == null)
                    throw new Exception("Спочатку створіть числа");

                if (num1.IsEqual(num2))
                    label1.Text = "Числа рівні";
                else
                    label1.Text = "Числа не рівні";
            }
            catch (Exception ex)
            {
                label1.Text = "Помилка: " + ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 == null || num2 == null)
                    throw new Exception("Спочатку створіть числа");

                ComplexNumber res = num1.Add(num2);
                label1.Text = "Сума: " + res.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = "Помилка: " + ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 == null || num2 == null)
                    throw new Exception("Спочатку створіть числа");

                ComplexNumber res = num1.Multiply(num2);
                label1.Text = "Добуток: " + res.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = "Помилка: " + ex.Message;
            }
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

                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Масив до сортування:");
                for (int i = 0; i < arr.Length; i++)
                {
                    sb.AppendLine(arr[i].ToString());
                }

                Array.Sort(arr);

                sb.AppendLine();
                sb.AppendLine("Масив після сортування:");
                for (int i = 0; i < arr.Length; i++)
                {
                    sb.AppendLine(arr[i].ToString());
                }

                MessageBox.Show(sb.ToString(), "Демонстрація");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        ComplexCollection collection = new ComplexCollection();
        ComplexCollection collection = new ComplexCollection();
        ComplexCollection collection = new ComplexCollection();
    }
}