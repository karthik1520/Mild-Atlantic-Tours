namespace MAT_Assignment1
{
    partial class MATApplicationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MATApplicationForm));
            DriverPortalPanel = new Panel();
            ProceedButton = new Button();
            BusIDTextBox = new TextBox();
            DriverNameTextBox = new TextBox();
            BusIDLabel = new Label();
            DriverNameLabel = new Label();
            MATLOGOPictureBox = new PictureBox();
            DriverDailyPassengerGroupBox = new GroupBox();
            ChildFaresTextBox = new TextBox();
            StudentFaresTextBox = new TextBox();
            FullFaresTextBox = new TextBox();
            ChildFaresLabel = new Label();
            StudentFaresLabel = new Label();
            FullFaresLabel = new Label();
            DriverDailyPassengerDetailsPanel = new Panel();
            DriverPanelExitButton = new Button();
            DriverPanelSummaryButton = new Button();
            DriverPanelClearButton = new Button();
            DriverPanelProcessButton = new Button();
            DriverSummaryGroupBox = new GroupBox();
            DriverSummaryTotalNumberOfDriversTextBox = new TextBox();
            DriverSummaryTotalNumberOfDriversLabel = new Label();
            DriverSummaryChildFareReceiptsPercentageTextBox = new TextBox();
            DriverSummaryStudentFareReceiptsPercentageTextBox = new TextBox();
            DriverSummaryFullFareReceiptsPercentageTextBox = new TextBox();
            DriverSummaryChildFareReceiptsTextBox = new TextBox();
            DriverSummaryStudentFareReceiptsTextBox = new TextBox();
            DriverSummaryFullFareReceiptsTextBox = new TextBox();
            DriverSummaryTotalDriverReceiptsTextBox = new TextBox();
            DriverSummaryTotalNumberofPassengersTextBox = new TextBox();
            DriverSummaryChildFareReceiptsLabel = new Label();
            DriverSummaryStudentFareReceiptsLabel = new Label();
            DriverSummaryFullFareReceiptsLabel = new Label();
            DriverSummaryTotalDriverReceiptsLabel = new Label();
            DriverSummaryTotalNumberOfPassengersLabel = new Label();
            ProcessToolTip = new ToolTip(components);
            ClearToolTip = new ToolTip(components);
            SummaryToolTip = new ToolTip(components);
            ExitToolTip = new ToolTip(components);
            ProceedToolTip = new ToolTip(components);
            DriverPortalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MATLOGOPictureBox).BeginInit();
            DriverDailyPassengerGroupBox.SuspendLayout();
            DriverDailyPassengerDetailsPanel.SuspendLayout();
            DriverSummaryGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DriverPortalPanel
            // 
            DriverPortalPanel.BackColor = SystemColors.ButtonHighlight;
            DriverPortalPanel.BorderStyle = BorderStyle.FixedSingle;
            DriverPortalPanel.Controls.Add(ProceedButton);
            DriverPortalPanel.Controls.Add(BusIDTextBox);
            DriverPortalPanel.Controls.Add(DriverNameTextBox);
            DriverPortalPanel.Controls.Add(BusIDLabel);
            DriverPortalPanel.Controls.Add(DriverNameLabel);
            DriverPortalPanel.Location = new Point(31, 33);
            DriverPortalPanel.Name = "DriverPortalPanel";
            DriverPortalPanel.Size = new Size(671, 107);
            DriverPortalPanel.TabIndex = 2;
            // 
            // ProceedButton
            // 
            ProceedButton.BackColor = SystemColors.ActiveCaption;
            ProceedButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProceedButton.Location = new Point(535, 37);
            ProceedButton.Name = "ProceedButton";
            ProceedButton.Size = new Size(94, 29);
            ProceedButton.TabIndex = 4;
            ProceedButton.Text = "Proceed";
            ProceedButton.UseVisualStyleBackColor = false;
            ProceedButton.Click += ProceedButton_Click;
            // 
            // BusIDTextBox
            // 
            BusIDTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BusIDTextBox.Location = new Point(414, 38);
            BusIDTextBox.Name = "BusIDTextBox";
            BusIDTextBox.Size = new Size(74, 27);
            BusIDTextBox.TabIndex = 1;
            BusIDTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverNameTextBox
            // 
            DriverNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverNameTextBox.Location = new Point(158, 37);
            DriverNameTextBox.Name = "DriverNameTextBox";
            DriverNameTextBox.Size = new Size(125, 27);
            DriverNameTextBox.TabIndex = 0;
            DriverNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // BusIDLabel
            // 
            BusIDLabel.AutoSize = true;
            BusIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BusIDLabel.Location = new Point(313, 40);
            BusIDLabel.Name = "BusIDLabel";
            BusIDLabel.Size = new Size(59, 20);
            BusIDLabel.TabIndex = 2;
            BusIDLabel.Text = "Bus ID:";
            // 
            // DriverNameLabel
            // 
            DriverNameLabel.AutoSize = true;
            DriverNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverNameLabel.Location = new Point(31, 40);
            DriverNameLabel.Name = "DriverNameLabel";
            DriverNameLabel.Size = new Size(102, 20);
            DriverNameLabel.TabIndex = 0;
            DriverNameLabel.Text = "Driver Name:";
            // 
            // MATLOGOPictureBox
            // 
            MATLOGOPictureBox.BackColor = SystemColors.ControlLightLight;
            MATLOGOPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            MATLOGOPictureBox.BorderStyle = BorderStyle.FixedSingle;
            MATLOGOPictureBox.Image = (Image)resources.GetObject("MATLOGOPictureBox.Image");
            MATLOGOPictureBox.InitialImage = (Image)resources.GetObject("MATLOGOPictureBox.InitialImage");
            MATLOGOPictureBox.Location = new Point(249, 155);
            MATLOGOPictureBox.Name = "MATLOGOPictureBox";
            MATLOGOPictureBox.Size = new Size(219, 123);
            MATLOGOPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            MATLOGOPictureBox.TabIndex = 3;
            MATLOGOPictureBox.TabStop = false;
            // 
            // DriverDailyPassengerGroupBox
            // 
            DriverDailyPassengerGroupBox.BackColor = SystemColors.ButtonHighlight;
            DriverDailyPassengerGroupBox.Controls.Add(ChildFaresTextBox);
            DriverDailyPassengerGroupBox.Controls.Add(StudentFaresTextBox);
            DriverDailyPassengerGroupBox.Controls.Add(FullFaresTextBox);
            DriverDailyPassengerGroupBox.Controls.Add(ChildFaresLabel);
            DriverDailyPassengerGroupBox.Controls.Add(StudentFaresLabel);
            DriverDailyPassengerGroupBox.Controls.Add(FullFaresLabel);
            DriverDailyPassengerGroupBox.Location = new Point(90, 302);
            DriverDailyPassengerGroupBox.Name = "DriverDailyPassengerGroupBox";
            DriverDailyPassengerGroupBox.Size = new Size(555, 178);
            DriverDailyPassengerGroupBox.TabIndex = 4;
            DriverDailyPassengerGroupBox.TabStop = false;
            DriverDailyPassengerGroupBox.Text = "Driver Daily Passenger";
            // 
            // ChildFaresTextBox
            // 
            ChildFaresTextBox.BorderStyle = BorderStyle.FixedSingle;
            ChildFaresTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChildFaresTextBox.Location = new Point(343, 138);
            ChildFaresTextBox.Name = "ChildFaresTextBox";
            ChildFaresTextBox.Size = new Size(125, 27);
            ChildFaresTextBox.TabIndex = 2;
            ChildFaresTextBox.TextAlign = HorizontalAlignment.Center;
            ChildFaresTextBox.MouseDown += ChildFaresTextBox_MouseDown;
            // 
            // StudentFaresTextBox
            // 
            StudentFaresTextBox.BorderStyle = BorderStyle.FixedSingle;
            StudentFaresTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StudentFaresTextBox.Location = new Point(343, 86);
            StudentFaresTextBox.Name = "StudentFaresTextBox";
            StudentFaresTextBox.Size = new Size(125, 27);
            StudentFaresTextBox.TabIndex = 1;
            StudentFaresTextBox.TextAlign = HorizontalAlignment.Center;
            StudentFaresTextBox.MouseDown += StudentFaresTextBox_MouseDown;
            // 
            // FullFaresTextBox
            // 
            FullFaresTextBox.BorderStyle = BorderStyle.FixedSingle;
            FullFaresTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FullFaresTextBox.Location = new Point(343, 39);
            FullFaresTextBox.Name = "FullFaresTextBox";
            FullFaresTextBox.Size = new Size(125, 27);
            FullFaresTextBox.TabIndex = 0;
            FullFaresTextBox.TextAlign = HorizontalAlignment.Center;
            FullFaresTextBox.MouseDown += FullFaresTextBox_MouseDown;
            // 
            // ChildFaresLabel
            // 
            ChildFaresLabel.AutoSize = true;
            ChildFaresLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChildFaresLabel.Location = new Point(112, 138);
            ChildFaresLabel.Name = "ChildFaresLabel";
            ChildFaresLabel.Size = new Size(85, 20);
            ChildFaresLabel.TabIndex = 2;
            ChildFaresLabel.Text = "Child Fares";
            // 
            // StudentFaresLabel
            // 
            StudentFaresLabel.AutoSize = true;
            StudentFaresLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StudentFaresLabel.Location = new Point(112, 86);
            StudentFaresLabel.Name = "StudentFaresLabel";
            StudentFaresLabel.Size = new Size(105, 20);
            StudentFaresLabel.TabIndex = 1;
            StudentFaresLabel.Text = "Student Fares";
            // 
            // FullFaresLabel
            // 
            FullFaresLabel.AutoSize = true;
            FullFaresLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FullFaresLabel.Location = new Point(112, 42);
            FullFaresLabel.Name = "FullFaresLabel";
            FullFaresLabel.Size = new Size(75, 20);
            FullFaresLabel.TabIndex = 0;
            FullFaresLabel.Text = "Full Fares";
            // 
            // DriverDailyPassengerDetailsPanel
            // 
            DriverDailyPassengerDetailsPanel.BackColor = SystemColors.ControlLightLight;
            DriverDailyPassengerDetailsPanel.Controls.Add(DriverPanelExitButton);
            DriverDailyPassengerDetailsPanel.Controls.Add(DriverPanelSummaryButton);
            DriverDailyPassengerDetailsPanel.Controls.Add(DriverPanelClearButton);
            DriverDailyPassengerDetailsPanel.Controls.Add(DriverPanelProcessButton);
            DriverDailyPassengerDetailsPanel.Location = new Point(90, 502);
            DriverDailyPassengerDetailsPanel.Name = "DriverDailyPassengerDetailsPanel";
            DriverDailyPassengerDetailsPanel.Size = new Size(555, 70);
            DriverDailyPassengerDetailsPanel.TabIndex = 6;
            // 
            // DriverPanelExitButton
            // 
            DriverPanelExitButton.BackColor = SystemColors.ActiveCaption;
            DriverPanelExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverPanelExitButton.Location = new Point(432, 20);
            DriverPanelExitButton.Name = "DriverPanelExitButton";
            DriverPanelExitButton.Size = new Size(94, 29);
            DriverPanelExitButton.TabIndex = 3;
            DriverPanelExitButton.Text = "&Exit";
            DriverPanelExitButton.UseVisualStyleBackColor = false;
            DriverPanelExitButton.Click += DriverPanelExitButton_Click;
            // 
            // DriverPanelSummaryButton
            // 
            DriverPanelSummaryButton.BackColor = SystemColors.ActiveCaption;
            DriverPanelSummaryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverPanelSummaryButton.Location = new Point(296, 20);
            DriverPanelSummaryButton.Name = "DriverPanelSummaryButton";
            DriverPanelSummaryButton.Size = new Size(94, 29);
            DriverPanelSummaryButton.TabIndex = 2;
            DriverPanelSummaryButton.Text = "&Summary";
            DriverPanelSummaryButton.UseVisualStyleBackColor = false;
            DriverPanelSummaryButton.Click += DriverPanelSummaryButton_Click;
            // 
            // DriverPanelClearButton
            // 
            DriverPanelClearButton.BackColor = SystemColors.ActiveCaption;
            DriverPanelClearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverPanelClearButton.Location = new Point(159, 20);
            DriverPanelClearButton.Name = "DriverPanelClearButton";
            DriverPanelClearButton.Size = new Size(94, 29);
            DriverPanelClearButton.TabIndex = 1;
            DriverPanelClearButton.Text = "&Clear";
            DriverPanelClearButton.UseVisualStyleBackColor = false;
            DriverPanelClearButton.Click += DriverPanelClearButton_Click;
            // 
            // DriverPanelProcessButton
            // 
            DriverPanelProcessButton.BackColor = SystemColors.ActiveCaption;
            DriverPanelProcessButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverPanelProcessButton.Location = new Point(26, 20);
            DriverPanelProcessButton.Name = "DriverPanelProcessButton";
            DriverPanelProcessButton.Size = new Size(94, 29);
            DriverPanelProcessButton.TabIndex = 0;
            DriverPanelProcessButton.Text = "&Process";
            DriverPanelProcessButton.UseVisualStyleBackColor = false;
            DriverPanelProcessButton.Click += DriverPanelProcessButton_Click;
            // 
            // DriverSummaryGroupBox
            // 
            DriverSummaryGroupBox.BackColor = SystemColors.ButtonHighlight;
            DriverSummaryGroupBox.Controls.Add(DriverSummaryTotalNumberOfDriversTextBox);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryTotalNumberOfDriversLabel);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryChildFareReceiptsPercentageTextBox);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryStudentFareReceiptsPercentageTextBox);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryFullFareReceiptsPercentageTextBox);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryChildFareReceiptsTextBox);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryStudentFareReceiptsTextBox);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryFullFareReceiptsTextBox);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryTotalDriverReceiptsTextBox);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryTotalNumberofPassengersTextBox);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryChildFareReceiptsLabel);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryStudentFareReceiptsLabel);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryFullFareReceiptsLabel);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryTotalDriverReceiptsLabel);
            DriverSummaryGroupBox.Controls.Add(DriverSummaryTotalNumberOfPassengersLabel);
            DriverSummaryGroupBox.Location = new Point(90, 613);
            DriverSummaryGroupBox.Name = "DriverSummaryGroupBox";
            DriverSummaryGroupBox.Size = new Size(552, 275);
            DriverSummaryGroupBox.TabIndex = 8;
            DriverSummaryGroupBox.TabStop = false;
            DriverSummaryGroupBox.Text = "Driver Summary";
            // 
            // DriverSummaryTotalNumberOfDriversTextBox
            // 
            DriverSummaryTotalNumberOfDriversTextBox.BorderStyle = BorderStyle.FixedSingle;
            DriverSummaryTotalNumberOfDriversTextBox.Location = new Point(337, 46);
            DriverSummaryTotalNumberOfDriversTextBox.Name = "DriverSummaryTotalNumberOfDriversTextBox";
            DriverSummaryTotalNumberOfDriversTextBox.Size = new Size(170, 27);
            DriverSummaryTotalNumberOfDriversTextBox.TabIndex = 14;
            DriverSummaryTotalNumberOfDriversTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverSummaryTotalNumberOfDriversLabel
            // 
            DriverSummaryTotalNumberOfDriversLabel.AutoSize = true;
            DriverSummaryTotalNumberOfDriversLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverSummaryTotalNumberOfDriversLabel.Location = new Point(68, 49);
            DriverSummaryTotalNumberOfDriversLabel.Name = "DriverSummaryTotalNumberOfDriversLabel";
            DriverSummaryTotalNumberOfDriversLabel.Size = new Size(179, 20);
            DriverSummaryTotalNumberOfDriversLabel.TabIndex = 13;
            DriverSummaryTotalNumberOfDriversLabel.Text = "Total Number of Drivers";
            // 
            // DriverSummaryChildFareReceiptsPercentageTextBox
            // 
            DriverSummaryChildFareReceiptsPercentageTextBox.BorderStyle = BorderStyle.FixedSingle;
            DriverSummaryChildFareReceiptsPercentageTextBox.Location = new Point(423, 228);
            DriverSummaryChildFareReceiptsPercentageTextBox.Name = "DriverSummaryChildFareReceiptsPercentageTextBox";
            DriverSummaryChildFareReceiptsPercentageTextBox.Size = new Size(84, 27);
            DriverSummaryChildFareReceiptsPercentageTextBox.TabIndex = 12;
            DriverSummaryChildFareReceiptsPercentageTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverSummaryStudentFareReceiptsPercentageTextBox
            // 
            DriverSummaryStudentFareReceiptsPercentageTextBox.BorderStyle = BorderStyle.FixedSingle;
            DriverSummaryStudentFareReceiptsPercentageTextBox.Location = new Point(423, 190);
            DriverSummaryStudentFareReceiptsPercentageTextBox.Name = "DriverSummaryStudentFareReceiptsPercentageTextBox";
            DriverSummaryStudentFareReceiptsPercentageTextBox.Size = new Size(84, 27);
            DriverSummaryStudentFareReceiptsPercentageTextBox.TabIndex = 11;
            DriverSummaryStudentFareReceiptsPercentageTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverSummaryFullFareReceiptsPercentageTextBox
            // 
            DriverSummaryFullFareReceiptsPercentageTextBox.BorderStyle = BorderStyle.FixedSingle;
            DriverSummaryFullFareReceiptsPercentageTextBox.Location = new Point(423, 152);
            DriverSummaryFullFareReceiptsPercentageTextBox.Name = "DriverSummaryFullFareReceiptsPercentageTextBox";
            DriverSummaryFullFareReceiptsPercentageTextBox.Size = new Size(84, 27);
            DriverSummaryFullFareReceiptsPercentageTextBox.TabIndex = 10;
            DriverSummaryFullFareReceiptsPercentageTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverSummaryChildFareReceiptsTextBox
            // 
            DriverSummaryChildFareReceiptsTextBox.BorderStyle = BorderStyle.FixedSingle;
            DriverSummaryChildFareReceiptsTextBox.Location = new Point(336, 228);
            DriverSummaryChildFareReceiptsTextBox.Name = "DriverSummaryChildFareReceiptsTextBox";
            DriverSummaryChildFareReceiptsTextBox.Size = new Size(81, 27);
            DriverSummaryChildFareReceiptsTextBox.TabIndex = 9;
            DriverSummaryChildFareReceiptsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverSummaryStudentFareReceiptsTextBox
            // 
            DriverSummaryStudentFareReceiptsTextBox.BorderStyle = BorderStyle.FixedSingle;
            DriverSummaryStudentFareReceiptsTextBox.Location = new Point(336, 190);
            DriverSummaryStudentFareReceiptsTextBox.Name = "DriverSummaryStudentFareReceiptsTextBox";
            DriverSummaryStudentFareReceiptsTextBox.Size = new Size(81, 27);
            DriverSummaryStudentFareReceiptsTextBox.TabIndex = 8;
            DriverSummaryStudentFareReceiptsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverSummaryFullFareReceiptsTextBox
            // 
            DriverSummaryFullFareReceiptsTextBox.BorderStyle = BorderStyle.FixedSingle;
            DriverSummaryFullFareReceiptsTextBox.Location = new Point(336, 152);
            DriverSummaryFullFareReceiptsTextBox.Name = "DriverSummaryFullFareReceiptsTextBox";
            DriverSummaryFullFareReceiptsTextBox.Size = new Size(81, 27);
            DriverSummaryFullFareReceiptsTextBox.TabIndex = 7;
            DriverSummaryFullFareReceiptsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverSummaryTotalDriverReceiptsTextBox
            // 
            DriverSummaryTotalDriverReceiptsTextBox.BorderStyle = BorderStyle.FixedSingle;
            DriverSummaryTotalDriverReceiptsTextBox.Location = new Point(336, 119);
            DriverSummaryTotalDriverReceiptsTextBox.Name = "DriverSummaryTotalDriverReceiptsTextBox";
            DriverSummaryTotalDriverReceiptsTextBox.Size = new Size(171, 27);
            DriverSummaryTotalDriverReceiptsTextBox.TabIndex = 6;
            DriverSummaryTotalDriverReceiptsTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverSummaryTotalNumberofPassengersTextBox
            // 
            DriverSummaryTotalNumberofPassengersTextBox.BorderStyle = BorderStyle.FixedSingle;
            DriverSummaryTotalNumberofPassengersTextBox.Location = new Point(336, 82);
            DriverSummaryTotalNumberofPassengersTextBox.Name = "DriverSummaryTotalNumberofPassengersTextBox";
            DriverSummaryTotalNumberofPassengersTextBox.Size = new Size(171, 27);
            DriverSummaryTotalNumberofPassengersTextBox.TabIndex = 5;
            DriverSummaryTotalNumberofPassengersTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DriverSummaryChildFareReceiptsLabel
            // 
            DriverSummaryChildFareReceiptsLabel.AutoSize = true;
            DriverSummaryChildFareReceiptsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverSummaryChildFareReceiptsLabel.Location = new Point(106, 228);
            DriverSummaryChildFareReceiptsLabel.Name = "DriverSummaryChildFareReceiptsLabel";
            DriverSummaryChildFareReceiptsLabel.Size = new Size(141, 20);
            DriverSummaryChildFareReceiptsLabel.TabIndex = 4;
            DriverSummaryChildFareReceiptsLabel.Text = "Child Fare Receipts";
            // 
            // DriverSummaryStudentFareReceiptsLabel
            // 
            DriverSummaryStudentFareReceiptsLabel.AutoSize = true;
            DriverSummaryStudentFareReceiptsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverSummaryStudentFareReceiptsLabel.Location = new Point(86, 190);
            DriverSummaryStudentFareReceiptsLabel.Name = "DriverSummaryStudentFareReceiptsLabel";
            DriverSummaryStudentFareReceiptsLabel.Size = new Size(161, 20);
            DriverSummaryStudentFareReceiptsLabel.TabIndex = 3;
            DriverSummaryStudentFareReceiptsLabel.Text = "Student Fare Receipts";
            // 
            // DriverSummaryFullFareReceiptsLabel
            // 
            DriverSummaryFullFareReceiptsLabel.AutoSize = true;
            DriverSummaryFullFareReceiptsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverSummaryFullFareReceiptsLabel.Location = new Point(119, 155);
            DriverSummaryFullFareReceiptsLabel.Name = "DriverSummaryFullFareReceiptsLabel";
            DriverSummaryFullFareReceiptsLabel.Size = new Size(131, 20);
            DriverSummaryFullFareReceiptsLabel.TabIndex = 2;
            DriverSummaryFullFareReceiptsLabel.Text = "Full Fare Receipts";
            // 
            // DriverSummaryTotalDriverReceiptsLabel
            // 
            DriverSummaryTotalDriverReceiptsLabel.AutoSize = true;
            DriverSummaryTotalDriverReceiptsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverSummaryTotalDriverReceiptsLabel.Location = new Point(96, 122);
            DriverSummaryTotalDriverReceiptsLabel.Name = "DriverSummaryTotalDriverReceiptsLabel";
            DriverSummaryTotalDriverReceiptsLabel.Size = new Size(154, 20);
            DriverSummaryTotalDriverReceiptsLabel.TabIndex = 1;
            DriverSummaryTotalDriverReceiptsLabel.Text = "Total Driver Receipts";
            // 
            // DriverSummaryTotalNumberOfPassengersLabel
            // 
            DriverSummaryTotalNumberOfPassengersLabel.AutoSize = true;
            DriverSummaryTotalNumberOfPassengersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DriverSummaryTotalNumberOfPassengersLabel.Location = new Point(40, 85);
            DriverSummaryTotalNumberOfPassengersLabel.Name = "DriverSummaryTotalNumberOfPassengersLabel";
            DriverSummaryTotalNumberOfPassengersLabel.Size = new Size(207, 20);
            DriverSummaryTotalNumberOfPassengersLabel.TabIndex = 0;
            DriverSummaryTotalNumberOfPassengersLabel.Text = "Total Number of Passengers";
            // 
            // ProcessToolTip
            // 
            ProcessToolTip.IsBalloon = true;
            ProcessToolTip.ToolTipIcon = ToolTipIcon.Info;
            ProcessToolTip.ToolTipTitle = "Info";
            // 
            // ClearToolTip
            // 
            ClearToolTip.IsBalloon = true;
            ClearToolTip.ToolTipIcon = ToolTipIcon.Info;
            ClearToolTip.ToolTipTitle = "Info";
            // 
            // SummaryToolTip
            // 
            SummaryToolTip.IsBalloon = true;
            SummaryToolTip.ToolTipIcon = ToolTipIcon.Info;
            SummaryToolTip.ToolTipTitle = "Info";
            // 
            // ExitToolTip
            // 
            ExitToolTip.IsBalloon = true;
            ExitToolTip.ToolTipIcon = ToolTipIcon.Info;
            ExitToolTip.ToolTipTitle = "Info";
            // 
            // ProceedToolTip
            // 
            ProceedToolTip.AutoPopDelay = 0;
            ProceedToolTip.InitialDelay = 500;
            ProceedToolTip.IsBalloon = true;
            ProceedToolTip.ReshowDelay = 100;
            ProceedToolTip.ToolTipIcon = ToolTipIcon.Info;
            ProceedToolTip.ToolTipTitle = "Info";
            // 
            // MATApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 924);
            Controls.Add(DriverSummaryGroupBox);
            Controls.Add(DriverDailyPassengerDetailsPanel);
            Controls.Add(DriverDailyPassengerGroupBox);
            Controls.Add(MATLOGOPictureBox);
            Controls.Add(DriverPortalPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MATApplicationForm";
            Text = "Welcome to MAT Driver Portal";
            DriverPortalPanel.ResumeLayout(false);
            DriverPortalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MATLOGOPictureBox).EndInit();
            DriverDailyPassengerGroupBox.ResumeLayout(false);
            DriverDailyPassengerGroupBox.PerformLayout();
            DriverDailyPassengerDetailsPanel.ResumeLayout(false);
            DriverSummaryGroupBox.ResumeLayout(false);
            DriverSummaryGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel DriverPortalPanel;
        private Button ProceedButton;
        private TextBox BusIDTextBox;
        private TextBox DriverNameTextBox;
        private Label BusIDLabel;
        private Label DriverNameLabel;
        private PictureBox MATLOGOPictureBox;
        private GroupBox DriverDailyPassengerGroupBox;
        private TextBox ChildFaresTextBox;
        private TextBox StudentFaresTextBox;
        private TextBox FullFaresTextBox;
        private Label ChildFaresLabel;
        private Label StudentFaresLabel;
        private Label FullFaresLabel;
        private Panel DriverDailyPassengerDetailsPanel;
        private Button DriverPanelExitButton;
        private Button DriverPanelSummaryButton;
        private Button DriverPanelClearButton;
        private Button DriverPanelProcessButton;
        private GroupBox DriverSummaryGroupBox;
        private TextBox DriverSummaryFullFareReceiptsPercentageTextBox;
        private TextBox DriverSummaryChildFareReceiptsTextBox;
        private TextBox DriverSummaryStudentFareReceiptsTextBox;
        private TextBox DriverSummaryFullFareReceiptsTextBox;
        private TextBox DriverSummaryTotalDriverReceiptsTextBox;
        private TextBox DriverSummaryTotalNumberofPassengersTextBox;
        private Label DriverSummaryChildFareReceiptsLabel;
        private Label DriverSummaryStudentFareReceiptsLabel;
        private Label DriverSummaryFullFareReceiptsLabel;
        private Label DriverSummaryTotalDriverReceiptsLabel;
        private Label DriverSummaryTotalNumberOfPassengersLabel;
        private TextBox DriverSummaryChildFareReceiptsPercentageTextBox;
        private TextBox DriverSummaryStudentFareReceiptsPercentageTextBox;
        private TextBox DriverSummaryTotalNumberOfDriversTextBox;
        private Label DriverSummaryTotalNumberOfDriversLabel;
        private ToolTip ProcessToolTip;
        private ToolTip ClearToolTip;
        private ToolTip SummaryToolTip;
        private ToolTip ExitToolTip;
        private ToolTip ProceedToolTip;
    }
}