namespace Magazacilik_Otomasyonu
{
    partial class PersonelGoruntule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sicilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciListesiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSet2 = new Magazacilik_Otomasyonu.ProjeDataSet2();
            this.kullaniciListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSet1 = new Magazacilik_Otomasyonu.ProjeDataSet1();
            this.kullanici_ListesiTableAdapter = new Magazacilik_Otomasyonu.ProjeDataSet1TableAdapters.Kullanici_ListesiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.kullanici_ListesiTableAdapter1 = new Magazacilik_Otomasyonu.ProjeDataSet2TableAdapters.Kullanici_ListesiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciListesiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sicilDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullaniciListesiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(554, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // sicilDataGridViewTextBoxColumn
            // 
            this.sicilDataGridViewTextBoxColumn.DataPropertyName = "Sicil";
            this.sicilDataGridViewTextBoxColumn.HeaderText = "Sicil";
            this.sicilDataGridViewTextBoxColumn.Name = "sicilDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "Telefon_No";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.Width = 115;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail Adresi";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // kullaniciListesiBindingSource1
            // 
            this.kullaniciListesiBindingSource1.DataMember = "Kullanici_Listesi";
            this.kullaniciListesiBindingSource1.DataSource = this.projeDataSet2;
            // 
            // projeDataSet2
            // 
            this.projeDataSet2.DataSetName = "ProjeDataSet2";
            this.projeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciListesiBindingSource
            // 
            this.kullaniciListesiBindingSource.DataMember = "Kullanici_Listesi";
            this.kullaniciListesiBindingSource.DataSource = this.projeDataSet1;
            // 
            // projeDataSet1
            // 
            this.projeDataSet1.DataSetName = "ProjeDataSet1";
            this.projeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanici_ListesiTableAdapter
            // 
            this.kullanici_ListesiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullanici_ListesiTableAdapter1
            // 
            this.kullanici_ListesiTableAdapter1.ClearBeforeFill = true;
            // 
            // PersonelGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magazacilik_Otomasyonu.Properties.Resources.Soft_Blue_Gradient_Background;
            this.ClientSize = new System.Drawing.Size(1278, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PersonelGoruntule";
            this.Text = "Personel Görüntüle";
            this.Load += new System.EventHandler(this.PersonelGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciListesiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjeDataSet1 projeDataSet1;
        private System.Windows.Forms.BindingSource kullaniciListesiBindingSource;
        private ProjeDataSet1TableAdapters.Kullanici_ListesiTableAdapter kullanici_ListesiTableAdapter;
        private System.Windows.Forms.Button button1;
        private ProjeDataSet2 projeDataSet2;
        private System.Windows.Forms.BindingSource kullaniciListesiBindingSource1;
        private ProjeDataSet2TableAdapters.Kullanici_ListesiTableAdapter kullanici_ListesiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
    }
}