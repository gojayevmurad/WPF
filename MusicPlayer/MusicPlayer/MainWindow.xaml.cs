using MahApps.Metro.IconPacks;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MediaPlayer mediaPlayer = new MediaPlayer();
        DispatcherTimer timer = new DispatcherTimer();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public double duration { get; set; } = 0;

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            timer.Interval = TimeSpan.FromSeconds(.5);
            timer.Tick += UpdateUIPerSecond;

            openFileDialog.Filter = "MP3 Files (*.mp3)|*.mp3";
            
            mediaPlayer.MediaOpened += setMediaData;
            mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;

        }

        private void MediaPlayer_MediaEnded(object? sender, EventArgs e)
        {
            mediaPlayer.Close();
            songNameLbl.Content = "Song Name";
        }

        private void UpdateUIPerSecond(object? sender, EventArgs e)
        {
            TimeSpan currentPosition = mediaPlayer.Position;
            currentTimeLbl.Content = string.Format("{0}:{1:D2}", (int)currentPosition.TotalMinutes, currentPosition.Seconds);

            if (duration != 0)
            {
                soundSlider.Value = (int)currentPosition.TotalSeconds / duration * 100;
            }
        }

        private void mainBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e) => this.Close();

        private void pausePlayBtn_Click(object sender, RoutedEventArgs e)
        {
            if (playPauseIcon.Kind == PackIconMaterialKind.Pause) pauseMusicHandler();
            else playMusicHandler();
        }

        private void playMusicHandler()
        {
            playPauseIcon.Kind = PackIconMaterialKind.Pause;
            playPauseIcon.Margin = new Thickness(0, 0, 0, 0);
            mediaPlayer.Play();
            timer.Start();
        }

        private void pauseMusicHandler()
        {
            playPauseIcon.Kind = PackIconMaterialKind.Play;
            playPauseIcon.Margin = new Thickness(4, 0, 0, 0);
            mediaPlayer.Pause();
            timer.Stop();
        }

        private void browseBtn_Click(object sender, RoutedEventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == true)
            {
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
                playMusicHandler();
            }
        }

        private void setMediaData(object? sender, EventArgs e)
        {
            songNameLbl.Content = openFileDialog.SafeFileName;
            TimeSpan totalDuration = mediaPlayer.NaturalDuration.TimeSpan;
            duration = (int)totalDuration.TotalSeconds;

            string formattedDuration = string.Format("{0:D2}:{1:D2}:{2:D2}", totalDuration.Hours, totalDuration.Minutes, totalDuration.Seconds);
            totalTimeLbl.Content = formattedDuration;
        }

    }
}
