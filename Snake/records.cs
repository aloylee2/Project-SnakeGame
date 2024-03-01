using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Snake
{
    public partial class records : Form
    {
        string Time;
        string Name;
        string Score;
        const int TOPPLAYER = 5;
        
        public records()    
        {
            InitializeComponent();
        }
        public string getName()
        {
            return playertextname.Text;
        }

        public string getScore()
        {
            return Score;
        }

        public string getTime()
        {
            return Time;
        }

        public records(string name, string time, string score)
        {
            InitializeComponent();
            this.Name = name;
            this.Time = time;
            this.Score = score;
            Scorelbl.Text = score;
            timelbl.Text = time;
            playertextname.Text = name;
        }

        public records(int timeElapsed, string score)
        {
            InitializeComponent();
            Scorelbl.Text = score;
            timelbl.Text = Time;
            int secs;
            int mins;
            int hrs;
            if (timeElapsed < 60)
            {
                secs = timeElapsed;
                if (secs < 10)
                    timelbl.Text = "00:00:0" + secs;
                else
                    timelbl.Text = "00:00:" + secs;
            }
            else if ((timeElapsed > 59) && (timeElapsed < 3600))
            {
                mins = timeElapsed / 60;
                secs = timeElapsed - (mins * 60);
                if (mins < 10)
                {
                    if (secs < 10)
                        timelbl.Text = "00:0" + mins + ":0" + secs;
                    else
                        timelbl.Text = "00:0" + mins + ":" + secs;
                }
                else
                {
                    if (secs < 10)
                        timelbl.Text = "00:" + mins + ":0" + secs;
                    else
                        timelbl.Text = "00:" + mins + ":" + secs;
                }
            }
            else if (timeElapsed > 3599)
            {
                hrs = timeElapsed / 3600;
                mins = (timeElapsed - (hrs * 3600)) / 60;
                secs = timeElapsed - (mins * 60) - (hrs * 3600);
                if (hrs < 10)
                {
                    if (mins < 10)
                    {
                        if (secs < 10)
                            timelbl.Text = "0" + hrs + ":0" + mins + ":0" + secs;
                        else
                            timelbl.Text = "0" + hrs + ":0" + mins + ":" + secs;
                    }
                    else
                    {
                        if (secs < 10)
                            timelbl.Text = "0" + hrs + ":" + mins + ":0" + secs;
                        else
                            timelbl.Text = "0" + hrs + ":" + mins + ":" + secs;
                    }
                }
                else
                {
                    if (mins < 10)
                    {
                        if (secs < 10)
                            timelbl.Text = hrs + ":0" + mins + ":0" + secs;
                        else
                            timelbl.Text = hrs + ":0" + mins + ":" + secs;
                    }
                    else
                    {
                        if (secs < 10)
                            timelbl.Text = hrs + ":" + mins + ":0" + secs;
                        else
                            timelbl.Text = hrs + ":" + mins + ":" + secs;
                    }
                }
            }
            Time = timelbl.Text;
        }

        private void records_Load(object sender, EventArgs e)
        {

        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            List<string> records = new List<string>();
            StreamWriter sw = new StreamWriter("C: \\Users\\Farhan A'Wahab\\Desktop\\PROJECT\\Lab8-SnakeTaskComplete\\Snake\bin\\Debug\\score.txt", true);
            sw.WriteLine(playertextname.Text + "," + timelbl.Text + "," + Scorelbl.Text);
            sw.Close();
            MessageBox.Show("Your Record is up!");
            new scoreboard().ShowDialog();
        }
    }
}
