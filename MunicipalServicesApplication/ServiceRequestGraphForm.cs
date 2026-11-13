using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApplication
{
    public partial class ServiceRequestGraphForm : Form
    {
        public ServiceRequestGraphForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
            private void btnConnect_Click(object sender, EventArgs e)
        {
            string location1 = txtLocation1.Text.Trim();
            string location2 = txtLocation2.Text.Trim();

            if (string.IsNullOrWhiteSpace(location1) ||
                string.IsNullOrWhiteSpace(location2))
            {
                MessageBox.Show("Please enter both locations.");
                return;
            }

            if (location1.Equals(location2, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter two different locations.");
                return;
            }

            if (!int.TryParse(txtWeight.Text.Trim(), out int weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a valid positive connection weight.");
                return;
            }

            ServiceRequestRepository.ConnectLocations(location1, location2, weight);

            MessageBox.Show(
                "The locations have been connected successfully.",
                "Connection Added");

           
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            string startLocation = txtStartLocation.Text.Trim();

            if (string.IsNullOrWhiteSpace(startLocation))
            {
                MessageBox.Show("Please enter a starting location.");
                return;
            }

            List<string> results =
                ServiceRequestRepository.GetLocationsBFS(startLocation);

            lstGraphResults.Items.Clear();

            if (results.Count == 0)
            {
                lstGraphResults.Items.Add("No locations found.");
                return;
            }

            lstGraphResults.Items.Add("Breadth-First Search Results:");

            foreach (string location in results)
            {
                lstGraphResults.Items.Add(location);
            }
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            string startLocation = txtStartLocation.Text.Trim();

            if (string.IsNullOrWhiteSpace(startLocation))
            {
                MessageBox.Show("Please enter a starting location.");
                return;
            }

            List<string> results =
                ServiceRequestRepository.GetLocationsDFS(startLocation);

            lstGraphResults.Items.Clear();

            if (results.Count == 0)
            {
                lstGraphResults.Items.Add("No locations found.");
                return;
            }

            lstGraphResults.Items.Add("Depth-First Search Results:");

            foreach (string location in results)
            {
                lstGraphResults.Items.Add(location);
            }
        }

        private void btnMST_Click(object sender, EventArgs e)
        {
            string startLocation = txtStartLocation.Text.Trim();

            if (string.IsNullOrWhiteSpace(startLocation))
            {
                MessageBox.Show("Please enter a starting location.");
                return;
            }

            List<ServiceRequestGraph.Edge> results =
                ServiceRequestRepository.GetMinimumSpanningTree(startLocation);

            lstGraphResults.Items.Clear();

            if (results.Count == 0)
            {
                lstGraphResults.Items.Add("No connections found for this location.");
                return;
            }

            lstGraphResults.Items.Add("Minimum Spanning Tree Results:");

            foreach (ServiceRequestGraph.Edge edge in results)
            {
                lstGraphResults.Items.Add(
                    edge.Destination + " (Weight: " + edge.Weight + ")");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
    
}
