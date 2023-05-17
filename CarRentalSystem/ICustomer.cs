using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    internal interface ICustomer
    {
        String customerName { get; set; }
        int customerAge { get; set; }
        int randomDiscount { get; set; }

        decimal CalculateTotalDue(int carSelected, int noOfDays);
        decimal CalculateTotalDue(int carSelected, int discount, int noOfDays);
    }
}
