using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Threading;

namespace Snake
{
    public partial class InsideDifficulty : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        Thread th;
        public InsideDifficulty()
        {
            InitializeComponent();
            player.URL = "difficultymode.mp3";

        }

        private void InsideDifficulty_Load(object sender, EventArgs e)
        {

        }

        private void easyBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Stream str = Properties.Resources.Button___sound_efx;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
            th = new Thread(openeasy);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openeasy(object obj)
        {
            Application.Run(new easymode());
        }

        private void hardBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Stream str = Properties.Resources.Button___sound_efx;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
            th = new Thread(openhard);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openhard(object obj)
        {
            Application.Run(new hardmode());
        }

        private void extremeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Stream str = Properties.Resources.Button___sound_efx;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
            th = new Thread(openextreme);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openextreme(object obj)
        {
            Application.Run(new extrememode());
        }
    }
}
