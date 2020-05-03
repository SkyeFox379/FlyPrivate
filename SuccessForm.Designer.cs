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
            this.SuspendLayout();
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLabel.Location = new System.Drawing.Point(138, 23);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(519, 33);
            this.AvailableLabel.TabIndex = 0;
            this.AvailableLabel.Text = "Flight available on the specified date at";
            // 
            // TimePlaceholderLabel
            // 
            this.TimePlaceholderLabel.AutoSize = true;
            this.TimePlaceholderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePlaceholderLabel.Location = new System.Drawing.Point(261, 79);
            this.TimePlaceholderLabel.Name = "TimePlaceholderLabel";
            this.TimePlaceholderLabel.Size = new System.Drawing.Size(264, 33);
            this.TimePlaceholderLabel.TabIndex = 1;
            this.TimePlaceholderLabel.Text = "<placeholder time>";
            // 
            // ForPriceLabel
            // 
            this.ForPriceLabel.AutoSize = true;
            this.ForPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForPriceLabel.Location = new System.Drawing.Point(187, 147);
            this.ForPriceLabel.Name = "ForPriceLabel";
            this.ForPriceLabel.Size = new System.Drawing.Size(211, 33);
            this.ForPriceLabel.TabIndex = 2;
            this.ForPriceLabel.Text = "For the price of";
            // 
            // PricePlaceholderLabel
            // 
            this.PricePlaceholderLabel.AutoSize = true;
            this.PricePlaceholderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePlaceholderLabel.Location = new System.Drawing.Point(404, 147);
            this.PricePlaceholderLabel.Name = "PricePlaceholderLabel";
            this.PricePlaceholderLabel.Size = new System.Drawing.Size(216, 33);
            this.PricePlaceholderLabel.TabIndex = 3;
            this.PricePlaceholderLabel.Text = "$<placeholder>";
            // 
            // BookBtn
            // 
            this.BookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBtn.Location = new System.Drawing.Point(316, 351);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(157, 70);
            this.BookBtn.TabIndex = 4;
            this.BookBtn.Text = "Book Now";
            this.BookBtn.UseVisualStyleBackColor = true;
            // 
            // SuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label TimePlaceholderLabel;
        private System.Windows.Forms.Label ForPriceLabel;
        private System.Windows.Forms.Label PricePlaceholderLabel;
        private System.Windows.Forms.Button BookBtn;
    }
}