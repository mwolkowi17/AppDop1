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
using AppDop.Dane;

namespace AppDop1Wer1
{
    /// <summary>
    /// Logika interakcji dla klasy PlanszeFirstB.xaml
    /// </summary>
    public partial class PlanszeFirstB : Page
    {
        public PlanszeFirstB()
        {
            InitializeComponent();
            Klik.ImageSource = new ImageSourceConverter().ConvertFromString(ZbiorDanych.IkonyProgramu[3].IkoAdress) as ImageSource;
            buttonFilm.Click += new RoutedEventHandler(buttonFilm_Click);
            buttonFilm.MouseEnter += new MouseEventHandler(buttonFilm_MouseEnter);
            buttonFilm.MouseLeave += new MouseEventHandler(buttonFilm_MouseLeave);
        }

        private void buttonFilm_Click(object sender, RoutedEventArgs e)
        {
            PlanszeFirstC planszeFirstC = new PlanszeFirstC();
            this.NavigationService.Navigate(planszeFirstC);
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
