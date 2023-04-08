
namespace Program3
{
    partial class uPickItGroceryCalculator
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
            this.FarmComboBox = new System.Windows.Forms.ComboBox();
            this.FarmLbl = new System.Windows.Forms.Label();
            this.ItemLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.InitialCostLbl = new System.Windows.Forms.Label();
            this.DiscountedCostLbl = new System.Windows.Forms.Label();
            this.ShipmentCostLbl = new System.Windows.Forms.Label();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.ItemsTxtBoxInput = new System.Windows.Forms.TextBox();
            this.QuantityTxtBoxInput = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.OutputInitialCost = new System.Windows.Forms.Label();
            this.OutputDiscountedCost = new System.Windows.Forms.Label();
            this.OutputShipmentCost = new System.Windows.Forms.Label();
            this.OutputTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FarmComboBox
            // 
            this.FarmComboBox.FormattingEnabled = true;
            this.FarmComboBox.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.FarmComboBox.Location = new System.Drawing.Point(227, 30);
            this.FarmComboBox.Name = "FarmComboBox";
            this.FarmComboBox.Size = new System.Drawing.Size(121, 28);
            this.FarmComboBox.TabIndex = 0;
            // 
            // FarmLbl
            // 
            this.FarmLbl.AutoSize = true;
            this.FarmLbl.Location = new System.Drawing.Point(149, 33);
            this.FarmLbl.Name = "FarmLbl";
            this.FarmLbl.Size = new System.Drawing.Size(50, 20);
            this.FarmLbl.TabIndex = 1;
            this.FarmLbl.Text = "Farm:";
            // 
            // ItemLbl
            // 
            this.ItemLbl.AutoSize = true;
            this.ItemLbl.Location = new System.Drawing.Point(154, 80);
            this.ItemLbl.Name = "ItemLbl";
            this.ItemLbl.Size = new System.Drawing.Size(45, 20);
            this.ItemLbl.TabIndex = 2;
            this.ItemLbl.Text = "Item:";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Location = new System.Drawing.Point(93, 124);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(106, 20);
            this.QuantityLbl.TabIndex = 3;
            this.QuantityLbl.Text = "Quantity (lbs):";
            // 
            // InitialCostLbl
            // 
            this.InitialCostLbl.AutoSize = true;
            this.InitialCostLbl.Location = new System.Drawing.Point(112, 218);
            this.InitialCostLbl.Name = "InitialCostLbl";
            this.InitialCostLbl.Size = new System.Drawing.Size(87, 20);
            this.InitialCostLbl.TabIndex = 4;
            this.InitialCostLbl.Text = "Initial Cost:";
            // 
            // DiscountedCostLbl
            // 
            this.DiscountedCostLbl.AutoSize = true;
            this.DiscountedCostLbl.Location = new System.Drawing.Point(68, 258);
            this.DiscountedCostLbl.Name = "DiscountedCostLbl";
            this.DiscountedCostLbl.Size = new System.Drawing.Size(131, 20);
            this.DiscountedCostLbl.TabIndex = 5;
            this.DiscountedCostLbl.Text = "Discounted Cost:";
            // 
            // ShipmentCostLbl
            // 
            this.ShipmentCostLbl.AutoSize = true;
            this.ShipmentCostLbl.Location = new System.Drawing.Point(81, 298);
            this.ShipmentCostLbl.Name = "ShipmentCostLbl";
            this.ShipmentCostLbl.Size = new System.Drawing.Size(118, 20);
            this.ShipmentCostLbl.TabIndex = 6;
            this.ShipmentCostLbl.Text = "Shipment Cost:";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Location = new System.Drawing.Point(112, 338);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(87, 20);
            this.TotalPriceLbl.TabIndex = 7;
            this.TotalPriceLbl.Text = "Total Price:";
            // 
            // ItemsTxtBoxInput
            // 
            this.ItemsTxtBoxInput.Location = new System.Drawing.Point(227, 77);
            this.ItemsTxtBoxInput.Name = "ItemsTxtBoxInput";
            this.ItemsTxtBoxInput.Size = new System.Drawing.Size(121, 26);
            this.ItemsTxtBoxInput.TabIndex = 8;
            // 
            // QuantityTxtBoxInput
            // 
            this.QuantityTxtBoxInput.Location = new System.Drawing.Point(227, 121);
            this.QuantityTxtBoxInput.Name = "QuantityTxtBoxInput";
            this.QuantityTxtBoxInput.Size = new System.Drawing.Size(121, 26);
            this.QuantityTxtBoxInput.TabIndex = 9;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(195, 164);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(121, 30);
            this.CalcButton.TabIndex = 10;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // OutputInitialCost
            // 
            this.OutputInitialCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputInitialCost.Location = new System.Drawing.Point(227, 217);
            this.OutputInitialCost.Name = "OutputInitialCost";
            this.OutputInitialCost.Size = new System.Drawing.Size(121, 23);
            this.OutputInitialCost.TabIndex = 11;
            // 
            // OutputDiscountedCost
            // 
            this.OutputDiscountedCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputDiscountedCost.Location = new System.Drawing.Point(227, 257);
            this.OutputDiscountedCost.Name = "OutputDiscountedCost";
            this.OutputDiscountedCost.Size = new System.Drawing.Size(121, 23);
            this.OutputDiscountedCost.TabIndex = 12;
            // 
            // OutputShipmentCost
            // 
            this.OutputShipmentCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputShipmentCost.Location = new System.Drawing.Point(227, 297);
            this.OutputShipmentCost.Name = "OutputShipmentCost";
            this.OutputShipmentCost.Size = new System.Drawing.Size(121, 23);
            this.OutputShipmentCost.TabIndex = 13;
            // 
            // OutputTotalPrice
            // 
            this.OutputTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTotalPrice.Location = new System.Drawing.Point(227, 337);
            this.OutputTotalPrice.Name = "OutputTotalPrice";
            this.OutputTotalPrice.Size = new System.Drawing.Size(121, 23);
            this.OutputTotalPrice.TabIndex = 14;
            // 
            // uPickItGroceryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.OutputTotalPrice);
            this.Controls.Add(this.OutputShipmentCost);
            this.Controls.Add(this.OutputDiscountedCost);
            this.Controls.Add(this.OutputInitialCost);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.QuantityTxtBoxInput);
            this.Controls.Add(this.ItemsTxtBoxInput);
            this.Controls.Add(this.TotalPriceLbl);
            this.Controls.Add(this.ShipmentCostLbl);
            this.Controls.Add(this.DiscountedCostLbl);
            this.Controls.Add(this.InitialCostLbl);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.ItemLbl);
            this.Controls.Add(this.FarmLbl);
            this.Controls.Add(this.FarmComboBox);
            this.Name = "uPickItGroceryCalculator";
            this.Text = "uPickItGroceryCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FarmComboBox;
        private System.Windows.Forms.Label FarmLbl;
        private System.Windows.Forms.Label ItemLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label InitialCostLbl;
        private System.Windows.Forms.Label DiscountedCostLbl;
        private System.Windows.Forms.Label ShipmentCostLbl;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.TextBox ItemsTxtBoxInput;
        private System.Windows.Forms.TextBox QuantityTxtBoxInput;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label OutputInitialCost;
        private System.Windows.Forms.Label OutputDiscountedCost;
        private System.Windows.Forms.Label OutputShipmentCost;
        private System.Windows.Forms.Label OutputTotalPrice;
    }
}

