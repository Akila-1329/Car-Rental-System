using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class CarRentalReturnAbstractDerivedClass : CarRentalReturnPriceAbstractClass
    {
        public override int CalculateReturnExtraMilagePrice(int estimatedPrice) => estimatedPrice + 500;
    }//class
}//namespace
