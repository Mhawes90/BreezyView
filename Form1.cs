using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Utilities.BVApt; // get utilities for BreezyViewApartments

/*
 * BreezyViewApartments
 * - Asks user for information about an apartment to get them a quote 
 *      about how much the apartment would cost. Demonstrates how 
 *      ability to use controls in a C# application
 * 
 * Week 12
 * by Mark Hawes
 * 
 * I know it's not a super great layout, and parts do not work.
 * That being said, I'm happy with how it looks even though I'm not 
 * super experienced in layouts/GUIs
 */

namespace BreezyViewApartments
{
    public partial class Form1 : Form
    {
        // default quote output text
        private string dftQuoteTxt = "Estimated Rent per Month: ";

        public Form1()
        {
            InitializeComponent();
        }

        private void BedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quoteButton_Click(object sender, EventArgs e)
        {
            // constants
            int beds, baths;
            bool view;
            double total;

            // try to get number of bedrooms
            try
            {
                beds = GetBedrooms();
            }catch (IndexOutOfRangeException)
            {
                quoteOutput.Text = "We have no apartments with that " +
                    "number of apartments";
                return;
            }catch (FormatException)
            {
                quoteOutput.Text = "Invalid input for bedrooms";
                return;
            }

            // try to get number of bathrooms
            try
            {
                baths = GetBaths();
            }catch (IndexOutOfRangeException)
            {
                quoteOutput.Text = "We have no apartments with that " +
                    "number of bathrooms";
                return;
            }catch (FormatException)
            {
                quoteOutput.Text = "Invalid input for bathrooms";
                return;
            }catch (TooManyBathsException)
            {
                quoteOutput.Text = "Why would you need that many bathrooms?";
                return;
            }

            // get view
            view = GetView();

            // get appt cost - save to total
            total = ApptCost(beds, baths, view);

            // append total to output
            quoteOutput.Text = dftQuoteTxt;
            quoteOutput.Text += total.ToString("c");
        } // end quoteButton_Click


        private int GetBedrooms()
        {
            // value to return
            int output = 0;

            // try to convert BedBox input
            output = Convert.ToInt32(BedBox.Text);

            // if input is not in the valid range throw exception
            if (output < 1 || output > 3)
                throw new IndexOutOfRangeException();

            return output;
        } // end GetBedrooms

        private int GetBaths()
        {
            // value to return
            int output = 0;

            // try to convert BathBox input
            output = Convert.ToInt32(BathBox.Text);

            if (output < 0)
                throw new IndexOutOfRangeException();
            else if (output > 6)
                throw new TooManyBathsException();

            return output;
        }

        private bool GetView()
        {
            // value to return
            bool lakeView = false;

            // check checkbox for value
            switch (ViewBox.SelectedValue)
            {
                case "Street View": lakeView = false; break;
                case "Lake View": lakeView = true; break;
            }

            return lakeView;
        }
    }
}


public class TooManyBathsException : Exception
{
    public TooManyBathsException()
    {

    }
}