using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDop1
{
    public class PlanszaTypC
    {
        public int PlanszaTypCId { get; set; }
        public string PlanszaTypCAdress { get; set; }
        public string PlanszaTypCNazwa { get; set; }

        public PlanszaTypC(int id, string adress, string nazwa)
        {
            PlanszaTypCId = id;
            PlanszaTypCAdress = adress;
            PlanszaTypCNazwa = nazwa;

        }

        public override string ToString()
        {
            return PlanszaTypCId + " " + PlanszaTypCAdress + " " + PlanszaTypCNazwa;

        }
    }
}
