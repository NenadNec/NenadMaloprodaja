namespace Maloprodaja
{
    partial class frmPodesavanje
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
            this.cbRezimObuke = new System.Windows.Forms.CheckBox();
            this.cbStampajLogo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewPoreskeStope = new System.Windows.Forms.ListView();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbOmoguciNacinePlacanja = new System.Windows.Forms.GroupBox();
            this.cbInstantPlacanje = new System.Windows.Forms.CheckBox();
            this.cbCek = new System.Windows.Forms.CheckBox();
            this.cbPlatnaKartica = new System.Windows.Forms.CheckBox();
            this.cbGotovina = new System.Windows.Forms.CheckBox();
            this.cbDrugo = new System.Windows.Forms.CheckBox();
            this.cbVaucer = new System.Windows.Forms.CheckBox();
            this.cbPrenosNaRacun = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbOmoguciNacinePlacanja.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRezimObuke
            // 
            this.cbRezimObuke.AutoSize = true;
            this.cbRezimObuke.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRezimObuke.Location = new System.Drawing.Point(14, 18);
            this.cbRezimObuke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRezimObuke.Name = "cbRezimObuke";
            this.cbRezimObuke.Size = new System.Drawing.Size(132, 22);
            this.cbRezimObuke.TabIndex = 0;
            this.cbRezimObuke.Text = "Režim obuke";
            this.cbRezimObuke.UseVisualStyleBackColor = true;
            this.cbRezimObuke.CheckedChanged += new System.EventHandler(this.cbRezimObuke_CheckedChanged);
            // 
            // cbStampajLogo
            // 
            this.cbStampajLogo.AutoSize = true;
            this.cbStampajLogo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStampajLogo.Location = new System.Drawing.Point(14, 69);
            this.cbStampajLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbStampajLogo.Name = "cbStampajLogo";
            this.cbStampajLogo.Size = new System.Drawing.Size(136, 22);
            this.cbStampajLogo.TabIndex = 1;
            this.cbStampajLogo.Text = "Štampaj logo";
            this.cbStampajLogo.UseVisualStyleBackColor = true;
            this.cbStampajLogo.CheckedChanged += new System.EventHandler(this.cbStampajLogo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.cbRezimObuke);
            this.panel1.Controls.Add(this.cbStampajLogo);
            this.panel1.Location = new System.Drawing.Point(14, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 487);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "PARAMETRI";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.listViewPoreskeStope);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Location = new System.Drawing.Point(392, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 487);
            this.panel2.TabIndex = 3;
            // 
            // listViewPoreskeStope
            // 
            this.listViewPoreskeStope.HideSelection = false;
            this.listViewPoreskeStope.Location = new System.Drawing.Point(16, 10);
            this.listViewPoreskeStope.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewPoreskeStope.Name = "listViewPoreskeStope";
            this.listViewPoreskeStope.Size = new System.Drawing.Size(285, 347);
            this.listViewPoreskeStope.TabIndex = 134;
            this.listViewPoreskeStope.UseCompatibleStateImageBehavior = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(31, 367);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(255, 38);
            this.button7.TabIndex = 133;
            this.button7.Text = "PRIKAŽI PORESKE STOPE";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(396, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "PORESKE STOPE NA ZAHTEV";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(51, 395);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(255, 38);
            this.button8.TabIndex = 125;
            this.button8.Text = "SAČUVAJ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label54.Location = new System.Drawing.Point(51, 255);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(98, 16);
            this.label54.TabIndex = 132;
            this.label54.Text = "Poreska stopa:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label53.Location = new System.Drawing.Point(51, 197);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(78, 16);
            this.label53.TabIndex = 132;
            this.label53.Text = "Napomena:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label52.Location = new System.Drawing.Point(51, 138);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(108, 16);
            this.label52.TabIndex = 132;
            this.label52.Text = "Poreska oznaka:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label51.Location = new System.Drawing.Point(51, 77);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(37, 16);
            this.label51.TabIndex = 131;
            this.label51.Text = "Šifra:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label50.Location = new System.Drawing.Point(51, 18);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(44, 16);
            this.label50.TabIndex = 130;
            this.label50.Text = "Naziv:";
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox17.Location = new System.Drawing.Point(51, 277);
            this.textBox17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(249, 26);
            this.textBox17.TabIndex = 129;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox16.Location = new System.Drawing.Point(51, 219);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(249, 26);
            this.textBox16.TabIndex = 128;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox15.Location = new System.Drawing.Point(51, 160);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(249, 26);
            this.textBox15.TabIndex = 127;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox14.Location = new System.Drawing.Point(51, 99);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(249, 26);
            this.textBox14.TabIndex = 126;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox13.Location = new System.Drawing.Point(51, 40);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(249, 26);
            this.textBox13.TabIndex = 125;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Controls.Add(this.gbOmoguciNacinePlacanja);
            this.panel3.Location = new System.Drawing.Point(754, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 487);
            this.panel3.TabIndex = 3;
            // 
            // gbOmoguciNacinePlacanja
            // 
            this.gbOmoguciNacinePlacanja.Controls.Add(this.cbInstantPlacanje);
            this.gbOmoguciNacinePlacanja.Controls.Add(this.cbCek);
            this.gbOmoguciNacinePlacanja.Controls.Add(this.cbPlatnaKartica);
            this.gbOmoguciNacinePlacanja.Controls.Add(this.cbGotovina);
            this.gbOmoguciNacinePlacanja.Controls.Add(this.cbDrugo);
            this.gbOmoguciNacinePlacanja.Controls.Add(this.cbVaucer);
            this.gbOmoguciNacinePlacanja.Controls.Add(this.cbPrenosNaRacun);
            this.gbOmoguciNacinePlacanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbOmoguciNacinePlacanja.ForeColor = System.Drawing.Color.White;
            this.gbOmoguciNacinePlacanja.Location = new System.Drawing.Point(26, 10);
            this.gbOmoguciNacinePlacanja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbOmoguciNacinePlacanja.Name = "gbOmoguciNacinePlacanja";
            this.gbOmoguciNacinePlacanja.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbOmoguciNacinePlacanja.Size = new System.Drawing.Size(279, 373);
            this.gbOmoguciNacinePlacanja.TabIndex = 140;
            this.gbOmoguciNacinePlacanja.TabStop = false;
            // 
            // cbInstantPlacanje
            // 
            this.cbInstantPlacanje.AutoSize = true;
            this.cbInstantPlacanje.ForeColor = System.Drawing.Color.Black;
            this.cbInstantPlacanje.Location = new System.Drawing.Point(20, 325);
            this.cbInstantPlacanje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbInstantPlacanje.Name = "cbInstantPlacanje";
            this.cbInstantPlacanje.Size = new System.Drawing.Size(157, 24);
            this.cbInstantPlacanje.TabIndex = 6;
            this.cbInstantPlacanje.Text = "Instant plaćanje";
            this.cbInstantPlacanje.UseVisualStyleBackColor = true;
            this.cbInstantPlacanje.CheckedChanged += new System.EventHandler(this.cbInstantPlacanje_CheckedChanged);
            // 
            // cbCek
            // 
            this.cbCek.AutoSize = true;
            this.cbCek.ForeColor = System.Drawing.Color.Black;
            this.cbCek.Location = new System.Drawing.Point(20, 273);
            this.cbCek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCek.Name = "cbCek";
            this.cbCek.Size = new System.Drawing.Size(59, 24);
            this.cbCek.TabIndex = 5;
            this.cbCek.Text = "Ček";
            this.cbCek.UseVisualStyleBackColor = true;
            this.cbCek.CheckedChanged += new System.EventHandler(this.cbCek_CheckedChanged);
            // 
            // cbPlatnaKartica
            // 
            this.cbPlatnaKartica.AutoSize = true;
            this.cbPlatnaKartica.ForeColor = System.Drawing.Color.Black;
            this.cbPlatnaKartica.Location = new System.Drawing.Point(20, 225);
            this.cbPlatnaKartica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPlatnaKartica.Name = "cbPlatnaKartica";
            this.cbPlatnaKartica.Size = new System.Drawing.Size(138, 24);
            this.cbPlatnaKartica.TabIndex = 4;
            this.cbPlatnaKartica.Text = "Platna kartica";
            this.cbPlatnaKartica.UseVisualStyleBackColor = true;
            this.cbPlatnaKartica.CheckedChanged += new System.EventHandler(this.cbPlatnaKartica_CheckedChanged);
            // 
            // cbGotovina
            // 
            this.cbGotovina.AutoSize = true;
            this.cbGotovina.ForeColor = System.Drawing.Color.Black;
            this.cbGotovina.Location = new System.Drawing.Point(20, 180);
            this.cbGotovina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGotovina.Name = "cbGotovina";
            this.cbGotovina.Size = new System.Drawing.Size(100, 24);
            this.cbGotovina.TabIndex = 3;
            this.cbGotovina.Text = "Gotovina";
            this.cbGotovina.UseVisualStyleBackColor = true;
            this.cbGotovina.CheckedChanged += new System.EventHandler(this.cbGotovina_CheckedChanged);
            // 
            // cbDrugo
            // 
            this.cbDrugo.AutoSize = true;
            this.cbDrugo.ForeColor = System.Drawing.Color.Black;
            this.cbDrugo.Location = new System.Drawing.Point(20, 133);
            this.cbDrugo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbDrugo.Name = "cbDrugo";
            this.cbDrugo.Size = new System.Drawing.Size(77, 24);
            this.cbDrugo.TabIndex = 2;
            this.cbDrugo.Text = "Drugo";
            this.cbDrugo.UseVisualStyleBackColor = true;
            this.cbDrugo.CheckedChanged += new System.EventHandler(this.cbDrugo_CheckedChanged);
            // 
            // cbVaucer
            // 
            this.cbVaucer.AutoSize = true;
            this.cbVaucer.ForeColor = System.Drawing.Color.Black;
            this.cbVaucer.Location = new System.Drawing.Point(20, 88);
            this.cbVaucer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbVaucer.Name = "cbVaucer";
            this.cbVaucer.Size = new System.Drawing.Size(85, 24);
            this.cbVaucer.TabIndex = 1;
            this.cbVaucer.Text = "Vaučer";
            this.cbVaucer.UseVisualStyleBackColor = true;
            this.cbVaucer.CheckedChanged += new System.EventHandler(this.cbVaucer_CheckedChanged);
            // 
            // cbPrenosNaRacun
            // 
            this.cbPrenosNaRacun.AutoSize = true;
            this.cbPrenosNaRacun.ForeColor = System.Drawing.Color.Black;
            this.cbPrenosNaRacun.Location = new System.Drawing.Point(20, 43);
            this.cbPrenosNaRacun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPrenosNaRacun.Name = "cbPrenosNaRacun";
            this.cbPrenosNaRacun.Size = new System.Drawing.Size(159, 24);
            this.cbPrenosNaRacun.TabIndex = 0;
            this.cbPrenosNaRacun.Text = "Prenos na račun";
            this.cbPrenosNaRacun.UseVisualStyleBackColor = true;
            this.cbPrenosNaRacun.CheckedChanged += new System.EventHandler(this.cbPrenosNaRacun_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(813, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 127;
            this.label3.Text = "NAČIN PLAĆANJA";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.Menu;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBox18);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.label54);
            this.panel4.Controls.Add(this.label50);
            this.panel4.Controls.Add(this.label53);
            this.panel4.Controls.Add(this.textBox13);
            this.panel4.Controls.Add(this.label52);
            this.panel4.Controls.Add(this.textBox14);
            this.panel4.Controls.Add(this.label51);
            this.panel4.Controls.Add(this.textBox15);
            this.panel4.Controls.Add(this.textBox16);
            this.panel4.Controls.Add(this.textBox17);
            this.panel4.Location = new System.Drawing.Point(1125, 46);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 487);
            this.panel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(51, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 134;
            this.label6.Text = "Cena:";
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox18.Location = new System.Drawing.Point(51, 346);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(249, 26);
            this.textBox18.TabIndex = 133;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 299);
            this.dataGridView1.TabIndex = 134;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button11);
            this.panel8.Controls.Add(this.button10);
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Controls.Add(this.button9);
            this.panel8.Location = new System.Drawing.Point(14, 610);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(830, 395);
            this.panel8.TabIndex = 137;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(554, 13);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(255, 38);
            this.button11.TabIndex = 136;
            this.button11.Text = "IZVEZI PROIZVODE";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(270, 13);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(255, 38);
            this.button10.TabIndex = 135;
            this.button10.Text = "SAČUVAJ";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(19, 13);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(222, 38);
            this.button9.TabIndex = 133;
            this.button9.Text = "UČITAJ PROIZVODE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(264, 586);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 18);
            this.label4.TabIndex = 138;
            this.label4.Text = "EXPORT IMPORT PROIZVODA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1197, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 18);
            this.label5.TabIndex = 139;
            this.label5.Text = "UNOS PROIZVODA";
            // 
            // frmPodesavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1496, 1022);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPodesavanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podešavanje";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbOmoguciNacinePlacanja.ResumeLayout(false);
            this.gbOmoguciNacinePlacanja.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbRezimObuke;
        private System.Windows.Forms.CheckBox cbStampajLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewPoreskeStope;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbOmoguciNacinePlacanja;
        private System.Windows.Forms.CheckBox cbInstantPlacanje;
        private System.Windows.Forms.CheckBox cbCek;
        private System.Windows.Forms.CheckBox cbPlatnaKartica;
        private System.Windows.Forms.CheckBox cbGotovina;
        private System.Windows.Forms.CheckBox cbDrugo;
        private System.Windows.Forms.CheckBox cbVaucer;
        private System.Windows.Forms.CheckBox cbPrenosNaRacun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox18;
    }
}