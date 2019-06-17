using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolbox
{
    public partial class Mainframe : Form
    {
        public Mainframe()
        {
            InitializeComponent();
        }

        private void Mainframe_Load(object sender, EventArgs e)
        {

        }

        private void btnTool1_Click(object sender, EventArgs e)
        {
            Form FileE = new FileExplorer.Form1();
            FileE.Show();
        }

        private void btnTool2_Click(object sender, EventArgs e)
        {
            Form Calc = new Calculator.Form1();
            Calc.Show();
        }

        private void btnTool3_Click(object sender, EventArgs e)
        {

        }

        private void btnTool4_Click(object sender, EventArgs e)
        {

        }

        private void btnTool5_Click(object sender, EventArgs e)
        {

        }

        private void btnTool6_Click(object sender, EventArgs e)
        {

        }

        private void btnTool7_Click(object sender, EventArgs e)
        {

        }

        private void btnTool8_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private bool mouseDown;
        private Point lastLocation;

        private void toolBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void toolBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void toolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }

        }
    }
}
