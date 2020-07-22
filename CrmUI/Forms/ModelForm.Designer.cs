namespace CrmUI.Forms
{
    partial class ModelForm
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.CustomerSpeed = new System.Windows.Forms.NumericUpDown();
            this.CashDeskSpeed = new System.Windows.Forms.NumericUpDown();
            this.CustomerSpeedText = new System.Windows.Forms.Label();
            this.CashDeskSpeedText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashDeskSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(645, 405);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(143, 33);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Старт";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // CustomerSpeed
            // 
            this.CustomerSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CustomerSpeed.Location = new System.Drawing.Point(157, 412);
            this.CustomerSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CustomerSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CustomerSpeed.Name = "CustomerSpeed";
            this.CustomerSpeed.Size = new System.Drawing.Size(120, 22);
            this.CustomerSpeed.TabIndex = 1;
            this.CustomerSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CustomerSpeed.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // CashDeskSpeed
            // 
            this.CashDeskSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CashDeskSpeed.Location = new System.Drawing.Point(481, 412);
            this.CashDeskSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CashDeskSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CashDeskSpeed.Name = "CashDeskSpeed";
            this.CashDeskSpeed.Size = new System.Drawing.Size(120, 22);
            this.CashDeskSpeed.TabIndex = 2;
            this.CashDeskSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CashDeskSpeed.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // CustomerSpeedText
            // 
            this.CustomerSpeedText.AutoSize = true;
            this.CustomerSpeedText.Location = new System.Drawing.Point(13, 414);
            this.CustomerSpeedText.Name = "CustomerSpeedText";
            this.CustomerSpeedText.Size = new System.Drawing.Size(138, 17);
            this.CustomerSpeedText.TabIndex = 3;
            this.CustomerSpeedText.Text = "Скорость клиентов:";
            // 
            // CashDeskSpeedText
            // 
            this.CashDeskSpeedText.AutoSize = true;
            this.CashDeskSpeedText.Location = new System.Drawing.Point(306, 414);
            this.CashDeskSpeedText.Name = "CashDeskSpeedText";
            this.CashDeskSpeedText.Size = new System.Drawing.Size(169, 17);
            this.CashDeskSpeedText.TabIndex = 3;
            this.CashDeskSpeedText.Text = "Скорость работы кассы:";
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CashDeskSpeedText);
            this.Controls.Add(this.CustomerSpeedText);
            this.Controls.Add(this.CashDeskSpeed);
            this.Controls.Add(this.CustomerSpeed);
            this.Controls.Add(this.ButtonStart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelForm_FormClosing);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashDeskSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.NumericUpDown CustomerSpeed;
        private System.Windows.Forms.NumericUpDown CashDeskSpeed;
        private System.Windows.Forms.Label CustomerSpeedText;
        private System.Windows.Forms.Label CashDeskSpeedText;
    }
}