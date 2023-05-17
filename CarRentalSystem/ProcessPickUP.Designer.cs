namespace CarRentalSystem
{
    partial class ProcessPickUP
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
            this.pickUpDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmReservationButton = new System.Windows.Forms.Button();
            this.showPickUPStatusLabel = new System.Windows.Forms.Label();
            this.odometerTextBox = new System.Windows.Forms.TextBox();
            this.processPickUPUserIdBox = new System.Windows.Forms.ComboBox();
            this.getReservationsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.processPickUPUserNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.pickUpDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pickUpDetailsGroupBox
            // 
            this.pickUpDetailsGroupBox.Controls.Add(this.label2);
            this.pickUpDetailsGroupBox.Controls.Add(this.confirmReservationButton);
            this.pickUpDetailsGroupBox.Controls.Add(this.showPickUPStatusLabel);
            this.pickUpDetailsGroupBox.Controls.Add(this.odometerTextBox);
            this.pickUpDetailsGroupBox.Controls.Add(this.processPickUPUserIdBox);
            this.pickUpDetailsGroupBox.Location = new System.Drawing.Point(52, 161);
            this.pickUpDetailsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.pickUpDetailsGroupBox.Name = "pickUpDetailsGroupBox";
            this.pickUpDetailsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.pickUpDetailsGroupBox.Size = new System.Drawing.Size(504, 154);
            this.pickUpDetailsGroupBox.TabIndex = 11;
            this.pickUpDetailsGroupBox.TabStop = false;
            this.pickUpDetailsGroupBox.Text = "Car Pick up details";
            this.pickUpDetailsGroupBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Odometer Reading";
            this.label2.Visible = false;
            // 
            // confirmReservationButton
            // 
            this.confirmReservationButton.Location = new System.Drawing.Point(213, 99);
            this.confirmReservationButton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmReservationButton.Name = "confirmReservationButton";
            this.confirmReservationButton.Size = new System.Drawing.Size(182, 27);
            this.confirmReservationButton.TabIndex = 4;
            this.confirmReservationButton.Text = "Confirm Reservation";
            this.confirmReservationButton.UseVisualStyleBackColor = true;
            this.confirmReservationButton.Visible = false;
            this.confirmReservationButton.Click += new System.EventHandler(this.confirmReservationButton_Click);
            // 
            // showPickUPStatusLabel
            // 
            this.showPickUPStatusLabel.AutoSize = true;
            this.showPickUPStatusLabel.Location = new System.Drawing.Point(8, 127);
            this.showPickUPStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showPickUPStatusLabel.Name = "showPickUPStatusLabel";
            this.showPickUPStatusLabel.Size = new System.Drawing.Size(0, 16);
            this.showPickUPStatusLabel.TabIndex = 5;
            // 
            // odometerTextBox
            // 
            this.odometerTextBox.Location = new System.Drawing.Point(11, 99);
            this.odometerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.odometerTextBox.Name = "odometerTextBox";
            this.odometerTextBox.Size = new System.Drawing.Size(176, 22);
            this.odometerTextBox.TabIndex = 6;
            this.odometerTextBox.Visible = false;
            // 
            // processPickUPUserIdBox
            // 
            this.processPickUPUserIdBox.FormattingEnabled = true;
            this.processPickUPUserIdBox.Location = new System.Drawing.Point(11, 37);
            this.processPickUPUserIdBox.Margin = new System.Windows.Forms.Padding(2);
            this.processPickUPUserIdBox.Name = "processPickUPUserIdBox";
            this.processPickUPUserIdBox.Size = new System.Drawing.Size(176, 24);
            this.processPickUPUserIdBox.TabIndex = 3;
            this.processPickUPUserIdBox.Visible = false;
            // 
            // getReservationsButton
            // 
            this.getReservationsButton.Location = new System.Drawing.Point(272, 116);
            this.getReservationsButton.Margin = new System.Windows.Forms.Padding(2);
            this.getReservationsButton.Name = "getReservationsButton";
            this.getReservationsButton.Size = new System.Drawing.Size(176, 25);
            this.getReservationsButton.TabIndex = 10;
            this.getReservationsButton.Text = "Get Reservations";
            this.getReservationsButton.UseVisualStyleBackColor = true;
            this.getReservationsButton.Click += new System.EventHandler(this.getReservationsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please Enter User Name To Proceed";
            // 
            // processPickUPUserNameTextBox
            // 
            this.processPickUPUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processPickUPUserNameTextBox.Location = new System.Drawing.Point(77, 116);
            this.processPickUPUserNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.processPickUPUserNameTextBox.Name = "processPickUPUserNameTextBox";
            this.processPickUPUserNameTextBox.Size = new System.Drawing.Size(175, 22);
            this.processPickUPUserNameTextBox.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(516, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "* You should be logged in as a MANAGER to process pickup";
            // 
            // ProcessPickUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 382);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pickUpDetailsGroupBox);
            this.Controls.Add(this.getReservationsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processPickUPUserNameTextBox);
            this.Name = "ProcessPickUP";
            this.Text = "ProcessPickUP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessPickUP_FormClosing);
            this.Load += new System.EventHandler(this.ProcessPickUP_Load);
            this.pickUpDetailsGroupBox.ResumeLayout(false);
            this.pickUpDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pickUpDetailsGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmReservationButton;
        private System.Windows.Forms.Label showPickUPStatusLabel;
        private System.Windows.Forms.TextBox odometerTextBox;
        private System.Windows.Forms.ComboBox processPickUPUserIdBox;
        private System.Windows.Forms.Button getReservationsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox processPickUPUserNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
    }
}