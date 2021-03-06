﻿using System;
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
using AppDop1;
using AppDop.Dane;
using System.Windows.Threading;

namespace AppDop1Wer1
{
    /// <summary>
    /// Logika interakcji dla klasy PlanszeThird.xaml
    /// </summary>
    public partial class PlanszeThird : Page
    {
        public PlanszeThird()
        {
            InitializeComponent();
            Film jeden = new Film(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\Dopalacze1_Wplyw_WERSJA2popr2cz2.mp4", "jedynka");
            //Video1.Source = new Uri(jeden.FilmAdress);
            Video1.Play();
            Video1.Stop();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            Klik.ImageSource = new ImageSourceConverter().ConvertFromString(ZbiorDanych.IkonyProgramu[3].IkoAdress) as ImageSource;
            buttonFilm.Click += new RoutedEventHandler(buttonFilm_Click);
            buttonFilm.MouseEnter += new MouseEventHandler(buttonFilm_MouseEnter);
            buttonFilm.MouseLeave += new MouseEventHandler(buttonFilm_MouseLeave);
        }

        private void buttonFilm_Click(object sender, RoutedEventArgs e)
        {

            //PlanszeSecondB planszeSecondB = new PlanszeSecondB();
            //this.NavigationService.Navigate(planszeSecondB);
            PlanszeThirdB planszeThirdB = new PlanszeThirdB();
            this.NavigationService.Navigate(planszeThirdB);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (Video1.Source != null)
            {
                if (Video1.NaturalDuration.HasTimeSpan)
                    lblStatus.Content = String.Format("{0} / {1}", Video1.Position.ToString(@"mm\:ss"), Video1.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                lblStatus.Content = "No file selected...";
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            Video1.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            Video1.Pause();


        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            Video1.Stop();
        }

        private void Element_MediaOpened(object sender, EventArgs e)
        {
            timelineSlider.Maximum = Video1.NaturalDuration.TimeSpan.TotalMilliseconds;
        }

        private void Element_MediaEnded(object sender, EventArgs e)
        {
            Video1.Stop();
        }

        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            int SliderValue = (int)timelineSlider.Value;

            // Overloaded constructor takes the arguments days, hours, minutes, seconds, milliseconds.
            // Create a TimeSpan with miliseconds equal to the slider value.
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            Video1.Position = ts;
        }

        private void buttonFilm_MouseEnter(object sender, MouseEventArgs e)
        {
            //PlanszaTypA ikonaC = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona3b.png", "Ikona3");
            Klik.ImageSource = new ImageSourceConverter().ConvertFromString(ZbiorDanych.IkonyProgramu[7].IkoAdress) as ImageSource;
        }
        private void buttonFilm_MouseLeave(object sender, MouseEventArgs e)
        {
            //PlanszaTypA ikonaC = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona3.png", "Ikona3");
            Klik.ImageSource = new ImageSourceConverter().ConvertFromString(ZbiorDanych.IkonyProgramu[3].IkoAdress) as ImageSource;
        }
    }
}
