namespace VehicleInventory
{
    partial class VehicleInventoryForm
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabNewVehicle = new System.Windows.Forms.TabPage();
            this.tabInventoryList = new System.Windows.Forms.TabPage();
            this.lblNewVehicle = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbResults = new System.Windows.Forms.TextBox();
            this.txbLicense = new System.Windows.Forms.TextBox();
            this.txbVIN = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbInventory = new System.Windows.Forms.ListBox();
            this.txbSummary = new System.Windows.Forms.TextBox();
            this.tab.SuspendLayout();
            this.tabNewVehicle.SuspendLayout();
            this.tabInventoryList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tab.Controls.Add(this.tabNewVehicle);
            this.tab.Controls.Add(this.tabInventoryList);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(4, 13);
            this.tab.Multiline = true;
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(784, 435);
            this.tab.TabIndex = 0;
            // 
            // tabNewVehicle
            // 
            this.tabNewVehicle.Controls.Add(this.cbType);
            this.tabNewVehicle.Controls.Add(this.txbVIN);
            this.tabNewVehicle.Controls.Add(this.txbLicense);
            this.tabNewVehicle.Controls.Add(this.txbResults);
            this.tabNewVehicle.Controls.Add(this.btnAdd);
            this.tabNewVehicle.Controls.Add(this.lblType);
            this.tabNewVehicle.Controls.Add(this.lblVIN);
            this.tabNewVehicle.Controls.Add(this.lblLicense);
            this.tabNewVehicle.Controls.Add(this.lblNewVehicle);
            this.tabNewVehicle.Location = new System.Drawing.Point(4, 4);
            this.tabNewVehicle.Name = "tabNewVehicle";
            this.tabNewVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewVehicle.Size = new System.Drawing.Size(752, 427);
            this.tabNewVehicle.TabIndex = 0;
            this.tabNewVehicle.Text = "New Vehicle Form";
            this.tabNewVehicle.UseVisualStyleBackColor = true;
            this.tabNewVehicle.Click += new System.EventHandler(this.tabNewVehicle_Click);
            // 
            // tabInventoryList
            // 
            this.tabInventoryList.Controls.Add(this.txbSummary);
            this.tabInventoryList.Controls.Add(this.lbInventory);
            this.tabInventoryList.Location = new System.Drawing.Point(4, 4);
            this.tabInventoryList.Name = "tabInventoryList";
            this.tabInventoryList.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventoryList.Size = new System.Drawing.Size(752, 427);
            this.tabInventoryList.TabIndex = 1;
            this.tabInventoryList.Text = "Inventory List";
            this.tabInventoryList.UseVisualStyleBackColor = true;
            // 
            // lblNewVehicle
            // 
            this.lblNewVehicle.AutoSize = true;
            this.lblNewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewVehicle.Location = new System.Drawing.Point(263, 12);
            this.lblNewVehicle.Name = "lblNewVehicle";
            this.lblNewVehicle.Size = new System.Drawing.Size(187, 25);
            this.lblNewVehicle.TabIndex = 0;
            this.lblNewVehicle.Text = "New Vehicle Form";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.Location = new System.Drawing.Point(91, 93);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(71, 20);
            this.lblLicense.TabIndex = 1;
            this.lblLicense.Text = "License";
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVIN.Location = new System.Drawing.Point(91, 128);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(39, 20);
            this.lblVIN.TabIndex = 2;
            this.lblVIN.Text = "VIN";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(91, 163);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(297, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txbResults
            // 
            this.txbResults.Location = new System.Drawing.Point(95, 266);
            this.txbResults.Multiline = true;
            this.txbResults.Name = "txbResults";
            this.txbResults.Size = new System.Drawing.Size(547, 140);
            this.txbResults.TabIndex = 5;
            // 
            // txbLicense
            // 
            this.txbLicense.Location = new System.Drawing.Point(268, 87);
            this.txbLicense.Name = "txbLicense";
            this.txbLicense.Size = new System.Drawing.Size(167, 26);
            this.txbLicense.TabIndex = 6;
            // 
            // txbVIN
            // 
            this.txbVIN.Location = new System.Drawing.Point(268, 122);
            this.txbVIN.Name = "txbVIN";
            this.txbVIN.Size = new System.Drawing.Size(167, 26);
            this.txbVIN.TabIndex = 7;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Sedan",
            "Truck"});
            this.cbType.Location = new System.Drawing.Point(268, 155);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(167, 28);
            this.cbType.TabIndex = 8;
            this.cbType.Text = "Sedan";
            // 
            // lbInventory
            // 
            this.lbInventory.FormattingEnabled = true;
            this.lbInventory.ItemHeight = 20;
            this.lbInventory.Location = new System.Drawing.Point(6, 6);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(380, 404);
            this.lbInventory.TabIndex = 0;
            this.lbInventory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbInventory_MouseDoubleClick);
            // 
            // txbSummary
            // 
            this.txbSummary.Location = new System.Drawing.Point(422, 7);
            this.txbSummary.Multiline = true;
            this.txbSummary.Name = "txbSummary";
            this.txbSummary.ReadOnly = true;
            this.txbSummary.Size = new System.Drawing.Size(315, 403);
            this.txbSummary.TabIndex = 1;
            // 
            // VehicleInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 456);
            this.Controls.Add(this.tab);
            this.Name = "VehicleInventoryForm";
            this.Text = "Form1";
            this.tab.ResumeLayout(false);
            this.tabNewVehicle.ResumeLayout(false);
            this.tabNewVehicle.PerformLayout();
            this.tabInventoryList.ResumeLayout(false);
            this.tabInventoryList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabNewVehicle;
        private System.Windows.Forms.TabPage tabInventoryList;
        private System.Windows.Forms.TextBox txbResults;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblNewVehicle;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txbVIN;
        private System.Windows.Forms.TextBox txbLicense;
        private System.Windows.Forms.TextBox txbSummary;
        private System.Windows.Forms.ListBox lbInventory;
    }
}

