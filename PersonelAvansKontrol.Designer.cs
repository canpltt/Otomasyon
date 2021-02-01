namespace Magazacilik_Otomasyonu
{
    partial class PersonelAvansKontrol
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
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kasiyerAvansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSet7 = new Magazacilik_Otomasyonu.ProjeDataSet7();
            this.kasiyer_AvansTableAdapter = new Magazacilik_Otomasyonu.ProjeDataSet7TableAdapters.Kasiyer_AvansTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kasiyerAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.kasiyerAvansBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projeDataSet8 = new Magazacilik_Otomasyonu.ProjeDataSet8();
            this.kasiyer_AvansTableAdapter1 = new Magazacilik_Otomasyonu.ProjeDataSet8TableAdapters.Kasiyer_AvansTableAdapter();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerAvansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerAvansBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1213, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // kasiyerAvansBindingSource
            // 
            this.kasiyerAvansBindingSource.DataMember = "Kasiyer_Avans";
            this.kasiyerAvansBindingSource.DataSource = this.projeDataSet7;
            // 
            // projeDataSet7
            // 
            this.projeDataSet7.DataSetName = "ProjeDataSet7";
            this.projeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasiyer_AvansTableAdapter
            // 
            this.kasiyer_AvansTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.kasiyerAvansBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1343, 345);
            this.dataGridView1.TabIndex = 2;
            // 
            // kasiyerAdiDataGridViewTextBoxColumn
            // 
            this.kasiyerAdiDataGridViewTextBoxColumn.DataPropertyName = "Kasiyer_Adi";
            this.kasiyerAdiDataGridViewTextBoxColumn.HeaderText = "Kasiyer Adı";
            this.kasiyerAdiDataGridViewTextBoxColumn.Name = "kasiyerAdiDataGridViewTextBoxColumn";
            this.kasiyerAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ikiyuztlDataGridViewTextBoxColumn
            // 
            this.ikiyuztlDataGridViewTextBoxColumn.DataPropertyName = "ikiyuztl";
            this.ikiyuztlDataGridViewTextBoxColumn.HeaderText = "200 TL";
            this.ikiyuztlDataGridViewTextBoxColumn.Name = "ikiyuztlDataGridViewTextBoxColumn";
            this.ikiyuztlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yuztlDataGridViewTextBoxColumn
            // 
            this.yuztlDataGridViewTextBoxColumn.DataPropertyName = "yuztl";
            this.yuztlDataGridViewTextBoxColumn.HeaderText = "100 TL";
            this.yuztlDataGridViewTextBoxColumn.Name = "yuztlDataGridViewTextBoxColumn";
            this.yuztlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ellitlDataGridViewTextBoxColumn
            // 
            this.ellitlDataGridViewTextBoxColumn.DataPropertyName = "ellitl";
            this.ellitlDataGridViewTextBoxColumn.HeaderText = "50 TL";
            this.ellitlDataGridViewTextBoxColumn.Name = "ellitlDataGridViewTextBoxColumn";
            this.ellitlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yirmitlDataGridViewTextBoxColumn
            // 
            this.yirmitlDataGridViewTextBoxColumn.DataPropertyName = "yirmitl";
            this.yirmitlDataGridViewTextBoxColumn.HeaderText = "20 TL";
            this.yirmitlDataGridViewTextBoxColumn.Name = "yirmitlDataGridViewTextBoxColumn";
            this.yirmitlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ontlDataGridViewTextBoxColumn
            // 
            this.ontlDataGridViewTextBoxColumn.DataPropertyName = "ontl";
            this.ontlDataGridViewTextBoxColumn.HeaderText = "10 TL";
            this.ontlDataGridViewTextBoxColumn.Name = "ontlDataGridViewTextBoxColumn";
            this.ontlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bestlDataGridViewTextBoxColumn
            // 
            this.bestlDataGridViewTextBoxColumn.DataPropertyName = "bestl";
            this.bestlDataGridViewTextBoxColumn.HeaderText = "5 TL";
            this.bestlDataGridViewTextBoxColumn.Name = "bestlDataGridViewTextBoxColumn";
            this.bestlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birtlDataGridViewTextBoxColumn
            // 
            this.birtlDataGridViewTextBoxColumn.DataPropertyName = "birtl";
            this.birtlDataGridViewTextBoxColumn.HeaderText = "1 TL";
            this.birtlDataGridViewTextBoxColumn.Name = "birtlDataGridViewTextBoxColumn";
            this.birtlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ellikrsDataGridViewTextBoxColumn
            // 
            this.ellikrsDataGridViewTextBoxColumn.DataPropertyName = "ellikrs";
            this.ellikrsDataGridViewTextBoxColumn.HeaderText = "50 KRS";
            this.ellikrsDataGridViewTextBoxColumn.Name = "ellikrsDataGridViewTextBoxColumn";
            this.ellikrsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yirmibeskrsDataGridViewTextBoxColumn
            // 
            this.yirmibeskrsDataGridViewTextBoxColumn.DataPropertyName = "yirmibeskrs";
            this.yirmibeskrsDataGridViewTextBoxColumn.HeaderText = "25 KRS";
            this.yirmibeskrsDataGridViewTextBoxColumn.Name = "yirmibeskrsDataGridViewTextBoxColumn";
            this.yirmibeskrsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onkrsDataGridViewTextBoxColumn
            // 
            this.onkrsDataGridViewTextBoxColumn.DataPropertyName = "onkrs";
            this.onkrsDataGridViewTextBoxColumn.HeaderText = "10 KRS";
            this.onkrsDataGridViewTextBoxColumn.Name = "onkrsDataGridViewTextBoxColumn";
            this.onkrsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beskrsDataGridViewTextBoxColumn
            // 
            this.beskrsDataGridViewTextBoxColumn.DataPropertyName = "beskrs";
            this.beskrsDataGridViewTextBoxColumn.HeaderText = "5 KRS";
            this.beskrsDataGridViewTextBoxColumn.Name = "beskrsDataGridViewTextBoxColumn";
            this.beskrsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birkrsDataGridViewTextBoxColumn
            // 
            this.birkrsDataGridViewTextBoxColumn.DataPropertyName = "birkrs";
            this.birkrsDataGridViewTextBoxColumn.HeaderText = "1 KRS";
            this.birkrsDataGridViewTextBoxColumn.Name = "birkrsDataGridViewTextBoxColumn";
            this.birkrsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kasiyerAvansBindingSource1
            // 
            this.kasiyerAvansBindingSource1.DataMember = "Kasiyer_Avans";
            this.kasiyerAvansBindingSource1.DataSource = this.projeDataSet8;
            // 
            // projeDataSet8
            // 
            this.projeDataSet8.DataSetName = "ProjeDataSet8";
            this.projeDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasiyer_AvansTableAdapter1
            // 
            this.kasiyer_AvansTableAdapter1.ClearBeforeFill = true;
            // 
            // PersonelAvansKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magazacilik_Otomasyonu.Properties.Resources.Soft_Blue_Gradient_Background;
            this.ClientSize = new System.Drawing.Size(1213, 629);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByToolStrip);
            this.Name = "PersonelAvansKontrol";
            this.Text = "PersonelAvansKontrol";
            this.Load += new System.EventHandler(this.PersonelAvansKontrol_Load);
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerAvansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasiyerAvansBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProjeDataSet7 projeDataSet7;
        private System.Windows.Forms.BindingSource kasiyerAvansBindingSource;
        private ProjeDataSet7TableAdapters.Kasiyer_AvansTableAdapter kasiyer_AvansTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjeDataSet8 projeDataSet8;
        private System.Windows.Forms.BindingSource kasiyerAvansBindingSource1;
        private ProjeDataSet8TableAdapters.Kasiyer_AvansTableAdapter kasiyer_AvansTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasiyerAdiDataGridViewTextBoxColumn;
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
    }
}