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
    public partial class ventana : Form
    {
        int contadorMovimiento = 1;
        public ventana()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int cantidadMovimiento = 5;
            if(contadorMovimiento <= cantidadMovimiento)
            {
                player1.Image = Properties.Resources.player12;
                contadorMovimiento++;
            }
            if ((contadorMovimiento > cantidadMovimiento / 2) && (contadorMovimiento <= cantidadMovimiento * 2)) 
            {
                player1.Image = Properties.Resources.player11;
                contadorMovimiento++;
            }

            contadorMovimiento = (contadorMovimiento > cantidadMovimiento *2 ) ? 0 : contadorMovimiento;
        }
    }
}
