using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.BackColor = Color.SandyBrown;
        }

        private void ReSize(object sender, EventArgs e)
        {
            labelplayer.Location = new Point(panelField.Width/2, panelField.Height/2);
            textBoxX.Text = $"x: {labelplayer.Location.X}";
            textBoxY.Text = $"y: {labelplayer.Location.Y}";
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if(!(labelplayer.Location.X + 50 > panelField.Size.Width))
            {
                labelplayer.Location = new Point(labelplayer.Location.X + 10, labelplayer.Location.Y);
                textBoxX.Text = $"x: {labelplayer.Location.X}";
                //int x = Convert.ToInt32(textBoxBRK);
                //x++;
                //textBoxBRK.Text = x.ToString();
            }

            else
            {
                //int y = Convert.ToInt32(textBoxBRGR);
                //y++;
                //textBoxBRGR.Text = y.ToString();
                MessageBox.Show("Van dozvoljenog opsega", "Obavestenje");
            }
        }
        
        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (!(labelplayer.Location.Y - 10 < 0))
            {
                labelplayer.Location = new Point(labelplayer.Location.X, labelplayer.Location.Y - 10);
                textBoxY.Text = $"y: {labelplayer.Location.Y}";
                //int x = Convert.ToInt32(textBoxBRK);
                //x++;
                //textBoxBRK.Text = x.ToString();
            }
            else
            {
                //int y = Convert.ToInt32(textBoxBRGR);
                //y++;
                //textBoxBRGR.Text = y.ToString();
                MessageBox.Show("Van dozvoljenog opsega", "Obavestenje");
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (!(labelplayer.Location.X - 10 < 0))
            {
                labelplayer.Location = new Point(labelplayer.Location.X - 10, labelplayer.Location.Y);
                textBoxX.Text = $"x: {labelplayer.Location.X}";
                //int x = Convert.ToInt32(textBoxBRK);
                //x++;
                //textBoxBRK.Text = x.ToString();
            }
            else
            {
                //int y = Convert.ToInt32(textBoxBRGR);
                //y++;
                //textBoxBRGR.Text = y.ToString();
                MessageBox.Show("Van dozvoljenog opsega", "Obavestenje");
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (!(labelplayer.Location.Y + 30 > panelField.Size.Height))
            {
                labelplayer.Location = new Point(labelplayer.Location.X, labelplayer.Location.Y + 10);
                textBoxY.Text = $"Y: {labelplayer.Location.Y}";
                //int x = Convert.ToInt32(textBoxBRK);
                //x++;
                //textBoxBRK.Text = x.ToString();
            }
            else
            {
                //int y = Convert.ToInt32(textBoxBRGR);
                //y++;
                //textBoxBRGR.Text = y.ToString();
                MessageBox.Show("Van dozvoljenog opsega", "Obavestenje");
            }
        }
    }
}
