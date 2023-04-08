//Grading ID: S0941
//CIS 199-02
//Program 3
//Due: (4/1/21)
//This assignment explores the use of parallel arrays and range matching.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class uPickItGroceryCalculator : Form
    {
        public uPickItGroceryCalculator()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            {
                //Arrays
                String[] farmArray = { "NE", "NW", "SE", "SW" }; // state/farm array
                double[] shipmentFeeArray = { 6.00, 7.17, 7.00, 8.74 }; // shipmentfees array

                int[] itemNumberArray = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 }; // item number array
                double[] costperitemArray = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 }; // cost per item array

                int[] poundsArray = { 0, 5, 6, 10, 11, 20, 21 }; // pounds array containing ranges as elements
                int[] discountArray = { 0, 5, 10, 15 }; // discount array

                // declaring variables to store the corresponding values
                double shipmentFee = 0; //holds value for shipment fee
                double costperitem = 0; //holds value for cost of the item
                double discount = 0; //holds value for the discount amount
                double initialCost, discountedCost, shipmentCost, totalCost; // declaring variables for the final results

                String itemNumber = ItemsTxtBoxInput.Text; //Declares string item number and sets it equal to value in items text box
                int quantity = Convert.ToInt32(QuantityTxtBoxInput.Text);

                for (int k = 0; k < itemNumberArray.Length; k++) //using for-loop and if statements to fetch cost/item using above declared arrays
                {
                    if (itemNumber == (itemNumberArray[k]).ToString())
                    {
                        costperitem = costperitemArray[k];
                    }
                }


                for (int j = 0; j < farmArray.Length; j++) //using for-loop and if statements to fetch shipment fees using above declared arrays
                {
                    if (FarmComboBox.SelectedIndex == j)
                    {
                        shipmentFee = shipmentFeeArray[j];
                    }
                }
                // using if-else statements to find the discount of the items using above declared arrays
                if (quantity >= poundsArray[0] && quantity <= poundsArray[1])
                {
                    discount = discountArray[0];
                }
                else if (quantity >= poundsArray[2] && quantity <= poundsArray[3])
                {
                    discount = discountArray[1];
                }
                else if (quantity >= poundsArray[4] && quantity <= poundsArray[5])
                {
                    discount = discountArray[2];
                }
                else if (quantity > poundsArray[6])
                {
                    discount = discountArray[3];
                }
                // checking if item number is between 10001 and 10007
                // because if input item number is not in the required range, then cost/item will be 0
                if (costperitem == 0)
                {
                    ItemsTxtBoxInput.Text = "";
                    QuantityTxtBoxInput.Text = "";
                }
               

                //percent conversion
                double discountPercent = discount / 100; //converts discount into a percentage
                double shipmentPercent = shipmentFee / 100; //converts shipment fee into a percentage

                // now evaluating each required costs
                initialCost = costperitem * quantity; //calculates the initial cost
                discountedCost = initialCost - (initialCost * discountPercent); //calculates the discounted cost
                shipmentCost = discountedCost * shipmentPercent; //calculates shipment cost
                totalCost = discountedCost + shipmentCost; //calculates total cost

                // displaying the evaluated results on the corresponding Text boxes in 2-decimal places
                OutputInitialCost.Text = $"${initialCost:F2}";  // Display the initial cost
                OutputDiscountedCost.Text = $"${discountedCost:F2}"; //Display the discounted cost
                OutputShipmentCost.Text = $"${shipmentCost:F2}"; //Display the Shipping cost
                OutputTotalPrice.Text = $"${totalCost:F2}"; //Display the final cost

            }
        }
    }
}
