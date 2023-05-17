namespace CarRentalSystem
{
    partial class GenerateReturnReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.getReportButton = new System.Windows.Forms.Button();
            this.returnDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.returnDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "* You should be logged in as a MANAGER to get the report";
            // 
            // getReportButton
            // 
            this.getReportButton.Location = new System.Drawing.Point(25, 58);
            this.getReportButton.Name = "getReportButton";
            this.getReportButton.Size = new System.Drawing.Size(188, 54);
            this.getReportButton.TabIndex = 4;
            this.getReportButton.Text = "Get Return Report";
            this.getReportButton.UseVisualStyleBackColor = true;
            this.getReportButton.Click += new System.EventHandler(this.getReportButton_Click);
            // 
            // returnDataGridView
            // 
            this.returnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnDataGridView.Location = new System.Drawing.Point(25, 135);
            this.returnDataGridView.Name = "returnDataGridView";
            this.returnDataGridView.RowHeadersWidth = 51;
            this.returnDataGridView.RowTemplate.Height = 24;
            this.returnDataGridView.Size = new System.Drawing.Size(747, 301);
            this.returnDataGridView.TabIndex = 3;
            // 
            // GenerateReturnReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getReportButton);
            this.Controls.Add(this.returnDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "GenerateReturnReportForm";
            this.Text = "Return Report";
            this.Load += new System.EventHandler(this.GenerateReturnReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getReportButton;
        private System.Windows.Forms.DataGridView returnDataGridView;
    }
}