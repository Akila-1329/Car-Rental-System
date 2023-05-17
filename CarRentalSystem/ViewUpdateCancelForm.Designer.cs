namespace CarRentalSystem
{
    partial class ViewUpdateCancelForm
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
            this.updateCancelGroupBox = new System.Windows.Forms.GroupBox();
            this.applyDiscountCheckBox = new System.Windows.Forms.CheckBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.noOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.availableSlotsComboBox = new System.Windows.Forms.ComboBox();
            this.enterNoOFDaysLabel = new System.Windows.Forms.Label();
            this.availableSlotsLabel = new System.Windows.Forms.Label();
            this.cancelReservationRadioButton = new System.Windows.Forms.RadioButton();
            this.updateReservationRadioButton = new System.Windows.Forms.RadioButton();
            this.viewReservationResultTextBox = new System.Windows.Forms.TextBox();
            this.viewReservationButton = new System.Windows.Forms.Button();
            this.reservationIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateCancelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateCancelGroupBox
            // 
            this.updateCancelGroupBox.Controls.Add(this.applyDiscountCheckBox);
            this.updateCancelGroupBox.Controls.Add(this.ageTextBox);
            this.updateCancelGroupBox.Controls.Add(this.ageLabel);
            this.updateCancelGroupBox.Controls.Add(this.carTypeComboBox);
            this.updateCancelGroupBox.Controls.Add(this.carTypeLabel);
            this.updateCancelGroupBox.Controls.Add(this.cancelButton);
            this.updateCancelGroupBox.Controls.Add(this.updateButton);
            this.updateCancelGroupBox.Controls.Add(this.noOfDaysTextBox);
            this.updateCancelGroupBox.Controls.Add(this.availableSlotsComboBox);
            this.updateCancelGroupBox.Controls.Add(this.enterNoOFDaysLabel);
            this.updateCancelGroupBox.Controls.Add(this.availableSlotsLabel);
            this.updateCancelGroupBox.Controls.Add(this.cancelReservationRadioButton);
            this.updateCancelGroupBox.Controls.Add(this.updateReservationRadioButton);
            this.updateCancelGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCancelGroupBox.Location = new System.Drawing.Point(54, 229);
            this.updateCancelGroupBox.Name = "updateCancelGroupBox";
            this.updateCancelGroupBox.Size = new System.Drawing.Size(899, 396);
            this.updateCancelGroupBox.TabIndex = 9;
            this.updateCancelGroupBox.TabStop = false;
            this.updateCancelGroupBox.Text = "Do you want to Update or Cancel your Reservation??";
            // 
            // applyDiscountCheckBox
            // 
            this.applyDiscountCheckBox.AutoSize = true;
            this.applyDiscountCheckBox.Location = new System.Drawing.Point(220, 334);
            this.applyDiscountCheckBox.Name = "applyDiscountCheckBox";
            this.applyDiscountCheckBox.Size = new System.Drawing.Size(158, 24);
            this.applyDiscountCheckBox.TabIndex = 12;
            this.applyDiscountCheckBox.Text = "Apply Discount";
            this.applyDiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Enabled = false;
            this.ageTextBox.Location = new System.Drawing.Point(220, 212);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(165, 27);
            this.ageTextBox.TabIndex = 11;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Enabled = false;
            this.ageLabel.Location = new System.Drawing.Point(11, 215);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(41, 20);
            this.ageLabel.TabIndex = 10;
            this.ageLabel.Text = "Age";
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.Enabled = false;
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Items.AddRange(new object[] {
            "RangeRover",
            "Toyota",
            "Ford",
            "Chevrolet",
            "Hyundai",
            "BMW",
            "Tesla",
            "Audi",
            "Subaru",
            "Acura",
            "Chrysler",
            "Lexus"});
            this.carTypeComboBox.Location = new System.Drawing.Point(220, 169);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(165, 28);
            this.carTypeComboBox.TabIndex = 9;
            this.carTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.carTypeComboBox_SelectedIndexChanged);
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Enabled = false;
            this.carTypeLabel.Location = new System.Drawing.Point(11, 169);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(85, 20);
            this.carTypeLabel.TabIndex = 8;
            this.carTypeLabel.Text = "Car Type";
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(743, 352);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 35);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(643, 353);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(94, 34);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // noOfDaysTextBox
            // 
            this.noOfDaysTextBox.Enabled = false;
            this.noOfDaysTextBox.Location = new System.Drawing.Point(220, 282);
            this.noOfDaysTextBox.Name = "noOfDaysTextBox";
            this.noOfDaysTextBox.Size = new System.Drawing.Size(165, 27);
            this.noOfDaysTextBox.TabIndex = 5;
            // 
            // availableSlotsComboBox
            // 
            this.availableSlotsComboBox.Enabled = false;
            this.availableSlotsComboBox.FormattingEnabled = true;
            this.availableSlotsComboBox.Location = new System.Drawing.Point(220, 248);
            this.availableSlotsComboBox.Name = "availableSlotsComboBox";
            this.availableSlotsComboBox.Size = new System.Drawing.Size(165, 28);
            this.availableSlotsComboBox.TabIndex = 4;
            // 
            // enterNoOFDaysLabel
            // 
            this.enterNoOFDaysLabel.AutoSize = true;
            this.enterNoOFDaysLabel.Enabled = false;
            this.enterNoOFDaysLabel.Location = new System.Drawing.Point(7, 289);
            this.enterNoOFDaysLabel.Name = "enterNoOFDaysLabel";
            this.enterNoOFDaysLabel.Size = new System.Drawing.Size(163, 20);
            this.enterNoOFDaysLabel.TabIndex = 3;
            this.enterNoOFDaysLabel.Text = "Enter No. Of Days";
            // 
            // availableSlotsLabel
            // 
            this.availableSlotsLabel.AutoSize = true;
            this.availableSlotsLabel.Enabled = false;
            this.availableSlotsLabel.Location = new System.Drawing.Point(7, 258);
            this.availableSlotsLabel.Name = "availableSlotsLabel";
            this.availableSlotsLabel.Size = new System.Drawing.Size(134, 20);
            this.availableSlotsLabel.TabIndex = 2;
            this.availableSlotsLabel.Text = "Available Slots";
            // 
            // cancelReservationRadioButton
            // 
            this.cancelReservationRadioButton.AutoSize = true;
            this.cancelReservationRadioButton.Location = new System.Drawing.Point(6, 107);
            this.cancelReservationRadioButton.Name = "cancelReservationRadioButton";
            this.cancelReservationRadioButton.Size = new System.Drawing.Size(194, 24);
            this.cancelReservationRadioButton.TabIndex = 1;
            this.cancelReservationRadioButton.TabStop = true;
            this.cancelReservationRadioButton.Text = "Cancel Reservation";
            this.cancelReservationRadioButton.UseVisualStyleBackColor = true;
            this.cancelReservationRadioButton.CheckedChanged += new System.EventHandler(this.cancelReservationRadioButton_CheckedChanged);
            // 
            // updateReservationRadioButton
            // 
            this.updateReservationRadioButton.AutoSize = true;
            this.updateReservationRadioButton.Location = new System.Drawing.Point(6, 76);
            this.updateReservationRadioButton.Name = "updateReservationRadioButton";
            this.updateReservationRadioButton.Size = new System.Drawing.Size(195, 24);
            this.updateReservationRadioButton.TabIndex = 0;
            this.updateReservationRadioButton.TabStop = true;
            this.updateReservationRadioButton.Text = "Update Reservation";
            this.updateReservationRadioButton.UseVisualStyleBackColor = true;
            this.updateReservationRadioButton.CheckedChanged += new System.EventHandler(this.updateReservationRadioButton_CheckedChanged);
            // 
            // viewReservationResultTextBox
            // 
            this.viewReservationResultTextBox.Location = new System.Drawing.Point(54, 136);
            this.viewReservationResultTextBox.Multiline = true;
            this.viewReservationResultTextBox.Name = "viewReservationResultTextBox";
            this.viewReservationResultTextBox.Size = new System.Drawing.Size(899, 77);
            this.viewReservationResultTextBox.TabIndex = 8;
            // 
            // viewReservationButton
            // 
            this.viewReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReservationButton.Location = new System.Drawing.Point(54, 90);
            this.viewReservationButton.Name = "viewReservationButton";
            this.viewReservationButton.Size = new System.Drawing.Size(194, 31);
            this.viewReservationButton.TabIndex = 7;
            this.viewReservationButton.Text = "View Reservation";
            this.viewReservationButton.UseVisualStyleBackColor = true;
            this.viewReservationButton.Click += new System.EventHandler(this.viewReservationButton_Click);
            // 
            // reservationIdTextBox
            // 
            this.reservationIdTextBox.Location = new System.Drawing.Point(307, 53);
            this.reservationIdTextBox.Name = "reservationIdTextBox";
            this.reservationIdTextBox.Size = new System.Drawing.Size(214, 22);
            this.reservationIdTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter your reservation Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(49, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(618, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "* You should be logged in as a USER to view/update/cancel reservations";
            // 
            // ViewUpdateCancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 630);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateCancelGroupBox);
            this.Controls.Add(this.viewReservationResultTextBox);
            this.Controls.Add(this.viewReservationButton);
            this.Controls.Add(this.reservationIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewUpdateCancelForm";
            this.Text = "3..3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewUpdateCancelForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewUpdateCancelForm_Load);
            this.updateCancelGroupBox.ResumeLayout(false);
            this.updateCancelGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox updateCancelGroupBox;
        private System.Windows.Forms.CheckBox applyDiscountCheckBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox noOfDaysTextBox;
        private System.Windows.Forms.ComboBox availableSlotsComboBox;
        private System.Windows.Forms.Label enterNoOFDaysLabel;
        private System.Windows.Forms.Label availableSlotsLabel;
        private System.Windows.Forms.RadioButton cancelReservationRadioButton;
        private System.Windows.Forms.RadioButton updateReservationRadioButton;
        private System.Windows.Forms.TextBox viewReservationResultTextBox;
        private System.Windows.Forms.Button viewReservationButton;
        private System.Windows.Forms.TextBox reservationIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}