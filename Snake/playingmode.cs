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
    public partial class playingmode : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        Thread th;
        public playingmode()
        {
            InitializeComponent();
            player.URL = "Eleague - MODE.mp3";

        }

        private void playingmode_Load(object sender, EventArgs e)
        {

        }

        private void difficultyBTN_Click(object sender, EventArgs e)
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
            Application.Run(new InsideDifficulty());
        }

        private void levelBTN_Click(object sender, EventArgs e)
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
            Application.Run(new Form1());
        }
    }
   
}
