using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace PRG455_PROJECT
{
    public partial class FormReceipt : Form
    {
        //array to store event info
        private string[] eventInfo = new string[10];
        /*
         * eventInfo[0] is the eventID,
         * eventInfo[1] is the eventDescription,
         * eventInfo[2] is the eventSource,
         * eventInfo[3] is the eventDestination,
         * eventInfo[4] is the departureTime,
         * eventInfo[5] is the arrivalTime,
         * eventInfo[6] is the seatsAvailable,
         * eventInfo[7] is the seatsSold,
         * eventInfo[8] is the price,
         * eventInfo[9] is the date;
         */

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

        public FormReceipt(string[] eventInfo, string[] customerInfo)
        {
            InitializeComponent();

            for (int i = 0; i < eventInfo.Length; i++)
            {
                this.eventInfo[i] = eventInfo[i];
            }

            for (int i = 0; i < customerInfo.Length; i++)
            {
                this.customerInfo[i] = customerInfo[i];
            }
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            //copies info about event ID to receipt
            lblReceiptEventID.Text += eventInfo[0];

            //copies info about event description to receipt
            lblReceiptEventDescription.Text += eventInfo[1];

            //copies info about event location to receipt
            if (eventInfo[0] == "1")    //if the event is for a flight
            {
                lblReceiptLocation.Text += "From: " + eventInfo[2] + " To: " + eventInfo[3];
            }
            else  //if the event is for a basketball game
            {
                lblReceiptLocation.Text += eventInfo[3] + " In: " + eventInfo[2];
            }
            
            //copies info about event price to receipt
            lblReceiptPrice.Text += eventInfo[8];

            //copies info about event date and time to receipt
            if (eventInfo[0] == "1")    //if the event is for a flight
            {
                lblReceiptDateTime.Text += eventInfo[9] + " Departure at: " + eventInfo[4] + " Arrival at: " + eventInfo[5];
            }
            else  //if the event is for a basketball game
            {
                lblReceiptDateTime.Text += eventInfo[9] + " at " + eventInfo[4];
            }

            //copies customer's first name to receipt
            lblReceiptFirstName.Text += customerInfo[0];

            //copies customer's last name to receipt
            lblReceiptLastName.Text += customerInfo[1];

            //copies customer's address to receipt
            lblReceiptAddress.Text += customerInfo[2];

            //copies customer's telephone number to receipt
            lblReceiptPhoneNumber.Text += customerInfo[3];

            //copies customer's credit card number to receipt
            lblReceiptCreditCardNum.Text += customerInfo[4];

            //copies customer's credit card date to receipt
            lblReceiptCreditCardDate.Text += customerInfo[5];

            //copies customer's credit card CCV to receipt
            lblReceiptCreditCardCCV.Text += customerInfo[6];

            //copies customer's seat number to receipt
            lblReceiptSeatNum.Text += customerInfo[7];

            //saves event info and customer info to a database file
            saveToDatabase();
        }

        private void btnReceiptClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void saveToDatabase()
        {
            //Creates a DataTable object
            DataTable dt1 = new DataTable("Event");
            DataTable dt2 = new DataTable("Customer");
            DataTable dt3 = new DataTable("Ticket");

            //Creates columns within  the event table
            dt1.Columns.AddRange(new DataColumn[8] {
                new DataColumn("eventID", typeof(string)),
                new DataColumn("eventDescription", typeof(string)),
                new DataColumn("location", typeof(string)),
                new DataColumn("time", typeof(string)),
                new DataColumn("numOfSeatsAvailable", typeof(string)),
                new DataColumn("numOfSeatsSold", typeof(string)),
                new DataColumn("price", typeof(string)),
                new DataColumn("date", typeof(string))
            });

            //Creates columns within the customer table
            dt2.Columns.AddRange(new DataColumn[8] {
                new DataColumn("customerID", typeof(string)),
                new DataColumn("firstName", typeof(string)),
                new DataColumn("lastName", typeof(string)),
                new DataColumn("address", typeof(string)),
                new DataColumn("phoneNumber", typeof(string)),
                new DataColumn("creditCardNumber", typeof(string)),
                new DataColumn("creditCardDate", typeof(string)),
                new DataColumn("creditCardCCV", typeof(string)),
            });

            //Creates columns within the ticket table
            dt3.Columns.AddRange(new DataColumn[17] {
                new DataColumn("eventID", typeof(string)),
                new DataColumn("eventDescription", typeof(string)),
                new DataColumn("location", typeof(string)),
                new DataColumn("time", typeof(string)),
                new DataColumn("numOfSeatsAvailable", typeof(string)),
                new DataColumn("numOfSeatsSold", typeof(string)),
                new DataColumn("price", typeof(string)),
                new DataColumn("date", typeof(string)),
                new DataColumn("customerID", typeof(string)),
                new DataColumn("firstName", typeof(string)),
                new DataColumn("lastName", typeof(string)),
                new DataColumn("address", typeof(string)),
                new DataColumn("phoneNumber", typeof(string)),
                new DataColumn("creditCardNumber", typeof(string)),
                new DataColumn("creditCardDate", typeof(string)),
                new DataColumn("creditCardCCV", typeof(string)),
                new DataColumn("seatNumber", typeof(string))
            });

            dt1.PrimaryKey = new DataColumn[] { dt1.Columns["eventID"] };
            dt2.PrimaryKey = new DataColumn[] { dt2.Columns["customerID"] };


            //Connection string
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\TICKETS.accdb";

            //SQL code
            string sqlStr1 = "INSERT INTO Event(eventID, eventDescription, location, time, numOfSeatsAvailable, numOfSeatsSold, price, date)VALUES(" + 
                            eventInfo[0] + "," + eventInfo[1] + "," + lblReceiptLocation.Text + "," + eventInfo[5] +  "," + eventInfo[6] + 
                            "," + eventInfo[7] + "," + eventInfo[8] + "," + eventInfo[9] + ")";

            string sqlStr2 = "INSERT INTO Event(customerID, firstName, lastName, address, phoneNumber, creditCardNumber, creditCardDate, creditCardCCV)VALUES(" +
                             customerInfo[7] + "," + customerInfo[0] + "," + customerInfo[1] + "," + customerInfo[2] + "," + customerInfo[3] + "," + customerInfo[4] + 
                             "," + customerInfo[5] + "," + customerInfo[6] + ")";

            foreach (DataRow dr2 in dt2.Rows) 
            {
                foreach (DataRow dr1 in dt1.Rows) 
                {
                    dt3.Rows.Add(dt1);
                }
                dt3.Rows.Add(dt2);
            }

            //Creating a Data Adapter object
            OleDbDataAdapter da1 = new OleDbDataAdapter(sqlStr1, conStr);
            OleDbDataAdapter da2 = new OleDbDataAdapter(sqlStr2, conStr);

            if (!File.Exists("C:\\TICKETS.accdb")){
                File.Create("C:\\TICKETS.accdb");
            }

            //OleDbConnection con = new OleDbConnection(conStr);
            //con.Open();

            try 
            {
                da1.Fill(dt1);
                da2.Fill(dt2);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }         
        }
    }
}
