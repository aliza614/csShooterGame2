using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csShooterGame2
{
    public partial class UserControl1: UserControl
    {
        bool isRight, isLeft, isShooting;
        string facing = "up";
        int health = 100;
        int points = 0;
        int speed = 20;
        int ammo = 20;
        int bulletSpeed = 30;
        int blockSpeed = 10;
        int score = 0;
        bool isGameOver=false
        const double MAX_HEIGHT=800D, MIN_HEIGHT=600D;
        public UserControl1()
        {
            InitializeComponent();
        }
        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            //if game is over do nothing
            if (isGameOver) return;
            //if key==h
            if (e.KeyCode == Keys.H)
                //player.x-=speed
                player.X -= speed;
                //player is going left


            //if key==;
                //player.x+=speed
            //if key=j
                //player.angle="left"
                //player.image=playerleft
            //if key=k
                //player.angle="up"
                //player.image=playerUp
            //if key=l
                //player.angle="right"
                //player.image=playerRight
            //if key==spacebar
                //player.shoot(form)
            //if key=m
                //timer pause
            //if key ==n
                //timer.start
        }
        public void OnKeyUp(object sender, KeyEventArgs e)
        {

        }
        public void GameEngine(EventArgs e) 
        {
            //check if still have life
                //update progressbar
            //else 
                //image=image player dead
                //timer.Stop()
                
            //for each object a in program
                //if it's a block or a hitblock and a picturebox and it intersects with the bounds of player
                    //health--;
                //if it's a picturebox and a coin and it intersects with the bounds of player
                    //points++;
                    
                
                //if it's a picturebox and ammo and it intersects with the bounds of player
                    //ammo+=5;
                    //ammo.remove from project
                    //ammo.delete
                //for each object b in program
                    //if a is a PictureBox and a bullet
                        //if b is a PictureBox and a block
                            //change tag to hitblock, change image to hit block
                            //remove a from program list
                            //delete a
                        //else if b is a PictureBox and a hitblock
                            //remove a and b from program list
                            //delete a and b

        }
    }
}
