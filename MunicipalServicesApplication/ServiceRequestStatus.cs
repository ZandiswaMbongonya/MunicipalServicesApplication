using System;
using System.Collections.Generic;
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

            if (string.IsNullOrWhiteSpace(requestID))
            {
                MessageBox.Show("Please enter a Request ID.");
                return;
            }

            // Temporary sample request records for testing.
            Dictionary<string, string> requestStatuses =
                new Dictionary<string, string>(
                    StringComparer.OrdinalIgnoreCase)
                {
            { "SR001", "Submitted - Your request has been received." },
            { "SR002", "In Progress - Your request is being attended to." },
            { "SR003", "Resolved - Your request has been completed." }
                };

            if (requestStatuses.TryGetValue(requestID, out string status))
            {
                lblStatusResult.Text = status;
            }
            else
            {
                lblStatusResult.Text =
                    "Request ID not found. Please check the ID and try again.";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}