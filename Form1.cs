/* Student Name: Karthik Mahadevan Ramesh Kumar
 * Student ID: 23101941
 * Date:28/09/2023
 * Assignment: 1
 * Assignment: Create an application for Mild Atlantic Tours Bus
 */

/* Mild Altantic Tours Bus
 * This application is designed to calculate the Fares for the usage of bus by different drivers
   and to calculate the summary of profit for the company
 */

using System.Drawing.Text;

namespace MAT_Assignment1
{
    public partial class MATApplicationForm : Form
    {
        // CONSTANT VARIABLES   
        const decimal FULLFAREPRICE = 9.50m;
        const decimal STUDENTFARE = 6.75m;
        const decimal CHILDFARE = 4.75m;
        // field variables/global variables
        // Declaring Fare and percentage variables as global variables - Used in summary and process buttons
        // field variables/global variables
        private int TotalDriverCount;
        private decimal FullFarePercentage, ChildFarePercentage, StudentFarePercentage;
        private int CompanySummaryTotalNoOfPassengers;
        private decimal CompanySummaryDriverReceiptsTotal;
        private decimal CompanySummaryReceiptsFullFare;
        private decimal CompanySummaryReceiptsChildFare;
        private decimal CompanySummaryReceiptsStudentFare;

        
         /* Inititalizing the initital state of the form
         * Setting the Text for the Tool Tips
         */
        public MATApplicationForm()
        {
            InitializeComponent();

            //On form load making the logo and the driver portal panel visible while hiding the remaining contents
            DriverPortalPanel.Visible = true;
            DriverDailyPassengerGroupBox.Visible = false;
            DriverSummaryGroupBox.Visible = false;
            DriverDailyPassengerDetailsPanel.Visible = false;
            MATLOGOPictureBox.Visible = true;
            DriverPanelSummaryButton.Enabled = false;

            // Setting Tool tip text
            ProceedToolTip.SetToolTip(ProceedButton, "Click to proceed to Data Entry");
            ProcessToolTip.SetToolTip(DriverPanelProcessButton, "Click to process the Data Entry");
            ClearToolTip.SetToolTip(DriverPanelClearButton, "Click to clear the current Data entry");
            SummaryToolTip.SetToolTip(DriverPanelSummaryButton, "Click to view the Company Summary");
            ExitToolTip.SetToolTip(DriverPanelExitButton, "Click to exit the Application");

        }

        /* The Mouse down event will select all the values inside the text box.
        * onclick of mouse inside the textbox will select all the values inside the textbox
        * same is followed for all the three fares textbox
        */
        private void FullFaresTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            FullFaresTextBox.SelectAll();
        }
        private void StudentFaresTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            StudentFaresTextBox.SelectAll();
        }
        private void ChildFaresTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ChildFaresTextBox.SelectAll();
        }

        /* Actions performed on proceed button click
           Incrementing the proceed button click by 1 each time the proceed is clicked. 
           Setting the focus to fullfarestextbox on click of proceed button.
           Setting the default value for each fare text box
        */
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            FullFaresTextBox.Text = "0";
            ChildFaresTextBox.Text = "0";
            StudentFaresTextBox.Text = "0";
            MATApplicationForm.ActiveForm.Text = "Data Entry for Driver:" + DriverNameTextBox.Text + " Bus ID:" + BusIDTextBox.Text;
            DriverPortalPanel.Visible = false;
            DriverDailyPassengerGroupBox.Visible = true;
            DriverDailyPassengerDetailsPanel.Visible = true;
            MATLOGOPictureBox.Location = new Point(261, 788);
            DriverDailyPassengerGroupBox.Location = new Point(90, 33);
            MATLOGOPictureBox.Visible = true;
            DriverDailyPassengerDetailsPanel.Location = new Point(90, 232);
            DriverDailyPassengerGroupBox.Enabled = true;
            FullFaresTextBox.Focus();
            TotalDriverCount++;
        }

        /* Actions performed on Driver Display Panel process button click
           Including exception Handling for FullFaresTextBox, ChildFaresTextBox and StudentFaresTextBox
           Performing Calculations for fares and its percentage
           to check for divide by 0 exception and to throw the error to user and help recover
           Try block checks and the catch block throws the error to the user
           The "C" formatting is used to display the currency
        */
        private void DriverPanelProcessButton_Click(object sender, EventArgs e)
        {
            DriverSummaryGroupBox.Visible = true;
            MATLOGOPictureBox.Location = new Point(261, 788);
            MATLOGOPictureBox.Visible = true;
            MATApplicationForm.ActiveForm.Text = "Data Entry for Driver:" + DriverNameTextBox.Text + " Bus ID:" + BusIDTextBox.Text;
            DriverSummaryGroupBox.Location = new Point(90, 354);
            DriverSummaryTotalNumberOfDriversLabel.Visible = false;
            DriverSummaryTotalNumberOfDriversTextBox.Visible = false;

            int FullFares, StudentFares, ChildFares;
            try
            {
                ChildFares = int.Parse(ChildFaresTextBox.Text);
                try
                {
                    StudentFares = int.Parse(StudentFaresTextBox.Text);
                    try
                    {
                        FullFares = int.Parse(FullFaresTextBox.Text);
                        try  
                        {

                            MATApplicationForm.ActiveForm.Text = "Driver Summary:" + DriverNameTextBox.Text + " Bus ID:" + BusIDTextBox.Text;
                            int TotalPassengers = FullFares + StudentFares + ChildFares;

                            decimal FullFareReceipts = FullFares * FULLFAREPRICE;
                            decimal StudentFareReceipts = StudentFares * STUDENTFARE;
                            decimal ChildFareReceipts = ChildFares * CHILDFARE;
                            decimal TotalDriverReceipts = FullFareReceipts + StudentFareReceipts + ChildFareReceipts;

                            decimal FullFarePercentage = ((FullFareReceipts / TotalDriverReceipts));
                            decimal StudentFarePercentage = ((StudentFareReceipts / TotalDriverReceipts));
                            decimal ChildFarePercentage = ((ChildFareReceipts / TotalDriverReceipts));

                            DriverSummaryTotalNumberofPassengersTextBox.Text = TotalPassengers.ToString();
                            DriverSummaryFullFareReceiptsTextBox.Text = FullFareReceipts.ToString("C");
                            DriverSummaryStudentFareReceiptsTextBox.Text = StudentFareReceipts.ToString("C");
                            DriverSummaryChildFareReceiptsTextBox.Text = ChildFareReceipts.ToString("C");
                            DriverSummaryTotalDriverReceiptsTextBox.Text = TotalDriverReceipts.ToString("C");
                            DriverSummaryFullFareReceiptsPercentageTextBox.Text = FullFarePercentage.ToString("p0");
                            DriverSummaryStudentFareReceiptsPercentageTextBox.Text = StudentFarePercentage.ToString("p0");
                            DriverSummaryChildFareReceiptsPercentageTextBox.Text = ChildFarePercentage.ToString("p0");


                            CompanySummaryTotalNoOfPassengers += TotalPassengers;
                            CompanySummaryDriverReceiptsTotal += TotalDriverReceipts;
                            CompanySummaryReceiptsFullFare += FullFareReceipts;
                            CompanySummaryReceiptsChildFare += ChildFareReceipts;
                            CompanySummaryReceiptsStudentFare += StudentFareReceipts;
                            FullFarePercentage = ((CompanySummaryReceiptsFullFare / CompanySummaryDriverReceiptsTotal));
                            StudentFarePercentage = ((CompanySummaryReceiptsStudentFare / CompanySummaryDriverReceiptsTotal));
                            ChildFarePercentage = ((CompanySummaryReceiptsChildFare / CompanySummaryDriverReceiptsTotal));

                            DriverPanelClearButton.Enabled = true;
                            DriverPanelSummaryButton.Enabled = true;

                            DriverDailyPassengerGroupBox.Enabled = false;
                        }
                        catch
                        {
                            DriverSummaryGroupBox.Visible = false;
                            MessageBox.Show("The form contains all 0 values. Kindly make sure to enter atleast one positive numerical value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            FullFaresTextBox.Focus();
                            FullFaresTextBox.SelectAll();
                            DriverPanelSummaryButton.Enabled = false;
                        }
                    }
                    catch
                    {
                        DriverSummaryGroupBox.Visible = false;
                        MessageBox.Show("Please make sure that the value entered is a numerical value for Full Fare", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FullFaresTextBox.Focus();
                        FullFaresTextBox.SelectAll();
                        DriverPanelSummaryButton.Enabled = false;

                    }
                }
                catch
                {
                    DriverSummaryGroupBox.Visible = false;
                    MessageBox.Show("Please make sure that the value entered is a numerical value for Student Fare", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StudentFaresTextBox.Focus();
                    StudentFaresTextBox.SelectAll();
                    DriverPanelSummaryButton.Enabled = false;
                }
            }
            catch
            {
                DriverSummaryGroupBox.Visible = false;
                MessageBox.Show("Please make sure that the value entered is a numerical value for Child Fare", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChildFaresTextBox.Focus();
                ChildFaresTextBox.SelectAll();
                DriverPanelSummaryButton.Enabled = false;
            }
        }

        /*Actions performed on Driver Display Panel Summary button click
          Displays the results of Calculation to find the Company summary who used different bus of the company
        */
        private void DriverPanelSummaryButton_Click(object sender, EventArgs e)
        {

            DriverSummaryTotalNumberOfDriversTextBox.Text = TotalDriverCount.ToString();
            DriverSummaryTotalNumberofPassengersTextBox.Text = CompanySummaryTotalNoOfPassengers.ToString();
            DriverSummaryTotalDriverReceiptsTextBox.Text = CompanySummaryDriverReceiptsTotal.ToString("C");
            DriverSummaryFullFareReceiptsTextBox.Text = CompanySummaryReceiptsFullFare.ToString("C");
            DriverSummaryChildFareReceiptsTextBox.Text = CompanySummaryReceiptsChildFare.ToString("C");
            DriverSummaryStudentFareReceiptsTextBox.Text = CompanySummaryReceiptsStudentFare.ToString("C");
            DriverSummaryFullFareReceiptsPercentageTextBox.Text = FullFarePercentage.ToString("p0");
            DriverSummaryStudentFareReceiptsPercentageTextBox.Text = StudentFarePercentage.ToString("p0");
            DriverSummaryChildFareReceiptsPercentageTextBox.Text = ChildFarePercentage.ToString("p0");
            DriverPanelProcessButton.Enabled = false;
            MATLOGOPictureBox.Location = new Point(261, 788);
            MATLOGOPictureBox.Visible = true;
            DriverDailyPassengerGroupBox.Visible = false;
            DriverDailyPassengerDetailsPanel.Location = new Point(90, 232);
            DriverDailyPassengerDetailsPanel.Visible = true;
            DriverSummaryGroupBox.Location = new Point(90, 354);
            MATApplicationForm.ActiveForm.Text = "MAT Summary Data";
            DriverSummaryTotalDriverReceiptsLabel.Text = "Total Company Receipts";
            DriverSummaryGroupBox.Text = "Company Summary";
            DriverSummaryTotalNumberOfDriversTextBox.Visible = true;
            DriverSummaryTotalNumberOfDriversLabel.Visible = true;
            DriverPanelSummaryButton.Enabled = false;
        }

        /* Actions performed on Driver Display Panel Clear button click
           Clears the screen for that particular driver and displays the initial page where the new driver can enter his details
        */
        private void DriverPanelClearButton_Click(object sender, EventArgs e)
        {
            MATApplicationForm.ActiveForm.Text = "Welcome to MAT Driver Portal";
            DriverPanelProcessButton.Enabled = false;
            DriverSummaryGroupBox.Visible = false;
            DriverDailyPassengerDetailsPanel.Visible = false;
            DriverDailyPassengerGroupBox.Visible = false;
            DriverNameTextBox.Text = "";
            BusIDTextBox.Text = "";
            DriverPortalPanel.Visible = true;
            MATLOGOPictureBox.Location = new Point(249, 155);
            DriverPanelProcessButton.Enabled = true;
            DriverPanelSummaryButton.Enabled = false;
            DriverPanelClearButton.Enabled = false;
        }
        /* Actions performed on Driver Display Panel Exit button click
           Exits the application
         */
        private void DriverPanelExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}