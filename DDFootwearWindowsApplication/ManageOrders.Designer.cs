namespace DDFootwearWindowsApplication
{
    partial class ManageOrders
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDDFootwearDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_DD_FootwearDataSet = new DDFootwearWindowsApplication.DB_DD_FootwearDataSet();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisplayAmount = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_DD_FootwearDataSet1 = new DDFootwearWindowsApplication.DB_DD_FootwearDataSet1();
            this.txtDisTotal = new System.Windows.Forms.TextBox();
            this.lblDis = new System.Windows.Forms.Label();
            this.pRODUCTTableAdapter = new DDFootwearWindowsApplication.DB_DD_FootwearDataSetTableAdapters.PRODUCTTableAdapter();
            this.oRDERSTableAdapter = new DDFootwearWindowsApplication.DB_DD_FootwearDataSet1TableAdapters.ORDERSTableAdapter();
            this.pRODUCTTableAdapter1 = new DDFootwearWindowsApplication.DB_DD_FootwearDataSet1TableAdapters.PRODUCTTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDDFootwearDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DD_FootwearDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DD_FootwearDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(126, 50);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(126, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(126, 91);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(126, 20);
            this.txtQty.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(177, 198);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.dBDDFootwearDataSetBindingSource;
            // 
            // dBDDFootwearDataSetBindingSource
            // 
            this.dBDDFootwearDataSetBindingSource.DataSource = this.dB_DD_FootwearDataSet;
            this.dBDDFootwearDataSetBindingSource.Position = 0;
            // 
            // dB_DD_FootwearDataSet
            // 
            this.dB_DD_FootwearDataSet.DataSetName = "DB_DD_FootwearDataSet";
            this.dB_DD_FootwearDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(126, 133);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(126, 20);
            this.txtOrderID.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order ID";
            // 
            // txtDisplayAmount
            // 
            this.txtDisplayAmount.Location = new System.Drawing.Point(126, 283);
            this.txtDisplayAmount.Name = "txtDisplayAmount";
            this.txtDisplayAmount.Size = new System.Drawing.Size(159, 20);
            this.txtDisplayAmount.TabIndex = 8;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(126, 335);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(79, 23);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "Pay Here";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.sizeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(305, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // sizeIDDataGridViewTextBoxColumn
            // 
            this.sizeIDDataGridViewTextBoxColumn.DataPropertyName = "sizeID";
            this.sizeIDDataGridViewTextBoxColumn.HeaderText = "sizeID";
            this.sizeIDDataGridViewTextBoxColumn.Name = "sizeIDDataGridViewTextBoxColumn";
            // 
            // pRODUCTBindingSource1
            // 
            this.pRODUCTBindingSource1.DataMember = "PRODUCT";
            this.pRODUCTBindingSource1.DataSource = this.dB_DD_FootwearDataSet1;
            // 
            // dB_DD_FootwearDataSet1
            // 
            this.dB_DD_FootwearDataSet1.DataSetName = "DB_DD_FootwearDataSet1";
            this.dB_DD_FootwearDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDisTotal
            // 
            this.txtDisTotal.Location = new System.Drawing.Point(126, 309);
            this.txtDisTotal.Name = "txtDisTotal";
            this.txtDisTotal.ReadOnly = true;
            this.txtDisTotal.Size = new System.Drawing.Size(159, 20);
            this.txtDisTotal.TabIndex = 11;
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.Location = new System.Drawing.Point(41, 312);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(70, 13);
            this.lblDis.TabIndex = 12;
            this.lblDis.Text = "Total Amount";
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // oRDERSTableAdapter
            // 
            this.oRDERSTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTTableAdapter1
            // 
            this.pRODUCTTableAdapter1.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(743, 335);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 31);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Logout";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtStockID
            // 
            this.txtStockID.Location = new System.Drawing.Point(126, 172);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(126, 20);
            this.txtStockID.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stock ID";
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDFootwearWindowsApplication.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 373);
            this.Controls.Add(this.txtStockID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.txtDisTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtDisplayAmount);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ManageOrders";
            this.Text = "Manage Orders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDDFootwearDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DD_FootwearDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DD_FootwearDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.BindingSource dBDDFootwearDataSetBindingSource;
        private DB_DD_FootwearDataSet dB_DD_FootwearDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private DB_DD_FootwearDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisplayAmount;
        private System.Windows.Forms.Button btnPayment;
        private DB_DD_FootwearDataSet1TableAdapters.ORDERSTableAdapter oRDERSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtDisTotal;
        private System.Windows.Forms.Label lblDis;
        private DB_DD_FootwearDataSet1 dB_DD_FootwearDataSet1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource1;
        private DB_DD_FootwearDataSet1TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtStockID;
        private System.Windows.Forms.Label label4;
    }
}