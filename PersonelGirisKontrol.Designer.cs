namespace Magazacilik_Otomasyonu
{
    partial class PersonelGirisKontrol
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
            this.projeDataSet9 = new Magazacilik_Otomasyonu.ProjeDataSet9();
            this.kasiyerGirisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasiyer_GirisTableAdapter = new Magazacilik_Otomasyonu.ProjeDataSet9TableAdapters.Kasiyer_GirisTableAdapter();
            this.kasiyerAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasiyerSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikiyuztlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yuztlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ellitlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yirmitlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ontlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bestlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ellikrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yirmibeskrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onkrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beskrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birkrsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerGirisBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kasiyerAdiDataGridViewTextBoxColumn,
            this.kasiyerSoyadiDataGridViewTextBoxColumn,
            this.ikiyuztlDataGridViewTextBoxColumn,
            this.yuztlDataGridViewTextBoxColumn,
            this.ellitlDataGridViewTextBoxColumn,
            this.yirmitlDataGridViewTextBoxColumn,
            this.ontlDataGridViewTextBoxColumn,
            this.bestlDataGridViewTextBoxColumn,
            this.birtlDataGridViewTextBoxColumn,
            this.ellikrsDataGridViewTextBoxColumn,
            this.yirmibeskrsDataGridViewTextBoxColumn,
            this.onkrsDataGridViewTextBoxColumn,
            this.beskrsDataGridViewTextBoxColumn,
            this.birkrsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kasiyerGirisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1443, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // projeDataSet9
            // 
            this.projeDataSet9.DataSetName = "ProjeDataSet9";
            this.projeDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasiyerGirisBindingSource
            // 
            this.kasiyerGirisBindingSource.DataMember = "Kasiyer_Giris";
            this.kasiyerGirisBindingSource.DataSource = this.projeDataSet9;
            // 
            // kasiyer_GirisTableAdapter
            // 
            this.kasiyer_GirisTableAdapter.ClearBeforeFill = true;
            // 
            // kasiyerAdiDataGridViewTextBoxColumn
            // 
            this.kasiyerAdiDataGridViewTextBoxColumn.DataPropertyName = "Kasiyer_Adi";
            this.kasiyerAdiDataGridViewTextBoxColumn.HeaderText = "Kasiyer Adı";
            this.kasiyerAdiDataGridViewTextBoxColumn.Name = "kasiyerAdiDataGridViewTextBoxColumn";
            // 
            // kasiyerSoyadiDataGridViewTextBoxColumn
            // 
            this.kasiyerSoyadiDataGridViewTextBoxColumn.DataPropertyName = "Kasiyer_Soyadi";
            this.kasiyerSoyadiDataGridViewTextBoxColumn.HeaderText = "Kasiyer Soyadı";
            this.kasiyerSoyadiDataGridViewTextBoxColumn.Name = "kasiyerSoyadiDataGridViewTextBoxColumn";
            // 
            // ikiyuztlDataGridViewTextBoxColumn
            // 
            this.ikiyuztlDataGridViewTextBoxColumn.DataPropertyName = "ikiyuztl";
            this.ikiyuztlDataGridViewTextBoxColumn.HeaderText = "200 TL";
            this.ikiyuztlDataGridViewTextBoxColumn.Name = "ikiyuztlDataGridViewTextBoxColumn";
            // 
            // yuztlDataGridViewTextBoxColumn
            // 
            this.yuztlDataGridViewTextBoxColumn.DataPropertyName = "yuztl";
            this.yuztlDataGridViewTextBoxColumn.HeaderText = "200 TL";
            this.yuztlDataGridViewTextBoxColumn.Name = "yuztlDataGridViewTextBoxColumn";
            // 
            // ellitlDataGridViewTextBoxColumn
            // 
            this.ellitlDataGridViewTextBoxColumn.DataPropertyName = "ellitl";
            this.ellitlDataGridViewTextBoxColumn.HeaderText = "50 TL";
            this.ellitlDataGridViewTextBoxColumn.Name = "ellitlDataGridViewTextBoxColumn";
            // 
            // yirmitlDataGridViewTextBoxColumn
            // 
            this.yirmitlDataGridViewTextBoxColumn.DataPropertyName = "yirmitl";
            this.yirmitlDataGridViewTextBoxColumn.HeaderText = "20 TL";
            this.yirmitlDataGridViewTextBoxColumn.Name = "yirmitlDataGridViewTextBoxColumn";
            // 
            // ontlDataGridViewTextBoxColumn
            // 
            this.ontlDataGridViewTextBoxColumn.DataPropertyName = "ontl";
            this.ontlDataGridViewTextBoxColumn.HeaderText = "10 TL";
            this.ontlDataGridViewTextBoxColumn.Name = "ontlDataGridViewTextBoxColumn";
            // 
            // bestlDataGridViewTextBoxColumn
            // 
            this.bestlDataGridViewTextBoxColumn.DataPropertyName = "bestl";
            this.bestlDataGridViewTextBoxColumn.HeaderText = "5 TL";
            this.bestlDataGridViewTextBoxColumn.Name = "bestlDataGridViewTextBoxColumn";
            // 
            // birtlDataGridViewTextBoxColumn
            // 
            this.birtlDataGridViewTextBoxColumn.DataPropertyName = "birtl";
            this.birtlDataGridViewTextBoxColumn.HeaderText = "1 TL";
            this.birtlDataGridViewTextBoxColumn.Name = "birtlDataGridViewTextBoxColumn";
            // 
            // ellikrsDataGridViewTextBoxColumn
            // 
            this.ellikrsDataGridViewTextBoxColumn.DataPropertyName = "ellikrs";
            this.ellikrsDataGridViewTextBoxColumn.HeaderText = "50 KRS";
            this.ellikrsDataGridViewTextBoxColumn.Name = "ellikrsDataGridViewTextBoxColumn";
            // 
            // yirmibeskrsDataGridViewTextBoxColumn
            // 
            this.yirmibeskrsDataGridViewTextBoxColumn.DataPropertyName = "yirmibeskrs";
            this.yirmibeskrsDataGridViewTextBoxColumn.HeaderText = "25 KRS";
            this.yirmibeskrsDataGridViewTextBoxColumn.Name = "yirmibeskrsDataGridViewTextBoxColumn";
            // 
            // onkrsDataGridViewTextBoxColumn
            // 
            this.onkrsDataGridViewTextBoxColumn.DataPropertyName = "onkrs";
            this.onkrsDataGridViewTextBoxColumn.HeaderText = "10 KRS";
            this.onkrsDataGridViewTextBoxColumn.Name = "onkrsDataGridViewTextBoxColumn";
            // 
            // beskrsDataGridViewTextBoxColumn
            // 
            this.beskrsDataGridViewTextBoxColumn.DataPropertyName = "beskrs";
            this.beskrsDataGridViewTextBoxColumn.HeaderText = "5 KRS";
            this.beskrsDataGridViewTextBoxColumn.Name = "beskrsDataGridViewTextBoxColumn";
            // 
            // birkrsDataGridViewTextBoxColumn
            // 
            this.birkrsDataGridViewTextBoxColumn.DataPropertyName = "birkrs";
            this.birkrsDataGridViewTextBoxColumn.HeaderText = "1 KRS";
            this.birkrsDataGridViewTextBoxColumn.Name = "birkrsDataGridViewTextBoxColumn";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1094, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // PersonelGirisKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magazacilik_Otomasyonu.Properties.Resources.Soft_Blue_Gradient_Background;
            this.ClientSize = new System.Drawing.Size(1094, 603);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PersonelGirisKontrol";
            this.Text = "PersonelGirisKontrol";
            this.Load += new System.EventHandler(this.PersonelGirisKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerGirisBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjeDataSet9 projeDataSet9;
        private System.Windows.Forms.BindingSource kasiyerGirisBindingSource;
        private ProjeDataSet9TableAdapters.Kasiyer_GirisTableAdapter kasiyer_GirisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasiyerAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasiyerSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikiyuztlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yuztlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ellitlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yirmitlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ontlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bestlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ellikrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yirmibeskrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onkrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beskrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birkrsDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}