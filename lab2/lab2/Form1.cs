using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount;
            int m = dataGridView1.ColumnCount;

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (dataGridView1[j, i].Value == null)
                    {
                        MessageBox.Show("Заповніть всі клітинки матриці");
                        return;
                    }

                    matrix[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
            }

            textBoxResult.Text = "";

            // сума рядків з від'ємними елементами
            for (int i = 0; i < n; i++)
            {
                int sum = 0;

                for (int j = 0; j < m; j++)
                {
                    sum += matrix[i, j]; // всі елементи
                }

                textBoxResult.Text += "Рядок " + i + " сума = " + sum + Environment.NewLine;
            }

            textBoxResult.Text += Environment.NewLine + "Сідлові точки:" + Environment.NewLine;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int element = matrix[i, j];

                    bool isMinInRow = true;
                    for (int col = 0; col < m; col++)
                    {
                        if (matrix[i, col] < element)
                        {
                            isMinInRow = false;
                            break;
                        }
                    }

                    bool isMaxInCol = true;
                    for (int row = 0; row < n; row++)
                    {
                        if (matrix[row, j] > element)
                        {
                            isMaxInCol = false;
                            break;
                        }
                    }

                    if (isMinInRow && isMaxInCol)
                    {
                        textBoxResult.Text += $"i={i} j={j} value={element}\r\n";
                    }
                }
            }

            // сума додатних елементів над головною діагоналлю
            if (n != m)
            {
                textBoxResult.Text += "\r\nМатриця не квадратна — неможливо знайти суму додатних елементів над головною діагоналлю";
            }
            else
            {
                int sumPositive = 0;

                for (int a = 0; a < n; a++)
                {
                    for (int b = 0; b < m; b++)
                    {
                        if (a < b)
                        {
                            sumPositive += matrix[a, b];
                        }
                    }
                }

                textBoxResult.Text += "\r\nСума додатних елементів над головною діагоналлю = " + sumPositive;
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = Convert.ToInt32(textBoxRows.Text);
                int cols = Convert.ToInt32(textBoxCols.Text);

                if (rows <= 0 || cols <= 0)
                {
                    MessageBox.Show("Кількість має бути більше 0");
                    return;
                }

                dataGridView1.RowCount = rows;
                dataGridView1.ColumnCount = cols;
            }
            catch
            {
                MessageBox.Show("Введіть числа!");
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, i].Value = rand.Next(-10, 10);
                }
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
