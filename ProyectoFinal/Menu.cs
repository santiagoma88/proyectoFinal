using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form juego = new ventana();
            juego.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debes cambiar la gravedad para mantenerte en las plataformas\n   Presiona M para activar jugador 1 o X para activar jugador 2\n\n                               !!!Trata de llegar al final!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form juegoOri = new JuegoOriginal();
            juegoOri.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
