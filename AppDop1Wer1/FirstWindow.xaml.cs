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
using AppDop1;
using AppDop.Dane;


namespace AppDop1Wer1
{
    /// <summary>
    /// Logika interakcji dla klasy FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Page
    {
        public FirstWindow()
        {
            InitializeComponent();
            //PlanszaTypA ikonaA = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona2.png", "Ikona1"); //w tej klasie duże ikony traktowane jak plansze

            //obrazekA.ImageSource = new ImageSourceConverter().ConvertFromString(ikonaA.PlanszaTypAAdress) as ImageSource;
            obrazekA.ImageSource = new ImageSourceConverter().ConvertFromString(ZbiorDanych.IkonyProgramu[1].IkoAdress) as ImageSource; // porządkuje trochę
            obrazekB.ImageSource = new ImageSourceConverter().ConvertFromString(ZbiorDanych.IkonyProgramu[0].IkoAdress) as ImageSource;
            obrazekC.ImageSource = new ImageSourceConverter().ConvertFromString(ZbiorDanych.IkonyProgramu[2].IkoAdress) as ImageSource;
            buttonA.MouseEnter += new MouseEventHandler(buttonA_MouseEnter);
            buttonA.MouseLeave += new MouseEventHandler(buttonA_MouseLeave);
            buttonA.Click += new RoutedEventHandler(buttonA_Click);
            buttonB.MouseEnter += new MouseEventHandler(buttonB_MouseEnter);
            buttonB.MouseLeave += new MouseEventHandler(buttonB_MouseLeave);
            buttonB.Click += new RoutedEventHandler(buttonB_Click);
            buttonC.MouseEnter += new MouseEventHandler(buttonC_MouseEnter);
            buttonC.MouseLeave += new MouseEventHandler(buttonC_MouseLeave);
            buttonC.Click += new RoutedEventHandler(buttonC_Click);
        }

        private void buttonB_Click(object sender, RoutedEventArgs e)
        {
            PlanszeFirst planszeFirstPage = new PlanszeFirst();
            this.NavigationService.Navigate(planszeFirstPage);

        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            PlanszeSecond planszeSecond = new PlanszeSecond();
            this.NavigationService.Navigate(planszeSecond);
        }
        private void buttonA_MouseEnter(object sender, MouseEventArgs e)
        {
            PlanszaTypA ikonaA = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona2b.png", "Ikona3");
            obrazekA.ImageSource = new ImageSourceConverter().ConvertFromString(ikonaA.PlanszaTypAAdress) as ImageSource;
        }
        private void buttonA_MouseLeave(object sender, MouseEventArgs e)
        {
            PlanszaTypA ikonaA = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona2.png", "Ikona3");
            obrazekA.ImageSource = new ImageSourceConverter().ConvertFromString(ikonaA.PlanszaTypAAdress) as ImageSource;
        }

        private void buttonB_MouseEnter(object sender, MouseEventArgs e)
        {
            PlanszaTypA ikonaB = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona1_wersja2b.png", "Ikona3");
            obrazekB.ImageSource = new ImageSourceConverter().ConvertFromString(ikonaB.PlanszaTypAAdress) as ImageSource;
        }
        private void buttonB_MouseLeave(object sender, MouseEventArgs e)
        {
            PlanszaTypA ikonaB = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona1_wersja2.png", "Ikona3");
            obrazekB.ImageSource = new ImageSourceConverter().ConvertFromString(ikonaB.PlanszaTypAAdress) as ImageSource;
        }

        private void buttonC_MouseEnter(object sender, MouseEventArgs e)
        {
            PlanszaTypA ikonaC = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona3b.png", "Ikona3");
            obrazekC.ImageSource = new ImageSourceConverter().ConvertFromString(ikonaC.PlanszaTypAAdress) as ImageSource;
        }
        private void buttonC_MouseLeave(object sender, MouseEventArgs e)
        {
            PlanszaTypA ikonaC = new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona3.png", "Ikona3");
            obrazekC.ImageSource = new ImageSourceConverter().ConvertFromString(ikonaC.PlanszaTypAAdress) as ImageSource;
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            //PlanszeFirst planszeFirstPage = new PlanszeFirst();
            //ObrazkiFirst obrazekpierwszy = new ObrazkiFirst();
            PlanszeThird planszeThird = new PlanszeThird();
            this.NavigationService.Navigate(planszeThird);
        }
    }
}
