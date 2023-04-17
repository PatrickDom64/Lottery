using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            // Criar uma instância da classe Random
            Random random = new Random();

            // Gerar um número aleatório entre 1 e 100 (inclusive)
            int numRandom_1 = random.Next(1, 1000);
            int numRandom_2 = random.Next(1, 1000);
            int numRandom_3 = random.Next(1, 1000);

            if (numRandom_1 == int.Parse(textBox1.Text) &&
                numRandom_2 == int.Parse(textBox2.Text) &&
                numRandom_3 == int.Parse(textBox3.Text)
                )
            {
                MessageBox.Show("congratulations you are very lucky");
            }
            else
            {
                MessageBox.Show("Sorry, Try again.");
            }
        }
    }
}
