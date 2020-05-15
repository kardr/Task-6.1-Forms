using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6._1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(numericUpDown1.Value);
                int[] mass = new int[n];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    mass[i] = r.Next(-50, 50);
                    textBox1.Text += mass[i] + " ";
                }
                Console.WriteLine();
                for (int i = 1; i < n; i = i + 2)
                {
                    if (mass[i] > 0)
                    {
                        textBox2.Text += mass[i] + " ";
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
