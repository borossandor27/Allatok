using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokForms
{
    class Kutya : Allat
    {
        private static int kutyaID = 0;
        public string Fajta;

        public Kutya(int kora, bool ivarerett, bool nem, string fajta) : base(kora, ivarerett, nem)
        {
            Fajta = fajta;
            ++kutyaID;
        }

        public string getMegnevezes()
        {
            if (Ivarerett)
            {
                return Nem ? "kan" : "szuka";
            }
            else
            {
                return "kölyök";
            }
        }

        public int getKutyaID()
        {
            return kutyaID;
        }

        ~Kutya()
        {
            kutyaID--;
        }

        public override string ToString()
        {
            return kutyaID + " " + Fajta + " " + getMegnevezes() + " (" + AllatID + ")";
        }
    }
}
