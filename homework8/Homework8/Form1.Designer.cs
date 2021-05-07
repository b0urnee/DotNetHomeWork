namespace Homework8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Addorder = new System.Windows.Forms.Button();
            this.OUTOrder = new System.Windows.Forms.Button();
            this.INOrder = new System.Windows.Forms.Button();
            this.ROrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchWay = new System.Windows.Forms.ComboBox();
            this.Return = new System.Windows.Forms.Button();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.OrderDetailView = new System.Windows.Forms.DataGridView();
            this.OrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OrderDetailView);
            this.splitContainer1.Panel2.Controls.Add(this.OrderView);
            this.splitContainer1.Size = new System.Drawing.Size(1204, 450);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.OUTOrder);
            this.panel1.Controls.Add(this.INOrder);
            this.panel1.Controls.Add(this.ROrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchWay);
            this.panel1.Controls.Add(this.Return);
            this.panel1.Controls.Add(this.Searchtxt);
            this.panel1.Controls.Add(this.Searchbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 132);
            this.panel1.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(342, 83);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(85, 35);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "删除订单";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Addorder);
            this.groupBox1.Location = new System.Drawing.Point(728, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加订单";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(283, 33);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(100, 25);
            this.TxtAddress.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "配送地址";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(84, 71);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 25);
            this.TxtName.TabIndex = 12;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(84, 29);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 25);
            this.TxtID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "顾客姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "订单号";
            // 
            // Addorder
            // 
            this.Addorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Addorder.Location = new System.Drawing.Point(347, 68);
            this.Addorder.Name = "Addorder";
            this.Addorder.Size = new System.Drawing.Size(91, 36);
            this.Addorder.TabIndex = 8;
            this.Addorder.Text = "添加";
            this.Addorder.UseVisualStyleBackColor = true;
            this.Addorder.Click += new System.EventHandler(this.Addorder_Click);
            // 
            // OUTOrder
            // 
            this.OUTOrder.Location = new System.Drawing.Point(226, 83);
            this.OUTOrder.Name = "OUTOrder";
            this.OUTOrder.Size = new System.Drawing.Size(90, 36);
            this.OUTOrder.TabIndex = 7;
            this.OUTOrder.Text = "导出订单";
            this.OUTOrder.UseVisualStyleBackColor = true;
            this.OUTOrder.Click += new System.EventHandler(this.OUTOrder_Click);
            // 
            // INOrder
            // 
            this.INOrder.Location = new System.Drawing.Point(117, 83);
            this.INOrder.Name = "INOrder";
            this.INOrder.Size = new System.Drawing.Size(90, 35);
            this.INOrder.TabIndex = 6;
            this.INOrder.Text = "导入订单";
            this.INOrder.UseVisualStyleBackColor = true;
            this.INOrder.Click += new System.EventHandler(this.INOrder_Click);
            // 
            // ROrder
            // 
            this.ROrder.Location = new System.Drawing.Point(12, 83);
            this.ROrder.Name = "ROrder";
            this.ROrder.Size = new System.Drawing.Size(85, 35);
            this.ROrder.TabIndex = 5;
            this.ROrder.Text = "修改订单";
            this.ROrder.UseVisualStyleBackColor = true;
            this.ROrder.Click += new System.EventHandler(this.ROrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "请选择查询的类型";
            // 
            // SearchWay
            // 
            this.SearchWay.BackColor = System.Drawing.SystemColors.Window;
            this.SearchWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchWay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchWay.FormattingEnabled = true;
            this.SearchWay.Items.AddRange(new object[] {
            "订单号",
            "客户名",
            "商品名"});
            this.SearchWay.Location = new System.Drawing.Point(12, 40);
            this.SearchWay.Name = "SearchWay";
            this.SearchWay.Size = new System.Drawing.Size(121, 23);
            this.SearchWay.TabIndex = 3;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(372, 35);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 32);
            this.Return.TabIndex = 2;
            this.Return.Text = "返回";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Location = new System.Drawing.Point(157, 40);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(100, 25);
            this.Searchtxt.TabIndex = 1;
            // 
            // Searchbtn
            // 
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Searchbtn.Location = new System.Drawing.Point(276, 35);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 32);
            this.Searchbtn.TabIndex = 0;
            this.Searchbtn.Text = "查询";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // OrderDetailView
            // 
            this.OrderDetailView.AutoGenerateColumns = false;
            this.OrderDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.OrderDetailView.DataSource = this.OrderDetailsBindingSource;
            this.OrderDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDetailView.Location = new System.Drawing.Point(677, 0);
            this.OrderDetailView.Name = "OrderDetailView";
            this.OrderDetailView.RowHeadersWidth = 51;
            this.OrderDetailView.RowTemplate.Height = 27;
            this.OrderDetailView.Size = new System.Drawing.Size(527, 314);
            this.OrderDetailView.TabIndex = 1;
            // 
            // OrderDetailsBindingSource
            // 
            this.OrderDetailsBindingSource.DataMember = "Orderde";
            this.OrderDetailsBindingSource.DataSource = this.OrderBindingSource;
            // 
            // OrderView
            // 
            this.OrderView.AutoGenerateColumns = false;
            this.OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.orderAddressDataGridViewTextBoxColumn});
            this.OrderView.DataSource = this.OrderBindingSource;
            this.OrderView.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrderView.Location = new System.Drawing.Point(0, 0);
            this.OrderView.Name = "OrderView";
            this.OrderView.RowHeadersWidth = 51;
            this.OrderView.RowTemplate.Height = 27;
            this.OrderView.Size = new System.Drawing.Size(677, 314);
            this.OrderView.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(Homework8.Order);
            // 
            // orderNumDataGridViewTextBoxColumn
            // 
            this.orderNumDataGridViewTextBoxColumn.DataPropertyName = "OrderNum";
            this.orderNumDataGridViewTextBoxColumn.HeaderText = "OrderNum";
            this.orderNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderNumDataGridViewTextBoxColumn.Name = "orderNumDataGridViewTextBoxColumn";
            this.orderNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderAddressDataGridViewTextBoxColumn
            // 
            this.orderAddressDataGridViewTextBoxColumn.DataPropertyName = "OrderAddress";
            this.orderAddressDataGridViewTextBoxColumn.HeaderText = "OrderAddress";
            this.orderAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderAddressDataGridViewTextBoxColumn.Name = "orderAddressDataGridViewTextBoxColumn";
            this.orderAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Goods";
            this.dataGridViewTextBoxColumn1.HeaderText = "Goods";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Num";
            this.dataGridViewTextBoxColumn3.HeaderText = "Num";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "订单管理";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView OrderView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView OrderDetailView;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.ComboBox SearchWay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OUTOrder;
        private System.Windows.Forms.Button INOrder;
        private System.Windows.Forms.Button ROrder;
        private System.Windows.Forms.TextBox Searchtxt;
        public System.Windows.Forms.BindingSource OrderDetailsBindingSource;
        private System.Windows.Forms.Button Addorder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

