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
        private int tiempoSegundos = 0; // Tiempo en segundos

        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta cuando el formulario carga
        private void Form1_Load(object sender, EventArgs e)
        {
            // Puedes agregar lógica aquí si es necesario cuando el formulario se carga
        }

        // Evento para detener el cronómetro
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Detiene el Timer
            button1.Enabled = true; // Activa el botón de "Iniciar"
            button2.Enabled = false; // Desactiva el botón de "Detener"
        }

        // Evento para iniciar el cronómetro
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); // Inicia el Timer
            button1.Enabled = false; // Desactiva el botón de "Iniciar" cuando está en marcha
            button2.Enabled = true; // Activa el botón de "Detener"
        }

        // Evento que se ejecuta cada vez que el Timer se actualiza (cada segundo)
        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoSegundos++;  // Incrementa el tiempo cada segundo
            label1.Text = TimeSpan.FromSeconds(tiempoSegundos).ToString(@"hh\:mm\:ss"); // Muestra el tiempo en formato HH:MM:SS
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // Detiene el Timer
            tiempoSegundos = 0; // Reinicia el contador de tiempo
            label1.Text = "00:00:00"; // Reinicia el texto del Label
            button1.Enabled = true; // Activa el botón de "Iniciar"
            button2.Enabled = false; // Desactiva el botón de "Detener"
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
