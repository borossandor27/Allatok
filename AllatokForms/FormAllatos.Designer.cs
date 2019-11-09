namespace AllatokForms
{
    partial class FormAllatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllatos));
            this.panel_Kutya = new System.Windows.Forms.Panel();
            this.comboBox_Kutya_Fajta = new System.Windows.Forms.ComboBox();
            this.listBox_Kutyak = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Kutya_Nosteny = new System.Windows.Forms.RadioButton();
            this.radioButton_Kutya_Him = new System.Windows.Forms.RadioButton();
            this.checkBox_Kutya_Ivarerett = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_Kutya_Eletkor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Kacsa = new System.Windows.Forms.Panel();
            this.button_Kacsat_Betolt = new System.Windows.Forms.Button();
            this.comboBox_Kacsa_tollazat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Kacsak = new System.Windows.Forms.ListBox();
            this.numeric_Kacsa_Kora = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Kacsa_Nosteny = new System.Windows.Forms.RadioButton();
            this.radioButton_Kacsa_Him = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Kacsa_Ivarerett = new System.Windows.Forms.CheckBox();
            this.panel_Kozepso = new System.Windows.Forms.Panel();
            this.label_KacsakSzama = new System.Windows.Forms.Label();
            this.label_Kutyafalka = new System.Windows.Forms.Label();
            this.label_Osszes_allat = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_Kacsa_Eltavolit = new System.Windows.Forms.Button();
            this.button_Kacsat_Kiir = new System.Windows.Forms.Button();
            this.button_Kacsat_hozzaad = new System.Windows.Forms.Button();
            this.button_Kutyat_Betolt = new System.Windows.Forms.Button();
            this.button_Kutya_Kiir = new System.Windows.Forms.Button();
            this.button_Kutya_Eltavolit = new System.Windows.Forms.Button();
            this.button_Kutyat_hozzaad = new System.Windows.Forms.Button();
            this.panel_Kutya.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Kutya_Eletkor)).BeginInit();
            this.panel_Kacsa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Kacsa_Kora)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel_Kozepso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Kutya
            // 
            this.panel_Kutya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Kutya.Controls.Add(this.button_Kutyat_Betolt);
            this.panel_Kutya.Controls.Add(this.button_Kutya_Kiir);
            this.panel_Kutya.Controls.Add(this.comboBox_Kutya_Fajta);
            this.panel_Kutya.Controls.Add(this.button_Kutya_Eltavolit);
            this.panel_Kutya.Controls.Add(this.button_Kutyat_hozzaad);
            this.panel_Kutya.Controls.Add(this.listBox_Kutyak);
            this.panel_Kutya.Controls.Add(this.groupBox1);
            this.panel_Kutya.Controls.Add(this.checkBox_Kutya_Ivarerett);
            this.panel_Kutya.Controls.Add(this.label3);
            this.panel_Kutya.Controls.Add(this.numeric_Kutya_Eletkor);
            this.panel_Kutya.Controls.Add(this.label1);
            this.panel_Kutya.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Kutya.Location = new System.Drawing.Point(0, 0);
            this.panel_Kutya.Name = "panel_Kutya";
            this.panel_Kutya.Size = new System.Drawing.Size(252, 510);
            this.panel_Kutya.TabIndex = 0;
            // 
            // comboBox_Kutya_Fajta
            // 
            this.comboBox_Kutya_Fajta.FormattingEnabled = true;
            this.comboBox_Kutya_Fajta.Items.AddRange(new object[] {
            "Abruzzói juhászkutya",
            "Afgán agár",
            "Afrikai oroszlánkutya",
            "Ainu",
            "Airedale terrier",
            "Akbash",
            "Akita",
            "Alaszkai malamut",
            "Amerikai bulldog",
            "Amerikai cocker spániel",
            "Amerikai-kanadai juhászkutya",
            "Amerikai pit bullterrier",
            "Amerikai rókakopó",
            "Amerikai staffordshire terrier",
            "Amerikai vízispániel",
            "Anatóliai juhászkutya",
            "Angol agár",
            "Angol bulldog",
            "Angol cocker spániel",
            "Angol masztiff",
            "Angol mosómedvekopó",
            "Angol rókakopó",
            "Angol springer spániel",
            "Angol szetter",
            "Angol véreb",
            "Angol véreb",
            "Appenzelli pásztorkutya",
            "Arab agár",
            "Arany ( Golden ) retriever",
            "Ardenni pásztorkutya",
            "Argentin dog",
            "Ariége-I kopó",
            "Ariége-I vizsla",
            "Artois-I kopó",
            "Atlasz-hegységi kutya",
            "Ausztrál juhászkutya",
            "Ausztrál pásztorkutya",
            "Ausztrál selyemszőrű terrier",
            "Ausztrál terrier",
            "Auvergne-I vizsla",
            "Azawakh",
            "Bajor hegyi véreb",
            "Balkáni kopó",
            "Barbet",
            "Basenji",
            "Basset artésien normand",
            "Basset bleu de Gascogne",
            "Basset fauve de Bretagne",
            "Basset griffon vendéen",
            "Basset hound",
            "Beagle",
            "Beagle harrier",
            "Bearded collie",
            "Beauce-I juhászkutya",
            "Bedlington terrier",
            "Belga griffon",
            "Belga vizsla",
            "Belga masztiff",
            "Bergamói juhászkutya",
            "Bernáthegyi kutya",
            "Berni kopó",
            "Berni pásztorkutya",
            "Bichon frisé",
            "Billy",
            "Bolognai pincs",
            "Bolonka cvetna",
            "Bolonka francuska",
            "Bordeaux-I dog",
            "Border collie",
            "Border terrier",
            "Boston terrier",
            "Boszniai drótszőrű kopó",
            "Bourbonne-I vizsla",
            "Brabacon",
            "Brazil kopó",
            "Breton spániel",
            "Brie-I juhászkutya",
            "Broholmer",
            "Brüsszeli griffon",
            "Bullmasztiff",
            "Bullterrier",
            "Bullterrier ( miniatűr )",
            "Burgosi vizsla",
            "Cairn terrier",
            "Cane corso",
            "Catahoulai leopárdkutya",
            "Cavalier King Charles spániel",
            "Chesapeake bay retriever",
            "Cirneco dell\'Etna",
            "Clumber spániel",
            "Coton de Tulear",
            "Csau-csau",
            "Cseh szálkás szőrű vizsla",
            "Cseh terrier",
            "Csivava",
            "Dalmata",
            "Dandie Dinmont terrier",
            "Délorosz juházkutya",
            "Dobermann",
            "Drenti vizsla",
            "Drever",
            "Drótszőrű griffon",
            "Dunker",
            "Dupuy-I vizsla",
            "Elghund",
            "Entlebuchi pásztorkutya",
            "Erdélyi kopó",
            "Eszkimó kutya",
            "Eurázsiai",
            "Európai orosz lajka",
            "Észt kopó",
            "Fáraókutya",
            "Fekete cser mosómedvekutya",
            "Fekete terrier",
            "Field  spániel",
            "Fila brasileiro",
            "Finn kopó",
            "Finn spicc",
            "Flandriai pásztorkutya",
            "Foxterrier, drótszőrű",
            "Foxterrier, sima szőrű",
            "Francia bulldog",
            "Francia háromszínű kopó",
            "Francia kétszínű kopó",
            "Francia spániel",
            "Francia vizsla ( pirénei )",
            "Francia vizsla ( gascogne-i )",
            "Fürjészeb",
            "Gascogne-I kis kék griffon",
            "Glen of Imaal terrier",
            "Gordon szetter",
            "Göndör szőrű retriever",
            "Görög kopó",
            "Griffon Fauve de Bretagne",
            "Groenandael",
            "Grönlandi kutya",
            "Gyapjas szörű griffon",
            "Halden kopó",
            "Hamilton kopó",
            "Hannoveri véreb",
            "Harlekin pincser",
            "Havannai pincs",
            "Holland pásztorkutya ",
            "Holland pásztorkutya ",
            "Holland pásztorkutya ",
            "Horvát juhászkutya",
            "Hovawart",
            "Hygenhund",
            "Ibizai kopó",
            "Ír farkaskutya",
            "Ír szetter",
            "Ír terrier",
            "Ír vízispániel",
            "Isztriai drótszőrű kopó",
            "Isztriai rövid szőrű kopó",
            "Izlandi juhászkutya",
            "Jack Russel terrier",
            "Jämthund",
            "Japán spániel",
            "Japán spicc",
            "Japán terrier",
            "Jugoszláv háromszínű kopó",
            "Jugoszláv hegyi kopó",
            "Jurai kopó",
            "Kai",
            "Kánaán kutya",
            "Kanári-szigeteki kutya",
            "Karéliai finn lajka",
            "Karéliai medvevadász kutya",
            "Katalán pásztorkutya",
            "Kaukázusi juhászkutya",
            "Keeshond",
            "Kék pettyes mosómedvekopó",
            "Kelet-szibériai lajka",
            "Kelpie",
            "Kenguruagár",
            "Kerry blue terrier",
            "Kínai harcikutya",
            "Kínai kopaszkutya",
            "King Charles spániel",
            "Kis angol terrier",
            "Kishu",
            "Kis Gascon-Saintongeoisi kopó",
            "Kis kék gascogne-I kopó",
            "Kis münszterlandi vizsla",
            "Kis olasz agár",
            "Kis oroszlánkutya",
            "Kis svájci kopó ( berni )",
            "Kis svájci kopó ( jurai )",
            "Kis svájci kopó ( luzerni)",
            "Kis svájci kopó ( schwyzi)",
            "Kooikerhond",
            "Komondor",
            "Közép-ázsiai juhászkutya",
            "Kras-medencei juhászkutya",
            "Kromfohrländer",
            "Kuvasz",
            "Labrador retriever",
            "Laekenois",
            "Lagotto",
            "Lakeland terrier",
            "Landseer",
            "Lappföldi spicc",
            "Lapp pásztorkutya",
            "Lengyel-alföldi pásztorkutya",
            "Lengyel kopó",
            "Leonbergi",
            "Lett kopo",
            "Levesque",
            "Lhasa apso",
            "Litván kopó",
            "Lundehund",
            "Luzerni kopó",
            "Magyar agár",
            "Magyar vizsla, drótszőrű",
            "Magyar vizsla, rövid szőrű",
            "Majompincs",
            "Malinois",
            "Mallorcai masztiff",
            "Mallorcai pásztorkutya",
            "Máltai selyemszőrű kutya",
            "Manchester terrier",
            "Mopsz",
            "Moszkvai dog",
            "Moszkvai őrkutya",
            "Mudi",
            "Nagy angol-francia háromszínű kopó",
            "Nagy angol-francia kétszínű kopó",
            "Nagy kék gascogne-I kopó",
            "Nagy münszterlandi vizsla",
            "Nagy svájci pásztorkutya",
            "Nápolyi masztiff",
            "Német boxer",
            "Német dog",
            "Német juhászkutya",
            "Német kopó",
            "Német spicc, közép",
            "Német spicc, nagy",
            "Német spicc, törpe",
            "Német vizsla, drótszőrű",
            "Német vizsla, hosszú szőrű",
            "Német vizsla, rövid szőrű",
            "Német vizsla, szálkás szőrű",
            "Nivernais-I griffon",
            "Norfolk terrier",
            "Normand poitevin",
            "Norrbotteni spicc",
            "Norvégiai buhund",
            "Norwich terrier",
            "Nyugat-szibériai lajka",
            "Nyulászkopó",
            "Óangol juhászkutya",
            "Olasz griffon",
            "Olasz kopó",
            "Olasz viszla",
            "Orosz agár",
            "Orosz foltos kopó",
            "Orosz kopó",
            "Orosz spániel",
            "Osztrák kopó",
            "Osztrák rövid szőrű pincser",
            "Ősi dán vizsla",
            "Papillon",
            "Pekingi palotakutya",
            "Perzsa agár",
            "Phaléne",
            "Picardiai juhászkutya",
            "Picardiai kék spániel",
            "Picardiai spániel",
            "Pincser",
            "Pireneusi hegyikutya",
            "Pireneusi juhászkutya félhosszú szőrű",
            "Pireneusi juhászkutya hosszú szőrű",
            "Pireneusi masztiff",
            "Plott kutya",
            "Pointer",
            "Pointevin",
            "Pomerániai törpespicc",
            "Pont-audeméri spániel",
            "Porcelánkopó",
            "Portugál hegyikutya",
            "Portugál kopó ( közép )",
            "Portugál kopó ( nagy )",
            "Portugál kopó ( törpe )",
            "Portugál őrzőkutya",
            "Portugál pásztokutya",
            "Portugál vízikutya",
            "Portugál vizsla",
            "Pudelpointer",
            "Puli",
            "Pumi",
            "Román pásztorkutya",
            "Rottweiler",
            "Saarloosi farkaskutya",
            "Saint Germain-I vizsla",
            "Sarplaninai juhászkutya",
            "Schapendoes ",
            "Schiller kopó",
            "Schipperke",
            "Schnauzer ( közép )",
            "Schnauzer ( óriás )",
            "Schnauzer ( törpe )",
            "Schwyzi kopó",
            "Sealyham terrier",
            "Serra de Aires-I juhászkutya",
            "Setlandi juhászkutya",
            "Shiba",
            "Shikoku",
            "Si-cu",
            "Sima szőrű retriever",
            "Skót juhászkutya ( rövid szőrű )",
            "Skót juhászkutya ( rövid szőrű )",
            "Skót szarvasagár",
            "Skót terrier",
            "Skye terrier",
            "Smalandi kopó",
            "Smoushond",
            "Soft-coated wheaten terrier",
            "Sommerset harrier",
            "Spanyol agár",
            "Spanyol kopó",
            "Spanyol masztiff",
            "Spanyol vízikutya",
            "Stabyhoun",
            "Staffordshire bullterrier",
            "Stíriai drótszőrű kopó",
            "Sussex spániel",
            "Svéd juhászkutya",
            "Szamojéd",
            "Szávavölgyi kopó",
            "Szibériai hushy",
            "Szíriai pásztorkutya",
            "Szlovák csuvacs",
            "Szlovák drótszőrű vizsla",
            "Szlovák kopó",
            "Szürke rénszarvasvadász kutya",
            "Tacskó ( hosszú szőrű )",
            "Tacskó ( rövid szőrű )",
            "Tacskó ( szálkás szőrű )",
            "Tacskókopó",
            "Tátrai juhászkutya",
            "Telomian",
            "Tennessee treening brindle",
            "Tervueren",
            "Tibeti masztiff",
            "Tibeti spániel",
            "Tibeti terrier",
            "Tiroliu kopó",
            "Tosa",
            "Törpe foxterrier",
            "Törpepincser",
            "Treening walker mosómedvekopó",
            "Trigg hound",
            "Újfundlandi",
            "Uszkár ( közép )",
            "Uszkár ( óriás )",
            "Uszkár ( törpe )",
            "Vadászterrier",
            "Vadkacsavadász retriever",
            "Vendéen-I griffon kopó",
            "Vendéen-I nagy griffon",
            "Vidravadász kopó",
            "Virelade",
            "Volpino",
            "Vörös mosómedvekopó",
            "Vörös pettyes mosómedvekopó",
            "Weimari vizsla",
            "Welsh Corgi, Cardigan",
            "Welsh Corgi, Pembroke",
            "Welsh Springer spániel",
            "Welsh terrier",
            "Westfáliai tacskókopó",
            "West Highland White terrier",
            "Wetterhoun",
            "Whippet",
            "Xoloitzcuintle",
            "Yorkshire terrier"});
            this.comboBox_Kutya_Fajta.Location = new System.Drawing.Point(14, 332);
            this.comboBox_Kutya_Fajta.Name = "comboBox_Kutya_Fajta";
            this.comboBox_Kutya_Fajta.Size = new System.Drawing.Size(189, 21);
            this.comboBox_Kutya_Fajta.TabIndex = 8;
            // 
            // listBox_Kutyak
            // 
            this.listBox_Kutyak.FormattingEnabled = true;
            this.listBox_Kutyak.Location = new System.Drawing.Point(16, 28);
            this.listBox_Kutyak.Name = "listBox_Kutyak";
            this.listBox_Kutyak.Size = new System.Drawing.Size(206, 147);
            this.listBox_Kutyak.TabIndex = 6;
            this.listBox_Kutyak.SelectedIndexChanged += new System.EventHandler(this.listBox_Kutyak_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Kutya_Nosteny);
            this.groupBox1.Controls.Add(this.radioButton_Kutya_Him);
            this.groupBox1.Location = new System.Drawing.Point(16, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Az állat neme";
            // 
            // radioButton_Kutya_Nosteny
            // 
            this.radioButton_Kutya_Nosteny.AutoSize = true;
            this.radioButton_Kutya_Nosteny.Location = new System.Drawing.Point(7, 44);
            this.radioButton_Kutya_Nosteny.Name = "radioButton_Kutya_Nosteny";
            this.radioButton_Kutya_Nosteny.Size = new System.Drawing.Size(64, 17);
            this.radioButton_Kutya_Nosteny.TabIndex = 1;
            this.radioButton_Kutya_Nosteny.TabStop = true;
            this.radioButton_Kutya_Nosteny.Text = "Nőstény";
            this.radioButton_Kutya_Nosteny.UseVisualStyleBackColor = true;
            // 
            // radioButton_Kutya_Him
            // 
            this.radioButton_Kutya_Him.AutoSize = true;
            this.radioButton_Kutya_Him.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Kutya_Him.Name = "radioButton_Kutya_Him";
            this.radioButton_Kutya_Him.Size = new System.Drawing.Size(45, 17);
            this.radioButton_Kutya_Him.TabIndex = 0;
            this.radioButton_Kutya_Him.TabStop = true;
            this.radioButton_Kutya_Him.Text = "Hím";
            this.radioButton_Kutya_Him.UseVisualStyleBackColor = true;
            // 
            // checkBox_Kutya_Ivarerett
            // 
            this.checkBox_Kutya_Ivarerett.AutoSize = true;
            this.checkBox_Kutya_Ivarerett.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_Kutya_Ivarerett.Location = new System.Drawing.Point(13, 299);
            this.checkBox_Kutya_Ivarerett.Name = "checkBox_Kutya_Ivarerett";
            this.checkBox_Kutya_Ivarerett.Size = new System.Drawing.Size(65, 17);
            this.checkBox_Kutya_Ivarerett.TabIndex = 4;
            this.checkBox_Kutya_Ivarerett.Text = "Ivarérett";
            this.checkBox_Kutya_Ivarerett.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Életkora";
            // 
            // numeric_Kutya_Eletkor
            // 
            this.numeric_Kutya_Eletkor.Location = new System.Drawing.Point(63, 262);
            this.numeric_Kutya_Eletkor.Name = "numeric_Kutya_Eletkor";
            this.numeric_Kutya_Eletkor.Size = new System.Drawing.Size(70, 20);
            this.numeric_Kutya_Eletkor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(59, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kutyák";
            // 
            // panel_Kacsa
            // 
            this.panel_Kacsa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Kacsa.Controls.Add(this.button_Kacsa_Eltavolit);
            this.panel_Kacsa.Controls.Add(this.button_Kacsat_Betolt);
            this.panel_Kacsa.Controls.Add(this.button_Kacsat_Kiir);
            this.panel_Kacsa.Controls.Add(this.comboBox_Kacsa_tollazat);
            this.panel_Kacsa.Controls.Add(this.button_Kacsat_hozzaad);
            this.panel_Kacsa.Controls.Add(this.label2);
            this.panel_Kacsa.Controls.Add(this.listBox_Kacsak);
            this.panel_Kacsa.Controls.Add(this.numeric_Kacsa_Kora);
            this.panel_Kacsa.Controls.Add(this.groupBox2);
            this.panel_Kacsa.Controls.Add(this.label4);
            this.panel_Kacsa.Controls.Add(this.checkBox_Kacsa_Ivarerett);
            this.panel_Kacsa.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Kacsa.Location = new System.Drawing.Point(654, 0);
            this.panel_Kacsa.Name = "panel_Kacsa";
            this.panel_Kacsa.Size = new System.Drawing.Size(246, 510);
            this.panel_Kacsa.TabIndex = 1;
            // 
            // button_Kacsat_Betolt
            // 
            this.button_Kacsat_Betolt.Image = global::AllatokForms.Properties.Resources.Hopstarter_Soft_Scraps_Folder_Open;
            this.button_Kacsat_Betolt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kacsat_Betolt.Location = new System.Drawing.Point(133, 436);
            this.button_Kacsat_Betolt.Name = "button_Kacsat_Betolt";
            this.button_Kacsat_Betolt.Size = new System.Drawing.Size(100, 46);
            this.button_Kacsat_Betolt.TabIndex = 9;
            this.button_Kacsat_Betolt.Text = "Betölt";
            this.button_Kacsat_Betolt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Kacsat_Betolt.UseVisualStyleBackColor = true;
            this.button_Kacsat_Betolt.Click += new System.EventHandler(this.button_Kacsat_Betolt_Click);
            // 
            // comboBox_Kacsa_tollazat
            // 
            this.comboBox_Kacsa_tollazat.FormattingEnabled = true;
            this.comboBox_Kacsa_tollazat.Items.AddRange(new object[] {
            "sárga",
            "tarka",
            "fehér",
            "barna",
            "nem tom"});
            this.comboBox_Kacsa_tollazat.Location = new System.Drawing.Point(31, 334);
            this.comboBox_Kacsa_tollazat.Name = "comboBox_Kacsa_tollazat";
            this.comboBox_Kacsa_tollazat.Size = new System.Drawing.Size(190, 21);
            this.comboBox_Kacsa_tollazat.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(76, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kacsák";
            // 
            // listBox_Kacsak
            // 
            this.listBox_Kacsak.FormattingEnabled = true;
            this.listBox_Kacsak.Location = new System.Drawing.Point(25, 28);
            this.listBox_Kacsak.Name = "listBox_Kacsak";
            this.listBox_Kacsak.Size = new System.Drawing.Size(204, 147);
            this.listBox_Kacsak.TabIndex = 6;
            this.listBox_Kacsak.SelectedIndexChanged += new System.EventHandler(this.listBox_Kacsak_SelectedIndexChanged);
            // 
            // numeric_Kacsa_Kora
            // 
            this.numeric_Kacsa_Kora.Location = new System.Drawing.Point(80, 264);
            this.numeric_Kacsa_Kora.Name = "numeric_Kacsa_Kora";
            this.numeric_Kacsa_Kora.Size = new System.Drawing.Size(70, 20);
            this.numeric_Kacsa_Kora.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Kacsa_Nosteny);
            this.groupBox2.Controls.Add(this.radioButton_Kacsa_Him);
            this.groupBox2.Location = new System.Drawing.Point(31, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Az állat neme";
            // 
            // radioButton_Kacsa_Nosteny
            // 
            this.radioButton_Kacsa_Nosteny.AutoSize = true;
            this.radioButton_Kacsa_Nosteny.Location = new System.Drawing.Point(7, 44);
            this.radioButton_Kacsa_Nosteny.Name = "radioButton_Kacsa_Nosteny";
            this.radioButton_Kacsa_Nosteny.Size = new System.Drawing.Size(64, 17);
            this.radioButton_Kacsa_Nosteny.TabIndex = 1;
            this.radioButton_Kacsa_Nosteny.TabStop = true;
            this.radioButton_Kacsa_Nosteny.Text = "Nőstény";
            this.radioButton_Kacsa_Nosteny.UseVisualStyleBackColor = true;
            // 
            // radioButton_Kacsa_Him
            // 
            this.radioButton_Kacsa_Him.AutoSize = true;
            this.radioButton_Kacsa_Him.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Kacsa_Him.Name = "radioButton_Kacsa_Him";
            this.radioButton_Kacsa_Him.Size = new System.Drawing.Size(45, 17);
            this.radioButton_Kacsa_Him.TabIndex = 0;
            this.radioButton_Kacsa_Him.TabStop = true;
            this.radioButton_Kacsa_Him.Text = "Hím";
            this.radioButton_Kacsa_Him.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Életkora";
            // 
            // checkBox_Kacsa_Ivarerett
            // 
            this.checkBox_Kacsa_Ivarerett.AutoSize = true;
            this.checkBox_Kacsa_Ivarerett.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_Kacsa_Ivarerett.Location = new System.Drawing.Point(30, 301);
            this.checkBox_Kacsa_Ivarerett.Name = "checkBox_Kacsa_Ivarerett";
            this.checkBox_Kacsa_Ivarerett.Size = new System.Drawing.Size(65, 17);
            this.checkBox_Kacsa_Ivarerett.TabIndex = 4;
            this.checkBox_Kacsa_Ivarerett.Text = "Ivarérett";
            this.checkBox_Kacsa_Ivarerett.UseVisualStyleBackColor = true;
            // 
            // panel_Kozepso
            // 
            this.panel_Kozepso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_Kozepso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Kozepso.Controls.Add(this.label_KacsakSzama);
            this.panel_Kozepso.Controls.Add(this.label_Kutyafalka);
            this.panel_Kozepso.Controls.Add(this.label_Osszes_allat);
            this.panel_Kozepso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Kozepso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel_Kozepso.Location = new System.Drawing.Point(252, 0);
            this.panel_Kozepso.Name = "panel_Kozepso";
            this.panel_Kozepso.Size = new System.Drawing.Size(402, 510);
            this.panel_Kozepso.TabIndex = 2;
            // 
            // label_KacsakSzama
            // 
            this.label_KacsakSzama.AutoSize = true;
            this.label_KacsakSzama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_KacsakSzama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_KacsakSzama.Location = new System.Drawing.Point(45, 147);
            this.label_KacsakSzama.Name = "label_KacsakSzama";
            this.label_KacsakSzama.Size = new System.Drawing.Size(70, 25);
            this.label_KacsakSzama.TabIndex = 0;
            this.label_KacsakSzama.Text = "label5";
            // 
            // label_Kutyafalka
            // 
            this.label_Kutyafalka.AutoSize = true;
            this.label_Kutyafalka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Kutyafalka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_Kutyafalka.Location = new System.Drawing.Point(45, 93);
            this.label_Kutyafalka.Name = "label_Kutyafalka";
            this.label_Kutyafalka.Size = new System.Drawing.Size(70, 25);
            this.label_Kutyafalka.TabIndex = 0;
            this.label_Kutyafalka.Text = "label5";
            // 
            // label_Osszes_allat
            // 
            this.label_Osszes_allat.AutoSize = true;
            this.label_Osszes_allat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Osszes_allat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_Osszes_allat.Location = new System.Drawing.Point(45, 28);
            this.label_Osszes_allat.Name = "label_Osszes_allat";
            this.label_Osszes_allat.Size = new System.Drawing.Size(70, 25);
            this.label_Osszes_allat.TabIndex = 0;
            this.label_Osszes_allat.Text = "label5";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Kacsa_Eltavolit
            // 
            this.button_Kacsa_Eltavolit.Image = global::AllatokForms.Properties.Resources.Close_icon;
            this.button_Kacsa_Eltavolit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kacsa_Eltavolit.Location = new System.Drawing.Point(133, 376);
            this.button_Kacsa_Eltavolit.Name = "button_Kacsa_Eltavolit";
            this.button_Kacsa_Eltavolit.Size = new System.Drawing.Size(100, 35);
            this.button_Kacsa_Eltavolit.TabIndex = 11;
            this.button_Kacsa_Eltavolit.Text = "Eltávolít";
            this.button_Kacsa_Eltavolit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Kacsa_Eltavolit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Kacsa_Eltavolit.UseVisualStyleBackColor = true;
            this.button_Kacsa_Eltavolit.Click += new System.EventHandler(this.button_Kacsa_Eltavolit_Click);
            // 
            // button_Kacsat_Kiir
            // 
            this.button_Kacsat_Kiir.Image = global::AllatokForms.Properties.Resources.Actions_document_save_icon;
            this.button_Kacsat_Kiir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kacsat_Kiir.Location = new System.Drawing.Point(18, 436);
            this.button_Kacsat_Kiir.Name = "button_Kacsat_Kiir";
            this.button_Kacsat_Kiir.Size = new System.Drawing.Size(100, 46);
            this.button_Kacsat_Kiir.TabIndex = 10;
            this.button_Kacsat_Kiir.Text = "Fájlba ír";
            this.button_Kacsat_Kiir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Kacsat_Kiir.UseVisualStyleBackColor = true;
            this.button_Kacsat_Kiir.Click += new System.EventHandler(this.button_Kacsat_Kiir_Click);
            // 
            // button_Kacsat_hozzaad
            // 
            this.button_Kacsat_hozzaad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Kacsat_hozzaad.Image = global::AllatokForms.Properties.Resources.add_icon;
            this.button_Kacsat_hozzaad.Location = new System.Drawing.Point(18, 376);
            this.button_Kacsat_hozzaad.Name = "button_Kacsat_hozzaad";
            this.button_Kacsat_hozzaad.Size = new System.Drawing.Size(100, 35);
            this.button_Kacsat_hozzaad.TabIndex = 7;
            this.button_Kacsat_hozzaad.Text = "Hozzáad";
            this.button_Kacsat_hozzaad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Kacsat_hozzaad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Kacsat_hozzaad.UseVisualStyleBackColor = true;
            this.button_Kacsat_hozzaad.Click += new System.EventHandler(this.button_Kacsat_hozzaad_Click);
            // 
            // button_Kutyat_Betolt
            // 
            this.button_Kutyat_Betolt.Image = global::AllatokForms.Properties.Resources.Hopstarter_Soft_Scraps_Folder_Open;
            this.button_Kutyat_Betolt.Location = new System.Drawing.Point(128, 436);
            this.button_Kutyat_Betolt.Name = "button_Kutyat_Betolt";
            this.button_Kutyat_Betolt.Size = new System.Drawing.Size(100, 46);
            this.button_Kutyat_Betolt.TabIndex = 9;
            this.button_Kutyat_Betolt.Text = "Betölt";
            this.button_Kutyat_Betolt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Kutyat_Betolt.UseVisualStyleBackColor = true;
            this.button_Kutyat_Betolt.Click += new System.EventHandler(this.button_Kutyat_Betolt_Click);
            // 
            // button_Kutya_Kiir
            // 
            this.button_Kutya_Kiir.Image = global::AllatokForms.Properties.Resources.Actions_document_save_icon;
            this.button_Kutya_Kiir.Location = new System.Drawing.Point(14, 436);
            this.button_Kutya_Kiir.Name = "button_Kutya_Kiir";
            this.button_Kutya_Kiir.Size = new System.Drawing.Size(100, 46);
            this.button_Kutya_Kiir.TabIndex = 10;
            this.button_Kutya_Kiir.Text = "Fájlba ír";
            this.button_Kutya_Kiir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Kutya_Kiir.UseVisualStyleBackColor = true;
            this.button_Kutya_Kiir.Click += new System.EventHandler(this.button_Kutya_Kiir_Click);
            // 
            // button_Kutya_Eltavolit
            // 
            this.button_Kutya_Eltavolit.Image = ((System.Drawing.Image)(resources.GetObject("button_Kutya_Eltavolit.Image")));
            this.button_Kutya_Eltavolit.Location = new System.Drawing.Point(128, 376);
            this.button_Kutya_Eltavolit.Name = "button_Kutya_Eltavolit";
            this.button_Kutya_Eltavolit.Size = new System.Drawing.Size(100, 35);
            this.button_Kutya_Eltavolit.TabIndex = 7;
            this.button_Kutya_Eltavolit.Text = "Eltávolít";
            this.button_Kutya_Eltavolit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Kutya_Eltavolit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Kutya_Eltavolit.UseVisualStyleBackColor = true;
            this.button_Kutya_Eltavolit.Click += new System.EventHandler(this.button_Kutya_Eltavolit_Click);
            // 
            // button_Kutyat_hozzaad
            // 
            this.button_Kutyat_hozzaad.Image = ((System.Drawing.Image)(resources.GetObject("button_Kutyat_hozzaad.Image")));
            this.button_Kutyat_hozzaad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kutyat_hozzaad.Location = new System.Drawing.Point(14, 376);
            this.button_Kutyat_hozzaad.Name = "button_Kutyat_hozzaad";
            this.button_Kutyat_hozzaad.Size = new System.Drawing.Size(100, 35);
            this.button_Kutyat_hozzaad.TabIndex = 7;
            this.button_Kutyat_hozzaad.Text = "Hozzáad";
            this.button_Kutyat_hozzaad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kutyat_hozzaad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Kutyat_hozzaad.UseVisualStyleBackColor = true;
            this.button_Kutyat_hozzaad.Click += new System.EventHandler(this.button_Kutyat_hozzaad_Click);
            // 
            // FormAllatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.panel_Kozepso);
            this.Controls.Add(this.panel_Kacsa);
            this.Controls.Add(this.panel_Kutya);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAllatos";
            this.Text = "- Öröklődés - inheritence -";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Kutya.ResumeLayout(false);
            this.panel_Kutya.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Kutya_Eletkor)).EndInit();
            this.panel_Kacsa.ResumeLayout(false);
            this.panel_Kacsa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Kacsa_Kora)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_Kozepso.ResumeLayout(false);
            this.panel_Kozepso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Kutya;
        private System.Windows.Forms.Panel panel_Kacsa;
        private System.Windows.Forms.Panel panel_Kozepso;
        private System.Windows.Forms.NumericUpDown numeric_Kutya_Eletkor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Kutyat_hozzaad;
        private System.Windows.Forms.ListBox listBox_Kutyak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Kutya_Nosteny;
        private System.Windows.Forms.RadioButton radioButton_Kutya_Him;
        private System.Windows.Forms.CheckBox checkBox_Kutya_Ivarerett;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Kacsat_hozzaad;
        private System.Windows.Forms.ListBox listBox_Kacsak;
        private System.Windows.Forms.NumericUpDown numeric_Kacsa_Kora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Kacsa_Nosteny;
        private System.Windows.Forms.RadioButton radioButton_Kacsa_Him;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Kacsa_Ivarerett;
        private System.Windows.Forms.Label label_KacsakSzama;
        private System.Windows.Forms.Label label_Kutyafalka;
        private System.Windows.Forms.Label label_Osszes_allat;
        private System.Windows.Forms.ComboBox comboBox_Kutya_Fajta;
        private System.Windows.Forms.ComboBox comboBox_Kacsa_tollazat;
        private System.Windows.Forms.Button button_Kutyat_Betolt;
        private System.Windows.Forms.Button button_Kutya_Kiir;
        private System.Windows.Forms.Button button_Kutya_Eltavolit;
        private System.Windows.Forms.Button button_Kacsa_Eltavolit;
        private System.Windows.Forms.Button button_Kacsat_Betolt;
        private System.Windows.Forms.Button button_Kacsat_Kiir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

