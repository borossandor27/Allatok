using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokForms
{
    class Kutya : Allat
    {
        private static int kutyaNum = 0;
        private int kutyaID;
        public string Fajta;

        public int KutyaID { get => kutyaID;}

        public Kutya(int kora, bool ivarerett, bool nem, string fajta) : base(kora, ivarerett, nem)
        {
            Fajta = fajta;
            kutyaID = kutyaNum++;
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

        public int getKutyaNum()
        {
            return kutyaNum;
        }

        ~Kutya()
        {
            kutyaNum--;
            Console.WriteLine("Kutya destruktor fut...");
        }

        public override string ToString()
        {
            return kutyaID + " " + Fajta + " " + getMegnevezes() + " (" + AllatNum + ")";
        }

        public string KutyaAdatok()
        {
            string Kutya_adatok = $"ID: {KutyaID}\n"
                + $"Fajta: {Fajta} " + getMegnevezes() + "\n"
                + $"Kora: {Kora}\n";
            return Kutya_adatok;
        }

        public string FajlbaIr()
        {
            return string.Join(";", this.kutyaID, this.Fajta, this.Ivarerett, this.Nem, this.Kora);
        }

    }
}
