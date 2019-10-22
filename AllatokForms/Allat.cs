using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokForms
{
    class Allat
    {
        private static int allatID = 0;
        private int kora;
        private bool ivarerett;
        private bool nem;

        protected int Kora { get => kora; set => kora = value; }
        protected bool Ivarerett { get => ivarerett; set => ivarerett = value; }
        protected bool Nem { get => nem; set => nem = value; }
        public static int AllatID { get => allatID; }

        public Allat(int kora, bool ivarerett, bool nem)
        {
            Kora = kora;
            Ivarerett = ivarerett;
            Nem = nem;
            ++allatID;
        }
        public int getAllatID()
        {
            return allatID;
        }
        ~Allat()
        {
            allatID--;
        }
    }
}
