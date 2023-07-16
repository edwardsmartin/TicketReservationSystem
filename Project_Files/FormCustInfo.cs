using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG455_PROJECT
{
    public partial class FormCustInfo : Form
    {
        //array to store event info
        private string[] eventInfo = new string[10];

        //array to store customer info
        private string[] customerInfo = new string[8];
        /*
         * customerInfo[0] is the firstName,
         * customerInfo[1] is the lastName,
         * customerInfo[2] is the address,
         * customerInfo[3] is the phoneNumber,
         * customerInfo[4] is the creditCardNumber,
         * customerInfo[5] is the creditCardDate,
         * customerInfo[6] is the creditCardCCV,
         * customerInfo[7] is the customerID;
         */

        public FormCustInfo(string[] eventInfo)
        {
            InitializeComponent();

            for (int i = 0; i < eventInfo.Length; i++)
            {
                this.eventInfo[i] = eventInfo[i];
            }
        }

        private void txtboxFirstName_TextChanged(object sender, EventArgs e)
        {
            customerInfo[0] = txtboxFirstName.Text;
        }

        private void txtboxLastName_TextChanged(object sender, EventArgs e)
        {
            customerInfo[1] = txtboxLastName.Text;
        }

        private void txtboxAddress_TextChanged(object sender, EventArgs e)
        {
            customerInfo[2] = txtboxAddress.Text;
        }

        private void txtboxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
                customerInfo[3] = txtboxPhoneNumber.Text;
        }

        private void txtboxCreditCardNumber_TextChanged(object sender, EventArgs e)
        {
                customerInfo[4] = txtboxCreditCardNumber.Text;
            
        }

        private void txtboxCreditCardDate_TextChanged(object sender, EventArgs e)
        {
                customerInfo[5] = txtboxCreditCardDate.Text;
        }

        private void txtboxCreditCardCCV_TextChanged(object sender, EventArgs e)
        {
                customerInfo[6] = txtboxCreditCardCCV.Text;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            if (string.IsNullOrEmpty(customerInfo[0]))
            {
                MessageBox.Show("Please enter your first name!");
            }
            else if (string.IsNullOrEmpty(customerInfo[1]))
            {
                MessageBox.Show("Please enter your last name!");
            }
            else if (string.IsNullOrEmpty(customerInfo[2]))
            {
                MessageBox.Show("Please enter your address!");
            }
            else if (string.IsNullOrEmpty(customerInfo[3]) || txtboxPhoneNumber.Text.Length > 10 || txtboxPhoneNumber.Text.Length < 10)
            {
                if (txtboxPhoneNumber.Text.Length > 10 || txtboxPhoneNumber.Text.Length < 10)
                    MessageBox.Show("Please enter a valid phone number that's 10 digits in length.");
                
                else
                    MessageBox.Show("Please enter your phone number!");
            }
            else if (string.IsNullOrEmpty(customerInfo[4]) || txtboxCreditCardNumber.Text.Length > 16 || txtboxCreditCardNumber.Text.Length < 16)
            {
                if (txtboxCreditCardNumber.Text.Length > 16 || txtboxCreditCardNumber.Text.Length < 16)
                    MessageBox.Show("Please enter a correct credit card number.");

                else
                    MessageBox.Show("Please enter your credit card number!");
            }
            else if (string.IsNullOrEmpty(customerInfo[5]) || txtboxCreditCardDate.Text.Length > 5 || txtboxCreditCardDate.Text.Length < 5)
            {
                if (txtboxCreditCardDate.Text.Length > 5 || txtboxCreditCardDate.Text.Length < 5)
                    MessageBox.Show("Please enter a correct expiration date for your credit card in the format (mm/yy)." +
                                    "Example: 02/23");
                else
                    MessageBox.Show("Please enter your credit card date!");
            }
            else if (string.IsNullOrEmpty(customerInfo[6]) || txtboxCreditCardCCV.Text.Length > 3 || txtboxCreditCardCCV.Text.Length < 3)
            {
                if (txtboxCreditCardCCV.Text.Length > 3 || txtboxCreditCardCCV.Text.Length < 3)
                    MessageBox.Show("Please enter a correct security code for your credit card.");

                else
                    MessageBox.Show("Please enter your credit card CCV!");
            }
            else
            {

                if (eventInfo[0] == "1")  //generates a random customer ID/seat number for a flight event
                {
                    customerInfo[7] = Convert.ToString(rand.Next(1, 51));
                    txtboxCustomerID.Text = customerInfo[7];
                }
                else   //generates a random customer ID/seat number for a basketball game
                {
                    customerInfo[7] = Convert.ToString(rand.Next(200, 2001));
                    txtboxCustomerID.Text = customerInfo[7];
                }
                
                //opens a form to display a receipt
                FormReceipt receipt = new FormReceipt(eventInfo, customerInfo);
                receipt.Show();

                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //goes back to the previous form about events
            FormEvents events = new FormEvents();
            events.Show();

            //this.Hide();
        }
    }
}
