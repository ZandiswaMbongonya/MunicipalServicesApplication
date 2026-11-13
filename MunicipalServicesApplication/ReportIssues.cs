
using System;
using System.Windows.Forms;

namespace MunicipalServicesApplication
{
    public partial class ReportIssues : Form
    {
        private string attachedFilePath = "";

        public ReportIssues()
        {
            InitializeComponent();

            progressBarEngagement.Minimum = 0;
            progressBarEngagement.Maximum = 100;
            progressBarEngagement.Value = 0;

            UpdateEngagement();
        }

        private void UpdateEngagement()
        {
            int completedFields = 0;
            int totalFields = 3;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                completedFields++;
            }

            if (cmbCategory.SelectedIndex != -1)
            {
                completedFields++;
            }

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                completedFields++;
            }

            int progress = (completedFields * 100) / totalFields;
            progressBarEngagement.Value = progress;

            if (progress == 100)
            {
                lblEngagement.Text = "Great! Your issue is ready to submit.";
            }
            else if (progress > 0)
            {
                lblEngagement.Text = "Good progress! Complete the remaining fields.";
            }
            else
            {
                lblEngagement.Text = "Complete the form to submit your issue";
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateEngagement();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEngagement();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateEngagement();
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                attachedFilePath = openFileDialog1.FileName;

                MessageBox.Show(
                    "File selected: " + attachedFilePath,
                    "Supporting Media");
            }
        }

        private void btnSubmitIssue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
    cmbCategory.SelectedIndex == -1 ||
    cmbPriority.SelectedIndex == -1 ||
    string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show(
                    "Please complete all required fields before submitting.",
                    "Incomplete Form");

                return;
            }

            Issue newIssue = new Issue
            {
                Location = txtLocation.Text,
                Category = cmbCategory.SelectedItem.ToString(),
                Priority = cmbPriority.SelectedItem.ToString(),
                Description = rtbDescription.Text,
                AttachedFile = attachedFilePath
            };

            string requestID = ServiceRequestRepository.AddRequest(newIssue);

            MessageBox.Show(
                "Your issue has been submitted successfully!\n\nYour Request ID is: " + requestID,
                "Success");

            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            attachedFilePath = "";

            UpdateEngagement();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void lblEngagement_Click(object sender, EventArgs e)
        {
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ReportIssues_Load(object sender, EventArgs e)
        {

        }
    }
}
