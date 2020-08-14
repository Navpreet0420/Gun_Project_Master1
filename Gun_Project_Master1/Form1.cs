using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun_Project_Master1
{
    public partial class shoot_start : Form
    {
        //instance of the play game class to execute the option 
        PlayGame playGame = new PlayGame();

        public shoot_start()
        {
            InitializeComponent();
            load_game.Enabled = false;
            spin_game.Enabled = false;
            shoot_btn.Enabled = false;
            shoot_away_btn.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void start_Game_Click(object sender, EventArgs e)
        {
            playGame.Execute_option1(start_Game);
            MessgChamber.Text = "CLick on the Load button to Load the game ";
            //enable the enxt button
            load_game.Enabled = true;
        }

        private void load_game_Click(object sender, EventArgs e)
        {
            playGame.Execute_option2(load_game);
            MessgChamber.Text = "CLick on the spin button to revolve the chamber ";
            //enable the enxt button
            spin_game.Enabled = true;
        }

        private void spin_game_Click(object sender, EventArgs e)
        {

            playGame.Execute_option3(spin_game);
            MessgChamber.Text = "Click on the shoot button to shoot  ";
            //enable the enxt button
            shoot_btn.Enabled = true;
            shoot_away_btn.Enabled = true;
            //change the photo 
            chamber.Image = Gun_Project_Master1.Properties.Resources.shoot;

        }

        private void shoot_btn_Click(object sender, EventArgs e)
        {
            //pass the button and label for message setting 
            playGame.Execute_option4(shoot_btn,MessgChamber);
        }

        private void shoot_away_btn_Click(object sender, EventArgs e)
        {
            MessgChamber.Text = "fire again";
            //pass the button and label for message setting 
            playGame.Execute_option4(shoot_away_btn, MessgChamber);
            start_Game.Enabled = true;
        }
    }
}
