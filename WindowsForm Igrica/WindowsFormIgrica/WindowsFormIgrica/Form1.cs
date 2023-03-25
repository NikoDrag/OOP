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
        public Form1()
        {
            InitializeComponent();
            lbltank.Location = new Point(pnlPField.Width / 2, pnlPField.Height / 2);
        }

        private void Resize(object sender, EventArgs e)
        {
            lbltank.Location = new Point(pnlPField.Width/2,pnlPField.Height/2);
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

        }

    }
}
