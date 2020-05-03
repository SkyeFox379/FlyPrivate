namespace FlyPrivate
{
    partial class NoFlightsForm
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
            this.NoFlightsLabel = new System.Windows.Forms.Label();
            this.NoFlightsLabel2 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoFlightsLabel
            // 
            this.NoFlightsLabel.AutoSize = true;
            this.NoFlightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoFlightsLabel.Location = new System.Drawing.Point(146, 35);
            this.NoFlightsLabel.Name = "NoFlightsLabel";
            this.NoFlightsLabel.Size = new System.Drawing.Size(483, 32);
            this.NoFlightsLabel.TabIndex = 0;
            this.NoFlightsLabel.Text = "There are no flights available for your";
            // 
            // NoFlightsLabel2
            // 
            this.NoFlightsLabel2.AutoSize = true;
            this.NoFlightsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoFlightsLabel2.Location = new System.Drawing.Point(239, 109);
            this.NoFlightsLabel2.Name = "NoFlightsLabel2";
            this.NoFlightsLabel2.Size = new System.Drawing.Size(308, 32);
            this.NoFlightsLabel2.TabIndex = 1;
            this.NoFlightsLabel2.Text = "date and time specified";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(245, 345);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(125, 75);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear Info";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(429, 345);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(125, 75);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Edit Info";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // NoFlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.NoFlightsLabel2);
            this.Controls.Add(this.NoFlightsLabel);
            this.Name = "NoFlightsForm";
            this.Text = "No Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoFlightsLabel;
        private System.Windows.Forms.Label NoFlightsLabel2;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button EditBtn;
    }
}