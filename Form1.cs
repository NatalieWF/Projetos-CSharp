using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void soma_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;
            int d;
            int e1; 

            int resultado;

            a = Convert.ToInt16(txt_a.Text);
            b = Convert.ToInt16(txt_b.Text);
            c = Convert.ToInt16(txt_c.Text);
            d = Convert.ToInt16(txt_d.Text);
            e1 = Convert.ToInt16(txt_e1.Text);

            resultado = a + b + c + d + e1;
            resultado = resultado / 5;

            MessageBox.Show(resultado.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
