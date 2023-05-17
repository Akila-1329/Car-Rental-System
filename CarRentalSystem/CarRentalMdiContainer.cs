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
    public partial class CarRentalMdiContainer : Form
    {
        public static bool IsLoggedIn = false;
        public static string loggedInUsername = "";
        public static int loggedInUserId = 0;
        //{
        //  get { return false; }
        //}
        public CarRentalMdiContainer()
        {
            InitializeComponent();
        }

        private void CarRentalMdiContainer_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.Teal;
            //pictureBox.Image = Properties.Resources.sale_car_rental;
            this.BackgroundImage = global::CarRentalSystem.Properties.Resources.sale_car_rental; 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        }//CarRentalMdiContainer_Load()

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }//closeToolStripMenuItem_Click()

        private void generatePickupReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneratePickupReportForm generatePickupReportForm = GeneratePickupReportForm.GetGeneratePickupReportForm();
            generatePickupReportForm.MdiParent = this;
            generatePickupReportForm.TopMost = true;
            generatePickupReportForm.Show();
        }//generatePickupReportToolStripMenuItem_Click()

        private void makeReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeReservationsForm makeReservationsForm = MakeReservationsForm.GetReservationsForm();
            makeReservationsForm.MdiParent = this;
            makeReservationsForm.Show();
        }//get reservation form()

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = LoginForm.GetLoginForm();
            loginForm.MdiParent = this;
            loginForm.Show();
        }//loginToolStripMenuItem_Click()

        private void viewUpdateCancelReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUpdateCancelForm viewUpdateCancelForm = ViewUpdateCancelForm.GetViewUpdateCancelForm();
            viewUpdateCancelForm.MdiParent = this;
            viewUpdateCancelForm.Show();
        }//viewUpdateCancelReservationsToolStripMenuItem_Click

        private void processPickupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessPickUP singletonProcessPickUpForm = ProcessPickUP.showProcessPickUP();

            singletonProcessPickUpForm.MdiParent = this;

            singletonProcessPickUpForm.Show();
        }

        private void processReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessReturnForm processReturnForm = ProcessReturnForm.showProcessPickUP();

            processReturnForm.MdiParent = this;

            processReturnForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutForm = AboutBox.showAboutBox();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void generateReturnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReturnReportForm generateReturnReportForm = GenerateReturnReportForm.ShowGenerateReturnReportForm();
            generateReturnReportForm.MdiParent = this;
            generateReturnReportForm.Show();
        }

        private void customerReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerReviewsForm customerReviewsForm = CustomerReviewsForm.ShowCustomerReviewsForm();
            customerReviewsForm.MdiParent = this;
            customerReviewsForm.Show();
        }
    }
}
