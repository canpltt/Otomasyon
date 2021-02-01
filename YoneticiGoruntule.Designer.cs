namespace Magazacilik_Otomasyonu
{
    partial class YoneticiGoruntule
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
            this.button1 = new System.Windows.Forms.Button();
            this.projeDataSet3 = new Magazacilik_Otomasyonu.ProjeDataSet3();
            this.yoneticiListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yonetici_ListesiTableAdapter = new Magazacilik_Otomasyonu.ProjeDataSet3TableAdapters.Yonetici_ListesiTableAdapter();
            this.yoneticiListesiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSet4 = new Magazacilik_Otomasyonu.ProjeDataSet4();
            this.yonetici_ListesiTableAdapter1 = new Magazacilik_Otomasyonu.ProjeDataSet4TableAdapters.Yonetici_ListesiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sicilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiListesiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSet5 = new Magazacilik_Otomasyonu.ProjeDataSet5();
            this.yonetici_ListesiTableAdapter2 = new Magazacilik_Otomasyonu.ProjeDataSet5TableAdapters.Yonetici_ListesiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiListesiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiListesiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projeDataSet3
            // 
            this.projeDataSet3.DataSetName = "ProjeDataSet3";
            this.projeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yoneticiListesiBindingSource
            // 
            this.yoneticiListesiBindingSource.DataMember = "Yonetici_Listesi";
            this.yoneticiListesiBindingSource.DataSource = this.projeDataSet3;
            // 
            // yonetici_ListesiTableAdapter
            // 
            this.yonetici_ListesiTableAdapter.ClearBeforeFill = true;
            // 
            // yoneticiListesiBindingSource1
            // 
            this.yoneticiListesiBindingSource1.DataMember = "Yonetici_Listesi";
            this.yoneticiListesiBindingSource1.DataSource = this.projeDataSet4;
            // 
            // projeDataSet4
            // 
            this.projeDataSet4.DataSetName = "ProjeDataSet4";
            this.projeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yonetici_ListesiTableAdapter1
            // 
            this.yonetici_ListesiTableAdapter1.ClearBeforeFill = true;
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
            this.pozisyonDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.yoneticiListesiBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(649, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 335);
            this.dataGridView1.TabIndex = 3;
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
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
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
            // pozisyonDataGridViewTextBoxColumn
            // 
            this.pozisyonDataGridViewTextBoxColumn.DataPropertyName = "Pozisyon";
            this.pozisyonDataGridViewTextBoxColumn.HeaderText = "Pozisyon";
            this.pozisyonDataGridViewTextBoxColumn.Name = "pozisyonDataGridViewTextBoxColumn";
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "Telefon_No";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.Width = 115;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mail Adresi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // yoneticiListesiBindingSource2
            // 
            this.yoneticiListesiBindingSource2.DataMember = "Yonetici_Listesi";
            this.yoneticiListesiBindingSource2.DataSource = this.projeDataSet5;
            // 
            // projeDataSet5
            // 
            this.projeDataSet5.DataSetName = "ProjeDataSet5";
            this.projeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yonetici_ListesiTableAdapter2
            // 
            this.yonetici_ListesiTableAdapter2.ClearBeforeFill = true;
            // 
            // YoneticiGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magazacilik_Otomasyonu.Properties.Resources.Soft_Blue_Gradient_Background;
            this.ClientSize = new System.Drawing.Size(1599, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "YoneticiGoruntule";
            this.Text = "Yöneticileri Görüntüle";
            this.Load += new System.EventHandler(this.YoneticiGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiListesiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiListesiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ProjeDataSet3 projeDataSet3;
        private System.Windows.Forms.BindingSource yoneticiListesiBindingSource;
        private ProjeDataSet3TableAdapters.Yonetici_ListesiTableAdapter yonetici_ListesiTableAdapter;
        private ProjeDataSet4 projeDataSet4;
        private System.Windows.Forms.BindingSource yoneticiListesiBindingSource1;
        private ProjeDataSet4TableAdapters.Yonetici_ListesiTableAdapter yonetici_ListesiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjeDataSet5 projeDataSet5;
        private System.Windows.Forms.BindingSource yoneticiListesiBindingSource2;
        private ProjeDataSet5TableAdapters.Yonetici_ListesiTableAdapter yonetici_ListesiTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozisyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}