using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public sealed class CustomerReviewsSealedClass
    {
        public List<ReviewObjectClass> GetCustomerReviews()
        {
            CarRentalIntermediaryClass carRentalIntermediaryClass = new CarRentalIntermediaryClass();
            DataTable reservationsTable = new DataTable();
            List<ReviewObjectClass> reviews = new List<ReviewObjectClass>();
            try
            {     
                reservationsTable = carRentalIntermediaryClass.GetCustomerReviews();
                if (reservationsTable.Rows.Count > 0)
                {
                     foreach (DataRow row in reservationsTable.Rows)
                     {
                        reviews.Add(new ReviewObjectClass(row["user_name"].ToString(), row["description"].ToString()));
                     }
                    // reviews.Sort();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return reviews;
        }
    }//class
}//namespace
