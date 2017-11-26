using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JogoRemove
{
    
    public partial class Form1 : Form
    {

        SoundPlayer simpleSound = new SoundPlayer(@"D:\sefWav.wav");
        int jogada = 0;
        int cont = 0;


        public void reiniciar()
        {
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
            this.button5.Visible = true;
            this.button6.Visible = true;
            this.button7.Visible = true;
            this.button8.Visible = true;
            this.button9.Visible = true;
        }
        public void trocaJog()
        {
            if (label1.Text == "Jogador 1")
                label1.Text = "Jogador 2";
            else if (label1.Text == "Jogador 2")
                label1.Text = "Jogador 1";
        }
        public void desabilita1()
        {
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;
            this.button9.Enabled = false;
        }
        public void desabilita2()
        {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button8.Enabled = false;
            this.button9.Enabled = false;
        }
        public void desabilita3()
        {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;

        }

        public void habilitabtn()
        {
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            label1.Text = "Jogador 1";
            label1.Visible = true;
            this.habilitabtn();
            this.habilitabtn();
            jogada = 0;
            cont = 0;
            this.btnIniciar.Enabled = false;
            reiniciar();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //simpleSound.Stop();
            this.desabilita1();
            this.button1.Visible = false;
            cont++;
            jogada++;
            if(cont!=0)
                this.button10.Enabled = true;
            if (cont == 3)
            {
               // if (jogada == 8)
                 //   simpleSound.Play();
                this.trocaJog();
                MessageBox.Show("Passou a vez!");
                cont = 0;
                habilitabtn();
                this.button10.Enabled = false;
            }
            if (jogada == 9)
            {
                MessageBox.Show(label1.Text + " perdeu!!");
                this.btnIniciar.Text = "Reiniciar";
                this.btnIniciar.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            this.button2.Visible = false;
            this.desabilita1();
            cont++;
            jogada++;
            if (cont != 0)
                this.button10.Enabled = true;
            if (cont == 3) { 
               // if (jogada == 8)
                    //simpleSound.Play();
            
                this.trocaJog();
                MessageBox.Show("Passou a vez!");
                cont = 0;
                habilitabtn();
                this.button10.Enabled = false;
            }
            if (jogada == 9)
            {
                MessageBox.Show(label1.Text + " perdeu!!");
                this.btnIniciar.Text = "Reiniciar";
                this.btnIniciar.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            this.button3.Visible = false;
            this.desabilita1();
            cont++;
            jogada++;
            if (cont != 0)
                this.button10.Enabled = true;
            if (cont == 3)
            {
             //   if (jogada == 8)
               //     simpleSound.Play();
                this.trocaJog();
                MessageBox.Show("Passou a vez!");
                cont = 0;
                habilitabtn();
                this.button10.Enabled = false;
            }
            if (jogada == 9)
            {
                MessageBox.Show(label1.Text + " perdeu!!");
                this.btnIniciar.Text = "Reiniciar";
                this.btnIniciar.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            this.button4.Visible = false;
            this.desabilita1();
            cont++;
            jogada++;
            if (cont != 0)
                this.button10.Enabled = true;
            if (cont == 3)
            {
               // if (jogada == 8)
                 //   simpleSound.Play();
                this.trocaJog();
                MessageBox.Show("Passou a vez!");
                cont = 0;
                habilitabtn();
                this.button10.Enabled = false;
            }
            if (jogada == 9)
            {
                MessageBox.Show(label1.Text + " perdeu!!");
                this.btnIniciar.Text = "Reiniciar";
                this.btnIniciar.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            this.button5.Visible = false;
            this.desabilita2();
            cont++;
            jogada++;
            if (cont != 0)
                this.button10.Enabled = true;
            if (cont == 3)
            {
               // if (jogada == 8)
                 //   simpleSound.Play();
                this.trocaJog();
                MessageBox.Show("Passou a vez!");
                cont = 0;
                habilitabtn();
                this.button10.Enabled = false;
            }
            if (jogada == 9)
            {
                MessageBox.Show(label1.Text + " perdeu!!");
                this.btnIniciar.Text = "Reiniciar";
                this.btnIniciar.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            this.button6.Visible = false;
            this.desabilita2();
            cont++;
            jogada++;
            if (cont != 0)
                this.button10.Enabled = true;
            if (cont == 3)
            {
               // if (jogada == 8)
                 //   simpleSound.Play();
                this.trocaJog();
                MessageBox.Show("Passou a vez!");
                cont = 0;
                habilitabtn();
                this.button10.Enabled = false;
            }
            if (jogada == 9)
            {
                MessageBox.Show(label1.Text + " perdeu!!");
                this.btnIniciar.Text = "Reiniciar";
                this.btnIniciar.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            this.button7.Visible = false;
            this.desabilita2();
            cont++;
            jogada++;
            if (cont != 0)
                this.button10.Enabled = true;
            if (cont == 3)
            {
              //  if (jogada == 8)
                //    simpleSound.Play();
                this.trocaJog();
                MessageBox.Show("Passou a vez!");
                cont = 0;
                habilitabtn();
                this.button10.Enabled = false;
            }
            if (jogada == 9)
            {
                MessageBox.Show(label1.Text + " perdeu!!");
                this.btnIniciar.Text = "Reiniciar";
                this.btnIniciar.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            this.button8.Visible = false;
            this.desabilita3();
            cont++;
            jogada++;
            if (cont != 0)
                this.button10.Enabled = true;
            if (cont == 3)
            {
               // if (jogada == 8)
                 //   simpleSound.Play();
                this.trocaJog();
                MessageBox.Show("Passou a vez!");
                cont = 0;
                habilitabtn();
                this.button10.Enabled = false;
            }
            if (jogada == 9)
            {
                MessageBox.Show(label1.Text + " perdeu!!");
                this.btnIniciar.Text = "Reiniciar";
                this.btnIniciar.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            this.button9.Visible = false;
            this.desabilita3();
            cont++;
            jogada++;
            if (cont != 0)
                this.button10.Enabled = true;
            if (cont == 3)
            {
              //  if (jogada == 8)
                //    simpleSound.Play();
                this.trocaJog();
                MessageBox.Show("Passou a vez!");
                this.button10.Enabled = false;
                cont = 0;
                habilitabtn();
                this.button10.Enabled = false;
            }
            if (jogada == 9)
            {
                MessageBox.Show(label1.Text + " perdeu!!");
                this.btnIniciar.Text = "Reiniciar";
                this.btnIniciar.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //if (jogada == 8)
              //  simpleSound.Play();
            this.trocaJog();
            cont = 0;
            habilitabtn();
            this.button10.Enabled = false;
            
        }
    }
}
