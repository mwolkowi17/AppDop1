﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDop1
{
    public class PlanszaTypA
    {
        public int PlanszaTypAId { get; set; }
        public string PlanszaTypAAdress { get; set; }
        public string PlanszaTypANazwa { get; set; }

        public PlanszaTypA(int id, string adress, string nazwa)
        {
            PlanszaTypAId = id;
            PlanszaTypAAdress = adress;
            PlanszaTypANazwa = nazwa;

        }

        public override string ToString()
        {
            return PlanszaTypAId + " " + PlanszaTypAAdress + " " + PlanszaTypANazwa;

        }
    }
}
