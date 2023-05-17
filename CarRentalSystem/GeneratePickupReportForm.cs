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
    public partial class GeneratePickupReportForm : Form
    {
        private static GeneratePickupReportForm generatePickupReportForm;
        private CarRentalIntermediaryClass carRentalIntermediaryClass = new CarRentalIntermediaryClass();
        private GeneratePickupReportForm()
        {
            InitializeComponent();
        }
        public static GeneratePickupReportForm GetGeneratePickupReportForm()
        {
            if (generatePickupReportForm == null) generatePickupReportForm = new GeneratePickupReportForm();
            return generatePickupReportForm;
        }

        private void GeneratePickupReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            generatePickupReportForm = null;
        }

        private void GeneratePickupReportForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.loggedInRole.ToLower() == "manager")
                getReportButton.Enabled = true;
            else
                getReportButton.Enabled = false;
        }

        private void getReportButton_Click(object sender, EventArgs e)
        {
            DataTable reservationsTable = new DataTable();
            reservationsTable = carRentalIntermediaryClass.GetPickupReport();
            dataGridView.DataSource = reservationsTable;
            dataGridView.ReadOnly = true;
        }
    }
}
