using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;
        public Form1()
        {

            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            pb_rocket.Top = play_ground.Bottom - (play_ground.Bottom / 12);
            label3.Left = (play_ground.Width / 2) - (label3.Width / 2);
            label3.Top = (play_ground.Height / 2) - (label3.Height / 2);
            label3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_rocket.Left = (Cursor.Position.X) - (pb_rocket.Width / 2);
            Ball.Left += speed_left;
            Ball.Top += speed_top;
            if (Ball.Left <= play_ground.Left)
                speed_left = -speed_left;
            if (Ball.Right >= play_ground.Right)
                speed_left = -speed_left;
            if (Ball.Top <= play_ground.Top)
                speed_top = -speed_top;
            if (Ball.Bottom >= play_ground.Bottom)
            {
                label3.Visible = true;
                timer1.Enabled = false;
            }
            if (Ball.Bottom >= pb_rocket.Top && Ball.Top <= pb_rocket.Bottom && Ball.Left >= pb_rocket.Left && Ball.Right <= pb_rocket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                lbl_point.Text = points.ToString();

                Random r = new Random();
                play_ground.BackColor = Color.FromArgb(r.Next(150, 250), r.Next(150, 250), r.Next(150, 250));
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.R)
            {
                Ball.Top = 50;
                Ball.Left = 50;
                speed_left = 1;
                points = 0;
                timer1.Enabled = true;
                label3.Visible = false;
            }

        }
    }
}
