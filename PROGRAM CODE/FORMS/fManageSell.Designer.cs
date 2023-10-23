namespace PROJECT
{
    partial class fManageSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManageSell));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnPaid = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lbTable = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTotalPrice);
            this.panel2.Controls.Add(this.btnPaid);
            this.panel2.Controls.Add(this.bunifuThinButton26);
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(700, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 693);
            this.panel2.TabIndex = 1;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.BorderColor = System.Drawing.Color.SeaGreen;
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.txbTotalPrice.Location = new System.Drawing.Point(254, 609);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(191, 35);
            this.txbTotalPrice.TabIndex = 12;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPaid
            // 
            this.btnPaid.ActiveBorderThickness = 1;
            this.btnPaid.ActiveCornerRadius = 20;
            this.btnPaid.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnPaid.ActiveForecolor = System.Drawing.Color.White;
            this.btnPaid.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnPaid.BackColor = System.Drawing.Color.Ivory;
            this.btnPaid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaid.BackgroundImage")));
            this.btnPaid.ButtonText = "Thanh toán";
            this.btnPaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaid.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaid.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPaid.IdleBorderThickness = 1;
            this.btnPaid.IdleCornerRadius = 80;
            this.btnPaid.IdleFillColor = System.Drawing.Color.Khaki;
            this.btnPaid.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnPaid.IdleLineColor = System.Drawing.Color.Khaki;
            this.btnPaid.Location = new System.Drawing.Point(455, 568);
            this.btnPaid.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(216, 109);
            this.btnPaid.TabIndex = 11;
            this.btnPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click_1);
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 20;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.BackColor = System.Drawing.Color.Ivory;
            this.bunifuThinButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton26.BackgroundImage")));
            this.bunifuThinButton26.ButtonText = "Hóa đơn";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton26.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 60;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.Khaki;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.Khaki;
            this.bunifuThinButton26.Location = new System.Drawing.Point(106, 0);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(504, 84);
            this.bunifuThinButton26.TabIndex = 11;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 93);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(676, 466);
            this.lsvBill.TabIndex = 3;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 177;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 113;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddProduct);
            this.panel3.Controls.Add(this.cbProduct);
            this.panel3.Controls.Add(this.lbTable);
            this.panel3.Controls.Add(this.cbCategory);
            this.panel3.Controls.Add(this.bunifuThinButton25);
            this.panel3.Controls.Add(this.nmCount);
            this.panel3.Controls.Add(this.bunifuCustomLabel4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Location = new System.Drawing.Point(3, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 696);
            this.panel3.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.ActiveBorderThickness = 1;
            this.btnAddProduct.ActiveCornerRadius = 20;
            this.btnAddProduct.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddProduct.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddProduct.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddProduct.BackColor = System.Drawing.Color.Ivory;
            this.btnAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.BackgroundImage")));
            this.btnAddProduct.ButtonText = "Chọn";
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddProduct.IdleBorderThickness = 1;
            this.btnAddProduct.IdleCornerRadius = 80;
            this.btnAddProduct.IdleFillColor = System.Drawing.Color.Khaki;
            this.btnAddProduct.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddProduct.IdleLineColor = System.Drawing.Color.Khaki;
            this.btnAddProduct.Location = new System.Drawing.Point(445, 571);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(177, 109);
            this.btnAddProduct.TabIndex = 14;
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // cbProduct
            // 
            this.cbProduct.BackColor = System.Drawing.Color.Ivory;
            this.cbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(215, 507);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(260, 30);
            this.cbProduct.TabIndex = 21;
            // 
            // lbTable
            // 
            this.lbTable.BackColor = System.Drawing.Color.Khaki;
            this.lbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTable.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbTable.Location = new System.Drawing.Point(219, 350);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(173, 74);
            this.lbTable.TabIndex = 11;
            this.lbTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Ivory;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(215, 459);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(260, 30);
            this.cbCategory.TabIndex = 20;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged_1);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.Ivory;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Chọn món tại đây";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 60;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.Khaki;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.Khaki;
            this.bunifuThinButton25.Location = new System.Drawing.Point(72, 3);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(504, 84);
            this.bunifuThinButton25.TabIndex = 10;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmCount
            // 
            this.nmCount.BackColor = System.Drawing.Color.Ivory;
            this.nmCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCount.ForeColor = System.Drawing.Color.SeaGreen;
            this.nmCount.Location = new System.Drawing.Point(215, 561);
            this.nmCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(120, 28);
            this.nmCount.TabIndex = 18;
            this.nmCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(76, 502);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(116, 29);
            this.bunifuCustomLabel4.TabIndex = 19;
            this.bunifuCustomLabel4.Text = "Tên món";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(76, 455);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 29);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "Loại";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(76, 554);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(117, 29);
            this.bunifuCustomLabel3.TabIndex = 17;
            this.bunifuCustomLabel3.Text = "Số lượng";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fnlTable
            // 
            this.fnlTable.Location = new System.Drawing.Point(12, 28);
            this.fnlTable.Name = "fnlTable";
            this.fnlTable.Size = new System.Drawing.Size(1359, 279);
            this.fnlTable.TabIndex = 4;
            // 
            // fManageSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1485, 1021);
            this.Controls.Add(this.fnlTable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fManageSell";
            this.Text = "ManageSell";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txbTotalPrice;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPaid;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private System.Windows.Forms.FlowLayoutPanel fnlTable;
        private System.Windows.Forms.ComboBox cbCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddProduct;
        private System.Windows.Forms.NumericUpDown nmCount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label lbTable;
    }
}