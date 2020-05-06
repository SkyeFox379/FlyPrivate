namespace FlyPrivate
{
    partial class Form1
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
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.StartLocCB = new System.Windows.Forms.ComboBox();
            this.DestinationCB = new System.Windows.Forms.ComboBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.SelectMonthCB = new System.Windows.Forms.ComboBox();
            this.SelectDayCB = new System.Windows.Forms.ComboBox();
            this.SelectYearCB = new System.Windows.Forms.ComboBox();
            this.TimeRNGLabel = new System.Windows.Forms.Label();
            this.HourCB = new System.Windows.Forms.ComboBox();
            this.ColonLabel = new System.Windows.Forms.Label();
            this.MinuteCB = new System.Windows.Forms.ComboBox();
            this.DashLabel = new System.Windows.Forms.Label();
            this.amORpmCB = new System.Windows.Forms.ComboBox();
            this.amORpm2CB = new System.Windows.Forms.ComboBox();
            this.Minute2CB = new System.Windows.Forms.ComboBox();
            this.Colon2Label = new System.Windows.Forms.Label();
            this.Hour2CB = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.NumPeopleLabel = new System.Windows.Forms.Label();
            this.NumOfFlyersCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(226, 26);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(170, 32);
            this.DestinationLabel.TabIndex = 0;
            this.DestinationLabel.Text = "Destination";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(91, 86);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(114, 25);
            this.FromLabel.TabIndex = 1;
            this.FromLabel.Text = "Flying From";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(410, 86);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(93, 25);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "Flying To";
            // 
            // StartLocCB
            // 
            this.StartLocCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartLocCB.FormattingEnabled = true;
            this.StartLocCB.Items.AddRange(new object[] {
            "Sioux Falls, SD",
            "Aberdeen, SD",
            "Rapid City, SD",
            "Madison, SD"});
            this.StartLocCB.Location = new System.Drawing.Point(40, 125);
            this.StartLocCB.Name = "StartLocCB";
            this.StartLocCB.Size = new System.Drawing.Size(212, 24);
            this.StartLocCB.TabIndex = 3;
            // 
            // DestinationCB
            // 
            this.DestinationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationCB.FormattingEnabled = true;
            this.DestinationCB.Items.AddRange(new object[] {
            "Sioux Falls, SD",
            "Aberdeen, SD",
            "Rapid City, SD",
            "Madison, SD"});
            this.DestinationCB.Location = new System.Drawing.Point(351, 125);
            this.DestinationCB.Name = "DestinationCB";
            this.DestinationCB.Size = new System.Drawing.Size(212, 24);
            this.DestinationCB.TabIndex = 4;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(259, 186);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(79, 32);
            this.DateLabel.TabIndex = 5;
            this.DateLabel.Text = "Date";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.Location = new System.Drawing.Point(89, 241);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(67, 25);
            this.MonthLabel.TabIndex = 6;
            this.MonthLabel.Text = "Month";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.Location = new System.Drawing.Point(277, 241);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(47, 25);
            this.DayLabel.TabIndex = 7;
            this.DayLabel.Text = "Day";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(457, 241);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(53, 25);
            this.YearLabel.TabIndex = 8;
            this.YearLabel.Text = "Year";
            // 
            // SelectMonthCB
            // 
            this.SelectMonthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectMonthCB.FormattingEnabled = true;
            this.SelectMonthCB.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "June",
            "July",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.SelectMonthCB.Location = new System.Drawing.Point(53, 281);
            this.SelectMonthCB.Name = "SelectMonthCB";
            this.SelectMonthCB.Size = new System.Drawing.Size(152, 24);
            this.SelectMonthCB.TabIndex = 9;
            // 
            // SelectDayCB
            // 
            this.SelectDayCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectDayCB.FormattingEnabled = true;
            this.SelectDayCB.Items.AddRange(new object[] {
            "how do i made the month affect num of days here",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.SelectDayCB.Location = new System.Drawing.Point(245, 281);
            this.SelectDayCB.Name = "SelectDayCB";
            this.SelectDayCB.Size = new System.Drawing.Size(121, 24);
            this.SelectDayCB.TabIndex = 10;
            // 
            // SelectYearCB
            // 
            this.SelectYearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectYearCB.FormattingEnabled = true;
            this.SelectYearCB.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.SelectYearCB.Location = new System.Drawing.Point(415, 281);
            this.SelectYearCB.Name = "SelectYearCB";
            this.SelectYearCB.Size = new System.Drawing.Size(148, 24);
            this.SelectYearCB.TabIndex = 11;
            // 
            // TimeRNGLabel
            // 
            this.TimeRNGLabel.AutoSize = true;
            this.TimeRNGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRNGLabel.Location = new System.Drawing.Point(152, 385);
            this.TimeRNGLabel.Name = "TimeRNGLabel";
            this.TimeRNGLabel.Size = new System.Drawing.Size(295, 32);
            this.TimeRNGLabel.TabIndex = 12;
            this.TimeRNGLabel.Text = "Leaving Time Range";
            // 
            // HourCB
            // 
            this.HourCB.FormattingEnabled = true;
            this.HourCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.HourCB.Location = new System.Drawing.Point(27, 437);
            this.HourCB.Name = "HourCB";
            this.HourCB.Size = new System.Drawing.Size(77, 24);
            this.HourCB.TabIndex = 13;
            // 
            // ColonLabel
            // 
            this.ColonLabel.AutoSize = true;
            this.ColonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColonLabel.Location = new System.Drawing.Point(111, 434);
            this.ColonLabel.Name = "ColonLabel";
            this.ColonLabel.Size = new System.Drawing.Size(19, 29);
            this.ColonLabel.TabIndex = 14;
            this.ColonLabel.Text = ":";
            // 
            // MinuteCB
            // 
            this.MinuteCB.FormattingEnabled = true;
            this.MinuteCB.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinuteCB.Location = new System.Drawing.Point(134, 438);
            this.MinuteCB.Name = "MinuteCB";
            this.MinuteCB.Size = new System.Drawing.Size(72, 24);
            this.MinuteCB.TabIndex = 15;
            // 
            // DashLabel
            // 
            this.DashLabel.AutoSize = true;
            this.DashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashLabel.Location = new System.Drawing.Point(292, 437);
            this.DashLabel.Name = "DashLabel";
            this.DashLabel.Size = new System.Drawing.Size(21, 29);
            this.DashLabel.TabIndex = 16;
            this.DashLabel.Text = "-";
            // 
            // amORpmCB
            // 
            this.amORpmCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amORpmCB.FormattingEnabled = true;
            this.amORpmCB.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.amORpmCB.Location = new System.Drawing.Point(218, 438);
            this.amORpmCB.Name = "amORpmCB";
            this.amORpmCB.Size = new System.Drawing.Size(68, 24);
            this.amORpmCB.TabIndex = 17;
            // 
            // amORpm2CB
            // 
            this.amORpm2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amORpm2CB.FormattingEnabled = true;
            this.amORpm2CB.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.amORpm2CB.Location = new System.Drawing.Point(510, 439);
            this.amORpm2CB.Name = "amORpm2CB";
            this.amORpm2CB.Size = new System.Drawing.Size(68, 24);
            this.amORpm2CB.TabIndex = 22;
            // 
            // Minute2CB
            // 
            this.Minute2CB.FormattingEnabled = true;
            this.Minute2CB.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.Minute2CB.Location = new System.Drawing.Point(426, 439);
            this.Minute2CB.Name = "Minute2CB";
            this.Minute2CB.Size = new System.Drawing.Size(72, 24);
            this.Minute2CB.TabIndex = 20;
            // 
            // Colon2Label
            // 
            this.Colon2Label.AutoSize = true;
            this.Colon2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colon2Label.Location = new System.Drawing.Point(403, 435);
            this.Colon2Label.Name = "Colon2Label";
            this.Colon2Label.Size = new System.Drawing.Size(19, 29);
            this.Colon2Label.TabIndex = 19;
            this.Colon2Label.Text = ":";
            // 
            // Hour2CB
            // 
            this.Hour2CB.FormattingEnabled = true;
            this.Hour2CB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Hour2CB.Location = new System.Drawing.Point(319, 438);
            this.Hour2CB.Name = "Hour2CB";
            this.Hour2CB.Size = new System.Drawing.Size(77, 24);
            this.Hour2CB.TabIndex = 18;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(232, 688);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(143, 69);
            this.SubmitBtn.TabIndex = 23;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // NumPeopleLabel
            // 
            this.NumPeopleLabel.AutoSize = true;
            this.NumPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPeopleLabel.Location = new System.Drawing.Point(55, 507);
            this.NumPeopleLabel.Name = "NumPeopleLabel";
            this.NumPeopleLabel.Size = new System.Drawing.Size(488, 32);
            this.NumPeopleLabel.TabIndex = 24;
            this.NumPeopleLabel.Text = "Number Of Flyers (Including Yourself)";
            // 
            // NumOfFlyersCB
            // 
            this.NumOfFlyersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumOfFlyersCB.FormattingEnabled = true;
            this.NumOfFlyersCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.NumOfFlyersCB.Location = new System.Drawing.Point(245, 576);
            this.NumOfFlyersCB.Name = "NumOfFlyersCB";
            this.NumOfFlyersCB.Size = new System.Drawing.Size(121, 24);
            this.NumOfFlyersCB.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 783);
            this.Controls.Add(this.NumOfFlyersCB);
            this.Controls.Add(this.NumPeopleLabel);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.amORpm2CB);
            this.Controls.Add(this.Minute2CB);
            this.Controls.Add(this.Colon2Label);
            this.Controls.Add(this.Hour2CB);
            this.Controls.Add(this.amORpmCB);
            this.Controls.Add(this.DashLabel);
            this.Controls.Add(this.MinuteCB);
            this.Controls.Add(this.ColonLabel);
            this.Controls.Add(this.HourCB);
            this.Controls.Add(this.TimeRNGLabel);
            this.Controls.Add(this.SelectYearCB);
            this.Controls.Add(this.SelectDayCB);
            this.Controls.Add(this.SelectMonthCB);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DestinationCB);
            this.Controls.Add(this.StartLocCB);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.DestinationLabel);
            this.Name = "Form1";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ComboBox SelectMonthCB;
        private System.Windows.Forms.ComboBox SelectDayCB;
        private System.Windows.Forms.ComboBox SelectYearCB;
        private System.Windows.Forms.Label TimeRNGLabel;
        private System.Windows.Forms.ComboBox HourCB;
        private System.Windows.Forms.Label ColonLabel;
        private System.Windows.Forms.ComboBox MinuteCB;
        private System.Windows.Forms.Label DashLabel;
        private System.Windows.Forms.ComboBox amORpmCB;
        private System.Windows.Forms.ComboBox amORpm2CB;
        private System.Windows.Forms.ComboBox Minute2CB;
        private System.Windows.Forms.Label Colon2Label;
        private System.Windows.Forms.ComboBox Hour2CB;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label NumPeopleLabel;
        public System.Windows.Forms.ComboBox StartLocCB;
        public System.Windows.Forms.ComboBox DestinationCB;
        public System.Windows.Forms.ComboBox NumOfFlyersCB;
    }
}