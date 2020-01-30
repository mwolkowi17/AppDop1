using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDop1;

namespace AppDop.Dane
{
    public class ZbiorDanych
    {
        public static List<PlanszaTypB> PlanszePodsumowojace { get; set; }
        public static List<IkonaApp> IkonyProgramu { get; set; }
        public static List<PlanszaTypA>PlanszePoczatkowe { get; set; }
        public static List<PlanszaTypC>PlanszePomoc { get; set; }

        static ZbiorDanych()
        {
            PlanszePodsumowojace = new List<PlanszaTypB>();
            PlanszePodsumowojace.Add(new PlanszaTypB(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pytanie1.jpg", "nowe"));
            PlanszePodsumowojace.Add(new PlanszaTypB(2, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pytanie2.jpg", "nowe2"));
            PlanszePodsumowojace.Add(new PlanszaTypB(3, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pytanie3.jpg", "nowe3"));
            PlanszePodsumowojace.Add(new PlanszaTypB(4, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pytanie4.jpg", "nowe4"));
            PlanszePodsumowojace.Add(new PlanszaTypB(5, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pytanie5.jpg", "nowe5"));
            PlanszePodsumowojace.Add(new PlanszaTypB(6, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pytanie6.jpg", "nowe6"));
            PlanszePodsumowojace.Add(new PlanszaTypB(7, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pytanie7.jpg", "nowe7"));

            IkonyProgramu = new List<IkonaApp>();

            IkonyProgramu.Add(new IkonaApp(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona1_wersja2.png", "Ikona1"));
            IkonyProgramu.Add(new IkonaApp(2, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona2.png", "Ikona2"));
            IkonyProgramu.Add(new IkonaApp(3, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona3.png", "Ikona3"));
            IkonyProgramu.Add(new IkonaApp(3, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\trojkat_dalej.png", "strzalka_dalej"));
            IkonyProgramu.Add(new IkonaApp(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona1_wersja2b.png", "Ikona4"));
            IkonyProgramu.Add(new IkonaApp(2, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona2b.png", "Ikona5"));
            IkonyProgramu.Add(new IkonaApp(3, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\D1_ikona3b.png", "Ikona6"));
            IkonyProgramu.Add(new IkonaApp(3, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\trojkat_dalej2.png", "strzalka_dalej"));

            PlanszePoczatkowe = new List<PlanszaTypA>();

            PlanszePoczatkowe.Add(new PlanszaTypA(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\grzyby_app.jpg", "nowe1"));
            PlanszePoczatkowe.Add(new PlanszaTypA(2, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\grzyby_app2.jpg", "nowe2"));
            PlanszePoczatkowe.Add(new PlanszaTypA(3, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\grzyby_app3.jpg", "nowe3"));
            PlanszePoczatkowe.Add(new PlanszaTypA(4, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\grzyby_app4.jpg", "nowe4"));
            PlanszePoczatkowe.Add(new PlanszaTypA(5, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\grzyby_app5.jpg", "nowe5"));
            PlanszePoczatkowe.Add(new PlanszaTypA(6, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\grzyby_app6.jpg", "nowe6"));

            PlanszePomoc = new List<PlanszaTypC>();

            PlanszePomoc.Add(new PlanszaTypC(1, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc1_2x.jpg", "nowe1"));
            PlanszePomoc.Add(new PlanszaTypC(2, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc2_2x.jpg", "nowe2"));
            PlanszePomoc.Add(new PlanszaTypC(3, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc3A_2x.jpg", "nowe3"));
            PlanszePomoc.Add(new PlanszaTypC(4, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc3B_2x.jpg", "nowe4"));
            PlanszePomoc.Add(new PlanszaTypC(5, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc4A_2x.jpg", "nowe5"));
            PlanszePomoc.Add(new PlanszaTypC(6, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc5A_2x.jpg", "nowe6"));
            PlanszePomoc.Add(new PlanszaTypC(7, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc5B_2x.jpg", "nowe7"));
            PlanszePomoc.Add(new PlanszaTypC(8, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc6A_2x.jpg", "nowe8"));
            PlanszePomoc.Add(new PlanszaTypC(9, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc6B_2x.jpg", "nowe9"));
            PlanszePomoc.Add(new PlanszaTypC(10, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc6C_2x.jpg", "nowe10"));
            PlanszePomoc.Add(new PlanszaTypC(11, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc7_2x.jpg", "nowe11"));
            PlanszePomoc.Add(new PlanszaTypC(12, @"C:\Users\Marcin\source\repos\EduAppProba\Grafiki\pierwsza_pomoc8_2x.jpg", "nowe12"));
        }
    }
}
