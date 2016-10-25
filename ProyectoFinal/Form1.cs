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
        int cambio = 1;
        int direccionp1 = 1;
        int direccionp2 = 1;
        public ventana()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
        }

        //timer que controlara el movimiento
        private void timer1_Tick(object sender, EventArgs e)
        {
            cambio++;

            if (cambio == 1) 
            {
                if (direccionp1 == 1)
                {
                    player1.Image = Properties.Resources.player11;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                if (direccionp1 == 2) 
                {
                    player1.Image = Properties.Resources.player11;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                if (direccionp2 == 1)
                {
                    player2.Image = Properties.Resources.player21;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                if (direccionp2 == 2)
                {
                    player2.Image = Properties.Resources.player21;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }
            }
            if (cambio == 2)
            {
                if (direccionp1 == 1)
                {
                    player1.Image = Properties.Resources.player12;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                if (direccionp1 == 2)
                {
                    player1.Image = Properties.Resources.player12;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                if (direccionp2 == 1)
                {
                    player2.Image = Properties.Resources.player22;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                if (direccionp2 == 2)
                {
                    player2.Image = Properties.Resources.player22;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }  
            }
            if (cambio == 3)
            {
                if (direccionp1 == 1)
                {
                    player1.Image = Properties.Resources.player13;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                if (direccionp1 == 2)
                {
                    player1.Image = Properties.Resources.player13;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                if (direccionp2 == 1)
                {
                    player2.Image = Properties.Resources.player23;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                if (direccionp2 == 2)
                {
                    player2.Image = Properties.Resources.player23;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }   
            }
            if (cambio == 4)
            {
                if (direccionp1 == 1)
                {
                    player1.Image = Properties.Resources.player14;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                if (direccionp1 == 2)
                {
                    player1.Image = Properties.Resources.player14;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                if (direccionp2 == 1)
                {
                    player2.Image = Properties.Resources.player24;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                if (direccionp2 == 2)
                {
                    player2.Image = Properties.Resources.player24;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }  
            }
            if (cambio == 5)
            {
                if (direccionp1 == 1)
                {
                    player1.Image = Properties.Resources.player15;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                if (direccionp1 == 2)
                {
                    player1.Image = Properties.Resources.player15;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                if (direccionp2 == 1)
                {
                    player2.Image = Properties.Resources.player25;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                if (direccionp2 == 2)
                {
                    player2.Image = Properties.Resources.player25;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }  
            }
            if (cambio == 6)
            {
                if (direccionp1 == 1)
                {
                    player1.Image = Properties.Resources.player16;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                if (direccionp1 == 2)
                {
                    player1.Image = Properties.Resources.player16;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                if (direccionp2 == 1)
                {
                    player2.Image = Properties.Resources.player26;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                if (direccionp2 == 2)
                {
                    player2.Image = Properties.Resources.player26;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }  
            }
            if (cambio == 7)
            {
                if (direccionp1 == 1)
                {
                    player1.Image = Properties.Resources.player17;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                if (direccionp1 == 2)
                {
                    player1.Image = Properties.Resources.player17;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                if (direccionp2 == 1)
                {
                    player2.Image = Properties.Resources.player27;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                if (direccionp2 == 2)
                {
                    player2.Image = Properties.Resources.player27;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }
                cambio = 1;
            }

        }

        private void ventana_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void ventana_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
                if (direccionp1 == 1)
                {
                    direccionp1 = 2;
                }
                if (direccionp1 == 2)
                {
                    
                    direccionp1 = 1;
                }
            }
        }

        

        

        
    }
}
