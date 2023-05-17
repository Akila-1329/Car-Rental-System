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
    public partial class ViewUpdateCancelForm : Form
    {
        //for singleton instance
        public static ViewUpdateCancelForm viewUpdateCancelForm;
        public int userId = CarRentalMdiContainer.loggedInUserId;
        private CarRentalIntermediaryClass carRentalIntermediaryClass = new CarRentalIntermediaryClass();
        private String carType;
        private int carTypeIndex;
        private int age;
        private int noOfDays;
        private string slotSelected;
        private int slotId;

        ErrorProvider errorProvider = new ErrorProvider();
        public ViewUpdateCancelForm()
        {
            InitializeComponent();
        }

        private void carTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carType = carTypeComboBox.SelectedItem.ToString();

            switch (carType)
            {
                case "RangeRover":
                    carTypeIndex = (int)CarType.RangeRover;
                    break;
                case "Toyota":
                    carTypeIndex = (int)CarType.Toyota;
                    break;
                case "Ford":
                    carTypeIndex = (int)CarType.Ford;
                    break;
                case "Chevrolet":
                    carTypeIndex = (int)CarType.Chevrolet;
                    break;
                case "Hyundai":
                    carTypeIndex = (int)CarType.Hyundai;
                    break;
                case "BMW":
                    carTypeIndex = (int)CarType.BMW;
                    break;
                case "Tesla":
                    carTypeIndex = (int)CarType.Tesla;
                    break;
                case "Audi":
                    carTypeIndex = (int)CarType.Audi;
                    break;
                case "Subaru":
                    carTypeIndex = (int)CarType.Subaru;
                    break;
                case "Acura":
                    carTypeIndex = (int)CarType.Acura;
                    break;
                case "Chrysler":
                    carTypeIndex = (int)CarType.Chrysler;
                    break;
                case "Lexus":
                    carTypeIndex = (int)CarType.Lexus;
                    break;
            }//selected index event
        }

        public static ViewUpdateCancelForm GetViewUpdateCancelForm()
        {
            if (viewUpdateCancelForm == null) viewUpdateCancelForm = new ViewUpdateCancelForm();
            return viewUpdateCancelForm;
        }//GetViewUpdateCancelForm()

        private void ViewUpdateCancelForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.loggedInRole.ToLower() == "user")
            {
                reservationIdTextBox.Enabled = true;
                viewReservationButton.Enabled = true;
                updateCancelGroupBox.Enabled = true;
            }          
            else
            {
                reservationIdTextBox.Enabled = false;
                viewReservationButton.Enabled = false;
                updateCancelGroupBox.Enabled = false;
            }
        }

        private void updateReservationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ManageRadioButtons();
        }
        public int getCountFromReservations()
        {
            int nextReservationId = carRentalIntermediaryClass.GetCount() + 1000 + 1;
            return nextReservationId;
            //MessageBox.Show($" Rservation Id :{nextReservationId} Count : {carRentalIntermediaryClass.GetCount()}");
        }

        private void viewReservationButton_Click(object sender, EventArgs e)
        {
            if (reservationIdTextBox.Text != string.Empty)
            {
                int reservationId = Convert.ToInt32(reservationIdTextBox.Text);
                DataTable reservation = carRentalIntermediaryClass.getReservationById(reservationId, userId);

                int count = reservation.Rows.Count;
                if (count > 0)
                {
                    viewReservationResultTextBox.Text = $"Reservation Details: {Environment.NewLine}" +
                        $"Reservation Id : {reservation.Rows[0]["reservation_id"].ToString().Trim()} {Environment.NewLine}" +
                    $"Date: {reservation.Rows[0]["reservation_slot"].ToString().Trim()} {Environment.NewLine}" +
                    $"Price: {reservation.Rows[0]["price"].ToString().Trim()} {Environment.NewLine}";
                }
                else
                {
                    MessageBox.Show("Please enter a valid reservation id");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid reservation id");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (carTypeComboBox.SelectedIndex != -1)
            {
                carTypeIndex = carTypeComboBox.SelectedIndex;
                try
                {
                    age = int.Parse(ageTextBox.Text);
                    if (age > 18)
                    {
                        if (availableSlotsComboBox.SelectedIndex != -1)
                        {
                            DataRowView dataRowView = availableSlotsComboBox.SelectedItem as DataRowView;
                            slotSelected = dataRowView.Row["slot_available"] as string;
                            slotId = int.Parse(dataRowView.Row["slot_id"].ToString());
                            //slotSelected = availableSlotsComboBox.SelectedItem.ToString();
                            try
                            {
                                noOfDays = int.Parse(noOfDaysTextBox.Text);


                                int generatedDiscount = MakeReservationsForm.generateRandomDiscount();
                                if (applyDiscountCheckBox.Checked == true)
                                {
                                    try
                                    {
                                        CalculateBill calculateBill = new CalculateBill(age, CarRentalMdiContainer.loggedInUsername);
                                        decimal totaldue = calculateBill.CalculateTotalDue(carTypeIndex, generatedDiscount, noOfDays);

                                        if ((carRentalIntermediaryClass.ReserveCar(viewUpdateCancelForm.getCountFromReservations(), slotSelected.Trim(), "Reserved", totaldue, CarRentalMdiContainer.loggedInUserId)) != -1)
                                        {
                                            if ((carRentalIntermediaryClass.changeStatusToUnavailable(slotId)) != -1)
                                            {
                                                MessageBox.Show($"Hey {CarRentalMdiContainer.loggedInUsername} {Environment.NewLine}" +
                                                $"Your total amount due after applying {generatedDiscount}% of discount is : {totaldue} {Environment.NewLine}" +
                                                $"Thank You");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Something went wrong!! Please try again later");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Insertion Failed!!!!");
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show($"{carRentalIntermediaryClass.LastError}");
                                    }



                                }
                                else
                                {

                                    try
                                    {
                                        CalculateBill calculateBill = new CalculateBill(age, CarRentalMdiContainer.loggedInUsername);
                                        decimal totaldue = calculateBill.CalculateTotalDue(carTypeIndex, noOfDays);

                                        if ((carRentalIntermediaryClass.ReserveCar(viewUpdateCancelForm.getCountFromReservations(), slotSelected.Trim(), "Reserved", totaldue, CarRentalMdiContainer.loggedInUserId)) != -1)
                                        {
                                            if ((carRentalIntermediaryClass.changeStatusToUnavailable(slotId)) != -1)
                                            {
                                                MessageBox.Show($"Hey {CarRentalMdiContainer.loggedInUsername} {Environment.NewLine}" +
                                                $"Your total amount due after applying {generatedDiscount}% of discount is : {totaldue} {Environment.NewLine}" +
                                                $"Thank You");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Something went wrong!! Please try again later");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Insertion Failed!!!!");
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show($"{carRentalIntermediaryClass.LastError}");
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                errorProvider.SetError(noOfDaysTextBox, "Enter a valid no. of days!!");
                            }
                        }
                        else
                        {
                            errorProvider.SetError(availableSlotsComboBox, "Choose a slot");
                        }
                    }
                    else
                    {
                        errorProvider.SetError(ageTextBox, "You are not eligible for renting a car");
                    }
                }
                catch
                {
                    errorProvider.SetError(ageTextBox, "Age can only be a numeric value!!");
                }
            }
            else
            {
                errorProvider.SetError(carTypeComboBox, "Choose a car!!");
            }
        }//update button

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (reservationIdTextBox.Text != string.Empty)
            {
                int reservationId = Convert.ToInt32(reservationIdTextBox.Text);
                DataTable reservation = carRentalIntermediaryClass.getReservationById(reservationId, userId);

                int count = reservation.Rows.Count;
                if (count > 0)
                {
                    string reservationSlot = reservation.Rows[0]["reservation_slot"].ToString().Trim();
                    //Select * from Slots INNER JOIN Reservations ON Slots.slot_available = Reservations.reservation_slot where Slots.slot_available = '9thNov';
                    DataTable slots = carRentalIntermediaryClass.getSlotByReservationDate(reservationSlot);
                    int slot_id = 0;
                    if (slots.Rows.Count > 0 )
                    {
                        slot_id = int.Parse(slots.Rows[0]["slot_id"].ToString());
                    } else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                    

                    //change the status of reservation table to cancelled &&
                    //change the status of slot table to available back for further reservations
                    if ((carRentalIntermediaryClass.changeStatusToCancelled(reservationId)) != -1)
                    {
                        if ((carRentalIntermediaryClass.changeStatusToAvailable(slot_id)) != -1)
                        {
                            MessageBox.Show($"Reservation Cancelled for Id : {reservationId}");
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong!! Please try later");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!!! Please try again later");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid reservation id");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid reservation id");
            }
        }

        private void ViewUpdateCancelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            viewUpdateCancelForm = null;
        }

        private void cancelReservationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ManageRadioButtons();
        }

        private void ManageRadioButtons()
        {
            if (updateReservationRadioButton.Checked == true)
            {
                availableSlotsLabel.Enabled = true;
                enterNoOFDaysLabel.Enabled = true;
                availableSlotsComboBox.Enabled = true;
                noOfDaysTextBox.Enabled = true;
                updateButton.Enabled = true;
                carTypeLabel.Enabled = true;
                carTypeComboBox.Enabled = true;
                ageLabel.Enabled = true;
                ageTextBox.Enabled = true;
                cancelButton.Enabled = false;
                applyDiscountCheckBox.Enabled = true;

                BindingSource reservationsBindingSource = new BindingSource();
                reservationsBindingSource.DataSource = carRentalIntermediaryClass.GetAvailableSlots();
                availableSlotsComboBox.DataSource = null;
                availableSlotsComboBox.Items.Clear();
                availableSlotsComboBox.DataSource = reservationsBindingSource;

                availableSlotsComboBox.DisplayMember = "slot_available";
                availableSlotsComboBox.ValueMember = "slot_id";
                availableSlotsComboBox.DataBindings.Clear();
                availableSlotsComboBox.DataBindings.Add("text", reservationsBindingSource, "slot_available", false, DataSourceUpdateMode.Never);

            }//enable all controls for update button and disable for cancel button
            else if (cancelReservationRadioButton.Checked == true)
            {
                availableSlotsLabel.Enabled = false;
                enterNoOFDaysLabel.Enabled = false;
                availableSlotsComboBox.Enabled = false;
                noOfDaysTextBox.Enabled = false;
                updateButton.Enabled = false;
                carTypeLabel.Enabled = false;
                carTypeComboBox.Enabled = false;
                ageLabel.Enabled = false;
                ageTextBox.Enabled = false;
                cancelButton.Enabled = true;
                applyDiscountCheckBox.Enabled = false;
            }
        }//ManageRadioButtons
    }
}
