namespace CarRentalSystem
{
    partial class ProcessReturnForm
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
            this.components = new System.ComponentModel.Container();
            this.calculatedPriceShowLabel = new System.Windows.Forms.Label();
            this.calculatedPricelabel = new System.Windows.Forms.Label();
            this.initialOdometerReading = new System.Windows.Forms.Label();
            this.checkReservationButton = new System.Windows.Forms.Button();
            this.estimatedPriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returnConfirmLabel = new System.Windows.Forms.Label();
            this.CalculatePriceButton = new System.Windows.Forms.Button();
            this.currentOdometerReadingLabel = new System.Windows.Forms.Label();
            this.returnConfirmationLabel = new System.Windows.Forms.Label();
            this.returnReservationIDTextBox = new System.Windows.Forms.TextBox();
            this.reservationIDlabel = new System.Windows.Forms.Label();
            this.confirmReturnButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnOdometerTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.returnLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculatedPriceShowLabel
            // 
            this.calculatedPriceShowLabel.AutoSize = true;
            this.calculatedPriceShowLabel.Location = new System.Drawing.Point(203, 222);
            this.calculatedPriceShowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculatedPriceShowLabel.Name = "calculatedPriceShowLabel";
            this.calculatedPriceShowLabel.Size = new System.Drawing.Size(14, 16);
            this.calculatedPriceShowLabel.TabIndex = 31;
            this.calculatedPriceShowLabel.Text = "0";
            this.calculatedPriceShowLabel.Visible = false;
            // 
            // calculatedPricelabel
            // 
            this.calculatedPricelabel.AutoSize = true;
            this.calculatedPricelabel.Location = new System.Drawing.Point(59, 222);
            this.calculatedPricelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calculatedPricelabel.Name = "calculatedPricelabel";
            this.calculatedPricelabel.Size = new System.Drawing.Size(103, 16);
            this.calculatedPricelabel.TabIndex = 30;
            this.calculatedPricelabel.Text = "calculated Price";
            this.calculatedPricelabel.Visible = false;
            // 
            // initialOdometerReading
            // 
            this.initialOdometerReading.AutoSize = true;
            this.initialOdometerReading.Location = new System.Drawing.Point(229, 152);
            this.initialOdometerReading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.initialOdometerReading.Name = "initialOdometerReading";
            this.initialOdometerReading.Size = new System.Drawing.Size(0, 16);
            this.initialOdometerReading.TabIndex = 29;
            // 
            // checkReservationButton
            // 
            this.checkReservationButton.Location = new System.Drawing.Point(366, 91);
            this.checkReservationButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkReservationButton.Name = "checkReservationButton";
            this.checkReservationButton.Size = new System.Drawing.Size(168, 35);
            this.checkReservationButton.TabIndex = 28;
            this.checkReservationButton.Text = "Check Reservation";
            this.checkReservationButton.UseVisualStyleBackColor = true;
            this.checkReservationButton.Click += new System.EventHandler(this.checkReservationButton_Click);
            // 
            // estimatedPriceLabel
            // 
            this.estimatedPriceLabel.AutoSize = true;
            this.estimatedPriceLabel.Location = new System.Drawing.Point(203, 123);
            this.estimatedPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.estimatedPriceLabel.Name = "estimatedPriceLabel";
            this.estimatedPriceLabel.Size = new System.Drawing.Size(0, 16);
            this.estimatedPriceLabel.TabIndex = 27;
            this.estimatedPriceLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Estimated Price";
            this.label3.Visible = false;
            // 
            // returnConfirmLabel
            // 
            this.returnConfirmLabel.AutoSize = true;
            this.returnConfirmLabel.Location = new System.Drawing.Point(52, 283);
            this.returnConfirmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.returnConfirmLabel.Name = "returnConfirmLabel";
            this.returnConfirmLabel.Size = new System.Drawing.Size(0, 16);
            this.returnConfirmLabel.TabIndex = 25;
            this.returnConfirmLabel.Visible = false;
            // 
            // CalculatePriceButton
            // 
            this.CalculatePriceButton.Location = new System.Drawing.Point(366, 175);
            this.CalculatePriceButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalculatePriceButton.Name = "CalculatePriceButton";
            this.CalculatePriceButton.Size = new System.Drawing.Size(168, 38);
            this.CalculatePriceButton.TabIndex = 24;
            this.CalculatePriceButton.Text = "Calculate Price";
            this.CalculatePriceButton.UseVisualStyleBackColor = true;
            this.CalculatePriceButton.Visible = false;
            this.CalculatePriceButton.Click += new System.EventHandler(this.CalculatePriceButton_Click);
            // 
            // currentOdometerReadingLabel
            // 
            this.currentOdometerReadingLabel.AutoSize = true;
            this.currentOdometerReadingLabel.Location = new System.Drawing.Point(55, 152);
            this.currentOdometerReadingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentOdometerReadingLabel.Name = "currentOdometerReadingLabel";
            this.currentOdometerReadingLabel.Size = new System.Drawing.Size(158, 16);
            this.currentOdometerReadingLabel.TabIndex = 23;
            this.currentOdometerReadingLabel.Text = "Initial Odometer Reading ";
            this.currentOdometerReadingLabel.Visible = false;
            // 
            // returnConfirmationLabel
            // 
            this.returnConfirmationLabel.AutoSize = true;
            this.returnConfirmationLabel.Location = new System.Drawing.Point(59, 256);
            this.returnConfirmationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.returnConfirmationLabel.Name = "returnConfirmationLabel";
            this.returnConfirmationLabel.Size = new System.Drawing.Size(0, 16);
            this.returnConfirmationLabel.TabIndex = 22;
            // 
            // returnReservationIDTextBox
            // 
            this.returnReservationIDTextBox.Location = new System.Drawing.Point(203, 91);
            this.returnReservationIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.returnReservationIDTextBox.Name = "returnReservationIDTextBox";
            this.returnReservationIDTextBox.Size = new System.Drawing.Size(143, 22);
            this.returnReservationIDTextBox.TabIndex = 21;
            // 
            // reservationIDlabel
            // 
            this.reservationIDlabel.AutoSize = true;
            this.reservationIDlabel.Location = new System.Drawing.Point(55, 94);
            this.reservationIDlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reservationIDlabel.Name = "reservationIDlabel";
            this.reservationIDlabel.Size = new System.Drawing.Size(96, 16);
            this.reservationIDlabel.TabIndex = 20;
            this.reservationIDlabel.Text = "Reservation ID";
            // 
            // confirmReturnButton
            // 
            this.confirmReturnButton.Location = new System.Drawing.Point(56, 256);
            this.confirmReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmReturnButton.Name = "confirmReturnButton";
            this.confirmReturnButton.Size = new System.Drawing.Size(193, 40);
            this.confirmReturnButton.TabIndex = 19;
            this.confirmReturnButton.Text = "Confirm Return";
            this.confirmReturnButton.UseVisualStyleBackColor = true;
            this.confirmReturnButton.Visible = false;
            this.confirmReturnButton.Click += new System.EventHandler(this.confirmReturnButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Car Return Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Odometer Reading";
            this.label1.Visible = false;
            // 
            // returnOdometerTextBox
            // 
            this.returnOdometerTextBox.Location = new System.Drawing.Point(203, 187);
            this.returnOdometerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.returnOdometerTextBox.Name = "returnOdometerTextBox";
            this.returnOdometerTextBox.Size = new System.Drawing.Size(143, 22);
            this.returnOdometerTextBox.TabIndex = 16;
            this.returnOdometerTextBox.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.returnLabel.Location = new System.Drawing.Point(55, 328);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(139, 16);
            this.returnLabel.TabIndex = 32;
            this.returnLabel.Text = "Return Successful!!";
            this.returnLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(21, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(516, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "* You should be logged in as a MANAGER to process pickup";
            // 
            // ProcessReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 394);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.calculatedPriceShowLabel);
            this.Controls.Add(this.calculatedPricelabel);
            this.Controls.Add(this.initialOdometerReading);
            this.Controls.Add(this.checkReservationButton);
            this.Controls.Add(this.estimatedPriceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returnConfirmLabel);
            this.Controls.Add(this.CalculatePriceButton);
            this.Controls.Add(this.currentOdometerReadingLabel);
            this.Controls.Add(this.returnConfirmationLabel);
            this.Controls.Add(this.returnReservationIDTextBox);
            this.Controls.Add(this.reservationIDlabel);
            this.Controls.Add(this.confirmReturnButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnOdometerTextBox);
            this.Name = "ProcessReturnForm";
            this.Text = "ProcessReturnForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessReturnForm_FormClosing);
            this.Load += new System.EventHandler(this.ProcessReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label calculatedPriceShowLabel;
        private System.Windows.Forms.Label calculatedPricelabel;
        private System.Windows.Forms.Label initialOdometerReading;
        private System.Windows.Forms.Button checkReservationButton;
        private System.Windows.Forms.Label estimatedPriceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label returnConfirmLabel;
        private System.Windows.Forms.Button CalculatePriceButton;
        private System.Windows.Forms.Label currentOdometerReadingLabel;
        private System.Windows.Forms.Label returnConfirmationLabel;
        private System.Windows.Forms.TextBox returnReservationIDTextBox;
        private System.Windows.Forms.Label reservationIDlabel;
        private System.Windows.Forms.Button confirmReturnButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox returnOdometerTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Label label7;
    }
}