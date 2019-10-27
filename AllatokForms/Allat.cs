using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokForms
{
    class Allat
    {
        private static int allatNum = 0;
        private int kora;
        private bool ivarerett;
        private bool nem;

        public int Kora { get => kora; set => kora = value; }
        public bool Ivarerett { get => ivarerett; set => ivarerett = value; }
        public bool Nem { get => nem; set => nem = value; }
        public int AllatNum { get => allatNum; }

        public Allat(int kora, bool ivarerett, bool nem)
        {
            Kora = kora;
            Ivarerett = ivarerett;
            Nem = nem;
            ++allatNum;
        }
        ~Allat()
        {
            allatNum--;
            Console.WriteLine("Allat destruktor fut...");
        }
    }
}
