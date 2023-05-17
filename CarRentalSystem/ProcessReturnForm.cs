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
    public partial class ProcessReturnForm : Form
    {
        private int currentOdometerReading;
        private int price = 0;

        private static ProcessReturnForm processReturnFormInstance;

        //intermediary Class
        private CarRentalIntermediaryClass carRentalIntermediaryClass = new CarRentalIntermediaryClass();
        private ProcessReturnForm()
        {
            InitializeComponent();
        }
        internal static ProcessReturnForm showProcessPickUP()
        {
            if (processReturnFormInstance == null)
                processReturnFormInstance = new ProcessReturnForm();
            return processReturnFormInstance;
        }

        private void ProcessReturnForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            processReturnFormInstance = null;
        }

        private void CalculatePriceButton_Click(object sender, EventArgs e)
        {
           
            if (returnOdometerTextBox.Text == null || returnOdometerTextBox.Text == "")
            {
                errorProvider1.SetError(returnOdometerTextBox, "Reading Should not ne empty");
            }
            else
            {
                errorProvider1.Clear();
                if (int.Parse(returnOdometerTextBox.Text.ToString()) < int.Parse(initialOdometerReading.Text.ToString()))
                {
                    errorProvider1.SetError(returnOdometerTextBox, "Return Reading Should not be less than older reading");
                }
                else
                {
                    errorProvider1.Clear();
                  //  initialOdometerReading.Text = (int.Parse(returnOdometerTextBox.Text) - int.Parse(initialOdometerReading.Text)).ToString();
                    if ((int.Parse(returnOdometerTextBox.Text) - int.Parse(initialOdometerReading.Text.ToString())) < 1500)
                    {
                        price = int.Parse(estimatedPriceLabel.Text);
                       // calculatedPriceShowLabel.Text = estimatedPriceLabel.Text;
                        calculatedPriceShowLabel.Text = price.ToString("C");
                        calculatedPriceShowLabel.Visible = true;
                        calculatedPricelabel.Visible = true;
                        confirmReturnButton.Visible = true;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        // price = int.Parse(estimatedPriceLabel.Text) + 500;
                        CarRentalReturnPriceAbstractClass obj = new CarRentalReturnAbstractDerivedClass();
                        price = obj.CalculateReturnExtraMilagePrice(int.Parse(estimatedPriceLabel.Text));
                        
                        calculatedPriceShowLabel.Text = price.ToString("C");
                        calculatedPriceShowLabel.Visible = true;
                        calculatedPricelabel.Visible = true;
                        confirmReturnButton.Visible = true;
                        errorProvider1.Clear();
                    }
                }
            }
        }

        private void confirmReturnButton_Click(object sender, EventArgs e)
        {
            if (carRentalIntermediaryClass.CompleteReservation(int.Parse(returnOdometerTextBox.Text), price, int.Parse(returnReservationIDTextBox.Text)) > 0)
            {
                returnLabel.Visible = true;
            } else
            {
                returnLabel.Visible = true;
                returnLabel.Text = "Something went wrong.";
            }
        }

        private void checkReservationButton_Click(object sender, EventArgs e)
        {
            if (returnReservationIDTextBox.Text.ToString() == null || returnReservationIDTextBox.Text.ToString() == "")
            {
                errorProvider1.SetError(returnReservationIDTextBox, "reservation ID Cannot be Empty");
            }
            else
            {
                if (carRentalIntermediaryClass.GetReservationsWithreservationIDeCount(returnReservationIDTextBox.Text.ToString()) > 0)
                {
                    BindingSource reservationsBindingSource = new BindingSource();
                    reservationsBindingSource.DataSource = carRentalIntermediaryClass.GetProcessReturnOdometerReading(returnReservationIDTextBox.Text.ToString());

                    estimatedPriceLabel.Text = "price";

                    estimatedPriceLabel.DataBindings.Add("text", reservationsBindingSource, "price", false, DataSourceUpdateMode.Never);
                    initialOdometerReading.DataBindings.Add("text", reservationsBindingSource, "current_odometer", false, DataSourceUpdateMode.Never);
                    label3.Visible = true;
                    estimatedPriceLabel.Visible = true;
                    currentOdometerReadingLabel.Visible = true;
                    initialOdometerReading.Visible = true;
                    label1.Visible = true;
                    returnOdometerTextBox.Visible = true;
                    CalculatePriceButton.Visible = true;
                }
                else
                {
                    errorProvider1.SetError(returnReservationIDTextBox, "Please enter proper reservation ID");
                }
            }
        }

        private void ProcessReturnForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.loggedInRole.ToLower() == "manager")
            {
                returnReservationIDTextBox.Enabled = true;
                checkReservationButton.Enabled = true;
                returnOdometerTextBox.Enabled = true;
                CalculatePriceButton.Enabled = true;
                confirmReturnButton.Enabled = true;
            }
            else
            {
                returnReservationIDTextBox.Enabled = false;
                checkReservationButton.Enabled = false;
                returnOdometerTextBox.Enabled = false;
                CalculatePriceButton.Enabled = false;
                confirmReturnButton.Enabled = false;
            }
        }
    }
}
