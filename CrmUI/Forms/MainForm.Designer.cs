namespace CrmUI.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.DataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChecksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsList = new System.Windows.Forms.ListBox();
            this.CartList = new System.Windows.Forms.ListBox();
            this.FullPriceLabel = new System.Windows.Forms.Label();
            this.ButtonPay = new System.Windows.Forms.Button();
            this.EnterLabel = new System.Windows.Forms.LinkLabel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataBaseToolStripMenuItem,
            this.ModelingToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // DataBaseToolStripMenuItem
            // 
            this.DataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsToolStripMenuItem,
            this.SellersToolStripMenuItem,
            this.CustomersToolStripMenuItem,
            this.ChecksToolStripMenuItem});
            this.DataBaseToolStripMenuItem.Name = "DataBaseToolStripMenuItem";
            this.DataBaseToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.DataBaseToolStripMenuItem.Text = "База данных";
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.ProductsToolStripMenuItem.Text = "Товары";
            this.ProductsToolStripMenuItem.Click += new System.EventHandler(this.ProductsToolStripMenuItem_Click);
            // 
            // SellersToolStripMenuItem
            // 
            this.SellersToolStripMenuItem.Name = "SellersToolStripMenuItem";
            this.SellersToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.SellersToolStripMenuItem.Text = "Продавцы";
            this.SellersToolStripMenuItem.Click += new System.EventHandler(this.SellersToolStripMenuItem_Click);
            // 
            // CustomersToolStripMenuItem
            // 
            this.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem";
            this.CustomersToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.CustomersToolStripMenuItem.Text = "Покупатели";
            this.CustomersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // ChecksToolStripMenuItem
            // 
            this.ChecksToolStripMenuItem.Name = "ChecksToolStripMenuItem";
            this.ChecksToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.ChecksToolStripMenuItem.Text = "Чеки";
            this.ChecksToolStripMenuItem.Click += new System.EventHandler(this.ChecksToolStripMenuItem_Click);
            // 
            // ModelingToolStripMenuItem
            // 
            this.ModelingToolStripMenuItem.Name = "ModelingToolStripMenuItem";
            this.ModelingToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.ModelingToolStripMenuItem.Text = "Моделирование";
            this.ModelingToolStripMenuItem.Click += new System.EventHandler(this.ModelingToolStripMenuItem_Click);
            // 
            // ProductsList
            // 
            this.ProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.ItemHeight = 18;
            this.ProductsList.Location = new System.Drawing.Point(15, 47);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(370, 382);
            this.ProductsList.TabIndex = 1;
            this.ProductsList.DoubleClick += new System.EventHandler(this.Products_DoubleClick);
            // 
            // CartList
            // 
            this.CartList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartList.FormattingEnabled = true;
            this.CartList.ItemHeight = 18;
            this.CartList.Location = new System.Drawing.Point(410, 63);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(370, 310);
            this.CartList.TabIndex = 1;
            this.CartList.DoubleClick += new System.EventHandler(this.CartList_DoubleClick);
            // 
            // FullPriceLabel
            // 
            this.FullPriceLabel.AutoSize = true;
            this.FullPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullPriceLabel.Location = new System.Drawing.Point(407, 376);
            this.FullPriceLabel.Name = "FullPriceLabel";
            this.FullPriceLabel.Size = new System.Drawing.Size(54, 18);
            this.FullPriceLabel.TabIndex = 2;
            this.FullPriceLabel.Text = "Итого:";
            // 
            // ButtonPay
            // 
            this.ButtonPay.Enabled = false;
            this.ButtonPay.Location = new System.Drawing.Point(410, 397);
            this.ButtonPay.Name = "ButtonPay";
            this.ButtonPay.Size = new System.Drawing.Size(370, 29);
            this.ButtonPay.TabIndex = 5;
            this.ButtonPay.Text = "Оплатить";
            this.ButtonPay.UseVisualStyleBackColor = true;
            this.ButtonPay.Click += new System.EventHandler(this.ButtonPay_Click);
            // 
            // EnterLabel
            // 
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterLabel.Location = new System.Drawing.Point(407, 42);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(138, 18);
            this.EnterLabel.TabIndex = 6;
            this.EnterLabel.TabStop = true;
            this.EnterLabel.Text = "Здравствуй, гость!";
            this.EnterLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EnterLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterLabel);
            this.Controls.Add(this.ButtonPay);
            this.Controls.Add(this.FullPriceLabel);
            this.Controls.Add(this.CartList);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM система";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem DataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChecksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModelingToolStripMenuItem;
        private System.Windows.Forms.ListBox ProductsList;
        private System.Windows.Forms.ListBox CartList;
        private System.Windows.Forms.Label FullPriceLabel;
        private System.Windows.Forms.Button ButtonPay;
        private System.Windows.Forms.LinkLabel EnterLabel;
        private System.Windows.Forms.ToolStripMenuItem CustomersToolStripMenuItem;
    }
}