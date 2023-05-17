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
    //Created by Sayali S. Bujade
    public partial class CustomerReviewsForm : Form
    {
        private static CustomerReviewsForm customerReviewsForm;
        private CustomerReviewsForm()
        {
            InitializeComponent();
        }

        public static CustomerReviewsForm ShowCustomerReviewsForm()
        {
            if (customerReviewsForm == null) customerReviewsForm = new CustomerReviewsForm();
            return customerReviewsForm;
        }

        private void CustomerReviewsForm_Load(object sender, EventArgs e)
        {
            CustomerReviewsSealedClass customerReviewsSealedClass = new CustomerReviewsSealedClass();
            List<ReviewObjectClass> reviews = customerReviewsSealedClass.GetCustomerReviews();
            reviewsListBox.Items.Add($"USER NAME\t\t\tCOMMENT");
            reviewsListBox.Items.Add("\n");
            //reviewsListBox.Items.Add("--------------------------------------------------");

            foreach (ReviewObjectClass review in reviews)
            {
                reviewsListBox.Items.Add($"{review.Username}    -    {review.Desc}");
                reviewsListBox.Items.Add("\n");
            }
        }

        private void CustomerReviewsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            customerReviewsForm = null;
        }
    }//class
}//namespace
