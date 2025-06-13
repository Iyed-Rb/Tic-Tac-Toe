using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form frmVsPlayer = new Form1();
            //frmVsPlayer.ShowDialog();

            Form1 frmGame = new Form1(this); // Pass "this" (Welcome form)
            this.Hide(); // Hide Welcome
            frmGame.ShowDialog(); // Open Player vs Player mode as a modal dialog
            this.Show(); // Show Welcome again after frmGame is closed

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 frmGamePC = new Form2(this); // Pass "this" (Welcome form)
            this.Hide(); // Hide Welcome
            frmGamePC.ShowDialog(); // Open Player vs Player mode as a modal dialog
            this.Show(); // Show Welcome again after frmGame is closed
 
        }
    }
}
