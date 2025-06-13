namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TicTacToe = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.Turn = new System.Windows.Forms.Label();
            this.Winner = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.btRestartGame = new System.Windows.Forms.Button();
            this.btMenue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // TicTacToe
            // 
            this.TicTacToe.AutoSize = true;
            this.TicTacToe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacToe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TicTacToe.Location = new System.Drawing.Point(370, 18);
            this.TicTacToe.Name = "TicTacToe";
            this.TicTacToe.Size = new System.Drawing.Size(369, 43);
            this.TicTacToe.TabIndex = 0;
            this.TicTacToe.Text = "Player 1 vs Player 2";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.White;
            this.lbTurn.Location = new System.Drawing.Point(58, 183);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(143, 37);
            this.lbTurn.TabIndex = 2;
            this.lbTurn.Text = "Player 1";
            // 
            // Turn
            // 
            this.Turn.AutoSize = true;
            this.Turn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn.ForeColor = System.Drawing.Color.Yellow;
            this.Turn.Location = new System.Drawing.Point(84, 131);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(89, 37);
            this.Turn.TabIndex = 3;
            this.Turn.Text = "Turn";
            // 
            // Winner
            // 
            this.Winner.AutoSize = true;
            this.Winner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner.ForeColor = System.Drawing.Color.Yellow;
            this.Winner.Location = new System.Drawing.Point(64, 235);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(127, 37);
            this.Winner.TabIndex = 4;
            this.Winner.Text = "Winner";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Lime;
            this.lbWinner.Location = new System.Drawing.Point(33, 287);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(195, 37);
            this.lbWinner.TabIndex = 5;
            this.lbWinner.Text = "In Progress";
            // 
            // btRestartGame
            // 
            this.btRestartGame.BackColor = System.Drawing.Color.Black;
            this.btRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestartGame.Font = new System.Drawing.Font("Andalus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestartGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRestartGame.Location = new System.Drawing.Point(40, 338);
            this.btRestartGame.Name = "btRestartGame";
            this.btRestartGame.Size = new System.Drawing.Size(222, 61);
            this.btRestartGame.TabIndex = 25;
            this.btRestartGame.Text = "Restart Game";
            this.btRestartGame.UseVisualStyleBackColor = false;
            this.btRestartGame.Click += new System.EventHandler(this.btRestartGame_Click);
            // 
            // btMenue
            // 
            this.btMenue.BackColor = System.Drawing.Color.Black;
            this.btMenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenue.Font = new System.Drawing.Font("Andalus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btMenue.Location = new System.Drawing.Point(40, 405);
            this.btMenue.Name = "btMenue";
            this.btMenue.Size = new System.Drawing.Size(222, 61);
            this.btMenue.TabIndex = 26;
            this.btMenue.Text = "Menue";
            this.btMenue.UseVisualStyleBackColor = false;
            this.btMenue.Click += new System.EventHandler(this.btMenue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe.Properties.Resources.tot;
            this.pictureBox1.Location = new System.Drawing.Point(84, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb6.Location = new System.Drawing.Point(663, 226);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(84, 75);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 21;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb5
            // 
            this.pb5.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb5.Location = new System.Drawing.Point(494, 226);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(84, 75);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 17;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb4
            // 
            this.pb4.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb4.Location = new System.Drawing.Point(327, 226);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(84, 75);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 24;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb7
            // 
            this.pb7.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb7.Location = new System.Drawing.Point(327, 353);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(84, 75);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb7.TabIndex = 18;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb8
            // 
            this.pb8.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb8.Location = new System.Drawing.Point(494, 353);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(84, 75);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb8.TabIndex = 19;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb9
            // 
            this.pb9.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb9.Location = new System.Drawing.Point(663, 353);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(84, 75);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb9.TabIndex = 20;
            this.pb9.TabStop = false;
            this.pb9.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb3
            // 
            this.pb3.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb3.Location = new System.Drawing.Point(663, 103);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(84, 75);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 22;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb2
            // 
            this.pb2.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb2.Location = new System.Drawing.Point(494, 103);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(84, 75);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 23;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pb1.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.pb1.Location = new System.Drawing.Point(327, 103);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(84, 75);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 16;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(827, 474);
            this.Controls.Add(this.btMenue);
            this.Controls.Add(this.btRestartGame);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TicTacToe);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TicTacToe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label Turn;
        private System.Windows.Forms.Label Winner;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btRestartGame;
        private System.Windows.Forms.Button btMenue;
    }
}

