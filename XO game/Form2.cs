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
    public partial class Form2 : Form
    {
        string oyuncu = "X";
        int proses = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Label qrafa = (Label)sender;
            qrafa.Text = oyuncu;

            qrafa.Enabled = false;

            if (oyuncu == "X")
            {
              
                oyuncu = "O";
   

            }
            else
            {
                
                oyuncu = "X";
              
            }


            if(label2.Text + label3.Text + label5.Text == "XXX" ||
               label8.Text + label6.Text + label9.Text == "XXX" ||
               label7.Text + label4.Text + label10.Text == "XXX"||
               label2.Text + label8.Text + label7.Text == "XXX" ||
               label3.Text + label6.Text + label4.Text == "XXX" ||
               label5.Text + label9.Text + label10.Text == "XXX"||
               label2.Text + label6.Text + label10.Text == "XXX"||
               label7.Text + label6.Text + label5.Text == "XXX")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                
                
            }



            if (label2.Text + label3.Text + label5.Text == "OOO" ||
               label8.Text + label6.Text + label9.Text == "OOO"  ||
               label7.Text + label4.Text + label10.Text == "OOO" ||
               label2.Text + label8.Text + label7.Text == "OOO"  ||
               label3.Text + label6.Text + label4.Text == "OOO"  ||
               label5.Text + label9.Text + label10.Text == "OOO" ||
               label2.Text + label6.Text + label10.Text == "OOO" ||
               label7.Text + label6.Text + label5.Text == "OOO")
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }
            proses++;
            if (proses == 9)
            {
                MessageBox.Show("Bərabərə Qaldız !!!");
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
