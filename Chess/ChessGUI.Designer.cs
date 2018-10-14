namespace Chess
{
    partial class ChessGUI
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
            this.StartGame = new System.Windows.Forms.Button();
            this.BoardImage = new System.Windows.Forms.PictureBox();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.BlackCapturedBox = new System.Windows.Forms.PictureBox();
            this.WhiteCapturedBox = new System.Windows.Forms.PictureBox();
            this.BlackCapturedLabel = new System.Windows.Forms.Label();
            this.WhiteCapturedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackCapturedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteCapturedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.Location = new System.Drawing.Point(12, 12);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(109, 33);
            this.StartGame.TabIndex = 2;
            this.StartGame.Text = "Start Game";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // BoardImage
            // 
            this.BoardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoardImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoardImage.Image = global::Chess.Properties.Resources.board;
            this.BoardImage.Location = new System.Drawing.Point(12, 98);
            this.BoardImage.Name = "BoardImage";
            this.BoardImage.Size = new System.Drawing.Size(266, 266);
            this.BoardImage.TabIndex = 8;
            this.BoardImage.TabStop = false;
            this.BoardImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoardImage_MouseClick);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.Location = new System.Drawing.Point(12, 75);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(0, 20);
            this.PlayerLabel.TabIndex = 9;
            // 
            // BlackCapturedBox
            // 
            this.BlackCapturedBox.BackColor = System.Drawing.SystemColors.Control;
            this.BlackCapturedBox.Location = new System.Drawing.Point(284, 98);
            this.BlackCapturedBox.Name = "BlackCapturedBox";
            this.BlackCapturedBox.Size = new System.Drawing.Size(266, 70);
            this.BlackCapturedBox.TabIndex = 10;
            this.BlackCapturedBox.TabStop = false;
            // 
            // WhiteCapturedBox
            // 
            this.WhiteCapturedBox.Location = new System.Drawing.Point(284, 294);
            this.WhiteCapturedBox.Name = "WhiteCapturedBox";
            this.WhiteCapturedBox.Size = new System.Drawing.Size(266, 70);
            this.WhiteCapturedBox.TabIndex = 11;
            this.WhiteCapturedBox.TabStop = false;
            // 
            // BlackCapturedLabel
            // 
            this.BlackCapturedLabel.AutoSize = true;
            this.BlackCapturedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackCapturedLabel.Location = new System.Drawing.Point(284, 171);
            this.BlackCapturedLabel.Name = "BlackCapturedLabel";
            this.BlackCapturedLabel.Size = new System.Drawing.Size(202, 20);
            this.BlackCapturedLabel.TabIndex = 12;
            this.BlackCapturedLabel.Text = "Pieces Captured by Black";
            // 
            // WhiteCapturedLabel
            // 
            this.WhiteCapturedLabel.AutoSize = true;
            this.WhiteCapturedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteCapturedLabel.Location = new System.Drawing.Point(284, 271);
            this.WhiteCapturedLabel.Name = "WhiteCapturedLabel";
            this.WhiteCapturedLabel.Size = new System.Drawing.Size(203, 20);
            this.WhiteCapturedLabel.TabIndex = 13;
            this.WhiteCapturedLabel.Text = "Pieces Captured by White";
            // 
            // ChessGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 381);
            this.Controls.Add(this.WhiteCapturedLabel);
            this.Controls.Add(this.BlackCapturedLabel);
            this.Controls.Add(this.WhiteCapturedBox);
            this.Controls.Add(this.BlackCapturedBox);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.BoardImage);
            this.Controls.Add(this.StartGame);
            this.Name = "ChessGUI";
            this.Text = "Chess";
            ((System.ComponentModel.ISupportInitialize)(this.BoardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlackCapturedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteCapturedBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.PictureBox BoardImage;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.PictureBox BlackCapturedBox;
        private System.Windows.Forms.PictureBox WhiteCapturedBox;
        private System.Windows.Forms.Label BlackCapturedLabel;
        private System.Windows.Forms.Label WhiteCapturedLabel;
    }
}

