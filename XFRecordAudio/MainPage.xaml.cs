using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.AudioRecorder;

namespace XFRecordAudio
{
    public partial class MainPage : ContentPage
    {
        private readonly AudioRecorderService audioRecorderService = new AudioRecorderService();

        private readonly AudioPlayer audioPlayer = new AudioPlayer();

        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (audioRecorderService.IsRecording)
            {
                audioRecorderService.StopRecording();

                audioPlayer.Play(audioRecorderService.GetAudioFilePath());
            }
            else
            {
                audioRecorderService.StartRecording();
            }
        }
    }
}
