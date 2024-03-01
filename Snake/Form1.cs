using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Snake
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        Snake mySnake;
        Board mainBoard;
        Rewards apples;

        string mode;
        Timer clock;
        int duration; //How long the game has been running
        int speed = 500; //500ms
        int score;
        int level;

        public Form1()
        {
            InitializeComponent();
            player.URL = "level.mp3";

            //You don't have to worry about the auto-size
            this.AutoSize = true;       //The size of the Form will autoadjust.
            boardPanel.AutoSize = true; //The size of the panel grouping all the squares will auto-adjust

            //Set up the main board
            mainBoard = new Board(this);

            //Set up the game timer at the given speed
            clock = new Timer();
            clock.Interval = speed; //Set the clock to tick every 500ms
            clock.Tick += new EventHandler(refresh); //Call the refresh method at every tick to redraw the board and snake.

            duration = 0;
            score = 0;
            level = 1;
            modeLBL.Text = mode;

            gotoNextLevel(level);

        }

        private void gotoNextLevel(int nextLevel)
        {

            mode = modeLBL.Text;

            if (nextLevel > 1)
            {
               if (clock.Interval >= 100)
                {
                    clock.Interval -= 50;
                }
            }

            if (nextLevel == 1)
            {
                mySnake = new Snake(mainBoard); //Brand new snake with length 1
            }
            if (nextLevel < 5)
            {
                apples = new Rewards(nextLevel, mainBoard); //<--- Generate based on level apples
            }
            else if (nextLevel < 10)
            {
                apples = new Rewards(7, mainBoard); //<--- Generate 7 apples
            }
            else if (nextLevel >= 13)
            {
                apples = new Rewards(10, mainBoard);//<-- Generate 10 apples

            }

        }

        private void upBTN_Click(object sender, EventArgs e)
        {
            mode = "UP";  //Just record the mode. The moving will be done in refresh method
        }

        private void downBTN_Click(object sender, EventArgs e)
        {
            mode = "DOWN";
        }

        private void leftBTN_Click(object sender, EventArgs e)
        {
            mode = "LEFT";
        }

        private void rightBTN_Click(object sender, EventArgs e)
        {
            mode = "RIGHT";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //Get arrow key input to move snake
        {
            switch (keyData)
            {
                case Keys.NumPad4:
                    mode = "LEFT";
                    break;
                case Keys.NumPad6:
                    mode = "RIGHT";
                    break;
                case Keys.NumPad8:
                    mode = "UP";
                    break;
                case Keys.NumPad2:
                    mode = "DOWN";
                    break;
                case Keys.NumPad7:
                    mode = "UPLEFT";
                    break;
                case Keys.NumPad9:
                    mode = "UPRIGHT";
                    break;
                case Keys.NumPad3:
                    mode = "DOWNRIGHT";
                    break;
                case Keys.NumPad1:
                    mode = "DOWNLEFT";
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void refresh(Object myObject, EventArgs myEventArgs)
        {
            mySnake.move(mode); //Move the snake based on mode
            modeLBL.Text = mode;

            mainBoard.draw();
            apples.draw();  //<----- draw apples
            mySnake.draw(mode);

            //increment the duration by amount of time that has passed
            //this method is called every speed millisecond
            duration += speed;
            duration += speed;
            int time = (duration / 1000); //Show time passed

            int seconds;
            int minutes;
            int hours;
            if (time < 60)
            {
                seconds = time;
                if (seconds < 10)
                    timerLBL.Text = "00:00:0" + seconds;
                else
                    timerLBL.Text = "00:00:" + seconds;
            }
            else if ((time > 59) && (time < 3600))
            {
                minutes = time / 60;
                seconds = time - (minutes * 60);
                if (minutes < 10)
                {
                    if (seconds < 10)
                        timerLBL.Text = "00:0" + minutes + ":0" + seconds;
                    else
                        timerLBL.Text = "00:0" + minutes + ":" + seconds;
                }
                else
                {
                    if (seconds < 10)
                        timerLBL.Text = "00:" + minutes + ":0" + seconds;
                    else
                        timerLBL.Text = "00:" + minutes + ":" + seconds;
                }
            }
            else if (time > 3599)
            {
                hours = time / 3600;
                minutes = (time - (hours * 3600)) / 60;
                seconds = time - (minutes * 60) - (hours * 3600);
                if (hours < 10)
                {
                    if (minutes < 10)
                    {
                        if (seconds < 10)
                            timerLBL.Text = "0" + hours + ":0" + minutes + ":0" + seconds;
                        else
                            timerLBL.Text = "0" + hours + ":0" + minutes + ":" + seconds;
                    }
                    else
                    {
                        if (seconds < 10)
                            timerLBL.Text = "0" + hours + ":" + minutes + ":0" + seconds;
                        else
                            timerLBL.Text = "0" + hours + ":" + minutes + ":" + seconds;
                    }
                }
                else
                {
                    if (minutes < 10)
                    {
                        if (seconds < 10)
                            timerLBL.Text = hours + ":0" + minutes + ":0" + seconds;
                        else
                            timerLBL.Text = hours + ":0" + minutes + ":" + seconds;
                    }
                    else
                    {
                        if (seconds < 10)
                            timerLBL.Text = hours + ":" + minutes + ":0" + seconds;
                        else
                            timerLBL.Text = hours + ":" + minutes + ":" + seconds;
                    }
                }
            }



            //Check if snke is biting itself. If so, call GameOver.
            if (mySnake.checkEatItself() == true)
            {
                GameOver();
            }
            else if (apples.checkIFSnakeHeadEatApple( mySnake.getHeadPosition()) == true)
            {
                score += apples.eatAppleAtPostion(mySnake.getHeadPosition());
                Stream str = Properties.Resources.Cartoon___Munch;
                SoundPlayer snd = new SoundPlayer(str);
                snd.Play();
                scoreLBL.Text = Convert.ToString(score);


                if (apples.noMoreApples() == true)
                {
                    level++;
                    levelLBL.Text = Convert.ToString(level);
                    gotoNextLevel(level);
                    mySnake.extendBody();
                }
                else
                {
                    if (level > 1)
                    {
                        mySnake.extendBody();
                    }

                    mySnake.extendBody();
                     

                }
            }
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            clock.Start();
            Stream str = Properties.Resources.Button___sound_efx;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }

        private void pauseBTN_Click(object sender, EventArgs e)
        {

            clock.Stop();
            Stream str = Properties.Resources.Super_Mario_Bros___Pause_Sound_Effect;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }

        private void GameOver()
        {

           clock.Stop();
           Stream str = Properties.Resources.Game___Over;
           SoundPlayer snd = new SoundPlayer(str);
           snd.Play();
           MessageBox.Show("Your time taken is " + duration / 1000 + " seconds. Bye Bye", "Game Over");
           new srecords((duration / 1000), score.ToString()).ShowDialog();
           this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void uprightBTN_Click(object sender, EventArgs e)
        {
            if (modeLBL.Text != "DOWNLEFT")
            {
                mode = "UPRIGHT";
            }
        }

        private void downrightBTN_Click(object sender, EventArgs e)
        {
            if (modeLBL.Text != "UPLEFT")
            {
                mode = "DOWNRIGHT";
            }
        }

        private void upleftBTN_Click(object sender, EventArgs e)
        {
            if (modeLBL.Text != "DOWNRIGHT")
            {
                mode = "UPLEFT";
            }
        }

        private void downleftBTN_Click(object sender, EventArgs e)
        {
            if (modeLBL.Text != "UPRIGHT")
            {
                mode = "DOWNLEFT";
            }
        }

        private void finishBTN_Click(object sender, EventArgs e)
        {
            
            Stream str = Properties.Resources.Button___sound_efx;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
            clock.Stop();
            MessageBox.Show("Your time taken is " + duration / 1000 + " seconds. ", "Game Over");
            GameOver();
        }

        private void boardPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
