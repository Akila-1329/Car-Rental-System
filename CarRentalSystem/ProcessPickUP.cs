using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class ProcessPickUP : Form
    {
        private static ProcessPickUP processPickUPFormInstance;
        //intermediary Class
        private CarRentalIntermediaryClass carRentalIntermediaryClass = new CarRentalIntermediaryClass();

        private ProcessPickUP()
        {
            InitializeComponent();
        }
        internal static ProcessPickUP showProcessPickUP()
        {
            if (processPickUPFormInstance == null)
                processPickUPFormInstance = new ProcessPickUP();
            return processPickUPFormInstance;
        }

        private void getReservationsButton_Click(object sender, EventArgs e)
        {
            if (processPickUPUserNameTextBox.Text == "" || processPickUPUserNameTextBox.Text == null)
            {
                errorProvider1.SetError(processPickUPUserNameTextBox, "User Name cannot be Empty");
            }
            else
            {

                if (carRentalIntermediaryClass.GetReservationsWithUserNameCount<string>(processPickUPUserNameTextBox.Text.ToString()) > 0)
                {
                    getReservationsButton.Enabled = false;
                    BindingSource reservationsBindingSource = new BindingSource();
                    reservationsBindingSource.DataSource = carRentalIntermediaryClass.GetProcessPickUPReservations(processPickUPUserNameTextBox.Text);
                    processPickUPUserIdBox.Visible = true;
                    confirmReservationButton.Visible = true;
                    label2.Visible = true;
                    odometerTextBox.Visible = true;
                    pickUpDetailsGroupBox.Visible = true;
                    processPickUPUserIdBox.Items.Clear();
                    errorProvider1.Dispose();
                    processPickUPUserIdBox.DataSource = reservationsBindingSource;

                    processPickUPUserIdBox.DisplayMember = "reservation_id";
                    processPickUPUserIdBox.ValueMember = "reservation_id";

                    processPickUPUserIdBox.DataBindings.Add("text", reservationsBindingSource, "reservation_id", false, DataSourceUpdateMode.Never);

                }
                else
                {
                    getReservationsButton.Enabled = true;
                    errorProvider1.SetError(processPickUPUserNameTextBox, "Enter Existing User Name");
                }
            }
        }

        private void ProcessPickUP_FormClosing(object sender, FormClosingEventArgs e)
        {
            processPickUPFormInstance = null;
        }

        private void confirmReservationButton_Click(object sender, EventArgs e)
        {
            string odometerReadingValue = odometerTextBox.ToString();
            try
            {
                if (odometerTextBox.Text != "")
                {
                    DataRowView dataRowView = processPickUPUserIdBox.SelectedItem as DataRowView;
                    int resId = int.Parse(dataRowView.Row["reservation_id"].ToString());

                    if (carRentalIntermediaryClass.ConfirmPickUP(resId, int.Parse(odometerTextBox.Text)) > 0)
                    {
                        showPickUPStatusLabel.Text = "updated";
                        confirmReservationButton.Enabled = false;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }
                else
                {
                    errorProvider1.SetError(odometerTextBox, "Please enter the odometer reading");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessPickUP_Load(object sender, EventArgs e)
        {
            if (LoginForm.loggedInRole.ToLower() == "manager")
            {
                processPickUPUserNameTextBox.Enabled = true;
                getReservationsButton.Enabled = true;
                pickUpDetailsGroupBox.Enabled = true;
            }
            else
            {
                processPickUPUserNameTextBox.Enabled = false;
                getReservationsButton.Enabled = false;
                pickUpDetailsGroupBox.Enabled = false;
            }
        }
    }
}
