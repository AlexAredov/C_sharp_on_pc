using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Пузырьком
//Шейкерная
//Вставкой
//5, 3, 7, 1, 9, 2, 4
namespace _33Project4
{
    public partial class Form1 : Form
    {
        private int[] arr;

        public Form1()
        {
            InitializeComponent();
        }

        private void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private int summa_plus(int[] arr)
        {
            int summa = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    summa += arr[i];
                }
            }
            return summa;
        }

        private int number_minus(int[] arr)
        {
            int number = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    number++;
                }
            }
            return number;
        }

        private int[] bubble_sort(int[] arr)
        {
            for (var i = 1; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            return arr;
        }

        private int[] insertion_sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int x = arr[i];
                int j = i;
                while (j > 0 && arr[j - 1] > x)
                {
                    swap(ref arr[j], ref arr[j-1]);
                    j--;
                }
                arr[j] = x;
            }
            return arr;
        }

        private int[] shaker_sort(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                bool swapFlag = false;
                for (int j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                for (int j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        swap(ref array[j - 1], ref array[j]);
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

            return array;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arr = textBox1.Text.Replace(" ", "").Split(',').Select(Int32.Parse).ToArray();
            label3.Text = "Изначальный массив: " + string.Join(", ", arr);
            if (comboBox1.SelectedItem.Equals("Пузырьком"))
            {
                arr = bubble_sort(arr);
            }
            else if (comboBox1.SelectedItem.Equals("Шейкерная"))
            {
                arr = shaker_sort(arr);
            }
            else if (comboBox1.SelectedItem.Equals("Вставкой"))
            {
                arr = insertion_sort(arr);
            }
            label4.Text = "Отсортированный массив: " + string.Join(", ", arr);
            label1.Text = "Сумма положительных: " + summa_plus(arr).ToString();
            label2.Text = "Количество отрицательных: " + number_minus(arr).ToString();
        }
    }
}
