using System;
using System.Windows.Forms;

namespace Assingment_1
{
    public partial class frmSalesSystem : Form
    {
        public frmSalesSystem()
        {
            InitializeComponent();
            
        }

        //Declaring the variables to store inputs from user 
        //To allow decimal numbers, double type has been used 
        int i_QtityShoes;
        int i_QtityJackets;
        int i_QtityGloves;
        int i_QtityBeanies;
        int i_QtitySweaters;
        int i_QtityScarfs;

        //Declaring variables needed for calculation
        double d_ShoesPrice;
        double d_JacketsPrice;
        double d_GlovesPrice;
        double d_BeaniesPrice;
        double d_SweatersPrice;
        double d_ScarfsPrice;
        double d_TotalAmount;

        //Unit Prices
        double[] d_UnitPrice = new double[6];

        private void GetDataFromUser()
        {
            //The format is int.TryParse (Input, out Output)
            //int.TryParse will only accept whole numbers as quantity can't be a fraction
            int.TryParse(txtQtityShoes.Text, out i_QtityShoes);
            int.TryParse(txtQtityJackets.Text, out i_QtityJackets);
            int.TryParse(txtQtityGloves.Text, out i_QtityGloves);
            int.TryParse(txtQtityBeanies.Text, out i_QtityBeanies);
            int.TryParse(txtQtitySweaters.Text, out i_QtitySweaters);
            int.TryParse(txtQtityScarfs.Text, out i_QtityScarfs);
        }

        //Calculate total amount
        private void CalcTotalAmount()
        {
             GetDataFromUser();

            //Shoes
           if (chkShoes.Checked)
            {
                d_ShoesPrice = d_UnitPrice[0] * i_QtityShoes;
            }
            else
            {
                d_ShoesPrice = 0;
            }

           //Jackets
           if (chkJackets.Checked)
            {
                d_JacketsPrice = d_UnitPrice[1] * i_QtityJackets;
            }
            else
            {
                d_JacketsPrice = 0;
            }

            //Beanies
            if (chkBeanies.Checked)
            {
                d_BeaniesPrice = d_UnitPrice[3] * i_QtityBeanies;
            }
            else
            {
                d_BeaniesPrice = 0;
            }

            //Gloves
            if (chkGloves.Checked)
            {
                d_GlovesPrice = d_UnitPrice[2] * i_QtityGloves;
            }
            else
            {
                d_GlovesPrice = 0;
            }

           //Sweaters
            if (chkSweaters.Checked)
            {
                d_SweatersPrice = d_UnitPrice[4] * i_QtitySweaters;
            }
            else
            {
                d_SweatersPrice = 0;
            }

            //Scarfs
            if (chkScarfs.Checked)
            {
                d_ScarfsPrice = d_UnitPrice[5] * i_QtityScarfs;
            }
            else
            {
                d_ScarfsPrice = 0;
            }
            d_TotalAmount = d_ShoesPrice + d_JacketsPrice + d_BeaniesPrice + d_GlovesPrice + d_SweatersPrice + d_ScarfsPrice;
            txtTotalAmount.Text = d_TotalAmount.ToString();
        }

                
        private void ShowError()
        {
            //Customer Details error 
            //First Name error box
            if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter First Name", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtFirstName.TextLength <= 2)
            {
                MessageBox.Show("Please enter correct first name", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Last name error box
            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter Last Name", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtLastName.TextLength <= 2)
            {
                MessageBox.Show("Please enter correct last name", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Street Address error box
            if (txtStreetAddress.TextLength <= 2)
            {
                MessageBox.Show("Please enter correct street address", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Suburb error box
            if (txtSuburb.TextLength <= 2)
            {
                MessageBox.Show("Please enter correct suburb", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //City error box
            if (txtCity.TextLength <= 2)
            {
                MessageBox.Show("Please enter correct city", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Country error box
            if (txtCountry.TextLength <= 2)
            {
                MessageBox.Show("Please enter correct country", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Credit card information error box
            //Card name
            if (txtNameOnCard.Text == "" && rdioCreditCard.Checked)
            {
                MessageBox.Show("Please enter Name on Card", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNameOnCard.TextLength <= 2 && rdioCreditCard.Checked)
            {
                MessageBox.Show("Please enter correct card name", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Card type
            if (cmboCardType.Text == "" && rdioCreditCard.Checked)
            {
                MessageBox.Show("Please enter Card Type", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Card number
            if (txtCardNumber.Text == "" && rdioCreditCard.Checked)
            {
                MessageBox.Show("Please enter Card Number", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCardNumber.TextLength <= 2 && rdioCreditCard.Checked)
            {
                MessageBox.Show("Please enter correct card number", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Expiry Month
            if (cmboExpiryMonth.Text == "" && rdioCreditCard.Checked)
            {
                MessageBox.Show("Please enter Expiry month", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Expiry year
            if (cmboExpiryYear.Text == "" && rdioCreditCard.Checked)
            {
                MessageBox.Show("Please enter expiry year", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Issuing bank
            if (cmboIssuingBank.Text == "" && rdioCreditCard.Checked)
            {
                MessageBox.Show("Please enter Issuing bank", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Product selection error box
            //Items selected
            if (chkShoes.Checked || chkJackets.Checked || chkGloves.Checked || chkBeanies.Checked || chkSweaters.Checked || chkScarfs.Checked)
            { }

            else
            {
                MessageBox.Show("Please select at least one item", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Quantity entered
            if (txtQtityShoes.Text.Length > 0 || txtQtityJackets.Text.Length > 0 || txtQtityGloves.Text.Length > 0 || txtQtityBeanies.Text.Length > 0 || txtQtityScarfs.Text.Length > 0 || txtQtitySweaters.Text.Length > 0)
            { }
            else
            {
                MessageBox.Show("Please enter at least one quantity", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Payment method error box
            if (!(rdioBankTransfer.Checked || rdioCreditCard.Checked || rdioCash.Checked))
            {
                MessageBox.Show("Please select at least one payment method", "Information Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ComboBoxes()
        {
            //Addding items to comboboxes
            //Expiry year
            cmboExpiryYear.Items.Add("");
            DateTime moment = DateTime.Now;
            int i_year = moment.Year;
            for (int i_moment = i_year; i_moment <= i_year + 9; i_moment++)
            {
                cmboExpiryYear.Items.Add(i_moment);
            }

            //Expiry month
            cmboExpiryMonth.Items.Add("");
            cmboExpiryMonth.Items.Add("January");
            cmboExpiryMonth.Items.Add("February");
            cmboExpiryMonth.Items.Add("March");
            cmboExpiryMonth.Items.Add("April");
            cmboExpiryMonth.Items.Add("May");
            cmboExpiryMonth.Items.Add("June");
            cmboExpiryMonth.Items.Add("July");
            cmboExpiryMonth.Items.Add("August");
            cmboExpiryMonth.Items.Add("September");
            cmboExpiryMonth.Items.Add("October");
            cmboExpiryMonth.Items.Add("November");
            cmboExpiryMonth.Items.Add("December");

            //Issuing bank
            cmboIssuingBank.Items.Add("");
            cmboIssuingBank.Items.Add("New Zealand");
            cmboIssuingBank.Items.Add("Overseas");

            //Card Type
            cmboCardType.Items.Add("");
            cmboCardType.Items.Add("Visa");
            cmboCardType.Items.Add("MasterCard");
            cmboCardType.Items.Add("Diners Club");
            cmboCardType.Items.Add("American Express");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //This is to clear the form 
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtStreetAddress.Text = string.Empty;
            txtSuburb.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtNameOnCard.Text = string.Empty;
            cmboCardType.Text = string.Empty;
            txtCardNumber.Text = string.Empty;
            cmboExpiryMonth.Text = string.Empty;
            cmboExpiryYear.Text = string.Empty;
            cmboIssuingBank.Text = string.Empty;
            txtQtityShoes.Text = string.Empty;
            txtQtityJackets.Text = string.Empty;
            txtQtityGloves.Text = string.Empty;
            txtQtityBeanies.Text = string.Empty;
            txtQtitySweaters.Text = string.Empty;
            txtQtityScarfs.Text = string.Empty;
            chkShoes.Checked = false;
            chkJackets.Checked = false;
            chkGloves.Checked = false;
            chkBeanies.Checked = false;
            chkSweaters.Checked = false;
            chkScarfs.Checked = false;
            rdioBankTransfer.Checked = false;
            rdioCash.Checked = false;
            rdioCreditCard.Checked = false;
            rdioCash.Enabled = true;
            rdioCreditCard.Enabled = true;
            txtTotalAmount.Text = string.Empty;
        }


        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            //This is to show error messages
            ShowError();

            //This is to display the summary of the data user has entered 
            Summary();
            
        }

        //Disabling credit card information when payment method is not credit card
        private void rdioCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            grpCreditCardInformation.Enabled = true;
        }

        private void rdioCash_CheckedChanged(object sender, EventArgs e)
        {
            grpCreditCardInformation.Enabled = false;
        }

        private void rdioBankTransfer_CheckedChanged(object sender, EventArgs e)
        {
            grpCreditCardInformation.Enabled = false;
        }


        //Setting Quantity Textboces to only accept numeric values as input 
        private void txtQtityShoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }

            else
                e.Handled = e.KeyChar != (char)Keys.Back;
            { }
            
        }

        private void txtQtityJackets_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }

            else
                e.Handled = e.KeyChar != (char)Keys.Back;
            { }
        }

        private void txtQtityGloves_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }

            else
                e.Handled = e.KeyChar != (char)Keys.Back;
            { }
        }

        private void txtQtityBeanies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }

            else
                e.Handled = e.KeyChar != (char)Keys.Back;
            { }
        }

        private void txtQtitySweaters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }

            else
                e.Handled = e.KeyChar != (char)Keys.Back;
            { }
        }

        private void txtQtityScarfs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            { }

            else
                e.Handled = e.KeyChar != (char)Keys.Back;
            { }
        }


        private void chkShoes_CheckedChanged(object sender, EventArgs e)
        {
            txtQtityShoes.Enabled = true;
        }

        private void frmSalesSystem_Load(object sender, EventArgs e)
        {
            //This is to show items in combo boxes
            ComboBoxes();
               
            //Assigning unit prices to items 
            d_UnitPrice[0] = 69.99; //Shoes
            d_UnitPrice[1] = 99.99; //Jackets
            d_UnitPrice[2] = 9.99; //Gloves
            d_UnitPrice[3] = 19.99; //Beanies
            d_UnitPrice[4] = 89.99; //Sweaters
            d_UnitPrice[5] = 29.99; //Sacrves

            //Displaying prices in textboxes
            txtUnitPriceShoes.Text = "$" + d_UnitPrice[0].ToString();
            txtUnitPriceJackets.Text = "$" + d_UnitPrice[1].ToString();
            txtUnitPriceGloves.Text = "$" + d_UnitPrice[2].ToString();
            txtUnitPriceBeanies.Text = "$" + d_UnitPrice[3].ToString();
            txtUnitPriceSweaters.Text = "$" + d_UnitPrice[4].ToString();
            txtUnitPriceScarfs.Text = "$" + d_UnitPrice[5].ToString();

            //Disabling credit card information when the program loads
            grpCreditCardInformation.Enabled = false;
        }

        private void m_Calculation(object sender, EventArgs e)
        {
            //Grabs user input to calculate total amount
            GetDataFromUser();

            //Calculates the total amount
            CalcTotalAmount();

            //Displays the total amount 
            txtTotalAmount.Text = d_TotalAmount.ToString();


            if (d_TotalAmount < 50)
            {
                rdioCreditCard.Enabled = false;
            }

            else
            {
                rdioCreditCard.Enabled = true;
            }

            if (d_TotalAmount > 1500)
            {
                rdioCash.Enabled = false;
            }
            else
            {
                rdioCash.Enabled = true;
            }
        }


        private void Summary()
        {
            string s_PaymentMethod = "";
            string s_FullMessage = "";

            //Records customer details entered
            s_FullMessage = "***Customer Details***" +"\n-----------------------------\n" + txtFirstName.Text + " " + txtLastName.Text + "\n" + txtStreetAddress.Text + "," + " " + txtSuburb.Text + "\n" + txtCity.Text + "," + " " + txtCountry.Text + "\n\n" + "***Order details***" + "\n-------------------------\n";

            //Checks if all required fields are entered
            if (txtFirstName.TextLength == 0 || txtLastName.TextLength == 0 || txtStreetAddress.TextLength == 0 || txtSuburb.TextLength == 0 || txtCity.TextLength == 0 || txtCountry.TextLength == 0 || txtNameOnCard.TextLength == 0 && rdioCreditCard.Checked || cmboCardType.Text == "" && rdioCreditCard.Checked ||
            cmboExpiryMonth.Text == "" && rdioCreditCard.Checked || cmboExpiryYear.Text == "" && rdioCreditCard.Checked || cmboIssuingBank.Text == "" && rdioCreditCard.Checked || txtCardNumber.TextLength == 0 && rdioCreditCard.Checked || txtQtityBeanies.TextLength == 0 && chkBeanies.Checked || txtQtityJackets.TextLength == 0 && chkJackets.Checked
             || txtQtityGloves.TextLength == 0 && chkGloves.Checked || txtQtityShoes.TextLength == 0 && chkShoes.Checked || txtQtitySweaters.TextLength == 0 && chkSweaters.Checked || txtQtityScarfs.TextLength == 0 && chkScarfs.Checked || (!(rdioBankTransfer.Checked || rdioCash.Checked || rdioCreditCard.Checked)))
            {
                MessageBox.Show("Please fill in all the details", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (chkShoes.Checked)
                {
                    s_FullMessage = s_FullMessage + "Shoes x" + " " + i_QtityShoes + " = $" + i_QtityShoes * d_ShoesPrice + "\n";
                }

                if (chkJackets.Checked)
                {
                    s_FullMessage = s_FullMessage + "Jackets x" + " " + i_QtityJackets + " = $" + i_QtityJackets * d_JacketsPrice + "\n";
                }

                if (chkGloves.Checked)
                {
                    s_FullMessage = s_FullMessage + "Gloves x" + " " + i_QtityGloves + " = $" + i_QtityGloves * d_GlovesPrice + "\n";
                }

                if (chkSweaters.Checked)
                {
                    s_FullMessage = s_FullMessage + "Sweaters x" + " " + i_QtitySweaters + " = $" + i_QtitySweaters * d_SweatersPrice + "\n";
                }

                if (chkScarfs.Checked)
                {
                    s_FullMessage = s_FullMessage + "Scarfs x" + " " + i_QtityScarfs + " = $" + i_QtityScarfs * d_ScarfsPrice + "\n";
                }

                if (chkBeanies.Checked)
                {
                    s_FullMessage = s_FullMessage + "Beanies x" + " " + i_QtityBeanies + " = $" + i_QtityBeanies * d_BeaniesPrice + "\n";
                }

                if (rdioBankTransfer.Checked)
                {
                    s_PaymentMethod = "Bank Transfer";
                }

                if (rdioCash.Checked)
                {
                    s_PaymentMethod = "Cash";
                }

                if (rdioCreditCard.Checked)
                {
                    s_PaymentMethod = "Credit Card:" + "\n" + "\n" + txtNameOnCard.Text + "\n" + cmboCardType.Text + "\n" + txtCardNumber.Text + "\n" + cmboExpiryMonth.Text + "," + " " + cmboExpiryYear.Text + "\n" + cmboIssuingBank.Text;
                }

                //Prints out payment details upon submission 
                s_FullMessage = s_FullMessage + "\n" + "***Payment Method***" + "\n-----------------------------\n" + s_PaymentMethod + "\n" + "\n" + "\n" + "Total Amount = " + " " + "$" + d_TotalAmount;
                MessageBox.Show(s_FullMessage, "Order summary", MessageBoxButtons.OK);

            }
        }       
    }  
}