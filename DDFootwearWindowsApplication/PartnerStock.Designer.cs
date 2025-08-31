namespace DDFootwearWindowsApplication
{
    partial class PartnerStock
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pARTNERSTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_DD_FootwearDataSetPartnerStock = new DDFootwearWindowsApplication.DB_DD_FootwearDataSetPartnerStock();
            this.fillByEmailPartnerToolStrip = new System.Windows.Forms.ToolStrip();
            this.emailToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.emailToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByEmailPartnerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.fillByProductIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.pIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByProductIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pARTNER_STOCKTableAdapter = new DDFootwearWindowsApplication.DB_DD_FootwearDataSetPartnerStockTableAdapters.PARTNER_STOCKTableAdapter();
            this.patStockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTNERSTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DD_FootwearDataSetPartnerStock)).BeginInit();
            this.fillByEmailPartnerToolStrip.SuspendLayout();
            this.fillByProductIDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patStockIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pARTNERSTOCKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(188, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // pARTNERSTOCKBindingSource
            // 
            this.pARTNERSTOCKBindingSource.DataMember = "PARTNER_STOCK";
            this.pARTNERSTOCKBindingSource.DataSource = this.dB_DD_FootwearDataSetPartnerStock;
            // 
            // dB_DD_FootwearDataSetPartnerStock
            // 
            this.dB_DD_FootwearDataSetPartnerStock.DataSetName = "DB_DD_FootwearDataSetPartnerStock";
            this.dB_DD_FootwearDataSetPartnerStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByEmailPartnerToolStrip
            // 
            this.fillByEmailPartnerToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByEmailPartnerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripLabel,
            this.emailToolStripTextBox,
            this.fillByEmailPartnerToolStripButton});
            this.fillByEmailPartnerToolStrip.Location = new System.Drawing.Point(589, 0);
            this.fillByEmailPartnerToolStrip.Name = "fillByEmailPartnerToolStrip";
            this.fillByEmailPartnerToolStrip.Size = new System.Drawing.Size(259, 25);
            this.fillByEmailPartnerToolStrip.TabIndex = 1;
            this.fillByEmailPartnerToolStrip.Text = "fillByEmailPartnerToolStrip";
            // 
            // emailToolStripLabel
            // 
            this.emailToolStripLabel.Name = "emailToolStripLabel";
            this.emailToolStripLabel.Size = new System.Drawing.Size(39, 22);
            this.emailToolStripLabel.Text = "email:";
            // 
            // emailToolStripTextBox
            // 
            this.emailToolStripTextBox.Name = "emailToolStripTextBox";
            this.emailToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByEmailPartnerToolStripButton
            // 
            this.fillByEmailPartnerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByEmailPartnerToolStripButton.Name = "fillByEmailPartnerToolStripButton";
            this.fillByEmailPartnerToolStripButton.Size = new System.Drawing.Size(106, 22);
            this.fillByEmailPartnerToolStripButton.Text = "FillByEmailPartner";
            this.fillByEmailPartnerToolStripButton.Click += new System.EventHandler(this.fillByEmailPartnerToolStripButton_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(405, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Salmon;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(717, 329);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 32);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(296, 296);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 34);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(296, 264);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(212, 26);
            this.txtSearchBox.TabIndex = 8;
            // 
            // fillByProductIDToolStrip
            // 
            this.fillByProductIDToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByProductIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pIDToolStripLabel,
            this.pIDToolStripTextBox,
            this.fillByProductIDToolStripButton});
            this.fillByProductIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByProductIDToolStrip.Name = "fillByProductIDToolStrip";
            this.fillByProductIDToolStrip.Size = new System.Drawing.Size(234, 25);
            this.fillByProductIDToolStrip.TabIndex = 12;
            this.fillByProductIDToolStrip.Text = "fillByProductIDToolStrip";
            // 
            // pIDToolStripLabel
            // 
            this.pIDToolStripLabel.Name = "pIDToolStripLabel";
            this.pIDToolStripLabel.Size = new System.Drawing.Size(28, 22);
            this.pIDToolStripLabel.Text = "pID:";
            // 
            // pIDToolStripTextBox
            // 
            this.pIDToolStripTextBox.Name = "pIDToolStripTextBox";
            this.pIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByProductIDToolStripButton
            // 
            this.fillByProductIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByProductIDToolStripButton.Name = "fillByProductIDToolStripButton";
            this.fillByProductIDToolStripButton.Size = new System.Drawing.Size(92, 22);
            this.fillByProductIDToolStripButton.Text = "FillByProductID";
            this.fillByProductIDToolStripButton.Click += new System.EventHandler(this.fillByProductIDToolStripButton_Click);
            // 
            // pARTNER_STOCKTableAdapter
            // 
            this.pARTNER_STOCKTableAdapter.ClearBeforeFill = true;
            // 
            // patStockIDDataGridViewTextBoxColumn
            // 
            this.patStockIDDataGridViewTextBoxColumn.DataPropertyName = "patStockID";
            this.patStockIDDataGridViewTextBoxColumn.HeaderText = "Partner Stock ID";
            this.patStockIDDataGridViewTextBoxColumn.Name = "patStockIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "User Email";
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            // 
            // PartnerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDFootwearWindowsApplication.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 373);
            this.Controls.Add(this.fillByProductIDToolStrip);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.fillByEmailPartnerToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "PartnerStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartnerStock";
            this.Load += new System.EventHandler(this.PartnerStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTNERSTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DD_FootwearDataSetPartnerStock)).EndInit();
            this.fillByEmailPartnerToolStrip.ResumeLayout(false);
            this.fillByEmailPartnerToolStrip.PerformLayout();
            this.fillByProductIDToolStrip.ResumeLayout(false);
            this.fillByProductIDToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_DD_FootwearDataSetPartnerStock dB_DD_FootwearDataSetPartnerStock;
        private System.Windows.Forms.BindingSource pARTNERSTOCKBindingSource;
        private DB_DD_FootwearDataSetPartnerStockTableAdapters.PARTNER_STOCKTableAdapter pARTNER_STOCKTableAdapter;
        private System.Windows.Forms.ToolStrip fillByEmailPartnerToolStrip;
        private System.Windows.Forms.ToolStripLabel emailToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox emailToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByEmailPartnerToolStripButton;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ToolStrip fillByProductIDToolStrip;
        private System.Windows.Forms.ToolStripLabel pIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox pIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByProductIDToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn patStockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
    }
}