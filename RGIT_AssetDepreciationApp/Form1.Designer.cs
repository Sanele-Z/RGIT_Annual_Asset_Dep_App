namespace RGIT_AssetDepreciationApp
{
    partial class frmRGITAnnualAssetDepreciationApp
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
            this.lblSalvageAverage = new System.Windows.Forms.Label();
            this.lblUsefulLife = new System.Windows.Forms.Label();
            this.txtAssetCost = new System.Windows.Forms.TextBox();
            this.txtSalvageValue = new System.Windows.Forms.TextBox();
            this.cmbUsefulLife = new System.Windows.Forms.ComboBox();
            this.btnDepreciationSchedules = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDepSchedule = new System.Windows.Forms.GroupBox();
            this.lblSumOfTheYearDigit = new System.Windows.Forms.Label();
            this.lstSYD = new System.Windows.Forms.ListBox();
            this.lstDDB = new System.Windows.Forms.ListBox();
            this.lblAssetCost = new System.Windows.Forms.Label();
            this.lblDoubleDecliningBalance = new System.Windows.Forms.Label();
            this.grpDepSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalvageAverage
            // 
            this.lblSalvageAverage.AutoSize = true;
            this.lblSalvageAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalvageAverage.Location = new System.Drawing.Point(19, 92);
            this.lblSalvageAverage.Name = "lblSalvageAverage";
            this.lblSalvageAverage.Size = new System.Drawing.Size(117, 17);
            this.lblSalvageAverage.TabIndex = 1;
            this.lblSalvageAverage.Text = "Salvage Value:";
            // 
            // lblUsefulLife
            // 
            this.lblUsefulLife.AutoSize = true;
            this.lblUsefulLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsefulLife.Location = new System.Drawing.Point(42, 141);
            this.lblUsefulLife.Name = "lblUsefulLife";
            this.lblUsefulLife.Size = new System.Drawing.Size(91, 17);
            this.lblUsefulLife.TabIndex = 2;
            this.lblUsefulLife.Text = "Useful Life:";
            // 
            // txtAssetCost
            // 
            this.txtAssetCost.Location = new System.Drawing.Point(139, 33);
            this.txtAssetCost.Name = "txtAssetCost";
            this.txtAssetCost.Size = new System.Drawing.Size(194, 22);
            this.txtAssetCost.TabIndex = 3;
            this.txtAssetCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAssetCost_KeyPress);
            // 
            // txtSalvageValue
            // 
            this.txtSalvageValue.Location = new System.Drawing.Point(142, 87);
            this.txtSalvageValue.Name = "txtSalvageValue";
            this.txtSalvageValue.Size = new System.Drawing.Size(191, 22);
            this.txtSalvageValue.TabIndex = 4;
            this.txtSalvageValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalvageValue_KeyPress);
            // 
            // cmbUsefulLife
            // 
            this.cmbUsefulLife.FormattingEnabled = true;
            this.cmbUsefulLife.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbUsefulLife.Location = new System.Drawing.Point(139, 138);
            this.cmbUsefulLife.Name = "cmbUsefulLife";
            this.cmbUsefulLife.Size = new System.Drawing.Size(194, 24);
            this.cmbUsefulLife.TabIndex = 5;
            this.cmbUsefulLife.Text = "---select---";
            // 
            // btnDepreciationSchedules
            // 
            this.btnDepreciationSchedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepreciationSchedules.Location = new System.Drawing.Point(22, 227);
            this.btnDepreciationSchedules.Name = "btnDepreciationSchedules";
            this.btnDepreciationSchedules.Size = new System.Drawing.Size(181, 57);
            this.btnDepreciationSchedules.TabIndex = 6;
            this.btnDepreciationSchedules.Text = "Display Depreciation Schedules";
            this.btnDepreciationSchedules.UseVisualStyleBackColor = true;
            this.btnDepreciationSchedules.Click += new System.EventHandler(this.btnDepreciationSchedules_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(239, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 57);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpDepSchedule
            // 
            this.grpDepSchedule.Controls.Add(this.lblDoubleDecliningBalance);
            this.grpDepSchedule.Controls.Add(this.lblSumOfTheYearDigit);
            this.grpDepSchedule.Controls.Add(this.lstSYD);
            this.grpDepSchedule.Controls.Add(this.lstDDB);
            this.grpDepSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDepSchedule.Location = new System.Drawing.Point(383, 33);
            this.grpDepSchedule.Name = "grpDepSchedule";
            this.grpDepSchedule.Size = new System.Drawing.Size(442, 249);
            this.grpDepSchedule.TabIndex = 8;
            this.grpDepSchedule.TabStop = false;
            this.grpDepSchedule.Text = "Depreciation Schedule";
            // 
            // lblSumOfTheYearDigit
            // 
            this.lblSumOfTheYearDigit.AutoSize = true;
            this.lblSumOfTheYearDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumOfTheYearDigit.Location = new System.Drawing.Point(231, 40);
            this.lblSumOfTheYearDigit.Name = "lblSumOfTheYearDigit";
            this.lblSumOfTheYearDigit.Size = new System.Drawing.Size(181, 17);
            this.lblSumOfTheYearDigit.TabIndex = 3;
            this.lblSumOfTheYearDigit.Text = "Sum-of-the-year\'s Digit:";
            // 
            // lstSYD
            // 
            this.lstSYD.FormattingEnabled = true;
            this.lstSYD.ItemHeight = 16;
            this.lstSYD.Location = new System.Drawing.Point(234, 59);
            this.lstSYD.Name = "lstSYD";
            this.lstSYD.Size = new System.Drawing.Size(202, 180);
            this.lstSYD.TabIndex = 1;
            // 
            // lstDDB
            // 
            this.lstDDB.FormattingEnabled = true;
            this.lstDDB.ItemHeight = 16;
            this.lstDDB.Location = new System.Drawing.Point(29, 60);
            this.lstDDB.Name = "lstDDB";
            this.lstDDB.Size = new System.Drawing.Size(186, 180);
            this.lstDDB.TabIndex = 0;
            // 
            // lblAssetCost
            // 
            this.lblAssetCost.AutoSize = true;
            this.lblAssetCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetCost.Location = new System.Drawing.Point(43, 38);
            this.lblAssetCost.Name = "lblAssetCost";
            this.lblAssetCost.Size = new System.Drawing.Size(90, 17);
            this.lblAssetCost.TabIndex = 4;
            this.lblAssetCost.Text = "Asset Cost:";
            // 
            // lblDoubleDecliningBalance
            // 
            this.lblDoubleDecliningBalance.AutoSize = true;
            this.lblDoubleDecliningBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoubleDecliningBalance.Location = new System.Drawing.Point(26, 40);
            this.lblDoubleDecliningBalance.Name = "lblDoubleDecliningBalance";
            this.lblDoubleDecliningBalance.Size = new System.Drawing.Size(199, 17);
            this.lblDoubleDecliningBalance.TabIndex = 5;
            this.lblDoubleDecliningBalance.Text = "Double Declining Balance:";
            // 
            // frmRGITAnnualAssetDepreciationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 373);
            this.Controls.Add(this.grpDepSchedule);
            this.Controls.Add(this.lblAssetCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDepreciationSchedules);
            this.Controls.Add(this.cmbUsefulLife);
            this.Controls.Add(this.txtSalvageValue);
            this.Controls.Add(this.txtAssetCost);
            this.Controls.Add(this.lblUsefulLife);
            this.Controls.Add(this.lblSalvageAverage);
            this.Name = "frmRGITAnnualAssetDepreciationApp";
            this.Text = "RGIT Annual Asset Depreciaton App";
            this.grpDepSchedule.ResumeLayout(false);
            this.grpDepSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSalvageAverage;
        private System.Windows.Forms.Label lblUsefulLife;
        private System.Windows.Forms.TextBox txtAssetCost;
        private System.Windows.Forms.TextBox txtSalvageValue;
        private System.Windows.Forms.ComboBox cmbUsefulLife;
        private System.Windows.Forms.Button btnDepreciationSchedules;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpDepSchedule;
        private System.Windows.Forms.Label lblSumOfTheYearDigit;
        private System.Windows.Forms.ListBox lstSYD;
        private System.Windows.Forms.ListBox lstDDB;
        private System.Windows.Forms.Label lblDoubleDecliningBalance;
        private System.Windows.Forms.Label lblAssetCost;
    }
}

