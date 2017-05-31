namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveNotApproveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.approveNotApproveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.approveNotApproveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryChalanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDeliveryChalanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSellInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.gRNToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.sellOrderToolStripMenuItem,
            this.deliveryChalanToolStripMenuItem,
            this.sellInvoiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.approveNotApproveToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // approveNotApproveToolStripMenuItem
            // 
            this.approveNotApproveToolStripMenuItem.Name = "approveNotApproveToolStripMenuItem";
            this.approveNotApproveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.approveNotApproveToolStripMenuItem.Text = "Approve/Not Approve";
            this.approveNotApproveToolStripMenuItem.Click += new System.EventHandler(this.approveNotApproveToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.approveNotApproveToolStripMenuItem1});
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // approveNotApproveToolStripMenuItem1
            // 
            this.approveNotApproveToolStripMenuItem1.Name = "approveNotApproveToolStripMenuItem1";
            this.approveNotApproveToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.approveNotApproveToolStripMenuItem1.Text = "Approve/Not Approve";
            this.approveNotApproveToolStripMenuItem1.Click += new System.EventHandler(this.approveNotApproveToolStripMenuItem1_Click);
            // 
            // gRNToolStripMenuItem
            // 
            this.gRNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewGRNToolStripMenuItem});
            this.gRNToolStripMenuItem.Name = "gRNToolStripMenuItem";
            this.gRNToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.gRNToolStripMenuItem.Text = "GRN";
            // 
            // createNewGRNToolStripMenuItem
            // 
            this.createNewGRNToolStripMenuItem.Name = "createNewGRNToolStripMenuItem";
            this.createNewGRNToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.createNewGRNToolStripMenuItem.Text = "Create new GRN";
            this.createNewGRNToolStripMenuItem.Click += new System.EventHandler(this.createNewGRNToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createInvoiceToolStripMenuItem});
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // createInvoiceToolStripMenuItem
            // 
            this.createInvoiceToolStripMenuItem.Name = "createInvoiceToolStripMenuItem";
            this.createInvoiceToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.createInvoiceToolStripMenuItem.Text = "Create Invoice";
            this.createInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createInvoiceToolStripMenuItem_Click);
            // 
            // sellOrderToolStripMenuItem
            // 
            this.sellOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.approveNotApproveToolStripMenuItem2});
            this.sellOrderToolStripMenuItem.Name = "sellOrderToolStripMenuItem";
            this.sellOrderToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.sellOrderToolStripMenuItem.Text = "Sell Order";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(192, 22);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // approveNotApproveToolStripMenuItem2
            // 
            this.approveNotApproveToolStripMenuItem2.Name = "approveNotApproveToolStripMenuItem2";
            this.approveNotApproveToolStripMenuItem2.Size = new System.Drawing.Size(192, 22);
            this.approveNotApproveToolStripMenuItem2.Text = "Approve/Not Approve";
            this.approveNotApproveToolStripMenuItem2.Click += new System.EventHandler(this.approveNotApproveToolStripMenuItem2_Click);
            // 
            // deliveryChalanToolStripMenuItem
            // 
            this.deliveryChalanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDeliveryChalanToolStripMenuItem});
            this.deliveryChalanToolStripMenuItem.Name = "deliveryChalanToolStripMenuItem";
            this.deliveryChalanToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.deliveryChalanToolStripMenuItem.Text = "Delivery Chalan";
            // 
            // createDeliveryChalanToolStripMenuItem
            // 
            this.createDeliveryChalanToolStripMenuItem.Name = "createDeliveryChalanToolStripMenuItem";
            this.createDeliveryChalanToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.createDeliveryChalanToolStripMenuItem.Text = "Create Delivery Chalan";
            this.createDeliveryChalanToolStripMenuItem.Click += new System.EventHandler(this.createDeliveryChalanToolStripMenuItem_Click);
            // 
            // sellInvoiceToolStripMenuItem
            // 
            this.sellInvoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSellInvoiceToolStripMenuItem});
            this.sellInvoiceToolStripMenuItem.Name = "sellInvoiceToolStripMenuItem";
            this.sellInvoiceToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.sellInvoiceToolStripMenuItem.Text = "Sell Invoice";
            // 
            // createSellInvoiceToolStripMenuItem
            // 
            this.createSellInvoiceToolStripMenuItem.Name = "createSellInvoiceToolStripMenuItem";
            this.createSellInvoiceToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.createSellInvoiceToolStripMenuItem.Text = "Create Sell invoice";
            this.createSellInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createSellInvoiceToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 337);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveNotApproveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem approveNotApproveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewGRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem approveNotApproveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deliveryChalanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDeliveryChalanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSellInvoiceToolStripMenuItem;
    }
}