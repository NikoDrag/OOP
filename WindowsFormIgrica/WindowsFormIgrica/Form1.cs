using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormIgrica
{
    public partial class Form1 : Form
    {
        private int poeni;
        private int poenidobit;
        private int shots;
        private int time;
        

        public Form1()
        {
            InitializeComponent();
            lbltank.Location = new Point(pnlPField.Width / 2, pnlPField.Height / 2);
            lblenemy.Location = new Point(RandomX(pnlEField.Width), RandomY(pnlEField.Height));
            Reset();
        }

        private void Resize(object sender, EventArgs e)
        {
            lbltank.Location = new Point(pnlPField.Width/2,pnlPField.Height/2);
            lblenemy.Location = new Point(RandomX(pnlEField.Width), RandomY(pnlEField.Height));
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (!(lbltank.Location.X - 10 < 0))
            {
                lbltank.Location = new Point(lbltank.Location.X - 10, lbltank.Location.Y);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (!(lbltank.Location.X + 40 > pnlPField.Width))
            {
                lbltank.Location = new Point(lbltank.Location.X + 10, lbltank.Location.Y);
            }
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            if (lbltank.Location.X >= lblenemy.Location.X - 10 && lbltank.Location.X <= lblenemy.Location.X + 10)
            {
                pnlEField.BackColor = Color.Crimson;
                timerWait.Start();
                lblenemy.Location = new Point(RandomX(pnlEField.Width), RandomY(pnlEField.Height));
                poeni += poenidobit;
                poenidobit = 10;
            }
            else if (poenidobit > 1)
            {
                poenidobit--;
            }
            shots++;

        }

        private int RandomX(int pov)
        {
            Random rnd = new Random();
            return rnd.Next(0, pov-40);
        }
        private int RandomY(int pov)
        {
            Random rnd = new Random();
            return rnd.Next(0, pov - 10);
        }
        

        public void Reset()
        {
            poeni = 0;
            poenidobit = 10;
            shots = 0;
            time = 0;
        }
        
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            textBoxVreme.Text = $"Vreme: {time}";
            textBoxPoeni.Text = $"Points: {poeni}";
            textBoxShots.Text = $"Shots: {shots}";
        }

        private void timerWait_Tick(object sender, EventArgs e)
        {
            pnlEField.BackColor = Color.SandyBrown;
            timerWait.Stop();
        }
        

    }
}
