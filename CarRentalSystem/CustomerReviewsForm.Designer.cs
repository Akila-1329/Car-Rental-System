namespace CarRentalSystem
{
    partial class CustomerReviewsForm
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
            this.reviewsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reviewsListBox
            // 
            this.reviewsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewsListBox.FormattingEnabled = true;
            this.reviewsListBox.ItemHeight = 20;
            this.reviewsListBox.Location = new System.Drawing.Point(98, 109);
            this.reviewsListBox.Name = "reviewsListBox";
            this.reviewsListBox.Size = new System.Drawing.Size(656, 284);
            this.reviewsListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Reviews";
            // 
            // CustomerReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reviewsListBox);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "CustomerReviewsForm";
            this.Text = "Customer Reviews";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerReviewsForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerReviewsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox reviewsListBox;
        private System.Windows.Forms.Label label1;
    }
}