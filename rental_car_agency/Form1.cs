using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rental_car_agency
{
    public partial class Form1 : Form
    {
        private float charged_all_customers = 0.00F;
        const float daily_charge = 15.00F;
        const float mileage_rate = 0.12F;

        public Form1()
        {
            InitializeComponent();
        }
        

        /// <summary>
        ///  clear all of the text boxes and labels that display computations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_cust_name.Clear();
            textBox_days_rent.Clear();
            textBox_odo_begin.Clear();
            textBox_odo_end.Clear();
            label_total_miles.Text = "Total Miles; This Customer: 0";
            label_total_customer.Text = "Total Charged, This Customer: $0.00";
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Calculate the values required.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_calculate_Click(object sender, EventArgs e)
        {
            float charged_miles = 0.00F;
            float charged_daily = 0.00F;
            float charged_total = 0.00F;
            int miles_driven = 0;
            int begin_odo = 0;
            int end_odo = 0;
            int days_rented = 0;

            try {
                // get the values from the text boxes
                begin_odo = Convert.ToInt32(textBox_odo_begin.Text);
                end_odo = Convert.ToInt32(textBox_odo_end.Text);
                days_rented = Convert.ToInt32(textBox_days_rent.Text);

                if (end_odo < begin_odo)
                {
                    
                    throw new Exception("Ending miles must be greater than starting miles.");
                } // end if
                else
                {
                    // do the computations for each of the items
                    miles_driven = (end_odo - begin_odo);
                    charged_miles = miles_driven * mileage_rate;
                    charged_daily = days_rented * daily_charge;

                    // calcualte the total for the current customer
                    charged_total = charged_miles + charged_daily;

                    // add to the amount that all customers have been charged 
                    charged_all_customers = charged_all_customers + charged_total;

                    // update the labels with each of the values
                    label_total_miles.Text = "Total Miles; This Customer: " + miles_driven;
                    label_total_customer.Text = "Total Charged, This Customer: $" + charged_total.ToString("0.00");
                    label_total_customer_all.Text = "Total Charged, All Customers: $" + charged_all_customers.ToString("0.00");
                } // end if
            } // end try 
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // end catch
        } // end function
    } // end class 
} // end namespace
