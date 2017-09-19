namespace PriceCalculator
{
    partial class main
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
            this.productFinalPriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buyingPrice = new System.Windows.Forms.NumericUpDown();
            this.shippingPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.profitPercentage = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buyingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // productFinalPriceLabel
            // 
            this.productFinalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productFinalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.productFinalPriceLabel.Location = new System.Drawing.Point(17, 215);
            this.productFinalPriceLabel.Name = "productFinalPriceLabel";
            this.productFinalPriceLabel.Size = new System.Drawing.Size(359, 108);
            this.productFinalPriceLabel.TabIndex = 0;
            this.productFinalPriceLabel.Text = "$0";
            this.productFinalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buying Price";
            // 
            // buyingPrice
            // 
            this.buyingPrice.DecimalPlaces = 2;
            this.buyingPrice.Location = new System.Drawing.Point(139, 14);
            this.buyingPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.buyingPrice.Name = "buyingPrice";
            this.buyingPrice.Size = new System.Drawing.Size(237, 22);
            this.buyingPrice.TabIndex = 2;
            // 
            // shippingPrice
            // 
            this.shippingPrice.DecimalPlaces = 2;
            this.shippingPrice.Location = new System.Drawing.Point(139, 57);
            this.shippingPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.shippingPrice.Name = "shippingPrice";
            this.shippingPrice.Size = new System.Drawing.Size(237, 22);
            this.shippingPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shipping";
            // 
            // profitPercentage
            // 
            this.profitPercentage.DecimalPlaces = 2;
            this.profitPercentage.Location = new System.Drawing.Point(179, 105);
            this.profitPercentage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.profitPercentage.Name = "profitPercentage";
            this.profitPercentage.Size = new System.Drawing.Size(197, 22);
            this.profitPercentage.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Profit Percentage";
            // 
            // calcBtn
            // 
            this.calcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.Location = new System.Drawing.Point(17, 145);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(359, 67);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 332);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.profitPercentage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shippingPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buyingPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productFinalPriceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.buyingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productFinalPriceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown buyingPrice;
        private System.Windows.Forms.NumericUpDown shippingPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown profitPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcBtn;
    }
}

