namespace Maloprodaja
{
    partial class frmNoviRacun
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
            this.cbproizvodi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvstavke = new System.Windows.Forms.ListView();
            this.txtkolicina = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPredracun = new System.Windows.Forms.RadioButton();
            this.rbRacun = new System.Windows.Forms.RadioButton();
            this.cbtipidentifikacijekupca = new System.Windows.Forms.ComboBox();
            this.txtbrojidentifikacije = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbrojdokumenta = new System.Windows.Forms.TextBox();
            this.cbdokument = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdrugo = new System.Windows.Forms.NumericUpDown();
            this.txtgotovina = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtplatnakartica = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcek = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtprenosnaracun = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtvaucer = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtinstantplacanje = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtzanaplatu = new System.Windows.Forms.TextBox();
            this.panelPrenosNaRacun = new System.Windows.Forms.Panel();
            this.panelVaucer = new System.Windows.Forms.Panel();
            this.panelDrugo = new System.Windows.Forms.Panel();
            this.panelOstalo = new System.Windows.Forms.Panel();
            this.panelGotovina = new System.Windows.Forms.Panel();
            this.cmdNaplati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtkolicina)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdrugo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgotovina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtplatnakartica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprenosnaracun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvaucer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinstantplacanje)).BeginInit();
            this.panelPrenosNaRacun.SuspendLayout();
            this.panelVaucer.SuspendLayout();
            this.panelDrugo.SuspendLayout();
            this.panelOstalo.SuspendLayout();
            this.panelGotovina.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbproizvodi
            // 
            this.cbproizvodi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbproizvodi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbproizvodi.FormattingEnabled = true;
            this.cbproizvodi.Location = new System.Drawing.Point(826, 50);
            this.cbproizvodi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbproizvodi.Name = "cbproizvodi";
            this.cbproizvodi.Size = new System.Drawing.Size(431, 26);
            this.cbproizvodi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(1488, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "ДОДАЈ СТАВКУ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lvstavke
            // 
            this.lvstavke.HideSelection = false;
            this.lvstavke.Location = new System.Drawing.Point(826, 95);
            this.lvstavke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvstavke.Name = "lvstavke";
            this.lvstavke.Size = new System.Drawing.Size(842, 604);
            this.lvstavke.TabIndex = 3;
            this.lvstavke.UseCompatibleStateImageBehavior = false;
            // 
            // txtkolicina
            // 
            this.txtkolicina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtkolicina.Location = new System.Drawing.Point(1287, 50);
            this.txtkolicina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtkolicina.Name = "txtkolicina";
            this.txtkolicina.Size = new System.Drawing.Size(107, 26);
            this.txtkolicina.TabIndex = 6;
            this.txtkolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPredracun);
            this.groupBox1.Controls.Add(this.rbRacun);
            this.groupBox1.Location = new System.Drawing.Point(237, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(330, 53);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rbPredracun
            // 
            this.rbPredracun.AutoSize = true;
            this.rbPredracun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPredracun.Location = new System.Drawing.Point(163, 18);
            this.rbPredracun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbPredracun.Name = "rbPredracun";
            this.rbPredracun.Size = new System.Drawing.Size(121, 22);
            this.rbPredracun.TabIndex = 1;
            this.rbPredracun.TabStop = true;
            this.rbPredracun.Text = "ПРЕДРАЧУН";
            this.rbPredracun.UseVisualStyleBackColor = true;
            // 
            // rbRacun
            // 
            this.rbRacun.AutoSize = true;
            this.rbRacun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbRacun.Location = new System.Drawing.Point(28, 18);
            this.rbRacun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbRacun.Name = "rbRacun";
            this.rbRacun.Size = new System.Drawing.Size(77, 22);
            this.rbRacun.TabIndex = 0;
            this.rbRacun.TabStop = true;
            this.rbRacun.Text = "РАЧУН";
            this.rbRacun.UseVisualStyleBackColor = true;
            // 
            // cbtipidentifikacijekupca
            // 
            this.cbtipidentifikacijekupca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbtipidentifikacijekupca.FormattingEnabled = true;
            this.cbtipidentifikacijekupca.Location = new System.Drawing.Point(15, 127);
            this.cbtipidentifikacijekupca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbtipidentifikacijekupca.Name = "cbtipidentifikacijekupca";
            this.cbtipidentifikacijekupca.Size = new System.Drawing.Size(430, 26);
            this.cbtipidentifikacijekupca.TabIndex = 8;
            // 
            // txtbrojidentifikacije
            // 
            this.txtbrojidentifikacije.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbrojidentifikacije.Location = new System.Drawing.Point(475, 127);
            this.txtbrojidentifikacije.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbrojidentifikacije.Name = "txtbrojidentifikacije";
            this.txtbrojidentifikacije.Size = new System.Drawing.Size(294, 26);
            this.txtbrojidentifikacije.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Тип идентификације купца:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(471, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Број идентификације:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(822, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Производ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1283, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количина:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(470, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Број документа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Документ:";
            // 
            // txtbrojdokumenta
            // 
            this.txtbrojdokumenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbrojdokumenta.Location = new System.Drawing.Point(474, 208);
            this.txtbrojdokumenta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbrojdokumenta.Name = "txtbrojdokumenta";
            this.txtbrojdokumenta.Size = new System.Drawing.Size(294, 26);
            this.txtbrojdokumenta.TabIndex = 15;
            // 
            // cbdokument
            // 
            this.cbdokument.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbdokument.FormattingEnabled = true;
            this.cbdokument.Location = new System.Drawing.Point(14, 208);
            this.cbdokument.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbdokument.Name = "cbdokument";
            this.cbdokument.Size = new System.Drawing.Size(430, 26);
            this.cbdokument.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Друго:";
            // 
            // txtdrugo
            // 
            this.txtdrugo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdrugo.Location = new System.Drawing.Point(4, 40);
            this.txtdrugo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdrugo.Name = "txtdrugo";
            this.txtdrugo.Size = new System.Drawing.Size(309, 29);
            this.txtdrugo.TabIndex = 19;
            this.txtdrugo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtgotovina
            // 
            this.txtgotovina.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtgotovina.Location = new System.Drawing.Point(4, 42);
            this.txtgotovina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtgotovina.Name = "txtgotovina";
            this.txtgotovina.Size = new System.Drawing.Size(310, 29);
            this.txtgotovina.TabIndex = 21;
            this.txtgotovina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Готовина:";
            // 
            // txtplatnakartica
            // 
            this.txtplatnakartica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtplatnakartica.Location = new System.Drawing.Point(4, 29);
            this.txtplatnakartica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtplatnakartica.Name = "txtplatnakartica";
            this.txtplatnakartica.Size = new System.Drawing.Size(310, 29);
            this.txtplatnakartica.TabIndex = 23;
            this.txtplatnakartica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(4, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Платна картица:";
            // 
            // txtcek
            // 
            this.txtcek.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcek.Location = new System.Drawing.Point(4, 113);
            this.txtcek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcek.Name = "txtcek";
            this.txtcek.Size = new System.Drawing.Size(310, 29);
            this.txtcek.TabIndex = 25;
            this.txtcek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(4, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Чек:";
            // 
            // txtprenosnaracun
            // 
            this.txtprenosnaracun.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtprenosnaracun.Location = new System.Drawing.Point(4, 42);
            this.txtprenosnaracun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtprenosnaracun.Name = "txtprenosnaracun";
            this.txtprenosnaracun.Size = new System.Drawing.Size(310, 29);
            this.txtprenosnaracun.TabIndex = 27;
            this.txtprenosnaracun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(5, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Пренос на рачун:";
            // 
            // txtvaucer
            // 
            this.txtvaucer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtvaucer.Location = new System.Drawing.Point(2, 42);
            this.txtvaucer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtvaucer.Name = "txtvaucer";
            this.txtvaucer.Size = new System.Drawing.Size(310, 29);
            this.txtvaucer.TabIndex = 29;
            this.txtvaucer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(4, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ваучер:";
            // 
            // txtinstantplacanje
            // 
            this.txtinstantplacanje.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtinstantplacanje.Location = new System.Drawing.Point(4, 198);
            this.txtinstantplacanje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtinstantplacanje.Name = "txtinstantplacanje";
            this.txtinstantplacanje.Size = new System.Drawing.Size(310, 29);
            this.txtinstantplacanje.TabIndex = 31;
            this.txtinstantplacanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(4, 164);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Инстант плаћање:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(15, 300);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "ЗА НАПЛАТУ:";
            // 
            // txtzanaplatu
            // 
            this.txtzanaplatu.Enabled = false;
            this.txtzanaplatu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtzanaplatu.Location = new System.Drawing.Point(14, 331);
            this.txtzanaplatu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtzanaplatu.Name = "txtzanaplatu";
            this.txtzanaplatu.Size = new System.Drawing.Size(313, 32);
            this.txtzanaplatu.TabIndex = 33;
            this.txtzanaplatu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelPrenosNaRacun
            // 
            this.panelPrenosNaRacun.Controls.Add(this.txtprenosnaracun);
            this.panelPrenosNaRacun.Controls.Add(this.label11);
            this.panelPrenosNaRacun.Location = new System.Drawing.Point(14, 377);
            this.panelPrenosNaRacun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelPrenosNaRacun.Name = "panelPrenosNaRacun";
            this.panelPrenosNaRacun.Size = new System.Drawing.Size(317, 78);
            this.panelPrenosNaRacun.TabIndex = 35;
            // 
            // panelVaucer
            // 
            this.panelVaucer.Controls.Add(this.label12);
            this.panelVaucer.Controls.Add(this.txtvaucer);
            this.panelVaucer.Location = new System.Drawing.Point(14, 463);
            this.panelVaucer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelVaucer.Name = "panelVaucer";
            this.panelVaucer.Size = new System.Drawing.Size(317, 78);
            this.panelVaucer.TabIndex = 36;
            // 
            // panelDrugo
            // 
            this.panelDrugo.Controls.Add(this.label7);
            this.panelDrugo.Controls.Add(this.txtdrugo);
            this.panelDrugo.Location = new System.Drawing.Point(14, 548);
            this.panelDrugo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelDrugo.Name = "panelDrugo";
            this.panelDrugo.Size = new System.Drawing.Size(317, 78);
            this.panelDrugo.TabIndex = 37;
            // 
            // panelOstalo
            // 
            this.panelOstalo.Controls.Add(this.label9);
            this.panelOstalo.Controls.Add(this.label13);
            this.panelOstalo.Controls.Add(this.txtplatnakartica);
            this.panelOstalo.Controls.Add(this.txtcek);
            this.panelOstalo.Controls.Add(this.label10);
            this.panelOstalo.Controls.Add(this.txtinstantplacanje);
            this.panelOstalo.Location = new System.Drawing.Point(454, 306);
            this.panelOstalo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelOstalo.Name = "panelOstalo";
            this.panelOstalo.Size = new System.Drawing.Size(317, 235);
            this.panelOstalo.TabIndex = 38;
            // 
            // panelGotovina
            // 
            this.panelGotovina.Controls.Add(this.label8);
            this.panelGotovina.Controls.Add(this.txtgotovina);
            this.panelGotovina.Location = new System.Drawing.Point(453, 548);
            this.panelGotovina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelGotovina.Name = "panelGotovina";
            this.panelGotovina.Size = new System.Drawing.Size(317, 78);
            this.panelGotovina.TabIndex = 39;
            // 
            // cmdNaplati
            // 
            this.cmdNaplati.BackColor = System.Drawing.Color.Maroon;
            this.cmdNaplati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNaplati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdNaplati.ForeColor = System.Drawing.Color.White;
            this.cmdNaplati.Location = new System.Drawing.Point(223, 648);
            this.cmdNaplati.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdNaplati.Name = "cmdNaplati";
            this.cmdNaplati.Size = new System.Drawing.Size(370, 68);
            this.cmdNaplati.TabIndex = 40;
            this.cmdNaplati.Text = "НАПЛАТИ";
            this.cmdNaplati.UseVisualStyleBackColor = false;
            // 
            // frmNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1701, 730);
            this.Controls.Add(this.cmdNaplati);
            this.Controls.Add(this.panelGotovina);
            this.Controls.Add(this.panelOstalo);
            this.Controls.Add(this.panelDrugo);
            this.Controls.Add(this.panelVaucer);
            this.Controls.Add(this.panelPrenosNaRacun);
            this.Controls.Add(this.txtzanaplatu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbrojdokumenta);
            this.Controls.Add(this.cbdokument);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbrojidentifikacije);
            this.Controls.Add(this.cbtipidentifikacijekupca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtkolicina);
            this.Controls.Add(this.lvstavke);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbproizvodi);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNoviRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiskalni račun";
            ((System.ComponentModel.ISupportInitialize)(this.txtkolicina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdrugo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgotovina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtplatnakartica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprenosnaracun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvaucer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinstantplacanje)).EndInit();
            this.panelPrenosNaRacun.ResumeLayout(false);
            this.panelPrenosNaRacun.PerformLayout();
            this.panelVaucer.ResumeLayout(false);
            this.panelVaucer.PerformLayout();
            this.panelDrugo.ResumeLayout(false);
            this.panelDrugo.PerformLayout();
            this.panelOstalo.ResumeLayout(false);
            this.panelOstalo.PerformLayout();
            this.panelGotovina.ResumeLayout(false);
            this.panelGotovina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbproizvodi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvstavke;
        private System.Windows.Forms.NumericUpDown txtkolicina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPredracun;
        private System.Windows.Forms.RadioButton rbRacun;
        private System.Windows.Forms.ComboBox cbtipidentifikacijekupca;
        private System.Windows.Forms.TextBox txtbrojidentifikacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbrojdokumenta;
        private System.Windows.Forms.ComboBox cbdokument;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtdrugo;
        private System.Windows.Forms.NumericUpDown txtgotovina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtplatnakartica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtcek;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtprenosnaracun;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtvaucer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown txtinstantplacanje;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtzanaplatu;
        private System.Windows.Forms.Panel panelPrenosNaRacun;
        private System.Windows.Forms.Panel panelVaucer;
        private System.Windows.Forms.Panel panelDrugo;
        private System.Windows.Forms.Panel panelOstalo;
        private System.Windows.Forms.Panel panelGotovina;
        private System.Windows.Forms.Button cmdNaplati;
    }
}