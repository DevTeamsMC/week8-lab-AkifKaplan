namespace hangman
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            lblWord = new Label();
            lblHint = new Label();
            lblScore = new Label();
            lblWrongLetters = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            btnEndGame = new Button();
            picHangman = new PictureBox();
            btnipucu = new Button();
            questionTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picHangman).BeginInit();
            SuspendLayout();
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("Segoe UI", 18F);
            lblWord.Location = new Point(49, 45);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(110, 41);
            lblWord.TabIndex = 0;
            lblWord.Text = "_ _ _ _ _";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Font = new Font("Segoe UI", 12F);
            lblHint.Location = new Point(49, 108);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(0, 28);
            lblHint.TabIndex = 1;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 12F);
            lblScore.Location = new Point(31, 317);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(97, 28);
            lblScore.TabIndex = 2;
            lblScore.Text = "Puan: 100";
            // 
            // lblWrongLetters
            // 
            lblWrongLetters.AutoSize = true;
            lblWrongLetters.Font = new Font("Segoe UI", 12F);
            lblWrongLetters.Location = new Point(31, 355);
            lblWrongLetters.Name = "lblWrongLetters";
            lblWrongLetters.Size = new Size(128, 28);
            lblWrongLetters.TabIndex = 3;
            lblWrongLetters.Text = "Yanlış Harfler:";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(31, 415);
            txtGuess.Margin = new Padding(3, 4, 3, 4);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(164, 27);
            txtGuess.TabIndex = 4;
            txtGuess.TextChanged += txtGuess_TextChanged;
            txtGuess.KeyPress += txtGuess_KeyPress;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(210, 415);
            btnGuess.Margin = new Padding(3, 4, 3, 4);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(165, 31);
            btnGuess.TabIndex = 5;
            btnGuess.Text = "Tahmin Et";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // btnEndGame
            // 
            btnEndGame.Location = new Point(381, 415);
            btnEndGame.Margin = new Padding(3, 4, 3, 4);
            btnEndGame.Name = "btnEndGame";
            btnEndGame.Size = new Size(165, 31);
            btnEndGame.TabIndex = 6;
            btnEndGame.Text = "Oyunu Bitir";
            btnEndGame.UseVisualStyleBackColor = true;
            btnEndGame.Click += btnEndGame_Click;
            // 
            // picHangman
            // 
            picHangman.Location = new Point(457, 32);
            picHangman.Margin = new Padding(3, 4, 3, 4);
            picHangman.Name = "picHangman";
            picHangman.Size = new Size(399, 351);
            picHangman.SizeMode = PictureBoxSizeMode.StretchImage;
            picHangman.TabIndex = 7;
            picHangman.TabStop = false;
            // 
            // btnipucu
            // 
            btnipucu.Location = new Point(143, 138);
            btnipucu.Name = "btnipucu";
            btnipucu.Size = new Size(94, 29);
            btnipucu.TabIndex = 8;
            btnipucu.Text = "İpucu";
            btnipucu.UseVisualStyleBackColor = true;
            btnipucu.Click += button1_Click;
            // 
            // questionTimer
            // 
            questionTimer.Interval = 1000;
            questionTimer.Tick += questionTimer_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnipucu);
            Controls.Add(txtGuess);
            Controls.Add(btnEndGame);
            Controls.Add(btnGuess);
            Controls.Add(lblWrongLetters);
            Controls.Add(lblScore);
            Controls.Add(lblHint);
            Controls.Add(lblWord);
            Controls.Add(picHangman);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            Click += btnGuess_Click;
            ((System.ComponentModel.ISupportInitialize)picHangman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWord;
        private Label lblHint;
        private Label lblScore;
        private Label lblWrongLetters;
        private TextBox txtGuess;
        private Button btnGuess;
        private Button btnEndGame;
        private PictureBox picHangman;
        private Button btnipucu;
        private System.Windows.Forms.Timer questionTimer;
    }
}