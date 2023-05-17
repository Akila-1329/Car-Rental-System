using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    //Created by Akila Dasari : 11/16/2022

    public enum CarType
    {
        RangeRover = 0,
        Toyota = 1,
        Ford = 2,
        Chevrolet = 3,
        Hyundai = 4,
        BMW = 5,
        Tesla = 6,
        Audi = 7,
        Subaru = 8,
        Acura = 9,
        Chrysler = 10,
        Lexus = 11,
    }//end enum CarType
    public partial class MakeReservationsForm : Form
    {
        //for singleton instance
        private static MakeReservationsForm makeReservationForm;
        private String name;
        private int age;
        private String carType;
        private int carTypeIndex;
        private int noOfDays;
        private string slotSelected;
        private int slotId;
        private static int discount;

        ErrorProvider errorProvider = new ErrorProvider();

        //intermediary Class
        private CarRentalIntermediaryClass carRentalIntermediaryClass = new CarRentalIntermediaryClass();
        private MakeReservationsForm()
        {
            InitializeComponent();
        }//end constructor

        public static MakeReservationsForm GetReservationsForm()
        {
            if (makeReservationForm == null) makeReservationForm = new MakeReservationsForm();
            return makeReservationForm;
        }//GetreservationForm()

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

        public static int generateRandomDiscount()
        {
            Random random = new Random();
            discount = random.Next(5, 15);
            return discount;
        }

        private int getCountFromReservations()
        {
            int nextReservationId = carRentalIntermediaryClass.GetCount() + 1000 + 1;
            return nextReservationId;
            //MessageBox.Show($" Rservation Id :{nextReservationId} Count : {carRentalIntermediaryClass.GetCount()}");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            //if (customerNameTextBox.Text != string.Empty)
            //{
            /*if (Regex.IsMatch(customerNameTextBox.Text, @"^[A-Za-z]*$"))
            {*/
            name = customerNameTextBox.Text;
            try
            {
                age = int.Parse(ageTextBox.Text);
                if (age > 18)
                {
                    if (carTypeComboBox.SelectedIndex != -1)
                    {
                        carTypeIndex = carTypeComboBox.SelectedIndex;
                        if (availableSlotsComboBox.SelectedIndex != -1)
                        {
                            DataRowView dataRowView = availableSlotsComboBox.SelectedItem as DataRowView;
                            slotSelected = dataRowView.Row["slot_available"] as string;
                            slotId = int.Parse(dataRowView.Row["slot_id"].ToString());
                            //slotSelected = availableSlotsComboBox.SelectedItem.ToString();
                            try
                            {
                                noOfDays = int.Parse(noOfDaysTextBox.Text);


                                int generatedDiscount = generateRandomDiscount();
                                if (applyDiscountCheckBox.Checked == true)
                                {
                                    try
                                    {
                                        //get all the values and supply it to method
                                        //slots table needs to be filled in order to get the slot selected
                                        //slot selection event needs to be generated in order to get the slot selected
                                        //created diff method in intermediary class to get the count of slots in order to increase that with "1" and make new reservation id: select count * + 1000 + 1
                                        //slots avilable in the drop down has to be listed only when status is available // work later
                                        //status can be removed from reservations table : not ideal
                                        //calculate total price for price attribute that has to be entered in table reservation
                                        /*CalculateBill calculateBill = new CalculateBill(age, name);
                                        decimal totaldue = calculateBill.CalculateTotalDue(carTypeIndex, generatedDiscount, noOfDays);*/
                                        //user id: use static data for now
                                        CalculateBill calculateBill = new CalculateBill(age, name);
                                        decimal totaldue = calculateBill.CalculateTotalDue(carTypeIndex, generatedDiscount, noOfDays);

                                        if ((carRentalIntermediaryClass.ReserveCar(makeReservationForm.getCountFromReservations(), slotSelected.Trim(), "Reserved", totaldue, CarRentalMdiContainer.loggedInUserId)) != -1)
                                        {
                                            if ((carRentalIntermediaryClass.changeStatusToUnavailable(slotId)) != -1)
                                            {
                                                MessageBox.Show($"Hey {name} {Environment.NewLine}" +
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

                                    /*CalculateBill calculateBill = new CalculateBill(age, name);
                                    decimal totaldue = calculateBill.CalculateTotalDue(carTypeIndex, generatedDiscount, noOfDays);
                                    MessageBox.Show($"Hey {name} {Environment.NewLine} cartypeIndex: {carTypeIndex}" +
                                        $"Your total amount due after applying {generatedDiscount}% of discount is : {totaldue} { Environment.NewLine}" + 
                                        $"Thank You");*/

                                }
                                else
                                {
                                    /*CalculateBill calculateBill = new CalculateBill(age, name);
                                    decimal totaldue = calculateBill.CalculateTotalDue(carTypeIndex, noOfDays);
                                    MessageBox.Show($"Hey {name} {Environment.NewLine}" +
                                        $"Your total amount due is : {totaldue} {Environment.NewLine}" +
                                        $"Thank You");*/
                                    try
                                    {
                                        CalculateBill calculateBill = new CalculateBill(age, name);
                                        decimal totaldue = calculateBill.CalculateTotalDue(carTypeIndex, noOfDays);

                                        if ((carRentalIntermediaryClass.ReserveCar(makeReservationForm.getCountFromReservations(), slotSelected.Trim(), "Reserved", totaldue, CarRentalMdiContainer.loggedInUserId)) != -1)
                                        {
                                            if ((carRentalIntermediaryClass.changeStatusToUnavailable(slotId)) != -1)
                                            {
                                                MessageBox.Show($"Hey {name} {Environment.NewLine}" +
                                                $"Your total amount due after applying {generatedDiscount}% of discount is : {totaldue} {Environment.NewLine}" +
                                                $"Thank You");
                                                submitButton.Enabled = false;
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
                        errorProvider.SetError(carTypeComboBox, "Choose a car!!");
                    }
                }
                else
                {
                    errorProvider.SetError(ageTextBox, "You are not eligible for renting a car");
                }
            }
            catch (Exception ex)
            {
                errorProvider.SetError(ageTextBox, ex.Message + "Enter a valid age!!!");
            }
            /*}
            else
            {
                errorProvider.SetError(customerNameTextBox, "Use alphabets only!!");
            }*/
            //}
            /*else
            {
                errorProvider.SetError(customerNameTextBox, "Enter a name");
            }*/
        }

        private void MakeReservationsForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.loggedInRole.ToLower() == "user")
            {
                customerNameTextBox.Enabled = true;
                ageTextBox.Enabled = true;
                carTypeComboBox.Enabled = true;
                availableSlotsComboBox.Enabled = true;
                noOfDaysTextBox.Enabled = true;
                applyDiscountCheckBox.Enabled = true;
                submitButton.Enabled = true;
            }       
            else
            {
                customerNameTextBox.Enabled = false;
                ageTextBox.Enabled = false;
                carTypeComboBox.Enabled = false;
                availableSlotsComboBox.Enabled = false;
                noOfDaysTextBox.Enabled = false;
                applyDiscountCheckBox.Enabled = false;
                submitButton.Enabled = false;
            }
               
            customerNameTextBox.Text = CarRentalMdiContainer.loggedInUsername;
            customerNameTextBox.Enabled = false;
            BindingSource reservationsBindingSource = new BindingSource();
            reservationsBindingSource.DataSource = carRentalIntermediaryClass.GetAvailableSlots();

            availableSlotsComboBox.Items.Clear();
            availableSlotsComboBox.DataSource = reservationsBindingSource;

            availableSlotsComboBox.DisplayMember = "slot_available";
            availableSlotsComboBox.ValueMember = "slot_id";

            availableSlotsComboBox.DataBindings.Add("text", reservationsBindingSource, "slot_available", false, DataSourceUpdateMode.Never);
        }//form load event

        private void MakeReservationsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            makeReservationForm = null;
        }
    }
}
