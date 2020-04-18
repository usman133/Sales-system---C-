namespace Assingment_1
{
    partial class frmSalesSystem
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
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpCreditCardInformation = new System.Windows.Forms.GroupBox();
            this.cmboIssuingBank = new System.Windows.Forms.ComboBox();
            this.cmboExpiryYear = new System.Windows.Forms.ComboBox();
            this.cmboExpiryMonth = new System.Windows.Forms.ComboBox();
            this.cmboCardType = new System.Windows.Forms.ComboBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.lblIssuingBank = new System.Windows.Forms.Label();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.grpProductSelection = new System.Windows.Forms.GroupBox();
            this.txtUnitPriceScarfs = new System.Windows.Forms.TextBox();
            this.txtQtityScarfs = new System.Windows.Forms.TextBox();
            this.txtQtityJackets = new System.Windows.Forms.TextBox();
            this.txtUnitPriceJackets = new System.Windows.Forms.TextBox();
            this.txtQtitySweaters = new System.Windows.Forms.TextBox();
            this.txtQtityBeanies = new System.Windows.Forms.TextBox();
            this.txtUnitPriceSweaters = new System.Windows.Forms.TextBox();
            this.txtUnitPriceBeanies = new System.Windows.Forms.TextBox();
            this.txtUnitPriceGloves = new System.Windows.Forms.TextBox();
            this.txtQtityGloves = new System.Windows.Forms.TextBox();
            this.txtQtityShoes = new System.Windows.Forms.TextBox();
            this.txtUnitPriceShoes = new System.Windows.Forms.TextBox();
            this.chkGloves = new System.Windows.Forms.CheckBox();
            this.chkBeanies = new System.Windows.Forms.CheckBox();
            this.chkJackets = new System.Windows.Forms.CheckBox();
            this.chkSweaters = new System.Windows.Forms.CheckBox();
            this.chkScarfs = new System.Windows.Forms.CheckBox();
            this.chkShoes = new System.Windows.Forms.CheckBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.grpPaymentType = new System.Windows.Forms.GroupBox();
            this.rdioCreditCard = new System.Windows.Forms.RadioButton();
            this.rdioBankTransfer = new System.Windows.Forms.RadioButton();
            this.rdioCash = new System.Windows.Forms.RadioButton();
            this.btnShowSummary = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpCustomerDetails.SuspendLayout();
            this.grpCreditCardInformation.SuspendLayout();
            this.grpProductSelection.SuspendLayout();
            this.grpPaymentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.txtCountry);
            this.grpCustomerDetails.Controls.Add(this.txtLastName);
            this.grpCustomerDetails.Controls.Add(this.txtCity);
            this.grpCustomerDetails.Controls.Add(this.txtSuburb);
            this.grpCustomerDetails.Controls.Add(this.txtStreetAddress);
            this.grpCustomerDetails.Controls.Add(this.txtFirstName);
            this.grpCustomerDetails.Controls.Add(this.lblLastName);
            this.grpCustomerDetails.Controls.Add(this.lblStreetAddress);
            this.grpCustomerDetails.Controls.Add(this.lblSuburb);
            this.grpCustomerDetails.Controls.Add(this.lblCity);
            this.grpCustomerDetails.Controls.Add(this.lblCountry);
            this.grpCustomerDetails.Controls.Add(this.lblFirstName);
            this.grpCustomerDetails.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerDetails.Location = new System.Drawing.Point(3, 12);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(354, 240);
            this.grpCustomerDetails.TabIndex = 0;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(147, 189);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(184, 25);
            this.txtCountry.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(147, 55);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(184, 25);
            this.txtLastName.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(147, 154);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(184, 25);
            this.txtCity.TabIndex = 5;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuburb.Location = new System.Drawing.Point(147, 122);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(184, 25);
            this.txtSuburb.TabIndex = 4;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.Location = new System.Drawing.Point(147, 90);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(184, 25);
            this.txtStreetAddress.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(147, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(184, 25);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(34, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(74, 17);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(34, 93);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(95, 17);
            this.lblStreetAddress.TabIndex = 8;
            this.lblStreetAddress.Text = "Street Address";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburb.Location = new System.Drawing.Point(34, 126);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(49, 17);
            this.lblSuburb.TabIndex = 3;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(36, 162);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 17);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(34, 197);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(55, 17);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(34, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name ";
            // 
            // grpCreditCardInformation
            // 
            this.grpCreditCardInformation.Controls.Add(this.cmboIssuingBank);
            this.grpCreditCardInformation.Controls.Add(this.cmboExpiryYear);
            this.grpCreditCardInformation.Controls.Add(this.cmboExpiryMonth);
            this.grpCreditCardInformation.Controls.Add(this.cmboCardType);
            this.grpCreditCardInformation.Controls.Add(this.txtCardNumber);
            this.grpCreditCardInformation.Controls.Add(this.txtNameOnCard);
            this.grpCreditCardInformation.Controls.Add(this.lblCardType);
            this.grpCreditCardInformation.Controls.Add(this.lblCardNumber);
            this.grpCreditCardInformation.Controls.Add(this.lblExpiry);
            this.grpCreditCardInformation.Controls.Add(this.lblIssuingBank);
            this.grpCreditCardInformation.Controls.Add(this.lblNameOnCard);
            this.grpCreditCardInformation.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreditCardInformation.Location = new System.Drawing.Point(3, 286);
            this.grpCreditCardInformation.Name = "grpCreditCardInformation";
            this.grpCreditCardInformation.Size = new System.Drawing.Size(354, 183);
            this.grpCreditCardInformation.TabIndex = 1;
            this.grpCreditCardInformation.TabStop = false;
            this.grpCreditCardInformation.Text = "Credit Card Information";
            // 
            // cmboIssuingBank
            // 
            this.cmboIssuingBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboIssuingBank.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboIssuingBank.FormattingEnabled = true;
            this.cmboIssuingBank.Location = new System.Drawing.Point(147, 144);
            this.cmboIssuingBank.Name = "cmboIssuingBank";
            this.cmboIssuingBank.Size = new System.Drawing.Size(184, 25);
            this.cmboIssuingBank.TabIndex = 5;
            // 
            // cmboExpiryYear
            // 
            this.cmboExpiryYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboExpiryYear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboExpiryYear.FormattingEnabled = true;
            this.cmboExpiryYear.Location = new System.Drawing.Point(277, 113);
            this.cmboExpiryYear.Name = "cmboExpiryYear";
            this.cmboExpiryYear.Size = new System.Drawing.Size(54, 25);
            this.cmboExpiryYear.TabIndex = 4;
            // 
            // cmboExpiryMonth
            // 
            this.cmboExpiryMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboExpiryMonth.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboExpiryMonth.FormattingEnabled = true;
            this.cmboExpiryMonth.Location = new System.Drawing.Point(147, 113);
            this.cmboExpiryMonth.Name = "cmboExpiryMonth";
            this.cmboExpiryMonth.Size = new System.Drawing.Size(124, 25);
            this.cmboExpiryMonth.TabIndex = 3;
            // 
            // cmboCardType
            // 
            this.cmboCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboCardType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboCardType.FormattingEnabled = true;
            this.cmboCardType.Location = new System.Drawing.Point(147, 52);
            this.cmboCardType.Name = "cmboCardType";
            this.cmboCardType.Size = new System.Drawing.Size(184, 25);
            this.cmboCardType.TabIndex = 1;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(147, 81);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(184, 25);
            this.txtCardNumber.TabIndex = 2;
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOnCard.Location = new System.Drawing.Point(147, 21);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(184, 25);
            this.txtNameOnCard.TabIndex = 0;
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardType.Location = new System.Drawing.Point(23, 55);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(70, 17);
            this.lblCardType.TabIndex = 5;
            this.lblCardType.Text = "Card Type";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(23, 81);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(89, 17);
            this.lblCardNumber.TabIndex = 4;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiry.Location = new System.Drawing.Point(23, 109);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(46, 17);
            this.lblExpiry.TabIndex = 3;
            this.lblExpiry.Text = "Expiry";
            // 
            // lblIssuingBank
            // 
            this.lblIssuingBank.AutoSize = true;
            this.lblIssuingBank.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuingBank.Location = new System.Drawing.Point(23, 144);
            this.lblIssuingBank.Name = "lblIssuingBank";
            this.lblIssuingBank.Size = new System.Drawing.Size(85, 17);
            this.lblIssuingBank.TabIndex = 2;
            this.lblIssuingBank.Text = "Isuuing Bank";
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnCard.Location = new System.Drawing.Point(23, 29);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(95, 17);
            this.lblNameOnCard.TabIndex = 0;
            this.lblNameOnCard.Text = "Name on Card";
            // 
            // grpProductSelection
            // 
            this.grpProductSelection.Controls.Add(this.txtUnitPriceScarfs);
            this.grpProductSelection.Controls.Add(this.txtQtityScarfs);
            this.grpProductSelection.Controls.Add(this.txtQtityJackets);
            this.grpProductSelection.Controls.Add(this.txtUnitPriceJackets);
            this.grpProductSelection.Controls.Add(this.txtQtitySweaters);
            this.grpProductSelection.Controls.Add(this.txtQtityBeanies);
            this.grpProductSelection.Controls.Add(this.txtUnitPriceSweaters);
            this.grpProductSelection.Controls.Add(this.txtUnitPriceBeanies);
            this.grpProductSelection.Controls.Add(this.txtUnitPriceGloves);
            this.grpProductSelection.Controls.Add(this.txtQtityGloves);
            this.grpProductSelection.Controls.Add(this.txtQtityShoes);
            this.grpProductSelection.Controls.Add(this.txtUnitPriceShoes);
            this.grpProductSelection.Controls.Add(this.chkGloves);
            this.grpProductSelection.Controls.Add(this.chkBeanies);
            this.grpProductSelection.Controls.Add(this.chkJackets);
            this.grpProductSelection.Controls.Add(this.chkSweaters);
            this.grpProductSelection.Controls.Add(this.chkScarfs);
            this.grpProductSelection.Controls.Add(this.chkShoes);
            this.grpProductSelection.Controls.Add(this.lblUnitPrice);
            this.grpProductSelection.Controls.Add(this.lblQuantity);
            this.grpProductSelection.Controls.Add(this.lblProductName);
            this.grpProductSelection.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProductSelection.Location = new System.Drawing.Point(379, 9);
            this.grpProductSelection.Name = "grpProductSelection";
            this.grpProductSelection.Size = new System.Drawing.Size(356, 227);
            this.grpProductSelection.TabIndex = 2;
            this.grpProductSelection.TabStop = false;
            this.grpProductSelection.Text = "Product Selection";
            this.grpProductSelection.TextChanged += new System.EventHandler(this.m_Calculation);
            // 
            // txtUnitPriceScarfs
            // 
            this.txtUnitPriceScarfs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPriceScarfs.Location = new System.Drawing.Point(214, 176);
            this.txtUnitPriceScarfs.Name = "txtUnitPriceScarfs";
            this.txtUnitPriceScarfs.ReadOnly = true;
            this.txtUnitPriceScarfs.Size = new System.Drawing.Size(50, 25);
            this.txtUnitPriceScarfs.TabIndex = 22;
            this.txtUnitPriceScarfs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtityScarfs
            // 
            this.txtQtityScarfs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtityScarfs.Location = new System.Drawing.Point(285, 176);
            this.txtQtityScarfs.MaxLength = 10;
            this.txtQtityScarfs.Name = "txtQtityScarfs";
            this.txtQtityScarfs.Size = new System.Drawing.Size(51, 25);
            this.txtQtityScarfs.TabIndex = 6;
            this.txtQtityScarfs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtityScarfs.TextChanged += new System.EventHandler(this.m_Calculation);
            this.txtQtityScarfs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtityScarfs_KeyPress);
            // 
            // txtQtityJackets
            // 
            this.txtQtityJackets.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtityJackets.Location = new System.Drawing.Point(285, 71);
            this.txtQtityJackets.MaxLength = 10;
            this.txtQtityJackets.Name = "txtQtityJackets";
            this.txtQtityJackets.Size = new System.Drawing.Size(51, 25);
            this.txtQtityJackets.TabIndex = 2;
            this.txtQtityJackets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtityJackets.TextChanged += new System.EventHandler(this.m_Calculation);
            this.txtQtityJackets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtityJackets_KeyPress);
            // 
            // txtUnitPriceJackets
            // 
            this.txtUnitPriceJackets.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPriceJackets.Location = new System.Drawing.Point(214, 72);
            this.txtUnitPriceJackets.Name = "txtUnitPriceJackets";
            this.txtUnitPriceJackets.ReadOnly = true;
            this.txtUnitPriceJackets.Size = new System.Drawing.Size(50, 25);
            this.txtUnitPriceJackets.TabIndex = 19;
            this.txtUnitPriceJackets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtitySweaters
            // 
            this.txtQtitySweaters.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtitySweaters.Location = new System.Drawing.Point(285, 150);
            this.txtQtitySweaters.MaxLength = 10;
            this.txtQtitySweaters.Name = "txtQtitySweaters";
            this.txtQtitySweaters.Size = new System.Drawing.Size(51, 25);
            this.txtQtitySweaters.TabIndex = 5;
            this.txtQtitySweaters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtitySweaters.TextChanged += new System.EventHandler(this.m_Calculation);
            this.txtQtitySweaters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtitySweaters_KeyPress);
            // 
            // txtQtityBeanies
            // 
            this.txtQtityBeanies.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtityBeanies.Location = new System.Drawing.Point(285, 123);
            this.txtQtityBeanies.MaxLength = 10;
            this.txtQtityBeanies.Name = "txtQtityBeanies";
            this.txtQtityBeanies.Size = new System.Drawing.Size(51, 25);
            this.txtQtityBeanies.TabIndex = 4;
            this.txtQtityBeanies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtityBeanies.TextChanged += new System.EventHandler(this.m_Calculation);
            this.txtQtityBeanies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtityBeanies_KeyPress);
            // 
            // txtUnitPriceSweaters
            // 
            this.txtUnitPriceSweaters.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPriceSweaters.Location = new System.Drawing.Point(214, 150);
            this.txtUnitPriceSweaters.Name = "txtUnitPriceSweaters";
            this.txtUnitPriceSweaters.ReadOnly = true;
            this.txtUnitPriceSweaters.Size = new System.Drawing.Size(50, 25);
            this.txtUnitPriceSweaters.TabIndex = 15;
            this.txtUnitPriceSweaters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitPriceBeanies
            // 
            this.txtUnitPriceBeanies.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPriceBeanies.Location = new System.Drawing.Point(214, 124);
            this.txtUnitPriceBeanies.Name = "txtUnitPriceBeanies";
            this.txtUnitPriceBeanies.ReadOnly = true;
            this.txtUnitPriceBeanies.Size = new System.Drawing.Size(50, 25);
            this.txtUnitPriceBeanies.TabIndex = 14;
            this.txtUnitPriceBeanies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitPriceGloves
            // 
            this.txtUnitPriceGloves.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPriceGloves.Location = new System.Drawing.Point(214, 98);
            this.txtUnitPriceGloves.Name = "txtUnitPriceGloves";
            this.txtUnitPriceGloves.ReadOnly = true;
            this.txtUnitPriceGloves.Size = new System.Drawing.Size(50, 25);
            this.txtUnitPriceGloves.TabIndex = 13;
            this.txtUnitPriceGloves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQtityGloves
            // 
            this.txtQtityGloves.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtityGloves.Location = new System.Drawing.Point(285, 97);
            this.txtQtityGloves.MaxLength = 10;
            this.txtQtityGloves.Name = "txtQtityGloves";
            this.txtQtityGloves.Size = new System.Drawing.Size(51, 25);
            this.txtQtityGloves.TabIndex = 3;
            this.txtQtityGloves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtityGloves.TextChanged += new System.EventHandler(this.m_Calculation);
            this.txtQtityGloves.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtityGloves_KeyPress);
            // 
            // txtQtityShoes
            // 
            this.txtQtityShoes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtityShoes.Location = new System.Drawing.Point(285, 45);
            this.txtQtityShoes.MaxLength = 10;
            this.txtQtityShoes.Name = "txtQtityShoes";
            this.txtQtityShoes.Size = new System.Drawing.Size(51, 25);
            this.txtQtityShoes.TabIndex = 1;
            this.txtQtityShoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtityShoes.TextChanged += new System.EventHandler(this.m_Calculation);
            this.txtQtityShoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtityShoes_KeyPress);
            // 
            // txtUnitPriceShoes
            // 
            this.txtUnitPriceShoes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPriceShoes.Location = new System.Drawing.Point(214, 46);
            this.txtUnitPriceShoes.Name = "txtUnitPriceShoes";
            this.txtUnitPriceShoes.ReadOnly = true;
            this.txtUnitPriceShoes.Size = new System.Drawing.Size(50, 25);
            this.txtUnitPriceShoes.TabIndex = 10;
            this.txtUnitPriceShoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkGloves
            // 
            this.chkGloves.AutoSize = true;
            this.chkGloves.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGloves.Location = new System.Drawing.Point(22, 98);
            this.chkGloves.Name = "chkGloves";
            this.chkGloves.Size = new System.Drawing.Size(67, 21);
            this.chkGloves.TabIndex = 9;
            this.chkGloves.Text = "Gloves";
            this.chkGloves.UseVisualStyleBackColor = true;
            // 
            // chkBeanies
            // 
            this.chkBeanies.AutoSize = true;
            this.chkBeanies.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBeanies.Location = new System.Drawing.Point(22, 124);
            this.chkBeanies.Name = "chkBeanies";
            this.chkBeanies.Size = new System.Drawing.Size(74, 21);
            this.chkBeanies.TabIndex = 8;
            this.chkBeanies.Text = "Beanies";
            this.chkBeanies.UseVisualStyleBackColor = true;
            // 
            // chkJackets
            // 
            this.chkJackets.AutoSize = true;
            this.chkJackets.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJackets.Location = new System.Drawing.Point(22, 72);
            this.chkJackets.Name = "chkJackets";
            this.chkJackets.Size = new System.Drawing.Size(71, 21);
            this.chkJackets.TabIndex = 7;
            this.chkJackets.Text = "Jackets";
            this.chkJackets.UseVisualStyleBackColor = true;
            // 
            // chkSweaters
            // 
            this.chkSweaters.AutoSize = true;
            this.chkSweaters.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSweaters.Location = new System.Drawing.Point(22, 150);
            this.chkSweaters.Name = "chkSweaters";
            this.chkSweaters.Size = new System.Drawing.Size(82, 21);
            this.chkSweaters.TabIndex = 6;
            this.chkSweaters.Text = "Sweaters";
            this.chkSweaters.UseVisualStyleBackColor = true;
            // 
            // chkScarfs
            // 
            this.chkScarfs.AutoSize = true;
            this.chkScarfs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkScarfs.Location = new System.Drawing.Point(22, 176);
            this.chkScarfs.Name = "chkScarfs";
            this.chkScarfs.Size = new System.Drawing.Size(65, 21);
            this.chkScarfs.TabIndex = 5;
            this.chkScarfs.Text = "Scarfs";
            this.chkScarfs.UseVisualStyleBackColor = true;
            // 
            // chkShoes
            // 
            this.chkShoes.AutoSize = true;
            this.chkShoes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShoes.Location = new System.Drawing.Point(22, 48);
            this.chkShoes.Name = "chkShoes";
            this.chkShoes.Size = new System.Drawing.Size(62, 21);
            this.chkShoes.TabIndex = 4;
            this.chkShoes.Text = "Shoes";
            this.chkShoes.UseVisualStyleBackColor = true;
            this.chkShoes.CheckedChanged += new System.EventHandler(this.chkShoes_CheckedChanged);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(211, 16);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(68, 17);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(290, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 17);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(19, 24);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(94, 17);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(429, 271);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(142, 17);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "TOTAL AMOUNT : $";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(568, 268);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(90, 25);
            this.txtTotalAmount.TabIndex = 23;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpPaymentType
            // 
            this.grpPaymentType.Controls.Add(this.rdioCreditCard);
            this.grpPaymentType.Controls.Add(this.rdioBankTransfer);
            this.grpPaymentType.Controls.Add(this.rdioCash);
            this.grpPaymentType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentType.Location = new System.Drawing.Point(379, 318);
            this.grpPaymentType.Name = "grpPaymentType";
            this.grpPaymentType.Size = new System.Drawing.Size(356, 67);
            this.grpPaymentType.TabIndex = 24;
            this.grpPaymentType.TabStop = false;
            this.grpPaymentType.Text = "Payment Type";
            // 
            // rdioCreditCard
            // 
            this.rdioCreditCard.AutoSize = true;
            this.rdioCreditCard.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioCreditCard.Location = new System.Drawing.Point(118, 35);
            this.rdioCreditCard.Name = "rdioCreditCard";
            this.rdioCreditCard.Size = new System.Drawing.Size(95, 21);
            this.rdioCreditCard.TabIndex = 1;
            this.rdioCreditCard.TabStop = true;
            this.rdioCreditCard.Text = "Credit Card";
            this.rdioCreditCard.UseVisualStyleBackColor = true;
            this.rdioCreditCard.CheckedChanged += new System.EventHandler(this.rdioCreditCard_CheckedChanged);
            // 
            // rdioBankTransfer
            // 
            this.rdioBankTransfer.AutoSize = true;
            this.rdioBankTransfer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioBankTransfer.Location = new System.Drawing.Point(214, 35);
            this.rdioBankTransfer.Name = "rdioBankTransfer";
            this.rdioBankTransfer.Size = new System.Drawing.Size(111, 21);
            this.rdioBankTransfer.TabIndex = 2;
            this.rdioBankTransfer.TabStop = true;
            this.rdioBankTransfer.Text = "Bank Transfer";
            this.rdioBankTransfer.UseVisualStyleBackColor = true;
            this.rdioBankTransfer.CheckedChanged += new System.EventHandler(this.rdioBankTransfer_CheckedChanged);
            // 
            // rdioCash
            // 
            this.rdioCash.AutoSize = true;
            this.rdioCash.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdioCash.Location = new System.Drawing.Point(43, 35);
            this.rdioCash.Name = "rdioCash";
            this.rdioCash.Size = new System.Drawing.Size(56, 21);
            this.rdioCash.TabIndex = 0;
            this.rdioCash.TabStop = true;
            this.rdioCash.Text = "Cash";
            this.rdioCash.UseVisualStyleBackColor = true;
            this.rdioCash.CheckedChanged += new System.EventHandler(this.rdioCash_CheckedChanged);
            // 
            // btnShowSummary
            // 
            this.btnShowSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnShowSummary.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSummary.ForeColor = System.Drawing.Color.Blue;
            this.btnShowSummary.Location = new System.Drawing.Point(538, 410);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new System.Drawing.Size(111, 37);
            this.btnShowSummary.TabIndex = 1;
            this.btnShowSummary.Text = "Show Summary";
            this.btnShowSummary.UseVisualStyleBackColor = false;
            this.btnShowSummary.Click += new System.EventHandler(this.btnShowSummary_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(452, 410);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmSalesSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(771, 499);
            this.Controls.Add(this.grpPaymentType);
            this.Controls.Add(this.btnShowSummary);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.grpProductSelection);
            this.Controls.Add(this.grpCreditCardInformation);
            this.Controls.Add(this.grpCustomerDetails);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmSalesSystem";
            this.Text = "Sales System";
            this.Load += new System.EventHandler(this.frmSalesSystem_Load);
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.grpCreditCardInformation.ResumeLayout(false);
            this.grpCreditCardInformation.PerformLayout();
            this.grpProductSelection.ResumeLayout(false);
            this.grpProductSelection.PerformLayout();
            this.grpPaymentType.ResumeLayout(false);
            this.grpPaymentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpCreditCardInformation;
        private System.Windows.Forms.ComboBox cmboIssuingBank;
        private System.Windows.Forms.ComboBox cmboExpiryYear;
        private System.Windows.Forms.ComboBox cmboExpiryMonth;
        private System.Windows.Forms.ComboBox cmboCardType;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.Label lblIssuingBank;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.GroupBox grpProductSelection;
        private System.Windows.Forms.TextBox txtUnitPriceScarfs;
        private System.Windows.Forms.TextBox txtQtityScarfs;
        private System.Windows.Forms.TextBox txtQtityJackets;
        private System.Windows.Forms.TextBox txtUnitPriceJackets;
        private System.Windows.Forms.TextBox txtQtitySweaters;
        private System.Windows.Forms.TextBox txtQtityBeanies;
        private System.Windows.Forms.TextBox txtUnitPriceSweaters;
        private System.Windows.Forms.TextBox txtUnitPriceBeanies;
        private System.Windows.Forms.TextBox txtUnitPriceGloves;
        private System.Windows.Forms.TextBox txtQtityGloves;
        private System.Windows.Forms.TextBox txtQtityShoes;
        private System.Windows.Forms.TextBox txtUnitPriceShoes;
        private System.Windows.Forms.CheckBox chkGloves;
        private System.Windows.Forms.CheckBox chkBeanies;
        private System.Windows.Forms.CheckBox chkJackets;
        private System.Windows.Forms.CheckBox chkSweaters;
        private System.Windows.Forms.CheckBox chkScarfs;
        private System.Windows.Forms.CheckBox chkShoes;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.GroupBox grpPaymentType;
        private System.Windows.Forms.Button btnShowSummary;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.RadioButton rdioCash;
        private System.Windows.Forms.RadioButton rdioCreditCard;
        private System.Windows.Forms.RadioButton rdioBankTransfer;
    }
}

