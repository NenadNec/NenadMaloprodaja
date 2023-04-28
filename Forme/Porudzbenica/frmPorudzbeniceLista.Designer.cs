namespace Maloprodaja.Forme.Artikli
{
    partial class frmPorudzbeniceLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeader2 = new System.Windows.Forms.Panel();
            this.pnlHeaderBottom = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIzveziArtikal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeaderTop = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnObrisiArtikal = new System.Windows.Forms.Button();
            this.btnIzmeniArtikal = new System.Windows.Forms.Button();
            this.btnDodajArtikal = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlBodyFilter = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dpDatumPorudzbeniceDo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dpDatumPorudzbeniceOd = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojPorudzbenice = new System.Windows.Forms.TextBox();
            this.txtPorucilac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlBodyGrid = new System.Windows.Forms.Panel();
            this.dgwPorudzbenice = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPorudzbenice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPorudzbenice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porucilac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIsporuke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porudzbenicaClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHeader2.SuspendLayout();
            this.pnlHeaderBottom.SuspendLayout();
            this.pnlHeaderTop.SuspendLayout();
            this.pnlBodyFilter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlBodyGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPorudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porudzbenicaClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1211, 21);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlHeader2
            // 
            this.pnlHeader2.Controls.Add(this.pnlHeaderBottom);
            this.pnlHeader2.Controls.Add(this.pnlHeaderTop);
            this.pnlHeader2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader2.Location = new System.Drawing.Point(0, 21);
            this.pnlHeader2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader2.Name = "pnlHeader2";
            this.pnlHeader2.Size = new System.Drawing.Size(93, 471);
            this.pnlHeader2.TabIndex = 1;
            // 
            // pnlHeaderBottom
            // 
            this.pnlHeaderBottom.Controls.Add(this.label9);
            this.pnlHeaderBottom.Controls.Add(this.btnIzveziArtikal);
            this.pnlHeaderBottom.Controls.Add(this.label8);
            this.pnlHeaderBottom.Controls.Add(this.btnClose);
            this.pnlHeaderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHeaderBottom.Location = new System.Drawing.Point(0, 309);
            this.pnlHeaderBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeaderBottom.Name = "pnlHeaderBottom";
            this.pnlHeaderBottom.Size = new System.Drawing.Size(93, 162);
            this.pnlHeaderBottom.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(19, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "IZVEZI";
            // 
            // btnIzveziArtikal
            // 
            this.btnIzveziArtikal.BackColor = System.Drawing.Color.DarkGray;
            this.btnIzveziArtikal.BackgroundImage = global::Maloprodaja.Properties.Resources.Izvezi;
            this.btnIzveziArtikal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIzveziArtikal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzveziArtikal.Location = new System.Drawing.Point(10, 0);
            this.btnIzveziArtikal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzveziArtikal.Name = "btnIzveziArtikal";
            this.btnIzveziArtikal.Size = new System.Drawing.Size(70, 49);
            this.btnIzveziArtikal.TabIndex = 12;
            this.btnIzveziArtikal.UseVisualStyleBackColor = false;
            this.btnIzveziArtikal.Click += new System.EventHandler(this.btnIzveziArtikal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(10, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "ZATVORI";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.BackgroundImage = global::Maloprodaja.Properties.Resources.Zatvori;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(10, 76);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 49);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlHeaderTop
            // 
            this.pnlHeaderTop.Controls.Add(this.label12);
            this.pnlHeaderTop.Controls.Add(this.label11);
            this.pnlHeaderTop.Controls.Add(this.label10);
            this.pnlHeaderTop.Controls.Add(this.btnObrisiArtikal);
            this.pnlHeaderTop.Controls.Add(this.btnIzmeniArtikal);
            this.pnlHeaderTop.Controls.Add(this.btnDodajArtikal);
            this.pnlHeaderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderTop.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeaderTop.Name = "pnlHeaderTop";
            this.pnlHeaderTop.Size = new System.Drawing.Size(93, 312);
            this.pnlHeaderTop.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(19, 208);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "OBRIŠI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(16, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "IZMENI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(19, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "DODAJ";
            // 
            // btnObrisiArtikal
            // 
            this.btnObrisiArtikal.BackColor = System.Drawing.Color.DarkGray;
            this.btnObrisiArtikal.BackgroundImage = global::Maloprodaja.Properties.Resources.Delete;
            this.btnObrisiArtikal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnObrisiArtikal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiArtikal.Location = new System.Drawing.Point(10, 158);
            this.btnObrisiArtikal.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiArtikal.Name = "btnObrisiArtikal";
            this.btnObrisiArtikal.Size = new System.Drawing.Size(70, 49);
            this.btnObrisiArtikal.TabIndex = 10;
            this.btnObrisiArtikal.UseVisualStyleBackColor = false;
            this.btnObrisiArtikal.Click += new System.EventHandler(this.btnObrisiArtikal_Click);
            // 
            // btnIzmeniArtikal
            // 
            this.btnIzmeniArtikal.BackColor = System.Drawing.Color.DarkGray;
            this.btnIzmeniArtikal.BackgroundImage = global::Maloprodaja.Properties.Resources.Izmeni;
            this.btnIzmeniArtikal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIzmeniArtikal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeniArtikal.Location = new System.Drawing.Point(10, 86);
            this.btnIzmeniArtikal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzmeniArtikal.Name = "btnIzmeniArtikal";
            this.btnIzmeniArtikal.Size = new System.Drawing.Size(70, 49);
            this.btnIzmeniArtikal.TabIndex = 9;
            this.btnIzmeniArtikal.UseVisualStyleBackColor = false;
            this.btnIzmeniArtikal.Click += new System.EventHandler(this.btnIzmeniArtikal_Click);
            // 
            // btnDodajArtikal
            // 
            this.btnDodajArtikal.BackColor = System.Drawing.Color.DarkGray;
            this.btnDodajArtikal.BackgroundImage = global::Maloprodaja.Properties.Resources.Dodaj;
            this.btnDodajArtikal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDodajArtikal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajArtikal.Location = new System.Drawing.Point(10, 13);
            this.btnDodajArtikal.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajArtikal.Name = "btnDodajArtikal";
            this.btnDodajArtikal.Size = new System.Drawing.Size(70, 49);
            this.btnDodajArtikal.TabIndex = 8;
            this.btnDodajArtikal.UseVisualStyleBackColor = false;
            this.btnDodajArtikal.Click += new System.EventHandler(this.btnDodajArtikal_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(93, 478);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1118, 14);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlBodyFilter
            // 
            this.pnlBodyFilter.Controls.Add(this.label3);
            this.pnlBodyFilter.Controls.Add(this.dpDatumPorudzbeniceDo);
            this.pnlBodyFilter.Controls.Add(this.label2);
            this.pnlBodyFilter.Controls.Add(this.dpDatumPorudzbeniceOd);
            this.pnlBodyFilter.Controls.Add(this.btnReset);
            this.pnlBodyFilter.Controls.Add(this.btnPretraga);
            this.pnlBodyFilter.Controls.Add(this.label5);
            this.pnlBodyFilter.Controls.Add(this.label4);
            this.pnlBodyFilter.Controls.Add(this.txtBrojPorudzbenice);
            this.pnlBodyFilter.Controls.Add(this.txtPorucilac);
            this.pnlBodyFilter.Controls.Add(this.label1);
            this.pnlBodyFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBodyFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlBodyFilter.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBodyFilter.Name = "pnlBodyFilter";
            this.pnlBodyFilter.Size = new System.Drawing.Size(294, 453);
            this.pnlBodyFilter.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Datum porudžbenice DO";
            // 
            // dpDatumPorudzbeniceDo
            // 
            this.dpDatumPorudzbeniceDo.CalendarFont = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDatumPorudzbeniceDo.CustomFormat = "dd.MM.yyyy";
            this.dpDatumPorudzbeniceDo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDatumPorudzbeniceDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDatumPorudzbeniceDo.Location = new System.Drawing.Point(11, 226);
            this.dpDatumPorudzbeniceDo.Name = "dpDatumPorudzbeniceDo";
            this.dpDatumPorudzbeniceDo.Size = new System.Drawing.Size(269, 34);
            this.dpDatumPorudzbeniceDo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Datum porudžbenice OD";
            // 
            // dpDatumPorudzbeniceOd
            // 
            this.dpDatumPorudzbeniceOd.CalendarFont = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDatumPorudzbeniceOd.CustomFormat = "dd.MM.yyyy";
            this.dpDatumPorudzbeniceOd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDatumPorudzbeniceOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDatumPorudzbeniceOd.Location = new System.Drawing.Point(11, 157);
            this.dpDatumPorudzbeniceOd.Name = "dpDatumPorudzbeniceOd";
            this.dpDatumPorudzbeniceOd.Size = new System.Drawing.Size(269, 34);
            this.dpDatumPorudzbeniceOd.TabIndex = 18;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(181, 307);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 49);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(11, 307);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(2);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(96, 49);
            this.btnPretraga.TabIndex = 6;
            this.btnPretraga.Text = "PRETRAGA";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Poručilac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // txtBrojPorudzbenice
            // 
            this.txtBrojPorudzbenice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBrojPorudzbenice.Location = new System.Drawing.Point(11, 33);
            this.txtBrojPorudzbenice.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojPorudzbenice.Name = "txtBrojPorudzbenice";
            this.txtBrojPorudzbenice.Size = new System.Drawing.Size(269, 27);
            this.txtBrojPorudzbenice.TabIndex = 2;
            // 
            // txtPorucilac
            // 
            this.txtPorucilac.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPorucilac.Location = new System.Drawing.Point(12, 95);
            this.txtPorucilac.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorucilac.Name = "txtPorucilac";
            this.txtPorucilac.Size = new System.Drawing.Size(269, 27);
            this.txtPorucilac.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj porudžbenice";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBody.Controls.Add(this.pnlBodyGrid);
            this.pnlBody.Controls.Add(this.pnlBodyFilter);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(93, 21);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1118, 457);
            this.pnlBody.TabIndex = 3;
            // 
            // pnlBodyGrid
            // 
            this.pnlBodyGrid.Controls.Add(this.dgwPorudzbenice);
            this.pnlBodyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBodyGrid.Location = new System.Drawing.Point(294, 0);
            this.pnlBodyGrid.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBodyGrid.Name = "pnlBodyGrid";
            this.pnlBodyGrid.Size = new System.Drawing.Size(820, 453);
            this.pnlBodyGrid.TabIndex = 1;
            // 
            // dgwPorudzbenice
            // 
            this.dgwPorudzbenice.AllowUserToAddRows = false;
            this.dgwPorudzbenice.AllowUserToDeleteRows = false;
            this.dgwPorudzbenice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPorudzbenice.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPorudzbenice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPorudzbenice.ColumnHeadersHeight = 34;
            this.dgwPorudzbenice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BrojPorudzbenice,
            this.DatumPorudzbenice,
            this.Porucilac,
            this.Telefon,
            this.DatumIsporuke,
            this.Napomena});
            this.dgwPorudzbenice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPorudzbenice.EnableHeadersVisualStyles = false;
            this.dgwPorudzbenice.Location = new System.Drawing.Point(0, 0);
            this.dgwPorudzbenice.Margin = new System.Windows.Forms.Padding(2);
            this.dgwPorudzbenice.Name = "dgwPorudzbenice";
            this.dgwPorudzbenice.RowHeadersVisible = false;
            this.dgwPorudzbenice.RowHeadersWidth = 62;
            this.dgwPorudzbenice.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgwPorudzbenice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.dgwPorudzbenice.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.dgwPorudzbenice.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgwPorudzbenice.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPorudzbenice.RowTemplate.Height = 33;
            this.dgwPorudzbenice.Size = new System.Drawing.Size(820, 453);
            this.dgwPorudzbenice.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // BrojPorudzbenice
            // 
            this.BrojPorudzbenice.HeaderText = "Broj porudzbenice";
            this.BrojPorudzbenice.MinimumWidth = 6;
            this.BrojPorudzbenice.Name = "BrojPorudzbenice";
            // 
            // DatumPorudzbenice
            // 
            this.DatumPorudzbenice.HeaderText = "Datum porudzbenice";
            this.DatumPorudzbenice.MinimumWidth = 6;
            this.DatumPorudzbenice.Name = "DatumPorudzbenice";
            // 
            // Porucilac
            // 
            this.Porucilac.HeaderText = "Poručilac";
            this.Porucilac.MinimumWidth = 6;
            this.Porucilac.Name = "Porucilac";
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            // 
            // DatumIsporuke
            // 
            this.DatumIsporuke.HeaderText = "Datum isporuke";
            this.DatumIsporuke.MinimumWidth = 6;
            this.DatumIsporuke.Name = "DatumIsporuke";
            // 
            // Napomena
            // 
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            // 
            // porudzbenicaClassBindingSource
            // 
            this.porudzbenicaClassBindingSource.DataSource = typeof(Maloprodaja.Klase.PorudzbenicaClass);
            // 
            // frmPorudzbeniceLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1211, 492);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader2);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPorudzbeniceLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POEUDZBENICE";
            this.Load += new System.EventHandler(this.frmPorudzbeniceLista_Load);
            this.pnlHeader2.ResumeLayout(false);
            this.pnlHeaderBottom.ResumeLayout(false);
            this.pnlHeaderBottom.PerformLayout();
            this.pnlHeaderTop.ResumeLayout(false);
            this.pnlHeaderTop.PerformLayout();
            this.pnlBodyFilter.ResumeLayout(false);
            this.pnlBodyFilter.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBodyGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPorudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porudzbenicaClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeader2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlHeaderBottom;
        private System.Windows.Forms.Panel pnlHeaderTop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIzveziArtikal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnObrisiArtikal;
        private System.Windows.Forms.Button btnIzmeniArtikal;
        private System.Windows.Forms.Button btnDodajArtikal;
        private System.Windows.Forms.Panel pnlBodyFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojPorudzbenice;
        private System.Windows.Forms.TextBox txtPorucilac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlBodyGrid;
        private System.Windows.Forms.DataGridView dgwPorudzbenice;
        private System.Windows.Forms.BindingSource porudzbenicaClassBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpDatumPorudzbeniceDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpDatumPorudzbeniceOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPorudzbenice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPorudzbenice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porucilac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIsporuke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
    }
}