namespace CrmUI.Forms
{
    partial class Main
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
            this.EntitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.EntitiesToolStripMenuItem,
            this.ModelingToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // EntitiesToolStripMenuItem
            // 
            this.EntitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductToolStripMenuItem,
            this.SellerToolStripMenuItem,
            this.CustomerToolStripMenuItem,
            this.CheckToolStripMenuItem});
            this.EntitiesToolStripMenuItem.Name = "EntitiesToolStripMenuItem";
            this.EntitiesToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.EntitiesToolStripMenuItem.Text = "Сущности";
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductAddToolStripMenuItem});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ProductToolStripMenuItem.Text = "Товар";
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // ProductAddToolStripMenuItem
            // 
            this.ProductAddToolStripMenuItem.Name = "ProductAddToolStripMenuItem";
            this.ProductAddToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.ProductAddToolStripMenuItem.Text = "Добавить";
            this.ProductAddToolStripMenuItem.Click += new System.EventHandler(this.ProductAddToolStripMenuItem_Click);
            // 
            // SellerToolStripMenuItem
            // 
            this.SellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SellerAddToolStripMenuItem});
            this.SellerToolStripMenuItem.Name = "SellerToolStripMenuItem";
            this.SellerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SellerToolStripMenuItem.Text = "Продавец";
            this.SellerToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // SellerAddToolStripMenuItem
            // 
            this.SellerAddToolStripMenuItem.Name = "SellerAddToolStripMenuItem";
            this.SellerAddToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.SellerAddToolStripMenuItem.Text = "Добавить";
            this.SellerAddToolStripMenuItem.Click += new System.EventHandler(this.SellerAddToolStripMenuItem_Click);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerAddToolStripMenuItem});
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CustomerToolStripMenuItem.Text = "Покупатель";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // CustomerAddToolStripMenuItem
            // 
            this.CustomerAddToolStripMenuItem.Name = "CustomerAddToolStripMenuItem";
            this.CustomerAddToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.CustomerAddToolStripMenuItem.Text = "Добавить";
            this.CustomerAddToolStripMenuItem.Click += new System.EventHandler(this.CustomerAddToolStripMenuItem_Click);
            // 
            // CheckToolStripMenuItem
            // 
            this.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem";
            this.CheckToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CheckToolStripMenuItem.Text = "Чек";
            this.CheckToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
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
            // Main
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
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem EntitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModelingToolStripMenuItem;
        private System.Windows.Forms.ListBox ProductsList;
        private System.Windows.Forms.ListBox CartList;
        private System.Windows.Forms.Label FullPriceLabel;
        private System.Windows.Forms.Button ButtonPay;
        private System.Windows.Forms.LinkLabel EnterLabel;
    }
}