using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using WMPLib;
using System.Threading;

namespace Snake
{
   
    public partial class Gameintro : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        Thread th;
        public Gameintro()
        {
            InitializeComponent();
            player.URL = "intro.mp3";

        }

        private void startBTN_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Stream str = Properties.Resources.Button___sound_efx;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

              
        }

        private void opennewform(object obj)
        {
            Application.Run(new playingmode());
        }

        private void instructionBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Stream str = Properties.Resources.Button___sound_efx;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform1(object obj)
        {
            Application.Run(new gameguide());
        }
        private void exitBTN_Click(object sender, EventArgs e)
        {
            Stream str = Properties.Resources.Button___sound_efx;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
            }
            else
            {

            }
            {
                this.Close();
            }
        }

        private void scoreboardBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Stream str = Properties.Resources.Button___sound_efx;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform2(object obj)
        {
            Application.Run(new scoreboard());
        }

        private void Gameintro_Load(object sender, EventArgs e)
        {
           
        }
    }
}


