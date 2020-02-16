namespace Telefoni
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridTelefoni = new System.Windows.Forms.DataGridView();
            this.sifraProizvodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodjacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smartTelefoniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartTelefoniDataSet = new Telefoni.SmartTelefoniDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifraProizvoda = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dtpDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.smartTelefoniTableAdapter = new Telefoni.SmartTelefoniDataSetTableAdapters.SmartTelefoniTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTelefoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartTelefoniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartTelefoniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridTelefoni);
            this.groupBox1.Location = new System.Drawing.Point(1, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telefoni";
            // 
            // gridTelefoni
            // 
            this.gridTelefoni.AllowUserToAddRows = false;
            this.gridTelefoni.AllowUserToDeleteRows = false;
            this.gridTelefoni.AutoGenerateColumns = false;
            this.gridTelefoni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTelefoni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifraProizvodaDataGridViewTextBoxColumn,
            this.proizvodjacDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.datumIzdavanjaDataGridViewTextBoxColumn});
            this.gridTelefoni.DataSource = this.smartTelefoniBindingSource;
            this.gridTelefoni.Location = new System.Drawing.Point(0, 19);
            this.gridTelefoni.Name = "gridTelefoni";
            this.gridTelefoni.ReadOnly = true;
            this.gridTelefoni.Size = new System.Drawing.Size(444, 148);
            this.gridTelefoni.TabIndex = 0;
            // 
            // sifraProizvodaDataGridViewTextBoxColumn
            // 
            this.sifraProizvodaDataGridViewTextBoxColumn.DataPropertyName = "Sifra proizvoda";
            this.sifraProizvodaDataGridViewTextBoxColumn.HeaderText = "Sifra proizvoda";
            this.sifraProizvodaDataGridViewTextBoxColumn.Name = "sifraProizvodaDataGridViewTextBoxColumn";
            this.sifraProizvodaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proizvodjacDataGridViewTextBoxColumn
            // 
            this.proizvodjacDataGridViewTextBoxColumn.DataPropertyName = "Proizvodjac";
            this.proizvodjacDataGridViewTextBoxColumn.HeaderText = "Proizvodjac";
            this.proizvodjacDataGridViewTextBoxColumn.Name = "proizvodjacDataGridViewTextBoxColumn";
            this.proizvodjacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumIzdavanjaDataGridViewTextBoxColumn
            // 
            this.datumIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "Datum izdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.HeaderText = "Datum izdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.Name = "datumIzdavanjaDataGridViewTextBoxColumn";
            this.datumIzdavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // smartTelefoniBindingSource
            // 
            this.smartTelefoniBindingSource.DataMember = "SmartTelefoni";
            this.smartTelefoniBindingSource.DataSource = this.smartTelefoniDataSet;
            // 
            // smartTelefoniDataSet
            // 
            this.smartTelefoniDataSet.DataSetName = "SmartTelefoniDataSet";
            this.smartTelefoniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sifra proizvoda\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proizvodjac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum izdavanja";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSifraProizvoda
            // 
            this.txtSifraProizvoda.Location = new System.Drawing.Point(12, 59);
            this.txtSifraProizvoda.Name = "txtSifraProizvoda";
            this.txtSifraProizvoda.Size = new System.Drawing.Size(66, 20);
            this.txtSifraProizvoda.TabIndex = 5;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(99, 60);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(58, 20);
            this.txtProizvodjac.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(179, 59);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(57, 20);
            this.txtModel.TabIndex = 7;
            // 
            // dtpDatumIzdavanja
            // 
            this.dtpDatumIzdavanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumIzdavanja.Location = new System.Drawing.Point(272, 59);
            this.dtpDatumIzdavanja.Name = "dtpDatumIzdavanja";
            this.dtpDatumIzdavanja.Size = new System.Drawing.Size(104, 20);
            this.dtpDatumIzdavanja.TabIndex = 8;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(179, 112);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 9;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(179, 160);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 10;
            this.btnIzbrisi.Text = "Izbrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(3, 160);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 11;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(98, 112);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnIzaberi.Size = new System.Drawing.Size(75, 23);
            this.btnIzaberi.TabIndex = 12;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(3, 112);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // smartTelefoniTableAdapter
            // 
            this.smartTelefoniTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Telefoni.Properties.Resources.Telefoni;
            this.ClientSize = new System.Drawing.Size(444, 465);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dtpDatumIzdavanja);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtSifraProizvoda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Telefoni";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTelefoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartTelefoniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartTelefoniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridTelefoni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifraProizvoda;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DateTimePicker dtpDatumIzdavanja;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Button btnDodaj;
        private SmartTelefoniDataSet smartTelefoniDataSet;
        private System.Windows.Forms.BindingSource smartTelefoniBindingSource;
        private SmartTelefoniDataSetTableAdapters.SmartTelefoniTableAdapter smartTelefoniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraProizvodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodjacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIzdavanjaDataGridViewTextBoxColumn;
    }
}

