using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObjectMoving
{
    public partial class FormView : Form
    {
        bool prawo;
        bool lewo;
        bool gora;
        bool dol;

        private int _x;
        private int _y;
        
        private int HURA;


        public FormView()
        {
            InitializeComponent();

            _x = 50;
            _y = 50;
            
            HURA = 0;
            playSound("Audio.wav");
            prawo = false;
            lewo = false;
            gora = false;
            dol = false;

            //zquanghoangz@gmail.com
        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 100, 100);
            Bitmap koko = new Bitmap("Wiedźmin.png");
            Bitmap kokos = new Bitmap("wiedźmin.jpg");

            e.Graphics.DrawImage(kokos, 0, 0, 800, 600);
            e.Graphics.DrawImage(koko, _x, _y, 64, 64);

            //DrawToBitmap(koko, kokos);
            


            if (HURA == 1) e.Graphics.DrawImage(new Bitmap("Ww.jpg"), 100, 200, 200, 200);
            
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            if (prawo == true)
            {
                _x += 10;
            }
            if (lewo == true)
            {
                _x -= 10;
            }
            if (gora == true)
            {
                _y -= 10;
            }
            if (dol == true)
            {
                _y += 10;
            }

            if (_x > 200 && _y > 300) HURA = 1;

            Invalidate();
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                lewo = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                prawo = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                gora = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                dol = true;
            }

        }
        private void FormView_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                lewo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                prawo = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                gora = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                dol = false;
            }

        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }

        private void playSound(string path)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }

        private void FormView_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
