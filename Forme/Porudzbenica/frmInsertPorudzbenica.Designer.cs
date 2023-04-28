namespace Maloprodaja.Forme.Porudzbenica
{
    partial class frmInsertPorudzbenica
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgwStavkePorudzbenice = new System.Windows.Forms.DataGridView();
            this.ArtikalRefId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtikalNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObrisiStavkuPorudzbenice = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.NumericUpDown();
            this.cmbArtikli = new System.Windows.Forms.ComboBox();
            this.txtNapomenaStake = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dpDatumIsporuke = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dpDatumPorudzbenice = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPorucilac = new System.Windows.Forms.TextBox();
            this.txtBrojPorudzbenice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSacuvajArtikal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Obrisi = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStavkePorudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKolicina)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1691, 812);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel4.Controls.Add(this.dgwStavkePorudzbenice);
            this.panel4.Controls.Add(this.btnDodajStavku);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtKolicina);
            this.panel4.Controls.Add(this.cmbArtikli);
            this.panel4.Controls.Add(this.txtNapomenaStake);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(582, 22);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1101, 764);
            this.panel4.TabIndex = 22;
            // 
            // dgwStavkePorudzbenice
            // 
            this.dgwStavkePorudzbenice.AllowUserToAddRows = false;
            this.dgwStavkePorudzbenice.AllowUserToDeleteRows = false;
            this.dgwStavkePorudzbenice.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStavkePorudzbenice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwStavkePorudzbenice.ColumnHeadersHeight = 29;
            this.dgwStavkePorudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwStavkePorudzbenice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtikalRefId,
            this.ArtikalNaziv,
            this.Kolicina,
            this.Napomena,
            this.ObrisiStavkuPorudzbenice});
            this.dgwStavkePorudzbenice.EnableHeadersVisualStyles = false;
            this.dgwStavkePorudzbenice.Location = new System.Drawing.Point(421, 51);
            this.dgwStavkePorudzbenice.Margin = new System.Windows.Forms.Padding(4);
            this.dgwStavkePorudzbenice.MultiSelect = false;
            this.dgwStavkePorudzbenice.Name = "dgwStavkePorudzbenice";
            this.dgwStavkePorudzbenice.RowHeadersVisible = false;
            this.dgwStavkePorudzbenice.RowHeadersWidth = 51;
            this.dgwStavkePorudzbenice.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgwStavkePorudzbenice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgwStavkePorudzbenice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.dgwStavkePorudzbenice.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.dgwStavkePorudzbenice.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgwStavkePorudzbenice.RowTemplate.Height = 29;
            this.dgwStavkePorudzbenice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwStavkePorudzbenice.Size = new System.Drawing.Size(669, 574);
            this.dgwStavkePorudzbenice.TabIndex = 30;
            this.dgwStavkePorudzbenice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStavkePorudzbenice_CellContentClick);
            // 
            // ArtikalRefId
            // 
            this.ArtikalRefId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArtikalRefId.HeaderText = "ArtikalRefId";
            this.ArtikalRefId.MinimumWidth = 6;
            this.ArtikalRefId.Name = "ArtikalRefId";
            this.ArtikalRefId.Visible = false;
            // 
            // ArtikalNaziv
            // 
            this.ArtikalNaziv.HeaderText = "Naziv artikla";
            this.ArtikalNaziv.MinimumWidth = 6;
            this.ArtikalNaziv.Name = "ArtikalNaziv";
            this.ArtikalNaziv.Width = 190;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.MinimumWidth = 6;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Width = 125;
            // 
            // Napomena
            // 
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.Width = 160;
            // 
            // ObrisiStavkuPorudzbenice
            // 
            this.ObrisiStavkuPorudzbenice.HeaderText = "Obriši";
            this.ObrisiStavkuPorudzbenice.Image = global::Maloprodaja.Properties.Resources.deleteItem;
            this.ObrisiStavkuPorudzbenice.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ObrisiStavkuPorudzbenice.MinimumWidth = 6;
            this.ObrisiStavkuPorudzbenice.Name = "ObrisiStavkuPorudzbenice";
            this.ObrisiStavkuPorudzbenice.Width = 55;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajStavku.FlatAppearance.BorderSize = 0;
            this.btnDodajStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajStavku.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDodajStavku.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDodajStavku.Location = new System.Drawing.Point(103, 486);
            this.btnDodajStavku.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(220, 46);
            this.btnDodajStavku.TabIndex = 9;
            this.btnDodajStavku.Text = "ДОДАЈ СТАВКУ";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(22, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 32);
            this.label8.TabIndex = 28;
            this.label8.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.DecimalPlaces = 2;
            this.txtKolicina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKolicina.Location = new System.Drawing.Point(21, 188);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(380, 35);
            this.txtKolicina.TabIndex = 7;
            this.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKolicina.ValueChanged += new System.EventHandler(this.txtKolicina_ValueChanged);
            this.txtKolicina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKolicina_KeyDown);
            // 
            // cmbArtikli
            // 
            this.cmbArtikli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbArtikli.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbArtikli.FormattingEnabled = true;
            this.cmbArtikli.Location = new System.Drawing.Point(22, 101);
            this.cmbArtikli.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmbArtikli.Name = "cmbArtikli";
            this.cmbArtikli.Size = new System.Drawing.Size(379, 35);
            this.cmbArtikli.TabIndex = 6;
            this.cmbArtikli.SelectedIndexChanged += new System.EventHandler(this.cmbArtikli_SelectedIndexChanged);
            this.cmbArtikli.TextUpdate += new System.EventHandler(this.cmbArtikli_TextUpdate);
            this.cmbArtikli.TextChanged += new System.EventHandler(this.cmbArtikli_TextChanged);
            this.cmbArtikli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbArtikli_KeyDown);
            // 
            // txtNapomenaStake
            // 
            this.txtNapomenaStake.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNapomenaStake.Location = new System.Drawing.Point(22, 281);
            this.txtNapomenaStake.Margin = new System.Windows.Forms.Padding(2);
            this.txtNapomenaStake.Multiline = true;
            this.txtNapomenaStake.Name = "txtNapomenaStake";
            this.txtNapomenaStake.Size = new System.Drawing.Size(379, 148);
            this.txtNapomenaStake.TabIndex = 8;
            this.txtNapomenaStake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNapomenaStake_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(21, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Napomena stavke";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(22, 61);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 32);
            this.label14.TabIndex = 5;
            this.label14.Text = "Artikal";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.label15);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1101, 40);
            this.panel6.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(429, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(213, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "STAVKE PORUDŽBENICE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel3.Controls.Add(this.txtNapomena);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dpDatumIsporuke);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dpDatumPorudzbenice);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtTelefon);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.txtPorucilac);
            this.panel3.Controls.Add(this.txtBrojPorudzbenice);
            this.panel3.Location = new System.Drawing.Point(154, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 764);
            this.panel3.TabIndex = 2;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNapomena.Location = new System.Drawing.Point(19, 616);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(2);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(352, 95);
            this.txtNapomena.TabIndex = 5;
            this.txtNapomena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNapomena_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 570);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Napomena porudzbenice";
            // 
            // dpDatumIsporuke
            // 
            this.dpDatumIsporuke.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDatumIsporuke.CustomFormat = "dd.MM.yyyy";
            this.dpDatumIsporuke.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDatumIsporuke.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDatumIsporuke.Location = new System.Drawing.Point(18, 493);
            this.dpDatumIsporuke.Margin = new System.Windows.Forms.Padding(4);
            this.dpDatumIsporuke.Name = "dpDatumIsporuke";
            this.dpDatumIsporuke.Size = new System.Drawing.Size(353, 31);
            this.dpDatumIsporuke.TabIndex = 4;
            this.dpDatumIsporuke.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpDatumIsporuke_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 444);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Datum isporuke";
            // 
            // dpDatumPorudzbenice
            // 
            this.dpDatumPorudzbenice.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDatumPorudzbenice.CustomFormat = "dd.MM.yyyy";
            this.dpDatumPorudzbenice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDatumPorudzbenice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDatumPorudzbenice.Location = new System.Drawing.Point(18, 390);
            this.dpDatumPorudzbenice.Margin = new System.Windows.Forms.Padding(4);
            this.dpDatumPorudzbenice.Name = "dpDatumPorudzbenice";
            this.dpDatumPorudzbenice.Size = new System.Drawing.Size(352, 31);
            this.dpDatumPorudzbenice.TabIndex = 3;
            this.dpDatumPorudzbenice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpDatumPorudzbenice_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(22, 243);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 32);
            this.label11.TabIndex = 16;
            this.label11.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefon.Location = new System.Drawing.Point(19, 286);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(353, 39);
            this.txtTelefon.TabIndex = 2;
            this.txtTelefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefon_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Poručilac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum porudžbenice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj porudžbenice";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(399, 40);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PODACI O PORUDŽBENICI";
            // 
            // txtPorucilac
            // 
            this.txtPorucilac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPorucilac.Location = new System.Drawing.Point(19, 188);
            this.txtPorucilac.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorucilac.Name = "txtPorucilac";
            this.txtPorucilac.Size = new System.Drawing.Size(353, 39);
            this.txtPorucilac.TabIndex = 1;
            this.txtPorucilac.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPorucilac_KeyDown);
            // 
            // txtBrojPorudzbenice
            // 
            this.txtBrojPorudzbenice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBrojPorudzbenice.Location = new System.Drawing.Point(19, 101);
            this.txtBrojPorudzbenice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojPorudzbenice.Name = "txtBrojPorudzbenice";
            this.txtBrojPorudzbenice.ReadOnly = true;
            this.txtBrojPorudzbenice.Size = new System.Drawing.Size(353, 39);
            this.txtBrojPorudzbenice.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnSacuvajArtikal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 812);
            this.panel2.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(0, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "SAČUVAJ (F12)";
            // 
            // btnSacuvajArtikal
            // 
            this.btnSacuvajArtikal.BackColor = System.Drawing.Color.DarkGray;
            this.btnSacuvajArtikal.BackgroundImage = global::Maloprodaja.Properties.Resources.SaveArtikal;
            this.btnSacuvajArtikal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSacuvajArtikal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvajArtikal.Location = new System.Drawing.Point(22, 22);
            this.btnSacuvajArtikal.Margin = new System.Windows.Forms.Padding(2);
            this.btnSacuvajArtikal.Name = "btnSacuvajArtikal";
            this.btnSacuvajArtikal.Size = new System.Drawing.Size(88, 68);
            this.btnSacuvajArtikal.TabIndex = 13;
            this.btnSacuvajArtikal.UseVisualStyleBackColor = false;
            this.btnSacuvajArtikal.Click += new System.EventHandler(this.btnSacuvajArtikal_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obriši";
            this.Obrisi.Image = global::Maloprodaja.Properties.Resources.remove_new;
            this.Obrisi.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.Width = 55;
            // 
            // frmInsertPorudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 812);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertPorudzbenica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNOS PORUDŽBENICE";
            this.Load += new System.EventHandler(this.frmInsertPorudzbenica_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInsertPorudzbenica_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStavkePorudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKolicina)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSacuvajArtikal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPorucilac;
        public System.Windows.Forms.TextBox txtBrojPorudzbenice;
        public System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpDatumIsporuke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpDatumPorudzbenice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtNapomenaStake;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtKolicina;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.ComboBox cmbArtikli;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgwStavkePorudzbenice;
        private System.Windows.Forms.DataGridViewImageColumn Obrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikalRefId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikalNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewImageColumn ObrisiStavkuPorudzbenice;
    }
}