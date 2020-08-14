namespace Gun_Project_Master1
{
    partial class shoot_start
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
            this.start_Game = new System.Windows.Forms.Button();
            this.load_game = new System.Windows.Forms.Button();
            this.spin_game = new System.Windows.Forms.Button();
            this.shoot_btn = new System.Windows.Forms.Button();
            this.shoot_away_btn = new System.Windows.Forms.Button();
            this.chamber = new System.Windows.Forms.PictureBox();
            this.MessgChamber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chamber)).BeginInit();
            this.SuspendLayout();
            // 
            // start_Game
            // 
            this.start_Game.BackColor = System.Drawing.Color.Black;
            this.start_Game.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_Game.ForeColor = System.Drawing.Color.Yellow;
            this.start_Game.Location = new System.Drawing.Point(12, 394);
            this.start_Game.Name = "start_Game";
            this.start_Game.Size = new System.Drawing.Size(215, 63);
            this.start_Game.TabIndex = 0;
            this.start_Game.Text = "Shoot Start";
            this.start_Game.UseVisualStyleBackColor = false;
            this.start_Game.Click += new System.EventHandler(this.start_Game_Click);
            // 
            // load_game
            // 
            this.load_game.BackColor = System.Drawing.Color.Black;
            this.load_game.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_game.ForeColor = System.Drawing.Color.Yellow;
            this.load_game.Location = new System.Drawing.Point(233, 394);
            this.load_game.Name = "load_game";
            this.load_game.Size = new System.Drawing.Size(215, 63);
            this.load_game.TabIndex = 1;
            this.load_game.Text = "Load Game";
            this.load_game.UseVisualStyleBackColor = false;
            this.load_game.Click += new System.EventHandler(this.load_game_Click);
            // 
            // spin_game
            // 
            this.spin_game.BackColor = System.Drawing.Color.Black;
            this.spin_game.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_game.ForeColor = System.Drawing.Color.Yellow;
            this.spin_game.Location = new System.Drawing.Point(454, 394);
            this.spin_game.Name = "spin_game";
            this.spin_game.Size = new System.Drawing.Size(215, 63);
            this.spin_game.TabIndex = 2;
            this.spin_game.Text = "Spin Game";
            this.spin_game.UseVisualStyleBackColor = false;
            this.spin_game.Click += new System.EventHandler(this.spin_game_Click);
            // 
            // shoot_btn
            // 
            this.shoot_btn.BackColor = System.Drawing.Color.Black;
            this.shoot_btn.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_btn.ForeColor = System.Drawing.Color.Yellow;
            this.shoot_btn.Location = new System.Drawing.Point(675, 394);
            this.shoot_btn.Name = "shoot_btn";
            this.shoot_btn.Size = new System.Drawing.Size(215, 63);
            this.shoot_btn.TabIndex = 3;
            this.shoot_btn.Text = "Shoot ";
            this.shoot_btn.UseVisualStyleBackColor = false;
            this.shoot_btn.Click += new System.EventHandler(this.shoot_btn_Click);
            // 
            // shoot_away_btn
            // 
            this.shoot_away_btn.BackColor = System.Drawing.Color.Black;
            this.shoot_away_btn.Font = new System.Drawing.Font("Castellar", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_away_btn.ForeColor = System.Drawing.Color.Yellow;
            this.shoot_away_btn.Location = new System.Drawing.Point(896, 394);
            this.shoot_away_btn.Name = "shoot_away_btn";
            this.shoot_away_btn.Size = new System.Drawing.Size(215, 63);
            this.shoot_away_btn.TabIndex = 4;
            this.shoot_away_btn.Text = "Shoot Away";
            this.shoot_away_btn.UseVisualStyleBackColor = false;
            this.shoot_away_btn.Click += new System.EventHandler(this.shoot_away_btn_Click);
            // 
            // chamber
            // 
            this.chamber.Image = global::Gun_Project_Master1.Properties.Resources.shoot;
            this.chamber.Location = new System.Drawing.Point(233, 97);
            this.chamber.Name = "chamber";
            this.chamber.Size = new System.Drawing.Size(721, 243);
            this.chamber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chamber.TabIndex = 5;
            this.chamber.TabStop = false;
            this.chamber.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MessgChamber
            // 
            this.MessgChamber.AutoSize = true;
            this.MessgChamber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessgChamber.Location = new System.Drawing.Point(449, 353);
            this.MessgChamber.Name = "MessgChamber";
            this.MessgChamber.Size = new System.Drawing.Size(349, 25);
            this.MessgChamber.TabIndex = 6;
            this.MessgChamber.Text = "Game messages to be appear here";
            // 
            // shoot_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gun_Project_Master1.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 469);
            this.Controls.Add(this.MessgChamber);
            this.Controls.Add(this.chamber);
            this.Controls.Add(this.shoot_away_btn);
            this.Controls.Add(this.shoot_btn);
            this.Controls.Add(this.spin_game);
            this.Controls.Add(this.load_game);
            this.Controls.Add(this.start_Game);
            this.Name = "shoot_start";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chamber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button shoot_away_btn;
        private System.Windows.Forms.PictureBox chamber;
        private System.Windows.Forms.Label MessgChamber;
        public System.Windows.Forms.Button start_Game;
        public System.Windows.Forms.Button load_game;
        public System.Windows.Forms.Button spin_game;
        public System.Windows.Forms.Button shoot_btn;
    }
}

