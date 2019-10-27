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
        private static int kacsaNum = 0;
        public int kacsaID;

        public Kacsa(int kora, bool ivarerett, bool nem, string tollazat) : base(kora, ivarerett, nem)
        {
            Tollazat = tollazat;
            kacsaID = kacsaNum++;
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

        public int getKacsaNum()
        {
            return kacsaNum;
        }
        ~Kacsa() 
        {
            kacsaNum--;
        }

        public override string ToString()
        {
            return kacsaID + " " + getMegnevezes() + " (" + AllatNum + ")";
        }

        public string KacsaAdatok()
        {
            string Kacsa_adatok = $"ID: {kacsaID}\n"
                + $"Tollazat: {Tollazat} " + getMegnevezes() + "\n"
                + $"Kora: {Kora}\n";
            return Kacsa_adatok;
        }
    }
}
