using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllatokForms
{
    public partial class Form1 : Form
    {
        int OsszesAllat = 0;
        int OsszesKacsa = 0;
        int OsszesKutya = 0;
        List<Kutya> kutyak = new List<Kutya>();
        List<Kacsa> kacsak = new List<Kacsa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kiirja_Kozepre_A_Peldanyszamokat();
            comboBox_Kutya_Fajta.SelectedIndex = 353;
        }

        private void button_Kutyat_hozzaad_Click(object sender, EventArgs e)
        {
            int kora = (int)numeric_Kutya_Eletkor.Value;
            bool ivarerett = false;
            if (checkBox_Kutya_Ivarerett.Checked)
            {
                ivarerett = true;
            }
            bool neme = radioButton_Kutya_Him.Checked ? true : false;

            Kutya uj = new Kutya(kora, ivarerett, neme, comboBox_Kutya_Fajta.SelectedItem.ToString());
            listBox_Kutyak.Items.Add(uj.ToString());
            OsszesKutya = uj.getKutyaID();
            OsszesAllat = uj.getAllatID();
            kutyak.Add(uj);
            Kiirja_Kozepre_A_Peldanyszamokat();
        }
        private void Kiirja_Kozepre_A_Peldanyszamokat()
        {
            label_Osszes_allat.Text = "Összesen " + OsszesAllat + " állatpéldány";
            label_Kutyafalka.Text = "A falkában " + OsszesKutya + " kutya van";
            label_KacsakSzama.Text = "Kacsák száma " + OsszesKacsa + " db";
        }

        private void button_Kacsat_hozzaad_Click(object sender, EventArgs e)
        {
            int kora = (int)numeric_Kacsa_Kora.Value;
            bool ivarerett = false;
            if (checkBox_Kacsa_Ivarerett.Checked)
            {
                ivarerett = true;
            }
            bool neme = radioButton_Kacsa_Him.Checked ? true : false;
            Kacsa uj = new Kacsa(kora, ivarerett, neme, comboBox_Kacsa_tollazat.SelectedItem.ToString());
            listBox_Kacsak.Items.Add(uj.ToString());
            OsszesKacsa = uj.getKacsaID();
            OsszesAllat = uj.getAllatID();
            Kiirja_Kozepre_A_Peldanyszamokat();
            kacsak.Add(uj);
        }
    }
}
