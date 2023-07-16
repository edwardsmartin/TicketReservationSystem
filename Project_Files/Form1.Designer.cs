namespace PRG455_PROJECT
{
    partial class FormEvents
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
            this.lblEvent = new System.Windows.Forms.Label();
            this.txtboxEventID = new System.Windows.Forms.TextBox();
            this.lblEventID = new System.Windows.Forms.Label();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.txtboxEventDescription = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.cmbBoxSource = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.cmbBoxDestination = new System.Windows.Forms.ComboBox();
            this.cmbBoxDepartureTime = new System.Windows.Forms.ComboBox();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.cmbBoxArrivalTime = new System.Windows.Forms.ComboBox();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.txtBoxSeatsAvailable = new System.Windows.Forms.TextBox();
            this.lblSeatsAvailable = new System.Windows.Forms.Label();
            this.lblSeatsSold = new System.Windows.Forms.Label();
            this.txtBoxSeatsSold = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.btnNextEvent = new System.Windows.Forms.Button();
            this.btnPreviousEvent = new System.Windows.Forms.Button();
            this.cmbboxDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEvent
            // 
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEvent.Location = new System.Drawing.Point(191, 13);
            this.lblEvent.MinimumSize = new System.Drawing.Size(186, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(186, 103);
            this.lblEvent.TabIndex = 0;
            this.lblEvent.Text = "Flight Details";
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxEventID
            // 
            this.txtboxEventID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtboxEventID.Location = new System.Drawing.Point(12, 84);
            this.txtboxEventID.Name = "txtboxEventID";
            this.txtboxEventID.ReadOnly = true;
            this.txtboxEventID.Size = new System.Drawing.Size(173, 20);
            this.txtboxEventID.TabIndex = 1;
            this.txtboxEventID.TextChanged += new System.EventHandler(this.txtboxFlightID_TextChanged);
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.Location = new System.Drawing.Point(12, 68);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(57, 13);
            this.lblEventID.TabIndex = 2;
            this.lblEventID.Text = "Event ID";
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDescription.Location = new System.Drawing.Point(385, 68);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(106, 13);
            this.lblEventDescription.TabIndex = 3;
            this.lblEventDescription.Text = "Flight Description";
            // 
            // txtboxEventDescription
            // 
            this.txtboxEventDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtboxEventDescription.Location = new System.Drawing.Point(382, 84);
            this.txtboxEventDescription.Multiline = true;
            this.txtboxEventDescription.Name = "txtboxEventDescription";
            this.txtboxEventDescription.ReadOnly = true;
            this.txtboxEventDescription.Size = new System.Drawing.Size(173, 57);
            this.txtboxEventDescription.TabIndex = 4;
            this.txtboxEventDescription.TextChanged += new System.EventHandler(this.txtboxFlightDescription_TextChanged);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(12, 144);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(47, 13);
            this.lblSource.TabIndex = 5;
            this.lblSource.Text = "Source";
            // 
            // cmbBoxSource
            // 
            this.cmbBoxSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSource.FormattingEnabled = true;
            this.cmbBoxSource.Location = new System.Drawing.Point(12, 161);
            this.cmbBoxSource.Name = "cmbBoxSource";
            this.cmbBoxSource.Size = new System.Drawing.Size(173, 21);
            this.cmbBoxSource.Sorted = true;
            this.cmbBoxSource.TabIndex = 6;
            this.cmbBoxSource.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSource_SelectedIndexChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(379, 144);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(71, 13);
            this.lblDestination.TabIndex = 7;
            this.lblDestination.Text = "Destination";
            // 
            // cmbBoxDestination
            // 
            this.cmbBoxDestination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDestination.FormattingEnabled = true;
            this.cmbBoxDestination.Location = new System.Drawing.Point(382, 161);
            this.cmbBoxDestination.Name = "cmbBoxDestination";
            this.cmbBoxDestination.Size = new System.Drawing.Size(173, 21);
            this.cmbBoxDestination.Sorted = true;
            this.cmbBoxDestination.TabIndex = 8;
            this.cmbBoxDestination.SelectedIndexChanged += new System.EventHandler(this.cmbBoxDestination_SelectedIndexChanged);
            // 
            // cmbBoxDepartureTime
            // 
            this.cmbBoxDepartureTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxDepartureTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDepartureTime.FormattingEnabled = true;
            this.cmbBoxDepartureTime.Location = new System.Drawing.Point(12, 245);
            this.cmbBoxDepartureTime.Name = "cmbBoxDepartureTime";
            this.cmbBoxDepartureTime.Size = new System.Drawing.Size(173, 21);
            this.cmbBoxDepartureTime.Sorted = true;
            this.cmbBoxDepartureTime.TabIndex = 10;
            this.cmbBoxDepartureTime.SelectedIndexChanged += new System.EventHandler(this.cmbBoxDepartureTime_SelectedIndexChanged);
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureTime.Location = new System.Drawing.Point(12, 229);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(94, 13);
            this.lblDepartureTime.TabIndex = 9;
            this.lblDepartureTime.Text = "Departure Time";
            // 
            // cmbBoxArrivalTime
            // 
            this.cmbBoxArrivalTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxArrivalTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxArrivalTime.FormattingEnabled = true;
            this.cmbBoxArrivalTime.Location = new System.Drawing.Point(382, 245);
            this.cmbBoxArrivalTime.Name = "cmbBoxArrivalTime";
            this.cmbBoxArrivalTime.Size = new System.Drawing.Size(173, 21);
            this.cmbBoxArrivalTime.Sorted = true;
            this.cmbBoxArrivalTime.TabIndex = 12;
            this.cmbBoxArrivalTime.SelectedIndexChanged += new System.EventHandler(this.cmbBoxArrivalTime_SelectedIndexChanged);
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalTime.Location = new System.Drawing.Point(385, 228);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(74, 13);
            this.lblArrivalTime.TabIndex = 11;
            this.lblArrivalTime.Text = "Arrival Time";
            // 
            // txtBoxSeatsAvailable
            // 
            this.txtBoxSeatsAvailable.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxSeatsAvailable.Location = new System.Drawing.Point(12, 331);
            this.txtBoxSeatsAvailable.Name = "txtBoxSeatsAvailable";
            this.txtBoxSeatsAvailable.ReadOnly = true;
            this.txtBoxSeatsAvailable.Size = new System.Drawing.Size(173, 20);
            this.txtBoxSeatsAvailable.TabIndex = 14;
            this.txtBoxSeatsAvailable.Text = "0";
            this.txtBoxSeatsAvailable.TextChanged += new System.EventHandler(this.txtBoxSeatsAvailable_TextChanged);
            // 
            // lblSeatsAvailable
            // 
            this.lblSeatsAvailable.AutoSize = true;
            this.lblSeatsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatsAvailable.Location = new System.Drawing.Point(12, 315);
            this.lblSeatsAvailable.Name = "lblSeatsAvailable";
            this.lblSeatsAvailable.Size = new System.Drawing.Size(95, 13);
            this.lblSeatsAvailable.TabIndex = 13;
            this.lblSeatsAvailable.Text = "Seats Available";
            // 
            // lblSeatsSold
            // 
            this.lblSeatsSold.AutoSize = true;
            this.lblSeatsSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatsSold.Location = new System.Drawing.Point(15, 398);
            this.lblSeatsSold.Name = "lblSeatsSold";
            this.lblSeatsSold.Size = new System.Drawing.Size(68, 13);
            this.lblSeatsSold.TabIndex = 15;
            this.lblSeatsSold.Text = "Seats Sold";
            // 
            // txtBoxSeatsSold
            // 
            this.txtBoxSeatsSold.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxSeatsSold.Location = new System.Drawing.Point(12, 414);
            this.txtBoxSeatsSold.Name = "txtBoxSeatsSold";
            this.txtBoxSeatsSold.ReadOnly = true;
            this.txtBoxSeatsSold.Size = new System.Drawing.Size(173, 20);
            this.txtBoxSeatsSold.TabIndex = 16;
            this.txtBoxSeatsSold.Text = "0";
            this.txtBoxSeatsSold.TextChanged += new System.EventHandler(this.txtBoxSeatsSold_TextChanged);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxPrice.Location = new System.Drawing.Point(382, 414);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.ReadOnly = true;
            this.txtBoxPrice.Size = new System.Drawing.Size(173, 20);
            this.txtBoxPrice.TabIndex = 18;
            this.txtBoxPrice.Text = "$0.00";
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.txtBoxPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(382, 398);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price";
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyTicket.Location = new System.Drawing.Point(244, 414);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(75, 23);
            this.btnBuyTicket.TabIndex = 19;
            this.btnBuyTicket.Text = "Buy Ticket";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // btnNextEvent
            // 
            this.btnNextEvent.Location = new System.Drawing.Point(382, 13);
            this.btnNextEvent.Name = "btnNextEvent";
            this.btnNextEvent.Size = new System.Drawing.Size(75, 41);
            this.btnNextEvent.TabIndex = 20;
            this.btnNextEvent.Text = "Next Event";
            this.btnNextEvent.UseVisualStyleBackColor = true;
            this.btnNextEvent.Click += new System.EventHandler(this.btnNextEvent_Click);
            // 
            // btnPreviousEvent
            // 
            this.btnPreviousEvent.Location = new System.Drawing.Point(110, 12);
            this.btnPreviousEvent.Name = "btnPreviousEvent";
            this.btnPreviousEvent.Size = new System.Drawing.Size(75, 42);
            this.btnPreviousEvent.TabIndex = 21;
            this.btnPreviousEvent.Text = "Previous Event";
            this.btnPreviousEvent.UseVisualStyleBackColor = true;
            this.btnPreviousEvent.Click += new System.EventHandler(this.btnPreviousEvent_Click);
            // 
            // cmbboxDate
            // 
            this.cmbboxDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbboxDate.Location = new System.Drawing.Point(382, 331);
            this.cmbboxDate.Name = "cmbboxDate";
            this.cmbboxDate.Size = new System.Drawing.Size(173, 20);
            this.cmbboxDate.TabIndex = 23;
            this.cmbboxDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(382, 315);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 13);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date";
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 465);
            this.Controls.Add(this.cmbboxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnPreviousEvent);
            this.Controls.Add(this.btnNextEvent);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtBoxSeatsSold);
            this.Controls.Add(this.lblSeatsSold);
            this.Controls.Add(this.txtBoxSeatsAvailable);
            this.Controls.Add(this.lblSeatsAvailable);
            this.Controls.Add(this.cmbBoxArrivalTime);
            this.Controls.Add(this.lblArrivalTime);
            this.Controls.Add(this.cmbBoxDepartureTime);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.cmbBoxDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.cmbBoxSource);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtboxEventDescription);
            this.Controls.Add(this.lblEventDescription);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.txtboxEventID);
            this.Controls.Add(this.lblEvent);
            this.Name = "FormEvents";
            this.Text = "Select Event";
            this.Load += new System.EventHandler(this.FormEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TextBox txtboxEventID;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.TextBox txtboxEventDescription;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.ComboBox cmbBoxSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.ComboBox cmbBoxDestination;
        private System.Windows.Forms.ComboBox cmbBoxDepartureTime;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.ComboBox cmbBoxArrivalTime;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.TextBox txtBoxSeatsAvailable;
        private System.Windows.Forms.Label lblSeatsAvailable;
        private System.Windows.Forms.Label lblSeatsSold;
        private System.Windows.Forms.TextBox txtBoxSeatsSold;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Button btnNextEvent;
        private System.Windows.Forms.Button btnPreviousEvent;
        private System.Windows.Forms.TextBox cmbboxDate;
        private System.Windows.Forms.Label lblDate;
    }
}

