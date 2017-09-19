using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCalculator
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double price = getCalculatedPrice((double)buyingPrice.Value, (double)shippingPrice.Value, (double)profitPercentage.Value);
            productFinalPriceLabel.Text = "$" + price.ToString("n");
        }

        private double getCalculatedPrice(double productPrice, double shippingPrice, double profitPercentage)
        {
            double res = 0.0;

            double totalCost = productPrice + shippingPrice;

            res = (totalCost * (100 + profitPercentage))/100;


            return res;
        }
    }
}
