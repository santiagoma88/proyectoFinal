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
        int direccionp1 = 1; // DIRECCION 2 PARA IR HACIA ARRIBA Y DIRECCION 1 PARA IR HACIA ABAJO
        int direccionp2 = 1; // DIRECCION 2 PARA IR HACIA ARRIBA Y DIRECCION 1 PARA IR HACIA ABAJO
        int cambio = 1;
        Rectangle r1, r2;
        bool puedeCambiar1 = false;
        bool puedeCambiar2 = false;
        PictureBox ganaste;
        
        
        Random generador = new Random();
        PictureBox[] barreras = new PictureBox[100];
        
        public ventana()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
            ganaste = new PictureBox();
            
            ganaste.Location = new Point(49500, 0);
            ganaste.Size = new Size(1200, 700);
            ganaste.Image = Properties.Resources.Ganaste;
            ganaste.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(ganaste);
            

            int numero,numero2;
            int aleatorio,aleatorio2;
            for (int i = 0; i < barreras.Length;i += 2 )
            {
                barreras[i] = new PictureBox();
                barreras[i + 1] = new PictureBox();
                aleatorio = (generador.Next(0, 200));
                aleatorio2 = (generador.Next(0, 200));

                if (aleatorio > 100)
                {
                    numero = (aleatorio * (-1)) + 100;
                }
                else {
                    numero = aleatorio;
                }

                if (aleatorio2 > 100)
                {
                    numero2 = (aleatorio2 * (-1)) + 100;
                }
                else
                {
                    numero2 = aleatorio2;
                }
                

                if (i == 0)
                {
                    barreras[i].Location = new Point(0, 270);
                    barreras[i].Size = new Size(2000, 50);
                    barreras[i + 1].Location = new Point(0, 425);
                    barreras[i + 1].Size = new Size(2000, 50);
                }
                else if (i == 2)
                {
                    barreras[i].Location = new Point(2200, 15);
                    barreras[i].Size = new Size(800, 50);
                    barreras[i + 1].Location = new Point(2200, 600);
                    barreras[i + 1].Size = new Size(800, 50);
                }
                else if ((i%3) ==2 )
                {

                    barreras[i].Location = new Point(barreras[i - 2].Location.X + barreras[i - 2].Size.Width + 150 , 220+numero);
                    barreras[i].Size = new Size(800, 50);
                    barreras[i + 1].Location = new Point((barreras[i - 1].Location.X + barreras[i - 1].Size.Width + 150), 430+numero2);
                    barreras[i + 1].Size = new Size(800, 50);
                
                }
                else if (i<barreras.Length)
                {
                    barreras[i].Location = new Point(barreras[i - 2].Location.X + barreras[i - 2].Size.Width + 150, 100 + numero);
                    barreras[i].Size = new Size(800, 50);
                    barreras[i + 1].Location = new Point(barreras[i - 1].Location.X + barreras[i - 1].Size.Width + 150, 500 + numero2);
                    barreras[i + 1].Size = new Size(800, 50);
                
                }
                barreras[i].Image = Properties.Resources.barrera;
                barreras[i].SizeMode = PictureBoxSizeMode.StretchImage;
                barreras[i + 1].Image = Properties.Resources.barrera;                
                barreras[i + 1].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(barreras[i]);
                this.Controls.Add(barreras[i + 1]);
            }                         

        }




        private void ventana_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar == 'm' || e.KeyChar == 'M') && puedeCambiar1 == true)  
            {
                if (direccionp1 == 1) {
                    direccionp1 = 2;
                }
                else
                {
                    direccionp1 = 1;
                }
            }
            if ((e.KeyChar == 'X' || e.KeyChar == 'x')&& puedeCambiar2 == true)
            {
                if (direccionp2 == 1)
                {
                    direccionp2 = 2;
                }
                else
                {
                    direccionp2 = 1;
                }
            }
        } 

        private void ventana_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.KeyPreview = true;
        }

        //timer que controlara el movimiento del player 1
        private void timer1_Tick(object sender, EventArgs e)
        {
            cambio++;
            if (cambio == 1) 
            {
                if (direccionp1 == 1 && colicionP1() == 1)
                {
                    player1.Image = Properties.Resources.player11;
                }
                else if (direccionp1 == 2 && colicionP1() == 2) 
                {
                    player1.Image = Properties.Resources.player11;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                else if(direccionp1 == 2 && colicionP1() == 3)
                {
                    player1.Image = Properties.Resources.player11;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                else if(direccionp1 == 1 && colicionP1() == 4)
                {
                    player1.Image = Properties.Resources.player11;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                else if (direccionp1 == 1 && colicionP1() == 5) 
                {
                    player1.Image = Properties.Resources.player11;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                    puedeCambiar1 = false;
                }
                else if(direccionp1 == 2 && colicionP1() == 5)
                {
                    player1.Image = Properties.Resources.player11;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                    puedeCambiar1 = false;
                }
            }
            if (cambio == 2)
            {
                if (direccionp1 == 1 && colicionP1() == 1)
                {
                    player1.Image = Properties.Resources.player12;
                }
                else if (direccionp1 == 2 && colicionP1() == 2)
                {
                    player1.Image = Properties.Resources.player12;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                else if (direccionp1 == 2 && colicionP1() == 3)
                {
                    player1.Image = Properties.Resources.player12;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                else if (direccionp1 == 1 && colicionP1() == 4)
                {
                    player1.Image = Properties.Resources.player12;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                else if (direccionp1 == 1 && colicionP1() == 5)
                {
                    player1.Image = Properties.Resources.player12;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                    puedeCambiar1 = false;
                }
                else if (direccionp1 == 2 && colicionP1() == 5)
                {
                    player1.Image = Properties.Resources.player12;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                    puedeCambiar1 = false;
                }
            }
            if (cambio == 3)
            {
                if (direccionp1 == 1 && colicionP1() == 1)
                {
                    player1.Image = Properties.Resources.player13;
                }
                else if (direccionp1 == 2 && colicionP1() == 2)
                {
                    player1.Image = Properties.Resources.player13;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                else if (direccionp1 == 2 && colicionP1() == 3)
                {
                    player1.Image = Properties.Resources.player13;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                else if (direccionp1 == 1 && colicionP1() == 4)
                {
                    player1.Image = Properties.Resources.player13;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                else if (direccionp1 == 1 && colicionP1() == 5)
                {
                    player1.Image = Properties.Resources.player13;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                    puedeCambiar1 = false;
                }
                else if (direccionp1 == 2 && colicionP1() == 5)
                {
                    player1.Image = Properties.Resources.player13;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                    puedeCambiar1 = false;
                }
                
            }
            if (cambio == 4)
            {
                if (direccionp1 == 1 && colicionP1() == 1)
                {
                    player1.Image = Properties.Resources.player14;
                }
                else if (direccionp1 == 2 && colicionP1() == 2)
                {
                    player1.Image = Properties.Resources.player14;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                }
                else if (direccionp1 == 2 && colicionP1() == 3)
                {
                    player1.Image = Properties.Resources.player14;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                else if (direccionp1 == 1 && colicionP1() == 4)
                {
                    player1.Image = Properties.Resources.player14;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                }
                else if (direccionp1 == 1 && colicionP1() == 5)
                {
                    player1.Image = Properties.Resources.player14;
                    player1.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                    puedeCambiar1 = false;
                }
                else if (direccionp1 == 2 && colicionP1() == 5)
                {
                    player1.Image = Properties.Resources.player14;
                    player1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player1.Location = new Point(player1.Location.X, player1.Location.Y - 5);
                    puedeCambiar1 = false;
                }
                cambio = 1;
            }
            label1.Location = new Point(player1.Location.X+player1.Size.Width+2,(player1.Location.Y+player1.Size.Height/2));
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            cambio++;
            if (cambio == 1)
            {
                if (direccionp2 == 1 && colicionP2() == 1)
                {
                    player2.Image = Properties.Resources.player21;
                }
                else if (direccionp2 == 2 && colicionP2() == 2)
                {
                    player2.Image = Properties.Resources.player21;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }
                else if (direccionp2 == 2 && colicionP2() == 3)
                {
                    player2.Image = Properties.Resources.player21;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                else if (direccionp2 == 1 && colicionP2() == 4)
                {
                    player2.Image = Properties.Resources.player21;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                else if (direccionp2 == 1 && colicionP2() == 5)
                {
                    player2.Image = Properties.Resources.player21;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                    puedeCambiar2 = false;
                }
                else if (direccionp2 == 2 && colicionP2() == 5)
                {
                    player2.Image = Properties.Resources.player21;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                    puedeCambiar2 = false;
                }
            }
            if (cambio == 2)
            {
                if (direccionp2 == 1 && colicionP2() == 1)
                {
                    player2.Image = Properties.Resources.player22;
                }
                else if (direccionp2 == 2 && colicionP2() == 2)
                {
                    player2.Image = Properties.Resources.player22;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }
                else if (direccionp2 == 2 && colicionP2() == 3)
                {
                    player2.Image = Properties.Resources.player22;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                else if (direccionp2 == 1 && colicionP2() == 4)
                {
                    player2.Image = Properties.Resources.player22;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                else if (direccionp2 == 1 && colicionP2() == 5)
                {
                    player2.Image = Properties.Resources.player22;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                    puedeCambiar2 = false;
                }
                else if (direccionp2 == 2 && colicionP2() == 5)
                {
                    player2.Image = Properties.Resources.player22;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                    puedeCambiar2 = false;
                }
            }
            if (cambio == 3)
            {
                if (direccionp2 == 1 && colicionP2() == 1)
                {
                    player2.Image = Properties.Resources.player23;
                }
                else if (direccionp2 == 2 && colicionP2() == 2)
                {
                    player2.Image = Properties.Resources.player23;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }
                else if (direccionp2 == 2 && colicionP2() == 3)
                {
                    player2.Image = Properties.Resources.player23;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                else if (direccionp2 == 1 && colicionP2() == 4)
                {
                    player2.Image = Properties.Resources.player23;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                else if (direccionp2 == 1 && colicionP2() == 5)
                {
                    player2.Image = Properties.Resources.player23;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                    puedeCambiar2 = false;
                }
                else if (direccionp2 == 2 && colicionP2() == 5)
                {
                    player2.Image = Properties.Resources.player23;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                    puedeCambiar2 = false;
                }
            }
            if (cambio == 4)
            {
                if (direccionp2 == 1 && colicionP2() == 1)
                {
                    player2.Image = Properties.Resources.player24;
                }
                else if (direccionp2 == 2 && colicionP2() == 2)
                {
                    player2.Image = Properties.Resources.player24;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                }
                else if (direccionp2 == 2 && colicionP2() == 3)
                {
                    player2.Image = Properties.Resources.player24;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                else if (direccionp2 == 1 && colicionP2() == 4)
                {
                    player2.Image = Properties.Resources.player24;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                }
                else if (direccionp2 == 1 && colicionP2() == 5)
                {
                    player2.Image = Properties.Resources.player24;
                    player2.Location = new Point(player2.Location.X, player2.Location.Y + 5);
                    puedeCambiar2 = false;
                }
                else if (direccionp2 == 2 && colicionP2() == 5)
                {
                    player2.Image = Properties.Resources.player24;
                    player2.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    player2.Location = new Point(player2.Location.X, player2.Location.Y - 5);
                    puedeCambiar2 = false;
                }
                cambio = 1;
            }
            label2.Location = new Point(player2.Location.X + player2.Size.Width + 2, (player2.Location.Y + player2.Size.Height / 2));
        }
            

        public int colicionP1() 
        {
            r1 = new Rectangle();
            r2 = new Rectangle();
            r1.Location = new Point(player1.Location.X, player1.Location.Y - 7);
            r1.Size = new Size(player1.Size.Width, player1.Size.Height+14);

            foreach (PictureBox barrera in barreras)
            {
                r2.Location = barrera.Location;
                r2.Size = barrera.Size;

                if (r1.IntersectsWith(r2) && r1.Location.Y < r2.Location.Y) 
                {
                    if (direccionp1 == 1) 
                    {
                        puedeCambiar1 = true;
                        return 1;
                    }
                    else if(direccionp1 == 2 && puedeCambiar1 == true)
                    {
                        puedeCambiar1 = false;
                        return 2;
                    }
                }
                else if (r1.IntersectsWith(r2) && r1.Location.Y > r2.Location.Y) 
                {
                    if (direccionp1 == 2) 
                    {
                        puedeCambiar1 = true;
                        return 3;
                    }
                    else if (direccionp1 == 1 && puedeCambiar1 == true) 
                    {
                        puedeCambiar1 = false;
                        return 4;
                    }
                }
            }
            return 5;
            
            
        }

        public int colicionP2()
        {
            r1 = new Rectangle();
            r2 = new Rectangle();
            r1.Location = new Point(player2.Location.X, player2.Location.Y - 7);
            r1.Size = new Size(player2.Size.Width, player2.Size.Height + 14);

            foreach (PictureBox barrera in barreras)
            {
                r2.Location = barrera.Location;
                r2.Size = barrera.Size;

                if (r1.IntersectsWith(r2) && r1.Location.Y < r2.Location.Y)
                {
                    if (direccionp2 == 1)
                    {
                        puedeCambiar2 = true;
                        return 1;
                    }
                    else if (direccionp2 == 2 && puedeCambiar2 == true)
                    {
                        puedeCambiar2 = false;
                        return 2;
                    }
                }
                else if (r1.IntersectsWith(r2) && r1.Location.Y > r2.Location.Y)
                {
                    if (direccionp2 == 2)
                    {
                        puedeCambiar2 = true;
                        return 3;
                    }
                    else if (direccionp2 == 1 && puedeCambiar2 == true)
                    {
                        puedeCambiar2 = false;
                        return 4;
                    }
                }
            }
            return 5;


        }




        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach(PictureBox barrera in barreras)
            {
                barrera.Location = new Point(barrera.Location.X - 10, barrera.Location.Y);
            }
            ganaste.Location = new Point(ganaste.Location.X - 10, ganaste.Location.Y);
            if ((player1.Location.Y < -60 || player1.Location.Y > 700) && (player2.Location.Y< -60 || player2.Location.Y>700)) 
            {
                perder();
            }
            if (ganaste.Location.X < 0)
            {
                ganar();
            }
            
        }

        public void perder() 
        {
            timer2.Stop();
            MessageBox.Show("lo siento han perdido, intentalo nuevamente");
            this.Close();
        }

        public void ganar()
        {
            timer2.Stop();
            MessageBox.Show("Felicitaciones has Ganado.");
            this.Close();
        }    
    }
}