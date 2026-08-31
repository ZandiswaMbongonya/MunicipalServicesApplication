using System;
using System.Windows.Forms;

namespace MunicipalServicesApplication
{
    public partial class ServiceRequestStatus : Form
    {
        public ServiceRequestStatus()
        {
            InitializeComponent();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            string requestID = txtRequestID.Text.Trim();

            if (string.IsNullOrEmpty(requestID))
            {
                MessageBox.Show("Please enter a Request ID.");

                return;
            }

            lblStatus.Text = "Request ID " + requestID + " is currently being processed.";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}