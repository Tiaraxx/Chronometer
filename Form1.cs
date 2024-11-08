using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cronometro
{
    public partial class Form1 : Form
    {
        private int tiempoSegundos = 0; 

        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
            button1.Enabled = true; 
            button2.Enabled = false; 
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
            button1.Enabled = false;
            button2.Enabled = true; 
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoSegundos++;  
            label1.Text = TimeSpan.FromSeconds(tiempoSegundos).ToString(@"hh\:mm\:ss"); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
            tiempoSegundos = 0; 
            label1.Text = "00:00:00";
            button1.Enabled = true; 
            button2.Enabled = false; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
