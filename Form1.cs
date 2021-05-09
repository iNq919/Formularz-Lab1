using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(text1.Text);
                float y = float.Parse(text2.Text);
                float z = float.Parse(text3.Text);
                wynik.Text = (x + y + z).ToString();
            }
            catch
            {
                MessageBox.Show("Podano bledne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                float x = float.Parse(text1.Text);
                float y = float.Parse(text2.Text);
                float z = float.Parse(text3.Text);
                wynik.Text = (x * y * z).ToString();
            }
            catch
            {
                MessageBox.Show("Podano bledne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
