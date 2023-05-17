using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class CalculateBill : ICustomer
    {
        private String name;
        private int age;
        private int discount;
        private const decimal DEPOSIT = 500m;
        private const decimal RANGEROVER = 350m;
        private const decimal TOYOTA = 200m;
        private const decimal FORD = 250m;
        private const decimal CHEVROLET = 270m;
        private const decimal HYUNDAI = 290m;
        private const decimal BMW = 400m;
        private const decimal TESLA = 500m;
        private const decimal AUDI = 450m;
        private const decimal SUBARU = 150m;
        private const decimal ACURA = 240m;
        private const decimal CHRYSLER = 320m;
        private const decimal LEXUS = 370m;
        decimal totalDue;

        public CalculateBill(int age, String name)
        {
            customerName = name;
            customerAge = age;
        }
        public String customerName
        {
            get { return name; }
            set { name = value; }
        }

        public int customerAge
        {
            get { return age; }
            set { age = value; }
        }

        public int randomDiscount
        {
            get { return discount; }
            set { discount = value; }
        }
        public decimal CalculateTotalDue(int carSelected, int noOfDays)
        {

            switch (carSelected)
            {
                case 0:
                    totalDue = (DEPOSIT + (RANGEROVER * noOfDays));
                    break;
                case 1:
                    totalDue = (DEPOSIT + (TOYOTA * noOfDays));
                    break;
                case 2:
                    totalDue = (DEPOSIT + (FORD * noOfDays));
                    break;
                case 3:
                    totalDue = (DEPOSIT + (CHEVROLET * noOfDays));
                    break;
                case 4:
                    totalDue = (DEPOSIT + (HYUNDAI * noOfDays));
                    break;
                case 5:
                    totalDue = (DEPOSIT + (BMW * noOfDays));
                    break;
                case 6:
                    totalDue = (DEPOSIT + (TESLA * noOfDays));
                    break;
                case 7:
                    totalDue = (DEPOSIT + (AUDI * noOfDays));
                    break;
                case 8:
                    totalDue = (DEPOSIT + (SUBARU * noOfDays));
                    break;
                case 9:
                    totalDue = (DEPOSIT + (ACURA * noOfDays));
                    break;
                case 10:
                    totalDue = (DEPOSIT + (CHRYSLER * noOfDays));
                    break;
                case 11:
                    totalDue = (DEPOSIT + (LEXUS * noOfDays));
                    break;


            }
            return totalDue;
        }

        public decimal CalculateTotalDue(int carSelected, int discount, int noOfDays)
        {
            //MessageBox.Show($"With discount");
            decimal discountInDecimal = 1 - discount / 100m;
            //MessageBox.Show($"{discount}");
            //MessageBox.Show($"{discountInDecimal}");
            switch (carSelected)
            {

                case 0:
                    totalDue = (DEPOSIT + (RANGEROVER * noOfDays * discountInDecimal));
                    break;
                case 1:
                    totalDue = (DEPOSIT + (TOYOTA * noOfDays * discountInDecimal));
                    break;
                case 2:
                    totalDue = (DEPOSIT + (FORD * noOfDays * discountInDecimal));
                    break;
                case 3:
                    totalDue = (DEPOSIT + (CHEVROLET * noOfDays * discountInDecimal));
                    break;
                case 4:
                    totalDue = (DEPOSIT + (HYUNDAI * noOfDays * discountInDecimal));
                    break;
                case 5:
                    totalDue = (DEPOSIT + (BMW * noOfDays * discountInDecimal));
                    break;
                case 6:
                    totalDue = (DEPOSIT + (TESLA * noOfDays * discountInDecimal));
                    break;
                case 7:
                    totalDue = (DEPOSIT + (AUDI * noOfDays * discountInDecimal));
                    break;
                case 8:
                    totalDue = (DEPOSIT + (SUBARU * noOfDays * discountInDecimal));
                    break;
                case 9:
                    totalDue = (DEPOSIT + (ACURA * noOfDays * discountInDecimal));
                    break;
                case 10:
                    totalDue = (DEPOSIT + (CHRYSLER * noOfDays * discountInDecimal));
                    break;
                case 11:
                    totalDue = (DEPOSIT + (LEXUS * noOfDays * discountInDecimal));
                    break;
            }
            return totalDue;
        }
    }
}
