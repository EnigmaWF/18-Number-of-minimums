using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_Number_of_minimums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string f(int[,] a)
        {
            int min = 99999999; //минимум
            int k = 0; //счетчик минимумов
            int n = 0; //&&&
                       //определяет минимальный элемент двумерного массива, а затем подсчитывает количество минимумов
        m: //метка
            {
                for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
                {
                    for (int j = 0; j < Convert.ToInt32(textBox3.Text); j++)
                    {
                        if (a[i, j] < min) //минимум
                        {
                            min = a[i, j];
                        }

                        //для второго прохождения циклов
                        if (n == 1)//поиск минимумов
                        {
                            if (a[i, j] == min)
                            {
                                k++;
                            }
                        }
                    }
                }
            }
            if (n == 0) //переход к m для поиска минимумов
            {
                n = 1;
                goto m;
            }
            return ("минимальное число " + min + "\nколичество повторов " + k);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*18. Напишите программу, которая с помощью функции определяет минимальный 
                  элемент двумерного массива, а затем подсчитывает количество минимумов*/

            string s = "";
            //ввод массива
            int[,] a = new int[Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)]; //[m,n]
            for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
            {
                for (int j = 0; j < Convert.ToInt32(textBox3.Text); j++)
                {
                    try
                    {
                        a[i, j] = int.Parse(textBox1.Lines[i * Convert.ToInt32(textBox3.Text) + j]);
                        s += a[i, j] +" ";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при вводе числа " + ex.Message);
                        return;
                    }
                }
                s += "\n";
            }

            label1.Text = "" + s + f(a);
        }
    }
}
