using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Random rnd = new Random();
            /*
            string[] pole = { "h3SeL23Ir", "I73m3S21", "loL90392pop", "j>V`F6XvS)-R", "~)8>!8'Eu<dj", "YBP5Yk)gP^jC", "jCN8HTn_<mW" };
            for(int i = 0; pole[i] == (string)num; i++) { }
            */
            char[] pole = new char[10];
            pole[0] = 'a';
            pole[1] = '2';
            pole[2] = '0';
            pole[3] = '2';
            pole[4] = '2';
            pole[5] = 'n';
            pole[6] = 'e';
            pole[7] = 'w';
            pole[8] = 'e';
            pole[9] = 'a';
             
            for (int i = 0; i < 10; i++)
            {
                textBox1.Text += pole[i];

            }

            

        }
    }
}
