
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

            if (string.IsNullOrWhiteSpace(requestID))
            {
                MessageBox.Show("Please enter a Request ID.");
                return;
            }

            Issue request = ServiceRequestRepository.GetRequestByID(requestID);

            if (request != null)
            {
                lblStatusResult.Text =
                    "Request ID: " + request.RequestID +
                    "\nStatus: " + request.Status +
                    "\nCategory: " + request.Category +
                    "\nLocation: " + request.Location;
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
