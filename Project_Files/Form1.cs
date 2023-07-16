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
    public partial class FormEvents : Form
    {
        //array used to store event data
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
        private bool flightEvent,
                     basketballEvent;

        public FormEvents()
        {
            InitializeComponent();
        }

        private void FormEvents_Load(object sender, EventArgs e)
        {
            //Loads event info for a flight
            this.cmbBoxSource.Items.AddRange(new object[] {
            "Cancun, Mexico",
            "Dublin, Ireland",
            "Kingston, Jamaica",
            "London, England",
            "Montego Bay, Jamaica",
            "Nassau, the Bahamas",
            "Paris, France",
            "Punta Cana, Dominican Republic",
            "Rome, Italy",
            "Shanghai, China",
            "Toronto, Ontario"});
            this.cmbBoxDestination.Items.AddRange(new object[] {
            "Cancun, Mexico",
            "Dublin, Ireland",
            "Kingston, Jamaica",
            "London, England",
            "Montego Bay, Jamaica",
            "Nassau, the Bahamas",
            "Paris, France",
            "Punta Cana, Dominican Republic",
            "Rome, Italy",
            "Shanghai, China",
            "Toronto, Ontario"});

            txtboxEventID.Text = "1";
            txtboxEventDescription.Text = "This event is for details about a flight.";

            flightEvent = true;
            basketballEvent = false;
        }

        private void txtboxFlightID_TextChanged(object sender, EventArgs e)
        {
            eventInfo[0] = txtboxEventID.Text;
        }

        private void txtboxFlightDescription_TextChanged(object sender, EventArgs e)
        {
            eventInfo[1] = txtboxEventDescription.Text;
        }

        private void cmbBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rand = new Random();

            int[] hours = new int[3],
                  minutes = new int[3];

            //if departure time is empty, fill it with random times
            if (string.IsNullOrEmpty(cmbBoxDepartureTime.Text))
            {
                for (int i = 0; i < 3; i++)
                {
                    //calculates the time for hours
                    hours[i] = rand.Next(1, 25);

                    //removes any duplicate numbers
                    if (hours.Length != hours.Distinct().Count())
                    {
                        //calculates the time for hours
                        hours[i] = rand.Next(1, 25);
                    }

                    for (int j = 0; j < 3; j++)
                    {
                        //calculates the time for minutes
                        minutes[j] = rand.Next(0, 11) * 5;

                        //removes any duplicate numbers
                        if (minutes.Length != minutes.Distinct().Count())
                        {
                            //calculates the time for minutes
                            minutes[j] = rand.Next(0, 11) * 5;
                        }

                        //adds the time into the departure time combo box and sets the minutes to 2 decimal places
                        this.cmbBoxDepartureTime.Items.AddRange(new object[] {
                            string.Format("{0:D2}", hours[i]) + ":" + string.Format("{0:D2}", minutes[j])
                        });
                    }
                }
                //sets the departure time to the first time in the combobox
                cmbBoxDepartureTime.Text = cmbBoxDepartureTime.Items[0].ToString();
            }

            //if the event is the flight event, it will update the description with flight details
            if (flightEvent)
                eventInfo[1] = "This event is for details about a flight.";

            else
                eventInfo[1] = "This event is for details about a basketball game.";

            txtboxEventDescription.Text = eventInfo[1];
            eventInfo[2] = cmbBoxSource.Text;

            //code to determine the number of seats available
            if (!string.IsNullOrEmpty(cmbBoxSource.Text) && !string.IsNullOrEmpty(cmbBoxDestination.Text))
            {
                //generates a random number from 0 - 60
                txtBoxSeatsAvailable.Text = Convert.ToString(rand.Next(61));

                //generates a random number from 0 - 60 based off of the number from SeatsAvailable
                txtBoxSeatsSold.Text = Convert.ToString(rand.Next(Convert.ToInt16(txtBoxSeatsAvailable.Text)));
            }

            //code to determine the price of the flight
            if (!string.IsNullOrEmpty(cmbBoxSource.Text) && !string.IsNullOrEmpty(cmbBoxDestination.Text))
            {
                //generates a random number between $400 - 1000
                txtBoxPrice.Text = string.Format("{0:C2}", rand.Next(400, 1001));
            }

            //checks to see if the source and destination are the same
            checkLocation();
        }

        private void cmbBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rand = new Random();

            int[] hours = new int[3],
                    minutes = new int[3];

            //if arrival time is empty, fill it with random times
            if (string.IsNullOrEmpty(cmbBoxArrivalTime.Text))
            {
                for (int i = 0; i < 3; i++)
                {
                    //calculates the time for hours
                    hours[i] = rand.Next(1, 25);

                    //removes any duplicate numbers
                    if (hours.Length != hours.Distinct().Count())
                    {
                        //calculates the time for hours
                        hours[i] = rand.Next(1, 25);
                    }

                    for (int j = 0; j < 3; j++)
                    {
                        //calculates the time for minutes
                        minutes[j] = rand.Next(0, 11) * 5;

                        //removes any duplicate numbers
                        if (minutes.Length != minutes.Distinct().Count())
                        {
                            //calculates the time for minutes
                            minutes[j] = rand.Next(0, 11) * 5;
                        }

                        //adds the time into the departure time combo box and sets the minutes to 2 decimal places
                        this.cmbBoxArrivalTime.Items.AddRange(new object[] {
                        string.Format("{0:D2}", hours[i]) + ":" + string.Format("{0:D2}", minutes[j])
                    });
                    }
                }
                //sets the arrival time to the first time in the combobox
                cmbBoxArrivalTime.Text = cmbBoxArrivalTime.Items[0].ToString();
            }

            //if the event is the flight event, it will update the description with flight details
            if (flightEvent)
                eventInfo[1] = "This event is for details about a flight.";

            else
                eventInfo[1] = "This event is for details about a basketball game.";

            txtboxEventDescription.Text = eventInfo[1];
            eventInfo[3] = cmbBoxDestination.Text;

            //code to determine the number of seats available
            if (!string.IsNullOrEmpty(cmbBoxSource.Text) && !string.IsNullOrEmpty(cmbBoxDestination.Text))
            {
                //generates a random number from 0 - 60
                txtBoxSeatsAvailable.Text = Convert.ToString(rand.Next(61));

                //generates a random number from 0 - 60 based off of the number from SeatsAvailable
                txtBoxSeatsSold.Text = Convert.ToString(rand.Next(Convert.ToInt16(txtBoxSeatsAvailable.Text)));
            }

            //code to determine the price of the flight
            if (!string.IsNullOrEmpty(cmbBoxSource.Text) && !string.IsNullOrEmpty(cmbBoxDestination.Text))
            {
                //generates a random number between $400 - 1000
                txtBoxPrice.Text = string.Format("{0:C2}", rand.Next(400, 1001));
            }
            //checks to see if the source and destination are the same
            checkLocation();
        }

        private void cmbBoxDepartureTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventInfo[4] = cmbBoxDepartureTime.Text;
        }

        private void cmbBoxArrivalTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventInfo[5] = cmbBoxArrivalTime.Text;
        }

        private void txtBoxSeatsAvailable_TextChanged(object sender, EventArgs e)
        {
            eventInfo[6] = txtBoxSeatsAvailable.Text;
        }

        private void txtBoxSeatsSold_TextChanged(object sender, EventArgs e)
        {
            eventInfo[7] = txtBoxSeatsSold.Text;
        }

        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {
            eventInfo[8] = txtBoxPrice.Text;
        }

        private void btnNextEvent_Click(object sender, EventArgs e)
        {
            flightEvent = false;
            basketballEvent = true;

            if (basketballEvent)
            {
                //Loads event info for a basketball game
                lblEvent.Text = "Basketball Game Details";
                txtboxEventID.Text = "2";
                lblEventDescription.Text = "Basketball Game Description";
                txtboxEventDescription.Text = "This event is for details about a basketball game.";
                lblSource.Text = "Location";
                lblDestination.Text = "Teams";
                lblDepartureTime.Text = "Time";
                lblArrivalTime.Visible = false;
                cmbBoxArrivalTime.Visible = false;
                txtBoxSeatsAvailable.Text = "";
                txtBoxSeatsSold.Text = "";
                txtBoxPrice.Text = "";

                //Changes location details to fit basketball game event
                cmbBoxSource.Items.Clear();
                cmbBoxDestination.Items.Clear();

                this.cmbBoxSource.Items.AddRange(new object[] {
                "Indianapolis",
                "Los Angeles",
                "Houston",
                "New York",
                "Atlanta"});
                this.cmbBoxDestination.Items.AddRange(new object[] {
                "Atlanta Hawks vs. Boston Celtics",
                "Brooklyn Nets vs. Charlotte Hornets",
                "Chicago Bulls vs. Cleveland Cavaliers",
                "Dallas Mavericks vs. Denver Nuggets",
                "Detroit Pistons vs. Golden State Warriors",
                "Houston Rockets vs. Indiana Pacers",
                "LA Clippers vs. Los Angeles Lakers",
                "Memphis Grizzlies vs. Miami Heat",
                "Milwaukee Bucks vs. Minnesota Timbewolves",
                "Phoenix Suns vs. Philadelphia 76ers",
                "Toronto Raptors vs. San Antonio Spurs"});
            }
            btnNextEvent.Enabled = false;
            btnPreviousEvent.Enabled = true;
        }

        private void btnPreviousEvent_Click(object sender, EventArgs e)
        {
            //Loads event info for a flight
            flightEvent = true;
            basketballEvent = false;

            if (flightEvent)
            {
                //Loads event info for a flight event
                lblEvent.Text = "Flight Details";
                txtboxEventID.Text = "1";
                lblEventDescription.Text = "Flight Description";
                txtboxEventDescription.Text = "This event is for details about a flight.";
                lblSource.Text = "Source";
                lblDestination.Text = "Destination";
                lblDepartureTime.Text = "Departure Time";
                lblArrivalTime.Visible = true;
                cmbBoxArrivalTime.Visible = true;
                txtBoxSeatsAvailable.Text = "";
                txtBoxSeatsSold.Text = "";
                txtBoxPrice.Text = "";

                //Changes location details to fit basketball game event
                cmbBoxSource.Items.Clear();
                cmbBoxDestination.Items.Clear();

                this.cmbBoxSource.Items.AddRange(new object[] {
                "Cancun, Mexico",
                "Dublin, Ireland",
                "Kingston, Jamaica",
                "London, England",
                "Montego Bay, Jamaica",
                "Nassau, the Bahamas",
                "Paris, France",
                "Punta Cana, Dominican Republic",
                "Rome, Italy",
                "Shanghai, China",
                "Toronto, Ontario"});
                this.cmbBoxDestination.Items.AddRange(new object[] {
                "Cancun, Mexico",
                "Dublin, Ireland",
                "Kingston, Jamaica",
                "London, England",
                "Montego Bay, Jamaica",
                "Nassau, the Bahamas",
                "Paris, France",
                "Punta Cana, Dominican Republic",
                "Rome, Italy",
                "Shanghai, China",
                "Toronto, Ontario"});
            }

            btnNextEvent.Enabled = true;
            btnPreviousEvent.Enabled = false;
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {

            if (!checkLocation())
            {
                if (flightEvent)
                {
                    if (string.IsNullOrEmpty(cmbBoxSource.Text))
                        MessageBox.Show("Please choose a source location!");

                    else if (string.IsNullOrEmpty(cmbBoxDestination.Text))
                        MessageBox.Show("Please choose a destination!");

                    else if (string.IsNullOrEmpty(cmbboxDate.Text))
                        MessageBox.Show("Please enter a date!");

                    else
                    {
                        //opens another form to ask for customer information
                        FormCustInfo custInfo = new FormCustInfo(eventInfo);
                        custInfo.Show();

                        this.Hide();
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(cmbBoxSource.Text))
                        MessageBox.Show("Please choose a location!");

                    else if (string.IsNullOrEmpty(cmbBoxDestination.Text))
                        MessageBox.Show("Please choose a team!");

                    else if (string.IsNullOrEmpty(cmbboxDate.Text))
                        MessageBox.Show("Please enter a date!");

                    else
                    {
                        //opens another form to ask for customer information
                        FormCustInfo custInfo = new FormCustInfo(eventInfo);
                        custInfo.Show();

                        this.Hide();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            eventInfo[9] = cmbboxDate.Text;
        }

        private bool checkLocation()
        {
            if (cmbBoxSource.Text == cmbBoxDestination.Text)
            {
                MessageBox.Show("Source and Destination cannot be the same!");
                txtBoxSeatsAvailable.Text = "0";
                txtBoxSeatsSold.Text = "0";
                txtBoxPrice.Text = "$0.00";
                return true;
            }
            else
                return false;
        }
    }
}
