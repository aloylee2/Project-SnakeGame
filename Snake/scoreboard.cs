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
using WMPLib;
using System.Threading;

namespace Snake
{
    public partial class scoreboard : Form
    {
        List<srecords> scorerecord = new List<srecords>();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        Thread th;


        public scoreboard()
        {
            InitializeComponent();
            player.URL = "scoreboard.mp3";

            scoreboardDGV.ColumnCount = 3;
            scoreboardDGV.Columns[0].HeaderText = "NAME";
            scoreboardDGV.Columns[1].HeaderText = "SCORE";
            scoreboardDGV.Columns[2].HeaderText = "TIME";

            scoreboardDGV.AllowUserToAddRows = false;
            scoreboardDGV.AllowUserToDeleteRows = false;
            scoreboardDGV.MultiSelect = false;
            scoreboardDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            scoreboardDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            StreamReader sr = new StreamReader("C: \\Users\\Aloy Lee\\Documents\\temps\\score.txt");
            String Row;
            Row = sr.ReadLine();
            while (Row != null)
            {
                String[] fields = Row.Split(',');
                srecords row = new srecords(fields[0], fields[1], fields[2]);
                scorerecord.Add(row);
                Row = sr.ReadLine();
            }
            sr.Close();
            refreshDGV();

            totallbl.Text = scorerecord.Count() + " Players have been updated";
        }

        private void refreshDGV()
        {
            scoreboardDGV.Rows.Clear();
            for (int i = 0; i < scorerecord.Count; i++)
            {
                scoreboardDGV.Rows.Add();
                scoreboardDGV.Rows[i].Cells[0].Value = scorerecord[i].getName();
                scoreboardDGV.Rows[i].Cells[1].Value = scorerecord[i].getScore();
                scoreboardDGV.Rows[i].Cells[2].Value = scorerecord[i].getTime();

            }
        }

        private void scoreboard_Load(object sender, EventArgs e)
        {

        }

        private void scoreboardDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            scoreboardDGV.Rows.Clear();
            for (int i = 0; i < 5; i++)
            {
                scoreboardDGV.Rows.Add();
                scoreboardDGV.Rows[i].Cells[0].Value = scorerecord[i].getName();
                scoreboardDGV.Rows[i].Cells[1].Value = scorerecord[i].getScore();
                scoreboardDGV.Rows[i].Cells[2].Value = scorerecord[i].getTime();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scoreboardDGV.Rows.Clear();
            for (int i = 0; i < scorerecord.Count; i++)
            {
                scoreboardDGV.Rows.Add();
                scoreboardDGV.Rows[i].Cells[0].Value = scorerecord[i].getName();
                scoreboardDGV.Rows[i].Cells[1].Value = scorerecord[i].getScore();
                scoreboardDGV.Rows[i].Cells[2].Value = scorerecord[i].getTime();

            }
        }
    }
}
