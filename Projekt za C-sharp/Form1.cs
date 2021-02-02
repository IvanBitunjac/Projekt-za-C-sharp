using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Speech.Recognition;
using WMPLib;

namespace Projekt_za_C_sharp
{ 
    public partial class Form1 : Form
    {
        string commandsHelp = "To play a song you must first enable voice recognition by clicking the 'Enable Voice' button. After enabling voice recognition " +
        "just say the bands name and the song the name to play it (ex. 'Alice In Chains Man In The Box'). To pause a song just say 'pause', " +
        "to continue the song just say 'continue' and to stop a song just say 'stop'. That's it, simple right?";

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        //string tracks_path = "C:\\Users\\Korisnik\\source\\repos\\Projekt za C-sharp\\Tracks";
        string folderPath = @"C:\Tracks folder - Music Player";
        List<string> playlist = new List<string>();
        int muted_at_volume;
        string[] tracks;
        Random random = new Random();
        SpeechRecognitionEngine speechRecogEngine = new SpeechRecognitionEngine();
        Dictionary<string, string> spokenTrackNamesPairs = new Dictionary<string, string>();
        List<string> spokenTrackNamesAndCommands = new List<string>();

        public Form1()
        {
            InitializeComponent();
            System.IO.Directory.CreateDirectory(folderPath);
            tracks = Directory.GetFiles(folderPath);
            btn_stop.Visible = true;
            btn_Unpause.Visible = false;
            btn_play.Visible = true;
            buttonDisableVoice.Enabled = false;
            label_trackStatus.Text = "Track status:";
            label_displayTrackStatus.Text = "Nothing is playing!";
            spokenTrackNamesAndCommands.Add("Stop");
            spokenTrackNamesAndCommands.Add("Pause");
            spokenTrackNamesAndCommands.Add("Continue");

            //Adds song names to listbox and voiced commands to list
            foreach (string track in tracks)
            {
                string song_name = Path.GetFileName(track);
                track_listbox.Items.Add(song_name);
                string editedSongName = TrackNameEditor.RemoveDashAndExtension(song_name);
                spokenTrackNamesPairs.Add(editedSongName, song_name);
                spokenTrackNamesAndCommands.Add(editedSongName);
            }
            Choices commands = new Choices();
            commands.Add(spokenTrackNamesAndCommands.ToArray());
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(commands);
            Grammar grammar = new Grammar(grammarBuilder);
            speechRecogEngine.LoadGrammarAsync(grammar);
            speechRecogEngine.SetInputToDefaultAudioDevice();
            speechRecogEngine.SpeechRecognized += speechRecogEngine_SpeechRecognized;
            player.settings.volume = 30;
            muted_at_volume = player.settings.volume;
            label_volume.Text = player.settings.volume.ToString();
            btn_muteVolume.Visible = true;
            btn_unmuteVolume.Visible = false;
        }

    
        //Plays selected track in listbox
        private void btn_play_Click(object sender, EventArgs e)
        {
            if (track_listbox.SelectedItem != null)
            {
                label_nowPlaying.Text = track_listbox.SelectedItem.ToString();
                player.URL = folderPath + "\\" + track_listbox.GetItemText(track_listbox.SelectedItem);
                player.controls.play();
                label_displayTrackStatus.Text = "Playing!";
            }
            else
            {
                label_nowPlaying.Text = "Cannot play nothing!";
            }
        }

        //Stops playing the current track
        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            label_displayTrackStatus.Text = "Stopped!";
            label_nowPlaying.Text = "";
        }

        //Pauses current playing track
        private void btn_Pause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            GetTrackTimeWhenPaused();
            btn_Pause.Visible = false;
            btn_Unpause.Visible = true;
        }

        //Continues playing paused track
        private void btn_Unpause_Click(object sender, EventArgs e)
        {
            player.controls.play();
            btn_Pause.Visible = true;
            btn_Unpause.Visible = false;
            label_displayTrackStatus.Text = "Playing!";
        }

    
        private void btn_volumeIncrease_Click(object sender, EventArgs e)
        {
            if(player.settings.volume == 100) {
                return;
            }
            else
            {
                player.settings.volume += 5;
                muted_at_volume = player.settings.volume;
            }
            label_volume.Text = player.settings.volume.ToString();
        }

        private void btn_volumeDecrease_Click(object sender, EventArgs e)
        {
            if(player.settings.volume > 0)
            {
                player.settings.volume -= 5;
                muted_at_volume = player.settings.volume;
            }
            label_volume.Text = player.settings.volume.ToString();
        }

        private void btn_muteVolume_Click(object sender, EventArgs e)
        {
            btn_muteVolume.Visible = false;
            btn_unmuteVolume.Visible = true;
            player.settings.volume = 0;
            label_volume.Text = 0.ToString();
        }

        private void btn_unmuteVolume_Click(object sender, EventArgs e)
        {
            btn_muteVolume.Visible = true;
            btn_unmuteVolume.Visible = false;
            player.settings.volume = muted_at_volume;
            label_volume.Text = player.settings.volume.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = folderPath;
            dialog.ShowDialog();
            var all_tracks = new DirectoryInfo(folderPath).GetFiles();
        }

      

        private void btn_playRandomTrack_Click(object sender, EventArgs e)
        {
            int random_track_index = random.Next(track_listbox.Items.Count);
            string random_track_name = track_listbox.Items[random_track_index].ToString();
            player.URL = folderPath + "//" + random_track_name;
            player.controls.play();
            label_nowPlaying.Text = random_track_name;
            label_displayTrackStatus.Text = "Playing!";
            track_listbox.SelectedItem = random_track_name;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(track_listbox.SelectedItem == null)
            {
                label_nowPlaying.Text = "Cannot play nothing";
            }
            else
            {
                int track_index = track_listbox.SelectedIndex;
                if(track_index >= track_listbox.Items.Count - 1)
                {
                    track_index = 0;
                    track_listbox.SelectedItem = track_listbox.Items[track_index];
                    player.URL = folderPath + "//" + track_listbox.Items[track_index].ToString();
                    player.controls.play();
                }
                else
                {
                    ++track_index;
                    track_listbox.SelectedItem = track_listbox.Items[track_index];
                    player.URL = folderPath + "//" + track_listbox.Items[track_index].ToString();
                    player.controls.play();
                }
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (track_listbox.SelectedItem == null)
            {
                label_nowPlaying.Text = "Cannot play nothing";
            }
            else
            {
                int track_index = track_listbox.SelectedIndex;
                if (track_index <= 0)
                {
                    track_index = track_listbox.Items.Count - 1;
                    track_listbox.SelectedItem = track_listbox.Items[track_index];
                    player.URL = folderPath + "//" + track_listbox.Items[track_index].ToString();
                    player.controls.play();
                }
                else
                {
                    --track_index;
                    track_listbox.SelectedItem = track_listbox.Items[track_index];
                    player.URL = folderPath + "//" + track_listbox.Items[track_index].ToString();
                    player.controls.play();
                }
            }
        }

        void speechRecogEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (spokenTrackNamesAndCommands.ElementAt(0).Equals(e.Result.Text)) {
                spokenCommandsResultTextbox.AppendText("Command: Stop\n");
                player.controls.stop();
                label_displayTrackStatus.Text = "Stopped!";
                label_nowPlaying.Text = "Nothing";
            }
            if (spokenTrackNamesAndCommands.ElementAt(1).Equals(e.Result.Text))
            {
                spokenCommandsResultTextbox.AppendText("Command: Pause\n");
                player.controls.pause();
                GetTrackTimeWhenPaused();
            }
            if (spokenTrackNamesAndCommands.ElementAt(2).Equals(e.Result.Text))
            {
                spokenCommandsResultTextbox.AppendText("Command: Continue\n");
                player.controls.play();
                label_displayTrackStatus.Text = "Playing!";
            }
            if (spokenTrackNamesPairs.ContainsKey(e.Result.Text))
            {
                player.URL = folderPath + "\\" + spokenTrackNamesPairs[e.Result.Text];
                player.controls.play();
                label_displayTrackStatus.Text = "Playing!";
                label_nowPlaying.Text = spokenTrackNamesPairs[e.Result.Text];
                spokenCommandsResultTextbox.AppendText("You said to play: " + e.Result.Text + "\n");
            }
            
        }

        private void GetTrackTimeWhenPaused()
        {
            double position = player.controls.currentPosition;
            double minute_paused;
            double seconds_paused;
            string position_text = player.controls.currentPosition.ToString();
            if (player.controls.currentPosition <= 60.0)
            {
                if (position < 10.0)
                {
                    label_displayTrackStatus.Text = "Paused at 0:0" + (int)position;
                }
                else
                {
                    label_displayTrackStatus.Text = "Paused at 0:" + (int)position;
                }
            }
            else
            {
                minute_paused = position / 60;
                seconds_paused = position - ((int)minute_paused * 60);
                if (seconds_paused < 10)
                {
                    label_displayTrackStatus.Text = "Paused at " + (int)minute_paused + ":0" + (int)seconds_paused;
                }
                else
                {
                    label_displayTrackStatus.Text = "Paused at " + (int)minute_paused + ":" + (int)seconds_paused;
                }
            }
        }

        private void buttonEnableVoice_Click(object sender, EventArgs e)
        {
            speechRecogEngine.RecognizeAsync(RecognizeMode.Multiple);
            buttonEnableVoice.Enabled = false;
            buttonDisableVoice.Enabled = true;
            btn_play.Enabled = false;
        }

        private void buttonDisableVoice_Click(object sender, EventArgs e)
        {
            speechRecogEngine.RecognizeAsyncStop();
            buttonEnableVoice.Enabled = true;
            buttonDisableVoice.Enabled = false;
            btn_play.Enabled = true;
        }

        private void buttonViewCommands_Click(object sender, EventArgs e)
        {
            MessageBox.Show(commandsHelp);
        }
    }
}
