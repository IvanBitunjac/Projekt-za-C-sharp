using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Test2
{
    public partial class Form1 : Form
    {
        
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        string track = "C:\\Users\\Korisnik\\source\\repos\\Projekt za C - sharp\\Tracks\\Alice In Chains - Man In The Box.mp3";

        public Form1()
        {
            InitializeComponent();



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = track;
            player.controls.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double position = player.controls.currentPosition;
            label1.Text = position.ToString();
        }
    }
}
