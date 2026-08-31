using System;
using System.Windows.Forms;

namespace MunicipalServicesApplication
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssues reportIssuesForm = new ReportIssues();
            reportIssuesForm.Show();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEvents localEventsForm = new LocalEvents();
            localEventsForm.Show();
        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            ServiceRequestStatus serviceRequestStatusForm =
                new ServiceRequestStatus();

            serviceRequestStatusForm.Show();
        }
    }
}