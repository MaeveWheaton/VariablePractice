/* 
 * April 23 2021
 * Maeve Wheaton
 * ISC3U
 * Mr. T
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;

            // display player name and number
            outputLabel.Text = $"{playerName} is number {playerNumber}.";
            Refresh();
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area;

            // Calculate area
            area = radius * pi * pi;

            // Display
            outputLabel.Text = $"The area of circle with a radius of {radius}cm is {area}cm^2.";
            Refresh();
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area;
            double totalCost;

            // Calculate area
            area = length * width;

            // Calculate cost
            totalCost = area * costPerMeter;

            // Display
            outputLabel.Text = $"The area of a room with dimensions {length}m x {width}m is {area}m^2.";
            outputLabel.Text += $"\n\nThe cost to carpet this area at ${costPerMeter} per square metre is ${totalCost}.";
            Refresh();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            double shirtPrice = 12.49;
            double cashPaid = 20.00;
            double taxRate = 0.13;
            double tax, totalCost, changeDue;

            // Calculate tax, total, change
            tax = shirtPrice * taxRate;
            totalCost = shirtPrice + tax;
            changeDue = cashPaid - totalCost;

            // Display receipt
            outputLabel.Text = "Bill of Sale";
            outputLabel.Text += $"\n\nShirt          ${shirtPrice}";
            outputLabel.Text += $"\n\nTax:           ${tax}";
            outputLabel.Text += $"\nTotal:         ${totalCost}";
            outputLabel.Text += $"\n\nTendered:      ${cashPaid}";
            outputLabel.Text += $"\nChange:        ${changeDue}";
            Refresh();
        }
    }
}
