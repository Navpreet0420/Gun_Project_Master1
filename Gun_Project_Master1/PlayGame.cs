using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gun_Project_Master1
{
   public class PlayGame
    {
        String[] btn = { "start_Game", "load_game", "spin_game" };
        //instance of the random class
        Random rd = new Random();
      public  int y = -1;
        int[] g = new int[2];
        int count_shoot = 0,count_Shoot_Away=0,win=0;

        //frst option to start the game 
        public void Execute_option1(Button btn) {
            y++;
            //disable  the button 
            btn.Enabled = false;
        }

        public void Execute_option2(Button btn)
        {
            y++;
            //disable  the button 
            btn.Enabled = false;
        }

        public void Execute_option3(Button btn)
        {
            g[0] = rd.Next(1, 6);
            g[1] = rd.Next(1, 4);
            y++;
            //disable  the button 
            btn.Enabled = false;
        }

        public void Execute_option4(Button btn,Label lbl)
        {
            count_shoot++;
            //genreate the sound of the bullet 
            System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(Gun_Project_Master1.Properties.Resources.shootGun);
            Sound.Play();

            if (count_shoot==g[0]) {
                lbl.Text = "You are die and loss the game ";
                btn.Enabled = false;
                MessageBox.Show("You are die");
            }
            else if (count_shoot==4) {
                lbl.Text = "You are winner of the game and got full points ";
                btn.Enabled = false;
                MessageBox.Show("Bullets finish");
            }
            y++;
            //disable  the button 
            
        }

        public void Execute_option5(Button btn, Label lbl)
        {
            count_Shoot_Away++;
            //genreate the sound of the bullet 
            System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(Gun_Project_Master1.Properties.Resources.shootGun);
            Sound.Play();

            if (count_Shoot_Away== g[1])
            {
                lbl.Text = "You are die and loss the game ";
                btn.Enabled = false;
                MessageBox.Show("You are die");
            }
            else if (count_shoot == 2)
            {
                lbl.Text = "You are winner of the game and got full points ";
                btn.Enabled = false;
                MessageBox.Show("Chances are finish");
            }
            y++;
            //disable  the button 

        }



    }
}
