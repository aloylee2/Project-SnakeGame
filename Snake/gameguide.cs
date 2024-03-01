using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Media;
using WMPLib;

namespace Snake
{
    public partial class gameguide : Form
    {
        Thread th;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public gameguide()
        {
            InitializeComponent();
            player.URL = "instruction.mp3";
        }

        private void button1_Click(object sender, EventArgs e)
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
            Application.Run(new Gameintro());
        }

        private void gameguide_Load(object sender, EventArgs e)
        {

        }
    }
}
