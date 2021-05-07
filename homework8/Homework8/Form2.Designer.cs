namespace Homework8
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderCus = new System.Windows.Forms.TextBox();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.TimeLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Restore = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DetailView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddDetail = new System.Windows.Forms.Button();
            this.GoodsNum = new System.Windows.Forms.TextBox();
            this.GoodsPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GoodsName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteDetail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OrderCus);
            this.groupBox1.Controls.Add(this.OrderId);
            this.groupBox1.Controls.Add(this.TimeLab);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(492, 18);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 25);
            this.Address.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "地址";
            // 
            // OrderCus
            // 
            this.OrderCus.Location = new System.Drawing.Point(243, 65);
            this.OrderCus.Name = "OrderCus";
            this.OrderCus.Size = new System.Drawing.Size(100, 25);
            this.OrderCus.TabIndex = 5;
            // 
            // OrderId
            // 
            this.OrderId.Location = new System.Drawing.Point(243, 18);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(100, 25);
            this.OrderId.TabIndex = 4;
            // 
            // TimeLab
            // 
            this.TimeLab.AutoSize = true;
            this.TimeLab.Location = new System.Drawing.Point(240, 101);
            this.TimeLab.Name = "TimeLab";
            this.TimeLab.Size = new System.Drawing.Size(55, 15);
            this.TimeLab.TabIndex = 3;
            this.TimeLab.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "下单时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            // 
            // Restore
            // 
            this.Restore.Location = new System.Drawing.Point(654, 120);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(134, 32);
            this.Restore.TabIndex = 6;
            this.Restore.Text = "保存订单";
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DetailView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单明细";
            // 
            // DetailView
            // 
            this.DetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailView.Location = new System.Drawing.Point(3, 21);
            this.DetailView.Name = "DetailView";
            this.DetailView.RowHeadersWidth = 51;
            this.DetailView.RowTemplate.Height = 27;
            this.DetailView.Size = new System.Drawing.Size(794, 376);
            this.DetailView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteDetail);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.Restore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 158);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddDetail);
            this.groupBox3.Controls.Add(this.GoodsNum);
            this.groupBox3.Controls.Add(this.GoodsPrice);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.GoodsName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 158);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加订单明细";
            // 
            // AddDetail
            // 
            this.AddDetail.Location = new System.Drawing.Point(179, 129);
            this.AddDetail.Name = "AddDetail";
            this.AddDetail.Size = new System.Drawing.Size(75, 23);
            this.AddDetail.TabIndex = 6;
            this.AddDetail.Text = "添加";
            this.AddDetail.UseVisualStyleBackColor = true;
            this.AddDetail.Click += new System.EventHandler(this.AddDetail_Click);
            // 
            // GoodsNum
            // 
            this.GoodsNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodsNum.Location = new System.Drawing.Point(83, 95);
            this.GoodsNum.Name = "GoodsNum";
            this.GoodsNum.Size = new System.Drawing.Size(100, 25);
            this.GoodsNum.TabIndex = 5;
            // 
            // GoodsPrice
            // 
            this.GoodsPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodsPrice.Location = new System.Drawing.Point(83, 60);
            this.GoodsPrice.Name = "GoodsPrice";
            this.GoodsPrice.Size = new System.Drawing.Size(100, 25);
            this.GoodsPrice.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "商品数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "商品价格";
            // 
            // GoodsName
            // 
            this.GoodsName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoodsName.Location = new System.Drawing.Point(83, 25);
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.Size = new System.Drawing.Size(100, 25);
            this.GoodsName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "商品名称";
            // 
            // DeleteDetail
            // 
            this.DeleteDetail.Location = new System.Drawing.Point(508, 120);
            this.DeleteDetail.Name = "DeleteDetail";
            this.DeleteDetail.Size = new System.Drawing.Size(125, 32);
            this.DeleteDetail.TabIndex = 8;
            this.DeleteDetail.Text = "删除订单明细";
            this.DeleteDetail.UseVisualStyleBackColor = true;
            this.DeleteDetail.Click += new System.EventHandler(this.DeleteDetail_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "修改订单";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetailView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Restore;
        public System.Windows.Forms.Label TimeLab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView DetailView;
        public System.Windows.Forms.TextBox OrderCus;
        public System.Windows.Forms.TextBox OrderId;
        public System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AddDetail;
        private System.Windows.Forms.TextBox GoodsNum;
        private System.Windows.Forms.TextBox GoodsPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GoodsName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteDetail;
    }
}