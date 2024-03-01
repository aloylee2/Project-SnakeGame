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
using System.Media;
using System.Threading;

namespace Snake
{
    public partial class srecords : Form
    {
        Thread th;
        string Time;
        string Name;
        string Score;
        const int MaxTopPlayer= 5;
        

        public srecords()
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
        private void srecords_Load(object sender, EventArgs e)
        {

        }

        public srecords(string name, string time, string score)
        {
            InitializeComponent();
            this.Name = name;
            this.Time = time;
            this.Score = score;
            scorelbl.Text = score;
            timelbl.Text = time;
            playertextname.Text = name;
        }

        public srecords(int timeElapsed, string score)
        {
            InitializeComponent();
            scorelbl.Text = score;
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> records = new List<string>();
            StreamWriter sw = new StreamWriter("C: \\Users\\Aloy Lee\\Documents\\temps\\score.txt", true);
            //"C:\\Users\\Farhan A'Wahab\\Desktop\\PROJECT\\Lab8-SnakeTaskComplete\\Snake\\tmp\\score.txt"
            sw.WriteLine(playertextname.Text + "," + timelbl.Text + "," + scorelbl.Text);
            sw.Close();
            MessageBox.Show("Your Score have been update!");
            this.Close();
            Stream str = Properties.Resources.Button___sound_efx;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
            th = new Thread(openscoreboard);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openscoreboard(object obj)
        {
            Application.Run(new scoreboard());
        }

        private void timelbl_Click(object sender, EventArgs e)
        {

        }

        private void playertextname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
