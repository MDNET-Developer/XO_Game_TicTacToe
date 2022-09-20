using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Hide();
            f2.label1.Text = textBox1.Text;
            f2.label11.Text = textBox2.Text;
                  }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
