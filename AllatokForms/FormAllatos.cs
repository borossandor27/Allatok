﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AllatokForms
{
    public partial class FormAllatos : Form
    {
        int OsszesAllat = 0;
        int OsszesKacsa = 0;
        int OsszesKutya = 0;

        //-- a listában kiválasztott egyedek tárolására
        Kutya kivalasztottKutya;
        Kacsa kivalasztottKacsa;

        //-- A listában az egyedeknek csak néhány tulajdonsága látszik, ezért listában is tároljuk őket
        List<Kutya> kutyak = new List<Kutya>();
        List<Kacsa> kacsak = new List<Kacsa>();

        //-- nehogymá kéteszer kellejen beírnom! ---
        string FajlFilter = "Pontosvesszővel tagolt szövegfájl (*.csv)|*.csv|Egyszerű szövegfájl (*.txt)|*.txt|All files (*.*)|*.*";

        public FormAllatos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kiirja_Kozepre_A_Peldanyszamokat();
            comboBox_Kutya_Fajta.SelectedIndex = 353; //-- alapértelmezett elemet állít be
            comboBox_Kacsa_tollazat.SelectedIndex = 0;  //-- alapértelmezett elemet állít be
        }

        /// <summary>
        ///     A beviteli mezők adatai alapján új egyedet hoz létre
        /// </summary>
        /// <param name="sender">Az eseményt kiváltó objektum</param>
        /// <param name="e">Az esemény jellemzői</param>
        private void button_Kutyat_hozzaad_Click(object sender, EventArgs e)
        {
            //-- kiolvassuk a beviteli mezőkből az egyedet jellemző adatokat --------------
            int kora = (int)numeric_Kutya_Eletkor.Value;
            bool ivarerett = false;
                ivarerett = checkBox_Kutya_Ivarerett.Checked;
            bool neme = radioButton_Kutya_Him.Checked ? true : false;
            string fajta = comboBox_Kutya_Fajta.SelectedItem.ToString();

            //-- adatok alapján új egyed létrehozása --------------------------------------
            Kutya uj = new Kutya(kora, ivarerett, neme, fajta);

            //-- Ellenőrzöm, hogy szerepel-e már ezekkel az adatokkal jellemzett egyed ----
            if (kutyak.Exists(x => x.Kora==kora && x.Ivarerett == ivarerett && x.Nem==neme && x.Fajta.Equals(fajta)))
            {
                DialogResult valasz = MessageBox.Show("A listában már szerepel ilyen egyed!\nMégis felveszi a listába?", "Figyelem!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (valasz==DialogResult.No)
                {
                    return;
                }
            }
            //-- Új egyedet láthatóvá tesszük a lista segítségével -------------------------
            listBox_Kutyak.Items.Add(uj.ToString());

            //-- Az új egyedet felvesszük a listába ----------------------------------------
            kutyak.Add(uj);

            Kiirja_Kozepre_A_Peldanyszamokat();
        }

        /// <summary>
        ///     A statisztikai adatokat megjeleníti a középső panelen ----------------------
        /// </summary>
        private void Kiirja_Kozepre_A_Peldanyszamokat()
        {
            //-- Aktualizáljuk a statisztikai adatokat -------------------------------------
            OsszesKutya = listBox_Kutyak.Items.Count;
            OsszesKacsa = listBox_Kacsak.Items.Count;
            OsszesAllat = OsszesKacsa + OsszesKutya;

            label_Osszes_allat.Text = "Összesen " + OsszesAllat + " állatpéldány";
            Panel_Kozepere(label_Osszes_allat);
            label_Kutyafalka.Text = "A falkában " + OsszesKutya + " kutya van";
            Panel_Kozepere(label_Kutyafalka);
            label_KacsakSzama.Text = "Kacsák száma " + OsszesKacsa + " db";
            Panel_Kozepere(label_KacsakSzama);
        }

        /// <summary>
        ///     A középső panelen vízszintesen középre igazítja a kapott szöveget
        /// </summary>
        /// <param name="cimke">Az igazítandó szöveg</param>
        private void Panel_Kozepere(Label cimke)
        {
            int w = cimke.Parent.Width; //-- a középső panel pillanatnyi szélessége pixelben 
            cimke.Left = (w - cimke.Width) / 2; //-- a címke relatív távolsága a panel bal szélétől pixelben
        }

        /// <summary>
        ///     A beviteli mezők adatai alapján új egyedet hoz létre
        /// </summary>
        /// <param name="sender">Az eseményt kiváltó objektum</param>
        /// <param name="e">Az esemény jellemzői</param>
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
            Kiirja_Kozepre_A_Peldanyszamokat();
            kacsak.Add(uj);
        }

        /// <summary>
        /// A listában kiválasztott elem adataival aktualizálja a többi objektumot. Az így kijelölt egyed a listából eltávolíthatóvá válik.
        /// </summary>
        /// <param name="sender">Az eseményt kiváltó objektum</param>
        /// <param name="e"></param>
        private void listBox_Kutyak_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-- A listában való kijelölés teszi lehetővé a törlést -------------------------------
            string[] sor = listBox_Kutyak.SelectedItem.ToString().Split();
            int kutyaID = int.Parse(sor[0]);
            kivalasztottKutya = kutyak.Find(x => x.KutyaID == kutyaID);
            KutyadatokUpdate();
        }

        private void KutyadatokUpdate()
        {
            numeric_Kutya_Eletkor.Value = kivalasztottKutya.Kora;
            checkBox_Kutya_Ivarerett.Checked = kivalasztottKutya.Ivarerett;
            comboBox_Kutya_Fajta.SelectedItem = kivalasztottKutya.Fajta;
 
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
        }

        /// <summary>
        ///     A listában kiválasztott elem adataival aktualizálja a többi objektumot. Az így kijelölt egyed a listából eltávolíthatóvá válik.
        /// </summary>
        /// <param name="sender">Az eseményt kiváltó objektum</param>
        /// <param name="e"></param>
        private void listBox_Kacsak_SelectedIndexChanged(object sender, EventArgs e)
        {
            //-- első lépés a kiválasztott egyed azonosítójának a meghatározása. 
            string[] sor = listBox_Kacsak.SelectedItem.ToString().Split();
            int kacsaID = int.Parse(sor[0]);    //-- A listbox sorában az első adat szóközzel határolva

            //-- Az azonosító osmeretében meghatározom a kiválasztott egyedet
            kivalasztottKacsa = kacsak.Find(x => x.kacsaID == kacsaID);
            Kacsaadatok_Update();
        }
        /// <summary>
        ///      A választásnak megfelelően aktualizálom a beviteli mezőket
        /// </summary>
        private void Kacsaadatok_Update()
        {
            numeric_Kacsa_Kora.Value = kivalasztottKacsa.Kora;
            checkBox_Kacsa_Ivarerett.Checked = kivalasztottKacsa.Ivarerett;
            comboBox_Kacsa_tollazat.SelectedItem = kivalasztottKacsa.Tollazat;
            if (kivalasztottKacsa.Nem)
            {
                radioButton_Kacsa_Him.Checked = true;
                radioButton_Kacsa_Nosteny.Checked = false;
            }
            else
            {
                radioButton_Kacsa_Him.Checked = false;
                radioButton_Kacsa_Nosteny.Checked = true;
            }
        }

        private void button_Kutya_Eltavolit_Click(object sender, EventArgs e)
        {

            DialogResult valasztas = MessageBox.Show(kivalasztottKutya.KutyaAdatok() + "\n\nvalóban törli ezt a példányt?", "Pédány törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (valasztas==DialogResult.Yes)
            {
                kutyak.Remove(kivalasztottKutya);
                //-- A megmaradt példányokkal újratöltjük a listát
                listBox_Kutyak.Items.Clear();
                foreach (var item in kutyak)
                {
                    listBox_Kutyak.Items.Add(item.ToString());
                }
                Kiirja_Kozepre_A_Peldanyszamokat();            }
        }

        /// <summary>
        /// A Kacsák listában kiválasztott elemet eltávolítja
        /// </summary>
        /// <param name="sender">Az eseményt kiváltó objektum</param>
        /// <param name="e"></param>
        private void button_Kacsa_Eltavolit_Click(object sender, EventArgs e)
        {
            DialogResult valasztas = MessageBox.Show(kivalasztottKacsa.KacsaAdatok() + "\n\nvalóban törli ezt a példányt?", "Pédány törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (valasztas == DialogResult.Yes)
            {
                kacsak.Remove(kivalasztottKacsa);
                listBox_Kacsak.Items.Clear();
                foreach (var item in kacsak)
                {
                    listBox_Kacsak.Items.Add(item.ToString());
                }
                if (kacsak.Count > 0)
                {
                    listBox_Kacsak.SelectedIndex = 0;
                }
                Kacsaadatok_Update();
                Kiirja_Kozepre_A_Peldanyszamokat();
            }
        }

        /// <summary>
        /// A kutyákat adatait szövegfájlba írja
        /// </summary>
        /// <param name="sender">Az eseményt kiváltó objektum</param>
        /// <param name="e"></param>
        private void button_Kutya_Kiir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory == "" ? Convert.ToString(Environment.SpecialFolder.MyDocuments) : saveFileDialog1.InitialDirectory;
            saveFileDialog1.Title = "Kutyák adatainak az elmentése...";
            saveFileDialog1.Filter = FajlFilter;
            saveFileDialog1.FileName = "kutyaAdatok.csv";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Trim().Length > 0)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        foreach (Kutya item in kutyak)
                        {
                            sw.WriteLine(item.FajlbaIr());
                        }
                    }
                }
                catch (IOException err)
                {
                    MessageBox.Show(err.Message);
                    throw;
                }
            }
        }

        private void button_Kutyat_Betolt_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show(listBox_Kutyak.Items.Count > 0 ? "Lecseréli a listának a tartalmát a fájlban lévő adatokra?":"Szeretné fájlból beolvasni az adatokat?", "Adatok betöltése", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.AddExtension = true;
                openFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory == "" ? Convert.ToString(Environment.SpecialFolder.MyDocuments) : openFileDialog1.InitialDirectory;
                openFileDialog1.Title = "Kutyák adatainak a visszatöltése...";
                openFileDialog1.Filter = FajlFilter;
                openFileDialog1.FileName = "kutyaAdatok.csv";

                if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Trim().Length > 0)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                        {
                            listBox_Kutyak.Items.Clear();
                            kutyak.Clear();
                            while (!sr.EndOfStream)
                            {
                                string[] sor = sr.ReadLine().Split(';');
                                int kutyaID = int.Parse(sor[0]);
                                string Fajta = sor[1];
                                bool Ivarerett = bool.Parse(sor[2]);
                                bool Nem = bool.Parse(sor[3]);
                                int Kora = int.Parse(sor[4]);
                                Kutya uj = new Kutya(Kora, Ivarerett, Nem, Fajta);
                                kutyak.Add(uj);

                                listBox_Kutyak.Items.Add(uj.ToString());
                            }
                            OsszesKutya = listBox_Kutyak.Items.Count;
                            OsszesAllat = OsszesKutya + OsszesKacsa;
                            Kiirja_Kozepre_A_Peldanyszamokat();
                        }
                    }
                    catch (IOException err)
                    {
                        MessageBox.Show(err.Message);
                        throw;
                    }
                }
            }        
        }

        private void button_Kacsat_Kiir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory == "" ? Convert.ToString(Environment.SpecialFolder.MyDocuments) : saveFileDialog1.InitialDirectory;
            saveFileDialog1.Title = "Kacsák adatainak az elmentése...";
            saveFileDialog1.Filter = FajlFilter;
            saveFileDialog1.FileName = "kacsaAdatok.csv";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Trim().Length > 0)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        foreach (Kacsa item in kacsak)
                        {
                            sw.WriteLine(item.FajlbaIr());
                        }
                    }
                }
                catch (IOException err)
                {
                    MessageBox.Show(err.Message);
                    throw;
                }
            }

        }

        private void button_Kacsat_Betolt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(listBox_Kutyak.Items.Count > 0 ? "Lecseréli a listának a tartalmát a fájlban lévő adatokra?" : "Szeretné fájlból beolvasni az adatokat?", "Adatok betöltése", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.AddExtension = true;
                openFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory == "" ? Convert.ToString(Environment.SpecialFolder.MyDocuments) : openFileDialog1.InitialDirectory;
                openFileDialog1.Title = "Kacsák adatainak a visszatöltése...";
                openFileDialog1.Filter = FajlFilter;
                openFileDialog1.FileName = "kacsaAdatok.csv";

                if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Trim().Length > 0)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                        {
                            listBox_Kacsak.Items.Clear();
                            kacsak.Clear();
                            while (!sr.EndOfStream)
                            {
                                string[] sor = sr.ReadLine().Split(';');
                                int kacsaID = int.Parse(sor[0]);
                                string tollazat = sor[1];
                                bool Ivarerett = bool.Parse(sor[2]);
                                bool Nem = bool.Parse(sor[3]);
                                int Kora = int.Parse(sor[4]);
                                Kacsa uj = new Kacsa(Kora, Ivarerett, Nem, tollazat);
                                kacsak.Add(uj);

                                listBox_Kacsak.Items.Add(uj.ToString());
                            }
                            OsszesKacsa = listBox_Kacsak.Items.Count;
                            OsszesAllat = OsszesKutya + OsszesKacsa;
                            Kiirja_Kozepre_A_Peldanyszamokat();
                        }
                    }
                    catch (IOException err)
                    {
                        MessageBox.Show(err.Message);
                        throw;
                    }
                }
            }
        }
    }
}
