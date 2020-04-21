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
            this.Destination = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Destination
            // 
            this.Destination.AutoSize = true;
            this.Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Destination.Location = new System.Drawing.Point(322, 19);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(170, 32);
            this.Destination.TabIndex = 0;
            this.Destination.Text = "Destination";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(103, 91);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(114, 25);
            this.From.TabIndex = 1;
            this.From.Text = "Flying From";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(566, 91);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(93, 25);
            this.To.TabIndex = 2;
            this.To.Text = "Flying To";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.Destination);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Destination;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label To;
    }
}

