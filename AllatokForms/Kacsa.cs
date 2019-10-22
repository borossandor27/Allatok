using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokForms
{
    class Kacsa : Allat
    {
        public string Tollazat;
        private static int kacsaID;

        public Kacsa(int kora, bool ivarerett, bool nem, string tollazat) : base(kora, ivarerett, nem)
        {
            Tollazat = tollazat;
            kacsaID++;
        }
        public string getMegnevezes()
        {
            if (Ivarerett)
            {
                return (Nem) ? "gácsér" : "tojó";
            }
            else
            {
                return "csibe";
            }
        }

        public int getKacsaID()
        {
            return kacsaID;
        }
        ~Kacsa()
        {
            kacsaID--;
        }

        public override string ToString()
        {
            return kacsaID + " " + getMegnevezes() + " (" + AllatID + ")";
        }
    }
}
