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
    public partial class GenerateReturnReportForm : Form
    {
        private static GenerateReturnReportForm generateReturnReportForm;
        private CarRentalIntermediaryClass carRentalIntermediaryClass = new CarRentalIntermediaryClass();
        private GenerateReturnReportForm()
        {
            InitializeComponent();
        }
        public static GenerateReturnReportForm ShowGenerateReturnReportForm()
        {
            if (generateReturnReportForm == null) generateReturnReportForm = new GenerateReturnReportForm();
            return generateReturnReportForm;
        }

        private void GenerateReturnReportForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.loggedInRole.ToLower() == "manager")
                getReportButton.Enabled = true;
            else
                getReportButton.Enabled = false;
        }

        private void getReportButton_Click(object sender, EventArgs e)
        {
            DataTable reservationsTable = new DataTable();
            reservationsTable = carRentalIntermediaryClass.GetReturnReport();
            returnDataGridView.DataSource = reservationsTable;
            returnDataGridView.ReadOnly = true;
        }
    }
}
