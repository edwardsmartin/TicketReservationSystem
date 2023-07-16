namespace PRG455_PROJECT
{
    partial class FormCustInfo
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
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtboxCustomerID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtboxPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.txtboxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.lblCreditCardDate = new System.Windows.Forms.Label();
            this.txtboxCreditCardDate = new System.Windows.Forms.TextBox();
            this.lblCreditCardCCV = new System.Windows.Forms.Label();
            this.txtboxCreditCardCCV = new System.Windows.Forms.TextBox();
            this.lblCreditCardInfo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCustomerInfo.Location = new System.Drawing.Point(191, 9);
            this.lblCustomerInfo.MinimumSize = new System.Drawing.Size(186, 0);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(186, 103);
            this.lblCustomerInfo.TabIndex = 1;
            this.lblCustomerInfo.Text = "Customer Info";
            this.lblCustomerInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(12, 401);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(76, 13);
            this.lblCustomerID.TabIndex = 4;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtboxCustomerID
            // 
            this.txtboxCustomerID.Location = new System.Drawing.Point(12, 417);
            this.txtboxCustomerID.Name = "txtboxCustomerID";
            this.txtboxCustomerID.ReadOnly = true;
            this.txtboxCustomerID.Size = new System.Drawing.Size(173, 20);
            this.txtboxCustomerID.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(12, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(12, 84);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(173, 20);
            this.txtboxFirstName.TabIndex = 5;
            this.txtboxFirstName.TextChanged += new System.EventHandler(this.txtboxFirstName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(12, 144);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name";
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(12, 161);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(173, 20);
            this.txtboxLastName.TabIndex = 7;
            this.txtboxLastName.TextChanged += new System.EventHandler(this.txtboxLastName_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 229);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(12, 245);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(173, 20);
            this.txtboxAddress.TabIndex = 9;
            this.txtboxAddress.TextChanged += new System.EventHandler(this.txtboxAddress_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 315);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(174, 13);
            this.lblPhoneNumber.TabIndex = 12;
            this.lblPhoneNumber.Text = "Telephone Number (10 digits)";
            // 
            // txtboxPhoneNumber
            // 
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(12, 331);
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(173, 20);
            this.txtboxPhoneNumber.TabIndex = 11;
            this.txtboxPhoneNumber.TextChanged += new System.EventHandler(this.txtboxPhoneNumber_TextChanged);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.Location = new System.Drawing.Point(403, 414);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 20;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNumber.Location = new System.Drawing.Point(384, 145);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(177, 13);
            this.lblCreditCardNumber.TabIndex = 22;
            this.lblCreditCardNumber.Text = "Credit Card Number (16 digits)";
            // 
            // txtboxCreditCardNumber
            // 
            this.txtboxCreditCardNumber.Location = new System.Drawing.Point(384, 161);
            this.txtboxCreditCardNumber.Name = "txtboxCreditCardNumber";
            this.txtboxCreditCardNumber.Size = new System.Drawing.Size(173, 20);
            this.txtboxCreditCardNumber.TabIndex = 21;
            this.txtboxCreditCardNumber.TextChanged += new System.EventHandler(this.txtboxCreditCardNumber_TextChanged);
            // 
            // lblCreditCardDate
            // 
            this.lblCreditCardDate.AutoSize = true;
            this.lblCreditCardDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardDate.Location = new System.Drawing.Point(384, 222);
            this.lblCreditCardDate.Name = "lblCreditCardDate";
            this.lblCreditCardDate.Size = new System.Drawing.Size(149, 13);
            this.lblCreditCardDate.TabIndex = 24;
            this.lblCreditCardDate.Text = "Credit Card Date (mm/yy)";
            // 
            // txtboxCreditCardDate
            // 
            this.txtboxCreditCardDate.Location = new System.Drawing.Point(384, 238);
            this.txtboxCreditCardDate.Name = "txtboxCreditCardDate";
            this.txtboxCreditCardDate.Size = new System.Drawing.Size(173, 20);
            this.txtboxCreditCardDate.TabIndex = 23;
            this.txtboxCreditCardDate.TextChanged += new System.EventHandler(this.txtboxCreditCardDate_TextChanged);
            // 
            // lblCreditCardCCV
            // 
            this.lblCreditCardCCV.AutoSize = true;
            this.lblCreditCardCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardCCV.Location = new System.Drawing.Point(384, 306);
            this.lblCreditCardCCV.Name = "lblCreditCardCCV";
            this.lblCreditCardCCV.Size = new System.Drawing.Size(98, 13);
            this.lblCreditCardCCV.TabIndex = 26;
            this.lblCreditCardCCV.Text = "Credit Card CCV";
            // 
            // txtboxCreditCardCCV
            // 
            this.txtboxCreditCardCCV.Location = new System.Drawing.Point(384, 322);
            this.txtboxCreditCardCCV.Name = "txtboxCreditCardCCV";
            this.txtboxCreditCardCCV.Size = new System.Drawing.Size(173, 20);
            this.txtboxCreditCardCCV.TabIndex = 25;
            this.txtboxCreditCardCCV.TextChanged += new System.EventHandler(this.txtboxCreditCardCCV_TextChanged);
            // 
            // lblCreditCardInfo
            // 
            this.lblCreditCardInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardInfo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCreditCardInfo.Location = new System.Drawing.Point(379, 106);
            this.lblCreditCardInfo.MinimumSize = new System.Drawing.Size(186, 0);
            this.lblCreditCardInfo.Name = "lblCreditCardInfo";
            this.lblCreditCardInfo.Size = new System.Drawing.Size(186, 39);
            this.lblCreditCardInfo.TabIndex = 27;
            this.lblCreditCardInfo.Text = "Credit Card Info";
            this.lblCreditCardInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(15, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormCustInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 465);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCreditCardInfo);
            this.Controls.Add(this.lblCreditCardCCV);
            this.Controls.Add(this.txtboxCreditCardCCV);
            this.Controls.Add(this.lblCreditCardDate);
            this.Controls.Add(this.txtboxCreditCardDate);
            this.Controls.Add(this.lblCreditCardNumber);
            this.Controls.Add(this.txtboxCreditCardNumber);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtboxPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtboxCustomerID);
            this.Controls.Add(this.lblCustomerInfo);
            this.Name = "FormCustInfo";
            this.Text = "Enter your personal information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtboxCustomerID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtboxPhoneNumber;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.TextBox txtboxCreditCardNumber;
        private System.Windows.Forms.Label lblCreditCardDate;
        private System.Windows.Forms.TextBox txtboxCreditCardDate;
        private System.Windows.Forms.Label lblCreditCardCCV;
        private System.Windows.Forms.TextBox txtboxCreditCardCCV;
        private System.Windows.Forms.Label lblCreditCardInfo;
        private System.Windows.Forms.Button btnBack;
    }
}