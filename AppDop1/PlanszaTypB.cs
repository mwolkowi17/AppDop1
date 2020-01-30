using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDop1
{
   public class PlanszaTypB
    {
        public int PlanszaTypBId { get; set; }
        public string PlanszaTypBAdress { get; set; }
        public string PlanszaTypBNazwa { get; set; }

        public PlanszaTypB(int id, string adress, string nazwa)
        {
            PlanszaTypBId = id;
            PlanszaTypBAdress = adress;
            PlanszaTypBNazwa = nazwa;

        }

        public override string ToString()
        {
            return PlanszaTypBId + " " + PlanszaTypBAdress + " " + PlanszaTypBNazwa;

        }
    }
}
