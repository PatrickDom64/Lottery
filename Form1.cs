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
        class RundomNumber{

            Random randomCamp = new Random();

            int number = randomCamp.Next(0, 100);
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
           
           string textBox1 = textBox1.ToString();

           textBox4.Text = textBox1;
        }
    }
}
