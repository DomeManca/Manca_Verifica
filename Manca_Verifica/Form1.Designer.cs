namespace Manca_Verifica
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Materia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataA = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.aggiungi = new System.Windows.Forms.Button();
            this.calcola = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.MateriaA = new System.Windows.Forms.DomainUpDown();
            this.ValutazioneA = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MateriaM = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.seleziona = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.VotoMo = new System.Windows.Forms.DomainUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ValutazioneMo = new System.Windows.Forms.DomainUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DataMo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.MateriaMo = new System.Windows.Forms.DomainUpDown();
            this.Modifica = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.VotoE = new System.Windows.Forms.DomainUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Elimina = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Materia,
            this.Voto,
            this.Data});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(441, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(347, 413);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Materia
            // 
            this.Materia.Text = "Materia";
            // 
            // Voto
            // 
            this.Voto.Text = "Voto";
            // 
            // Data
            // 
            this.Data.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Voto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // DataA
            // 
            this.DataA.CustomFormat = "";
            this.DataA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataA.Location = new System.Drawing.Point(109, 120);
            this.DataA.Name = "DataA";
            this.DataA.Size = new System.Drawing.Size(169, 20);
            this.DataA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Elenco voti";
            // 
            // aggiungi
            // 
            this.aggiungi.Location = new System.Drawing.Point(346, 393);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(75, 23);
            this.aggiungi.TabIndex = 9;
            this.aggiungi.Text = "Aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // calcola
            // 
            this.calcola.Location = new System.Drawing.Point(346, 394);
            this.calcola.Name = "calcola";
            this.calcola.Size = new System.Drawing.Size(75, 23);
            this.calcola.TabIndex = 10;
            this.calcola.Text = "Calcola";
            this.calcola.UseVisualStyleBackColor = true;
            this.calcola.Click += new System.EventHandler(this.calcola_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 449);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.MateriaA);
            this.tabPage1.Controls.Add(this.ValutazioneA);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.aggiungi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.DataA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aggiungi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "* Valutazione in centesimi";
            // 
            // MateriaA
            // 
            this.MateriaA.Items.Add("Italiano");
            this.MateriaA.Items.Add("Inglese");
            this.MateriaA.Items.Add("Matematica");
            this.MateriaA.Items.Add("Storia");
            this.MateriaA.Items.Add("Informatica");
            this.MateriaA.Items.Add("TPSI");
            this.MateriaA.Items.Add("Telecomunicazioni");
            this.MateriaA.Items.Add("Motoria");
            this.MateriaA.Items.Add("Religione");
            this.MateriaA.Location = new System.Drawing.Point(109, 49);
            this.MateriaA.Name = "MateriaA";
            this.MateriaA.ReadOnly = true;
            this.MateriaA.Size = new System.Drawing.Size(169, 20);
            this.MateriaA.TabIndex = 13;
            // 
            // ValutazioneA
            // 
            this.ValutazioneA.Items.Add("10");
            this.ValutazioneA.Items.Add("15");
            this.ValutazioneA.Items.Add("20");
            this.ValutazioneA.Items.Add("25");
            this.ValutazioneA.Items.Add("30");
            this.ValutazioneA.Items.Add("35");
            this.ValutazioneA.Items.Add("40");
            this.ValutazioneA.Items.Add("45");
            this.ValutazioneA.Items.Add("50");
            this.ValutazioneA.Items.Add("55");
            this.ValutazioneA.Items.Add("60");
            this.ValutazioneA.Items.Add("65");
            this.ValutazioneA.Items.Add("70");
            this.ValutazioneA.Items.Add("75");
            this.ValutazioneA.Items.Add("80");
            this.ValutazioneA.Items.Add("85");
            this.ValutazioneA.Items.Add("90");
            this.ValutazioneA.Items.Add("95");
            this.ValutazioneA.Items.Add("100");
            this.ValutazioneA.Location = new System.Drawing.Point(109, 76);
            this.ValutazioneA.Name = "ValutazioneA";
            this.ValutazioneA.ReadOnly = true;
            this.ValutazioneA.Size = new System.Drawing.Size(169, 20);
            this.ValutazioneA.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seleziona tutti i campi e premi il bottone \"Aggiungi\"";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MateriaM);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.calcola);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(427, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Media";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MateriaM
            // 
            this.MateriaM.Items.Add("Italiano");
            this.MateriaM.Items.Add("Inglese");
            this.MateriaM.Items.Add("Matematica");
            this.MateriaM.Items.Add("Storia");
            this.MateriaM.Items.Add("Informatica");
            this.MateriaM.Items.Add("TPSI");
            this.MateriaM.Items.Add("Telecomunicazioni");
            this.MateriaM.Items.Add("Motoria");
            this.MateriaM.Items.Add("Religione");
            this.MateriaM.Location = new System.Drawing.Point(11, 48);
            this.MateriaM.Name = "MateriaM";
            this.MateriaM.ReadOnly = true;
            this.MateriaM.Size = new System.Drawing.Size(169, 20);
            this.MateriaM.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Media";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Materia :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Selezionala materia e premi il bottone \"Calcola\" per visualizzare la media";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.seleziona);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.VotoMo);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.ValutazioneMo);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.DataMo);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.MateriaMo);
            this.tabPage3.Controls.Add(this.Modifica);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(427, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modifica";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // seleziona
            // 
            this.seleziona.Location = new System.Drawing.Point(274, 28);
            this.seleziona.Name = "seleziona";
            this.seleziona.Size = new System.Drawing.Size(75, 23);
            this.seleziona.TabIndex = 30;
            this.seleziona.Text = "Selezoina";
            this.seleziona.UseVisualStyleBackColor = true;
            this.seleziona.Click += new System.EventHandler(this.seleziona_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(148, 198);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 26);
            this.label21.TabIndex = 29;
            this.label21.Text = "Seleziona una valutazione\r\n\r\n";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Voto";
            // 
            // VotoMo
            // 
            this.VotoMo.Location = new System.Drawing.Point(99, 31);
            this.VotoMo.Name = "VotoMo";
            this.VotoMo.ReadOnly = true;
            this.VotoMo.Size = new System.Drawing.Size(169, 20);
            this.VotoMo.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Voto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(96, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "* Valutazione in centesimi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 26);
            this.label10.TabIndex = 25;
            this.label10.Text = "Seleziona una valutazione\r\n\r\n";
            // 
            // ValutazioneMo
            // 
            this.ValutazioneMo.Items.Add("10");
            this.ValutazioneMo.Items.Add("15");
            this.ValutazioneMo.Items.Add("20");
            this.ValutazioneMo.Items.Add("25");
            this.ValutazioneMo.Items.Add("30");
            this.ValutazioneMo.Items.Add("35");
            this.ValutazioneMo.Items.Add("40");
            this.ValutazioneMo.Items.Add("45");
            this.ValutazioneMo.Items.Add("50");
            this.ValutazioneMo.Items.Add("55");
            this.ValutazioneMo.Items.Add("60");
            this.ValutazioneMo.Items.Add("65");
            this.ValutazioneMo.Items.Add("70");
            this.ValutazioneMo.Items.Add("75");
            this.ValutazioneMo.Items.Add("80");
            this.ValutazioneMo.Items.Add("85");
            this.ValutazioneMo.Items.Add("90");
            this.ValutazioneMo.Items.Add("95");
            this.ValutazioneMo.Items.Add("100");
            this.ValutazioneMo.Location = new System.Drawing.Point(99, 113);
            this.ValutazioneMo.Name = "ValutazioneMo";
            this.ValutazioneMo.ReadOnly = true;
            this.ValutazioneMo.Size = new System.Drawing.Size(169, 20);
            this.ValutazioneMo.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Materia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Voto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Data";
            // 
            // DataMo
            // 
            this.DataMo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataMo.Location = new System.Drawing.Point(99, 156);
            this.DataMo.Name = "DataMo";
            this.DataMo.Size = new System.Drawing.Size(169, 20);
            this.DataMo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Seleziona tutti i campi e premi il bottone \"Modifica\"";
            // 
            // MateriaMo
            // 
            this.MateriaMo.Items.Add("Italiano");
            this.MateriaMo.Items.Add("Inglese");
            this.MateriaMo.Items.Add("Matematica");
            this.MateriaMo.Items.Add("Storia");
            this.MateriaMo.Items.Add("Informatica");
            this.MateriaMo.Items.Add("TPSI");
            this.MateriaMo.Items.Add("Telecomunicazioni");
            this.MateriaMo.Items.Add("Motoria");
            this.MateriaMo.Items.Add("Religione");
            this.MateriaMo.Location = new System.Drawing.Point(99, 91);
            this.MateriaMo.Name = "MateriaMo";
            this.MateriaMo.ReadOnly = true;
            this.MateriaMo.Size = new System.Drawing.Size(169, 20);
            this.MateriaMo.TabIndex = 18;
            // 
            // Modifica
            // 
            this.Modifica.Location = new System.Drawing.Point(340, 388);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(75, 23);
            this.Modifica.TabIndex = 17;
            this.Modifica.Text = "Modifica";
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Voto";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.VotoE);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.Elimina);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(427, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Elimina";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Voto";
            // 
            // VotoE
            // 
            this.VotoE.Location = new System.Drawing.Point(99, 27);
            this.VotoE.Name = "VotoE";
            this.VotoE.ReadOnly = true;
            this.VotoE.Size = new System.Drawing.Size(169, 20);
            this.VotoE.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 13);
            this.label22.TabIndex = 32;
            this.label22.Text = "Voto";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 26);
            this.label23.TabIndex = 31;
            this.label23.Text = "Seleziona una valutazione\r\n\r\n";
            // 
            // Elimina
            // 
            this.Elimina.Location = new System.Drawing.Point(346, 393);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(75, 23);
            this.Elimina.TabIndex = 18;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = true;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.listView2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(427, 423);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ordina per data";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Enter += new System.EventHandler(this.tabPage5_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Elenco ordinato per data";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(8, 29);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(413, 390);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Materia";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Voto";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Libretto";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.Button calcola;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DomainUpDown MateriaA;
        private System.Windows.Forms.DomainUpDown ValutazioneA;
        private System.Windows.Forms.DomainUpDown MateriaM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DataMo;
        private System.Windows.Forms.DomainUpDown MateriaMo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Materia;
        private System.Windows.Forms.ColumnHeader Voto;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DomainUpDown ValutazioneMo;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DomainUpDown VotoMo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button seleziona;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DomainUpDown VotoE;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

