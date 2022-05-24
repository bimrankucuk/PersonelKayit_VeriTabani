
namespace personel_kayıt
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.permaas = new System.Windows.Forms.MaskedTextBox();
            this.perbekar = new System.Windows.Forms.RadioButton();
            this.perevli = new System.Windows.Forms.RadioButton();
            this.persehir = new System.Windows.Forms.ComboBox();
            this.permeslek = new System.Windows.Forms.TextBox();
            this.persoyad = new System.Windows.Forms.TextBox();
            this.perad = new System.Windows.Forms.TextBox();
            this.perıd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grafik = new System.Windows.Forms.Button();
            this.istatistik = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet4 = new personel_kayıt.PersonelVeriTabaniDataSet4();
            this.table_1TableAdapter = new personel_kayıt.PersonelVeriTabaniDataSet4TableAdapters.Table_1TableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.permaas);
            this.groupBox1.Controls.Add(this.perbekar);
            this.groupBox1.Controls.Add(this.perevli);
            this.groupBox1.Controls.Add(this.persehir);
            this.groupBox1.Controls.Add(this.permeslek);
            this.groupBox1.Controls.Add(this.persoyad);
            this.groupBox1.Controls.Add(this.perad);
            this.groupBox1.Controls.Add(this.perıd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel kayıt";
            // 
            // permaas
            // 
            this.permaas.Location = new System.Drawing.Point(160, 250);
            this.permaas.Mask = "0000";
            this.permaas.Name = "permaas";
            this.permaas.Size = new System.Drawing.Size(139, 24);
            this.permaas.TabIndex = 4;
            this.permaas.ValidatingType = typeof(int);
            // 
            // perbekar
            // 
            this.perbekar.AutoSize = true;
            this.perbekar.Location = new System.Drawing.Point(229, 304);
            this.perbekar.Name = "perbekar";
            this.perbekar.Size = new System.Drawing.Size(70, 22);
            this.perbekar.TabIndex = 3;
            this.perbekar.TabStop = true;
            this.perbekar.Text = "Bekar";
            this.perbekar.UseVisualStyleBackColor = true;
            this.perbekar.CheckedChanged += new System.EventHandler(this.perbekar_CheckedChanged);
            // 
            // perevli
            // 
            this.perevli.AutoSize = true;
            this.perevli.Location = new System.Drawing.Point(160, 304);
            this.perevli.Name = "perevli";
            this.perevli.Size = new System.Drawing.Size(53, 22);
            this.perevli.TabIndex = 3;
            this.perevli.TabStop = true;
            this.perevli.Text = "Evli";
            this.perevli.UseVisualStyleBackColor = true;
            this.perevli.CheckedChanged += new System.EventHandler(this.perevli_CheckedChanged);
            // 
            // persehir
            // 
            this.persehir.FormattingEnabled = true;
            this.persehir.Location = new System.Drawing.Point(160, 197);
            this.persehir.Name = "persehir";
            this.persehir.Size = new System.Drawing.Size(139, 26);
            this.persehir.TabIndex = 2;
            // 
            // permeslek
            // 
            this.permeslek.Location = new System.Drawing.Point(160, 357);
            this.permeslek.Name = "permeslek";
            this.permeslek.Size = new System.Drawing.Size(139, 24);
            this.permeslek.TabIndex = 1;
            this.permeslek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // persoyad
            // 
            this.persoyad.Location = new System.Drawing.Point(160, 136);
            this.persoyad.Name = "persoyad";
            this.persoyad.Size = new System.Drawing.Size(139, 24);
            this.persoyad.TabIndex = 1;
            this.persoyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // perad
            // 
            this.perad.Location = new System.Drawing.Point(160, 85);
            this.perad.Name = "perad";
            this.perad.Size = new System.Drawing.Size(139, 24);
            this.perad.TabIndex = 1;
            this.perad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // perıd
            // 
            this.perıd.Enabled = false;
            this.perıd.Location = new System.Drawing.Point(160, 43);
            this.perıd.Name = "perıd";
            this.perıd.Size = new System.Drawing.Size(139, 24);
            this.perıd.TabIndex = 1;
            this.perıd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "personel meslek : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "personel durum : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "personel maaş : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "personel sehir : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "personel soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "personel ad : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "personel ıd :";
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.LightCoral;
            this.listele.Location = new System.Drawing.Point(95, 43);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(132, 29);
            this.listele.TabIndex = 1;
            this.listele.Text = "LİSTELE";
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.grafik);
            this.groupBox2.Controls.Add(this.istatistik);
            this.groupBox2.Controls.Add(this.temizle);
            this.groupBox2.Controls.Add(this.güncelle);
            this.groupBox2.Controls.Add(this.sil);
            this.groupBox2.Controls.Add(this.kaydet);
            this.groupBox2.Controls.Add(this.listele);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Location = new System.Drawing.Point(434, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 414);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // grafik
            // 
            this.grafik.BackColor = System.Drawing.Color.LightCoral;
            this.grafik.Location = new System.Drawing.Point(95, 352);
            this.grafik.Name = "grafik";
            this.grafik.Size = new System.Drawing.Size(132, 29);
            this.grafik.TabIndex = 1;
            this.grafik.Text = "GRAFİK";
            this.grafik.UseVisualStyleBackColor = false;
            // 
            // istatistik
            // 
            this.istatistik.BackColor = System.Drawing.Color.LightCoral;
            this.istatistik.Location = new System.Drawing.Point(95, 297);
            this.istatistik.Name = "istatistik";
            this.istatistik.Size = new System.Drawing.Size(132, 29);
            this.istatistik.TabIndex = 1;
            this.istatistik.Text = "İSTATİSTİK";
            this.istatistik.UseVisualStyleBackColor = false;
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.Color.LightCoral;
            this.temizle.Location = new System.Drawing.Point(95, 245);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(132, 29);
            this.temizle.TabIndex = 1;
            this.temizle.Text = "TEMİZLE";
            this.temizle.UseVisualStyleBackColor = false;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // güncelle
            // 
            this.güncelle.BackColor = System.Drawing.Color.LightCoral;
            this.güncelle.Location = new System.Drawing.Point(95, 195);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(132, 29);
            this.güncelle.TabIndex = 1;
            this.güncelle.Text = "GÜNCELLE";
            this.güncelle.UseVisualStyleBackColor = false;
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.LightCoral;
            this.sil.Location = new System.Drawing.Point(95, 146);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(132, 29);
            this.sil.TabIndex = 1;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.LightCoral;
            this.kaydet.Location = new System.Drawing.Point(95, 91);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(132, 29);
            this.kaydet.TabIndex = 1;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.persehirDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 208);
            this.dataGridView1.TabIndex = 3;
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "perad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "perad";
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "persoyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "persoyad";
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            // 
            // persehirDataGridViewTextBoxColumn
            // 
            this.persehirDataGridViewTextBoxColumn.DataPropertyName = "persehir";
            this.persehirDataGridViewTextBoxColumn.HeaderText = "persehir";
            this.persehirDataGridViewTextBoxColumn.Name = "persehirDataGridViewTextBoxColumn";
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "permaas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "permaas";
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.personelVeriTabaniDataSet4;
            // 
            // personelVeriTabaniDataSet4
            // 
            this.personelVeriTabaniDataSet4.DataSetName = "PersonelVeriTabaniDataSet4";
            this.personelVeriTabaniDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(774, 729);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox perıd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox permaas;
        private System.Windows.Forms.RadioButton perbekar;
        private System.Windows.Forms.RadioButton perevli;
        private System.Windows.Forms.ComboBox persehir;
        private System.Windows.Forms.TextBox permeslek;
        private System.Windows.Forms.TextBox persoyad;
        private System.Windows.Forms.TextBox perad;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button grafik;
        private System.Windows.Forms.Button istatistik;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabaniDataSet4 personelVeriTabaniDataSet4;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private PersonelVeriTabaniDataSet4TableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

