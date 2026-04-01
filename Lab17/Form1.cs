using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab17_array;

namespace Lab17_array
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
                int[] arr1 = ParseArray(textBox1.Text);
                int[] arr2 = ParseArray(textBox2.Text);

                Sortarray a1 = new Sortarray(arr1);
                Sortarray a2 = new Sortarray(arr2);

                Array result = a1.Add(a2);
                result.Process();

                textBox3.Text = result.Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr1 = ParseArray(textBox1.Text);
                int[] arr2 = ParseArray(textBox2.Text);

                Xorarray a1 = new Xorarray(arr1);
                Xorarray a2 = new Xorarray(arr2);

                Array result = a1.Add(a2);
                result.Process();

                textBox3.Text = result.Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int[] ParseArray(string input)
        {
            return input.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
