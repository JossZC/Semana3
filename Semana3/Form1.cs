using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean content = true;
            int i = 35;
            string comentario = "Hello World";
            String[] myints = { "5", "10", "15" };
            string num = "";
            textBox1.Text = Convert.ToString(content);
            textBox2.Text = Convert.ToString(i);
            textBox3.Text = comentario;
            foreach ( string Numeros in myints)
            {
                num = num + Numeros + " ";   
                
            }
            MessageBox.Show(num);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
