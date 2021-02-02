namespace Projekt_za_C_sharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play_track_label = new System.Windows.Forms.Label();
            this.track_listbox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_displayTrackStatus = new System.Windows.Forms.Label();
            this.label_trackStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_nowPlaying = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_volume = new System.Windows.Forms.Label();
            this.btn_volumeIncrease = new System.Windows.Forms.Button();
            this.btn_volumeDecrease = new System.Windows.Forms.Button();
            this.btn_muteVolume = new System.Windows.Forms.Button();
            this.btn_unmuteVolume = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Unpause = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_playRandomTrack = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.buttonEnableVoice = new System.Windows.Forms.Button();
            this.buttonDisableVoice = new System.Windows.Forms.Button();
            this.spokenCommandsResultTextbox = new System.Windows.Forms.RichTextBox();
            this.labelVoiceHelp = new System.Windows.Forms.Label();
            this.buttonViewCommands = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play_track_label
            // 
            this.play_track_label.AutoSize = true;
            this.play_track_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_track_label.Location = new System.Drawing.Point(13, 112);
            this.play_track_label.Name = "play_track_label";
            this.play_track_label.Size = new System.Drawing.Size(64, 13);
            this.play_track_label.TabIndex = 4;
            this.play_track_label.Text = "All tracks:";
            // 
            // track_listbox
            // 
            this.track_listbox.FormattingEnabled = true;
            this.track_listbox.Location = new System.Drawing.Point(83, 112);
            this.track_listbox.Name = "track_listbox";
            this.track_listbox.Size = new System.Drawing.Size(224, 95);
            this.track_listbox.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_displayTrackStatus
            // 
            this.label_displayTrackStatus.Location = new System.Drawing.Point(420, 142);
            this.label_displayTrackStatus.Name = "label_displayTrackStatus";
            this.label_displayTrackStatus.Size = new System.Drawing.Size(102, 32);
            this.label_displayTrackStatus.TabIndex = 8;
            this.label_displayTrackStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_trackStatus
            // 
            this.label_trackStatus.AutoEllipsis = true;
            this.label_trackStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_trackStatus.Location = new System.Drawing.Point(313, 142);
            this.label_trackStatus.Name = "label_trackStatus";
            this.label_trackStatus.Size = new System.Drawing.Size(101, 32);
            this.label_trackStatus.TabIndex = 10;
            this.label_trackStatus.Text = "Track status:";
            this.label_trackStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_trackStatus.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Now playing:";
            // 
            // label_nowPlaying
            // 
            this.label_nowPlaying.AutoSize = true;
            this.label_nowPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nowPlaying.Location = new System.Drawing.Point(111, 304);
            this.label_nowPlaying.Name = "label_nowPlaying";
            this.label_nowPlaying.Size = new System.Drawing.Size(51, 13);
            this.label_nowPlaying.TabIndex = 15;
            this.label_nowPlaying.Text = "Nothing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Volume:";
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Location = new System.Drawing.Point(80, 239);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(0, 13);
            this.label_volume.TabIndex = 17;
            // 
            // btn_volumeIncrease
            // 
            this.btn_volumeIncrease.Location = new System.Drawing.Point(121, 224);
            this.btn_volumeIncrease.Name = "btn_volumeIncrease";
            this.btn_volumeIncrease.Size = new System.Drawing.Size(45, 22);
            this.btn_volumeIncrease.TabIndex = 18;
            this.btn_volumeIncrease.Text = "+";
            this.btn_volumeIncrease.UseVisualStyleBackColor = true;
            this.btn_volumeIncrease.Click += new System.EventHandler(this.btn_volumeIncrease_Click);
            // 
            // btn_volumeDecrease
            // 
            this.btn_volumeDecrease.Location = new System.Drawing.Point(121, 252);
            this.btn_volumeDecrease.Name = "btn_volumeDecrease";
            this.btn_volumeDecrease.Size = new System.Drawing.Size(45, 22);
            this.btn_volumeDecrease.TabIndex = 19;
            this.btn_volumeDecrease.Text = "-";
            this.btn_volumeDecrease.UseVisualStyleBackColor = true;
            this.btn_volumeDecrease.Click += new System.EventHandler(this.btn_volumeDecrease_Click);
            // 
            // btn_muteVolume
            // 
            this.btn_muteVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muteVolume.Location = new System.Drawing.Point(316, 184);
            this.btn_muteVolume.Name = "btn_muteVolume";
            this.btn_muteVolume.Size = new System.Drawing.Size(75, 23);
            this.btn_muteVolume.TabIndex = 20;
            this.btn_muteVolume.Text = "Mute";
            this.btn_muteVolume.UseVisualStyleBackColor = true;
            this.btn_muteVolume.Click += new System.EventHandler(this.btn_muteVolume_Click);
            // 
            // btn_unmuteVolume
            // 
            this.btn_unmuteVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unmuteVolume.Location = new System.Drawing.Point(316, 184);
            this.btn_unmuteVolume.Name = "btn_unmuteVolume";
            this.btn_unmuteVolume.Size = new System.Drawing.Size(75, 23);
            this.btn_unmuteVolume.TabIndex = 21;
            this.btn_unmuteVolume.Text = "Unmute";
            this.btn_unmuteVolume.UseVisualStyleBackColor = true;
            this.btn_unmuteVolume.Click += new System.EventHandler(this.btn_unmuteVolume_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add track(s)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Unpause
            // 
            this.btn_Unpause.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Unpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Unpause.Image = global::Projekt_za_C_sharp.Properties.Resources.rsz_unpausebutton;
            this.btn_Unpause.Location = new System.Drawing.Point(338, 12);
            this.btn_Unpause.Name = "btn_Unpause";
            this.btn_Unpause.Size = new System.Drawing.Size(134, 49);
            this.btn_Unpause.TabIndex = 9;
            this.btn_Unpause.UseVisualStyleBackColor = false;
            this.btn_Unpause.Click += new System.EventHandler(this.btn_Unpause_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.Image = global::Projekt_za_C_sharp.Properties.Resources.rsz_pausebutton;
            this.btn_Pause.Location = new System.Drawing.Point(338, 12);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(134, 49);
            this.btn_Pause.TabIndex = 6;
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_stop.Image = global::Projekt_za_C_sharp.Properties.Resources.rsz_stopbutton;
            this.btn_stop.Location = new System.Drawing.Point(173, 12);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(134, 49);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Image = global::Projekt_za_C_sharp.Properties.Resources.rsz_playbutton;
            this.btn_play.Location = new System.Drawing.Point(12, 12);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(134, 49);
            this.btn_play.TabIndex = 0;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_playRandomTrack
            // 
            this.btn_playRandomTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playRandomTrack.Location = new System.Drawing.Point(221, 213);
            this.btn_playRandomTrack.Name = "btn_playRandomTrack";
            this.btn_playRandomTrack.Size = new System.Drawing.Size(86, 39);
            this.btn_playRandomTrack.TabIndex = 23;
            this.btn_playRandomTrack.Text = "Play random track";
            this.btn_playRandomTrack.UseVisualStyleBackColor = true;
            this.btn_playRandomTrack.Click += new System.EventHandler(this.btn_playRandomTrack_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.Location = new System.Drawing.Point(102, 83);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(84, 23);
            this.btn_previous.TabIndex = 25;
            this.btn_previous.Text = "<< Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(212, 83);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(84, 23);
            this.btn_next.TabIndex = 26;
            this.btn_next.Text = "Next >>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // buttonEnableVoice
            // 
            this.buttonEnableVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnableVoice.Location = new System.Drawing.Point(12, 378);
            this.buttonEnableVoice.Name = "buttonEnableVoice";
            this.buttonEnableVoice.Size = new System.Drawing.Size(113, 45);
            this.buttonEnableVoice.TabIndex = 27;
            this.buttonEnableVoice.Text = "Enable Voice";
            this.buttonEnableVoice.UseVisualStyleBackColor = true;
            this.buttonEnableVoice.Click += new System.EventHandler(this.buttonEnableVoice_Click);
            // 
            // buttonDisableVoice
            // 
            this.buttonDisableVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisableVoice.Location = new System.Drawing.Point(131, 378);
            this.buttonDisableVoice.Name = "buttonDisableVoice";
            this.buttonDisableVoice.Size = new System.Drawing.Size(113, 45);
            this.buttonDisableVoice.TabIndex = 28;
            this.buttonDisableVoice.Text = "Disable Voice";
            this.buttonDisableVoice.UseVisualStyleBackColor = true;
            this.buttonDisableVoice.Click += new System.EventHandler(this.buttonDisableVoice_Click);
            // 
            // spokenCommandsResultTextbox
            // 
            this.spokenCommandsResultTextbox.Location = new System.Drawing.Point(281, 349);
            this.spokenCommandsResultTextbox.Name = "spokenCommandsResultTextbox";
            this.spokenCommandsResultTextbox.Size = new System.Drawing.Size(453, 171);
            this.spokenCommandsResultTextbox.TabIndex = 29;
            this.spokenCommandsResultTextbox.Text = "";
            // 
            // labelVoiceHelp
            // 
            this.labelVoiceHelp.AutoSize = true;
            this.labelVoiceHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoiceHelp.Location = new System.Drawing.Point(13, 435);
            this.labelVoiceHelp.Name = "labelVoiceHelp";
            this.labelVoiceHelp.Size = new System.Drawing.Size(128, 13);
            this.labelVoiceHelp.TabIndex = 30;
            this.labelVoiceHelp.Text = "Voice command help:";
            // 
            // buttonViewCommands
            // 
            this.buttonViewCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewCommands.Location = new System.Drawing.Point(147, 430);
            this.buttonViewCommands.Name = "buttonViewCommands";
            this.buttonViewCommands.Size = new System.Drawing.Size(75, 23);
            this.buttonViewCommands.TabIndex = 31;
            this.buttonViewCommands.Text = "View help";
            this.buttonViewCommands.UseVisualStyleBackColor = true;
            this.buttonViewCommands.Click += new System.EventHandler(this.buttonViewCommands_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.buttonViewCommands);
            this.Controls.Add(this.labelVoiceHelp);
            this.Controls.Add(this.spokenCommandsResultTextbox);
            this.Controls.Add(this.buttonDisableVoice);
            this.Controls.Add(this.buttonEnableVoice);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_playRandomTrack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_unmuteVolume);
            this.Controls.Add(this.btn_muteVolume);
            this.Controls.Add(this.btn_volumeDecrease);
            this.Controls.Add(this.btn_volumeIncrease);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_nowPlaying);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_trackStatus);
            this.Controls.Add(this.btn_Unpause);
            this.Controls.Add(this.label_displayTrackStatus);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.track_listbox);
            this.Controls.Add(this.play_track_label);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MusicPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ListBox track_listbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Label play_track_label;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Label label_displayTrackStatus;
        private System.Windows.Forms.Button btn_Unpause;
        private System.Windows.Forms.Label label_trackStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_nowPlaying;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Button btn_volumeIncrease;
        private System.Windows.Forms.Button btn_volumeDecrease;
        private System.Windows.Forms.Button btn_muteVolume;
        private System.Windows.Forms.Button btn_unmuteVolume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_playRandomTrack;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button buttonEnableVoice;
        private System.Windows.Forms.Button buttonDisableVoice;
        private System.Windows.Forms.RichTextBox spokenCommandsResultTextbox;
        private System.Windows.Forms.Label labelVoiceHelp;
        private System.Windows.Forms.Button buttonViewCommands;
    }
}

