namespace FlyPrivate
{
    partial class SuccessForm
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
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.TimePlaceholderLabel = new System.Windows.Forms.Label();
            this.ForPriceLabel = new System.Windows.Forms.Label();
            this.PricePlaceholderLabel = new System.Windows.Forms.Label();
            this.BookBtn = new System.Windows.Forms.Button();
            this.PlaceHolderDateLabel = new System.Windows.Forms.Label();
            this.ExtBtn = new System.Windows.Forms.Button();
            this.GoBackToApplicationBtn = new System.Windows.Forms.Button();
            this.WithPilotLabel = new System.Windows.Forms.Label();
            this.PlaceHolderPilot = new System.Windows.Forms.Label();
            this.aircraftInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLabel.Location = new System.Drawing.Point(12, 22);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(263, 38);
            this.AvailableLabel.TabIndex = 0;
            this.AvailableLabel.Text = "Flight Available!";
            // 
            // TimePlaceholderLabel
            // 
            this.TimePlaceholderLabel.AutoSize = true;
            this.TimePlaceholderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePlaceholderLabel.Location = new System.Drawing.Point(309, 82);
            this.TimePlaceholderLabel.Name = "TimePlaceholderLabel";
            this.TimePlaceholderLabel.Size = new System.Drawing.Size(257, 32);
            this.TimePlaceholderLabel.TabIndex = 1;
            this.TimePlaceholderLabel.Text = "<placeholder time>";
            this.TimePlaceholderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForPriceLabel
            // 
            this.ForPriceLabel.AutoSize = true;
            this.ForPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForPriceLabel.Location = new System.Drawing.Point(12, 183);
            this.ForPriceLabel.Name = "ForPriceLabel";
            this.ForPriceLabel.Size = new System.Drawing.Size(252, 38);
            this.ForPriceLabel.TabIndex = 2;
            this.ForPriceLabel.Text = "For the price of";
            // 
            // PricePlaceholderLabel
            // 
            this.PricePlaceholderLabel.AutoSize = true;
            this.PricePlaceholderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePlaceholderLabel.Location = new System.Drawing.Point(309, 189);
            this.PricePlaceholderLabel.Name = "PricePlaceholderLabel";
            this.PricePlaceholderLabel.Size = new System.Drawing.Size(212, 32);
            this.PricePlaceholderLabel.TabIndex = 3;
            this.PricePlaceholderLabel.Text = "$<placeholder>";
            this.PricePlaceholderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookBtn
            // 
            this.BookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBtn.Location = new System.Drawing.Point(241, 519);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(180, 93);
            this.BookBtn.TabIndex = 4;
            this.BookBtn.Text = "Book Now";
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // PlaceHolderDateLabel
            // 
            this.PlaceHolderDateLabel.AutoSize = true;
            this.PlaceHolderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceHolderDateLabel.Location = new System.Drawing.Point(309, 28);
            this.PlaceHolderDateLabel.Name = "PlaceHolderDateLabel";
            this.PlaceHolderDateLabel.Size = new System.Drawing.Size(259, 32);
            this.PlaceHolderDateLabel.TabIndex = 5;
            this.PlaceHolderDateLabel.Text = "<placeholder date>";
            this.PlaceHolderDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExtBtn
            // 
            this.ExtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtBtn.Location = new System.Drawing.Point(470, 519);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(154, 93);
            this.ExtBtn.TabIndex = 6;
            this.ExtBtn.Text = "Exit";
            this.ExtBtn.UseVisualStyleBackColor = true;
            this.ExtBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // GoBackToApplicationBtn
            // 
            this.GoBackToApplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackToApplicationBtn.Location = new System.Drawing.Point(38, 519);
            this.GoBackToApplicationBtn.Name = "GoBackToApplicationBtn";
            this.GoBackToApplicationBtn.Size = new System.Drawing.Size(154, 93);
            this.GoBackToApplicationBtn.TabIndex = 7;
            this.GoBackToApplicationBtn.Text = "Re-Enter Info";
            this.GoBackToApplicationBtn.UseVisualStyleBackColor = true;
            this.GoBackToApplicationBtn.Click += new System.EventHandler(this.GoBackToApplicationBtn_Click);
            // 
            // WithPilotLabel
            // 
            this.WithPilotLabel.AutoSize = true;
            this.WithPilotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithPilotLabel.Location = new System.Drawing.Point(12, 312);
            this.WithPilotLabel.Name = "WithPilotLabel";
            this.WithPilotLabel.Size = new System.Drawing.Size(164, 38);
            this.WithPilotLabel.TabIndex = 8;
            this.WithPilotLabel.Text = "With Pilot";
            // 
            // PlaceHolderPilot
            // 
            this.PlaceHolderPilot.AutoSize = true;
            this.PlaceHolderPilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceHolderPilot.Location = new System.Drawing.Point(309, 318);
            this.PlaceHolderPilot.Name = "PlaceHolderPilot";
            this.PlaceHolderPilot.Size = new System.Drawing.Size(196, 32);
            this.PlaceHolderPilot.TabIndex = 9;
            this.PlaceHolderPilot.Text = "<placeholder>";
            this.PlaceHolderPilot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aircraftInfoLabel
            // 
            this.aircraftInfoLabel.AutoSize = true;
            this.aircraftInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aircraftInfoLabel.Location = new System.Drawing.Point(14, 426);
            this.aircraftInfoLabel.Name = "aircraftInfoLabel";
            this.aircraftInfoLabel.Size = new System.Drawing.Size(250, 32);
            this.aircraftInfoLabel.TabIndex = 10;
            this.aircraftInfoLabel.Text = "<placeholder Info>";
            this.aircraftInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 663);
            this.Controls.Add(this.aircraftInfoLabel);
            this.Controls.Add(this.PlaceHolderPilot);
            this.Controls.Add(this.WithPilotLabel);
            this.Controls.Add(this.GoBackToApplicationBtn);
            this.Controls.Add(this.ExtBtn);
            this.Controls.Add(this.PlaceHolderDateLabel);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.PricePlaceholderLabel);
            this.Controls.Add(this.ForPriceLabel);
            this.Controls.Add(this.TimePlaceholderLabel);
            this.Controls.Add(this.AvailableLabel);
            this.Name = "SuccessForm";
            this.Text = "Result Found";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.Label ForPriceLabel;
        private System.Windows.Forms.Button BookBtn;
        public System.Windows.Forms.Label TimePlaceholderLabel;
        public System.Windows.Forms.Label PricePlaceholderLabel;
        public System.Windows.Forms.Label PlaceHolderDateLabel;
        private System.Windows.Forms.Button ExtBtn;
        public System.Windows.Forms.Button GoBackToApplicationBtn;
        private System.Windows.Forms.Label WithPilotLabel;
        public System.Windows.Forms.Label PlaceHolderPilot;
        public System.Windows.Forms.Label aircraftInfoLabel;
    }
}