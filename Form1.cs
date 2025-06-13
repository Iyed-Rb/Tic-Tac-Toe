using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private Welcome welcomeForm;
        public Form1(Welcome welcome)
        {
            InitializeComponent();
            this.welcomeForm = welcome;
        }

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

        void Reset(PictureBox pb)
        {
            pb.Image = Resources.question_mark_96;
            pb.Tag = "?";
            pb.BackColor = Color.Black;
        }
        void SetDefault()
        {
            Reset(pb1);
            Reset(pb2);
            Reset(pb3);
            Reset(pb4);
            Reset(pb5);
            Reset(pb6);
            Reset(pb7);
            Reset(pb8);
            Reset(pb9);

            PlayerTurn = enPlayer.Player1;
            lbTurn.Text = "Player 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lbWinner.Text = "In Progress";

        }
        private void btRestartGame_Click(object sender, EventArgs e)
        {
            SetDefault();
            EnableAllpb();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefault();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255);

            Pen Pen = new Pen(White);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 630, 450, 630, 90);
            e.Graphics.DrawLine(Pen, 450, 450, 450, 90);

            e.Graphics.DrawLine(Pen, 300, 200, 780, 200);
            e.Graphics.DrawLine(Pen, 300, 330, 780, 330);
        }

        void DisableAllpb()
        {
            pb1.Enabled = false;
            pb2.Enabled = false;
            pb3.Enabled = false;
            pb4.Enabled = false;
            pb5.Enabled = false;
            pb6.Enabled = false;
            pb7.Enabled = false;
            pb8.Enabled = false;
            pb9.Enabled = false;
        }
        void EnableAllpb()
        {
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            pb7.Enabled = true;
            pb8.Enabled = true;
            pb9.Enabled = true;
        }


        private void Update(PictureBox pb)
        {
            if (pb.Tag.ToString() == "?")
            { 

                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        pb.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lbTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        pb.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        pb.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lbTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        pb.Tag = "O";
                        CheckWinner();
                        break;
                }

            }

            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void pb_Click(object sender, EventArgs e)
        { 
            Update( (PictureBox) sender); 
        }
  

        public bool CheckValues(PictureBox pbA, PictureBox pbB, PictureBox pbC)
        {
            
            
            if (pbA.Tag.ToString() != "?" && pbA.Tag.ToString() == pbB.Tag.ToString() && pbA.Tag.ToString() == pbC.Tag.ToString())
            {
       
                pbA.BackColor = pbB.BackColor = pbC.BackColor = Color.YellowGreen;

                if (pbA.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
               
            }
            
            return false;
        }

        void EndGame()
        {

            lbTurn.Text = "Game Over";
            DisableAllpb();
            switch (GameStatus.Winner)
            {

                case enWinner.Player1:

                    lbWinner.Text = "   Player1";
                    break;

                case enWinner.Player2:

                    lbWinner.Text = "   Player2";
                    break;

                default:

                    lbWinner.Text = "     Draw";
                    break;

            }
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);

        }

        void CheckWinner()
        {
            if (CheckValues(pb1, pb2, pb3)) return;
            if (CheckValues(pb4, pb5, pb6)) return;
            if (CheckValues(pb7, pb8, pb9)) return;

            if (CheckValues(pb1, pb5, pb9)) return;
            if (CheckValues(pb3, pb5, pb7)) return;

            if (CheckValues(pb1, pb4, pb7)) return;
            if (CheckValues(pb2, pb5, pb8)) return;
            if (CheckValues(pb3, pb6, pb9)) return;

            if (GameStatus.PlayCount == 9 && !GameStatus.GameOver)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        private void btMenue_Click(object sender, EventArgs e)
        {
            welcomeForm.Show();
            this.Close();
        }
    }
}


