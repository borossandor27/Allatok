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
    public partial class FormAllatos : Form
    {
        int OsszesAllat = 0;
        int OsszesKacsa = 0;
        int OsszesKutya = 0;
        Kutya kivalasztottKutya;
        Kacsa kivalasztottKacsa;
        List<Kutya> kutyak = new List<Kutya>();
        List<Kacsa> kacsak = new List<Kacsa>();
        public FormAllatos()
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

            string fajta = comboBox_Kutya_Fajta.SelectedItem.ToString();
            Kutya uj = new Kutya(kora, ivarerett, neme, fajta);
            if (kutyak.Exists(x => x.Kora==kora && x.Ivarerett == ivarerett && x.Nem==neme && x.Fajta.Equals(fajta)))
            {
                DialogResult valasz = MessageBox.Show("A listában már szerepel ilyen egyed!\nMégis felveszi a listába?", "Figyelem!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (valasz==DialogResult.No)
                {
                    return;
                }
            }
            listBox_Kutyak.Items.Add(uj.ToString());
            OsszesKutya = listBox_Kutyak.Items.Count;
            OsszesAllat = OsszesKutya + OsszesKacsa;
            kutyak.Add(uj);
            Kiirja_Kozepre_A_Peldanyszamokat();
        }
        private void Kiirja_Kozepre_A_Peldanyszamokat()
        {
            label_Osszes_allat.Text = "Összesen " + OsszesAllat + " állatpéldány";
            Panel_Kozepere(label_Osszes_allat);
            label_Kutyafalka.Text = "A falkában " + OsszesKutya + " kutya van";
            Panel_Kozepere(label_Kutyafalka);
            label_KacsakSzama.Text = "Kacsák száma " + OsszesKacsa + " db";
            Panel_Kozepere(label_KacsakSzama);
        }
        private void Panel_Kozepere(Label cimke)
        {
            int w = cimke.Parent.Width;
            cimke.Left = (w - cimke.Width) / 2;
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
            OsszesKacsa = listBox_Kacsak.Items.Count;
            OsszesAllat = OsszesKacsa + OsszesKutya;
            Kiirja_Kozepre_A_Peldanyszamokat();
            kacsak.Add(uj);
        }

        private void listBox_Kutyak_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] sor = listBox_Kutyak.SelectedItem.ToString().Split();
            int kutyaID = int.Parse(sor[0]);
            kivalasztottKutya = kutyak.Find(x => x.KutyaID == kutyaID);
            if (kivalasztottKutya.Nem)
            {
                radioButton_Kutya_Him.Checked = true;
                radioButton_Kutya_Nosteny.Checked = false;
            }
            else
            {
                radioButton_Kutya_Him.Checked = false;
                radioButton_Kutya_Nosteny.Checked = true;
            }
            numeric_Kutya_Eletkor.Value = kivalasztottKutya.Kora;
            checkBox_Kutya_Ivarerett.Checked = kivalasztottKutya.Ivarerett;
            comboBox_Kutya_Fajta.SelectedItem = kivalasztottKutya.Fajta;
        }

        private void listBox_Kacsak_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] sor = listBox_Kacsak.SelectedItem.ToString().Split();
            int kacsaID = int.Parse(sor[0]);
            kivalasztottKacsa = kacsak.Find(x => x.kacsaID == kacsaID);
            if (kivalasztottKacsa.Nem)
            {
                radioButton_Kacsa_Him.Checked = true;
            }
            else
            {
                radioButton_Kacsa_Nosteny.Checked = true;
            }
            numeric_Kacsa_Kora.Value = kivalasztottKacsa.Kora;
            checkBox_Kacsa_Ivarerett.Checked = kivalasztottKacsa.Ivarerett;
            comboBox_Kacsa_tollazat.SelectedItem = kivalasztottKacsa.Tollazat;
        }

        private void button_Kutya_Eltavolit_Click(object sender, EventArgs e)
        {

            DialogResult valasztas = MessageBox.Show(kivalasztottKutya.KutyaAdatok() + "\n\nvalóban törli ezt a példányt?", "Pédány törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (valasztas==DialogResult.Yes)
            {
                kutyak.Remove(kivalasztottKutya);
                listBox_Kutyak.Items.Clear();
                foreach (var item in kutyak)
                {
                    listBox_Kutyak.Items.Add(item.ToString());
                }
                OsszesKutya--;
                OsszesAllat--;
                GC.SuppressFinalize(kivalasztottKutya); //-- A GC külön szálon fut, ezért vélhetően nem fog lefutni futásidőben.
                Console.WriteLine(kivalasztottKutya.Fajta);
            }
        }

        private void button_Kacsa_Eltavolit_Click(object sender, EventArgs e)
        {
            DialogResult valasztas = MessageBox.Show(kivalasztottKacsa.KacsaAdatok() + "\n\nvalóban törli ezt a példányt?", "Pédány törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (valasztas == DialogResult.Yes)
            {
                kacsak.Remove(kivalasztottKacsa);
                listBox_Kutyak.Items.Clear();
                foreach (var item in kacsak)
                {
                    listBox_Kacsak.Items.Add(item.ToString());
                }
                OsszesKacsa--;
                OsszesAllat--;
                GC.SuppressFinalize(kivalasztottKutya);
                Console.WriteLine(kivalasztottKutya.Fajta);
            }
        }
    }
}
