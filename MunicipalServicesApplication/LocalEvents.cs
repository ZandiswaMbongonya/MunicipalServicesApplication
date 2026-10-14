using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApplication
{
    public partial class LocalEvents : Form
    {
        private EventManager eventManager;

        public LocalEvents()
        {
            InitializeComponent();

            eventManager = new EventManager();

            LoadCategories();
            LoadUpcomingEvents();

            // Make sure the date is today's date.
            dtpDate.Value = DateTime.Today;
        }

        // Load unique categories from the HashSet.
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("All Categories");

            foreach (string category in eventManager.Categories.OrderBy(c => c))
            {
                cmbCategory.Items.Add(category);
            }

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }
        }

        // Display upcoming events when the form opens.
        private void LoadUpcomingEvents()
        {
            lstEvents.Items.Clear();

            DateTime today = DateTime.Today;

            // Create a copy of the Queue so the original queue is not emptied.
            Queue<MunicipalEvent> upcomingQueue =
                new Queue<MunicipalEvent>(eventManager.UpcomingEvents);

            List<MunicipalEvent> upcomingEvents =
                new List<MunicipalEvent>();

            // Process the queue in FIFO order.
            while (upcomingQueue.Count > 0)
            {
                MunicipalEvent municipalEvent =
                    upcomingQueue.Dequeue();

                if (municipalEvent.Date.Date >= today)
                {
                    upcomingEvents.Add(municipalEvent);
                }
            }

            // Display upcoming events in date order.
            upcomingEvents = upcomingEvents
                .OrderBy(e => e.Date)
                .ThenBy(e => e.Priority)
                .ToList();

            if (upcomingEvents.Count == 0)
            {
                lstEvents.Items.Add(
                    "No upcoming events are currently available.");
                return;
            }

            foreach (MunicipalEvent municipalEvent in upcomingEvents)
            {
                lstEvents.Items.Add(
                    FormatEvent(municipalEvent));
            }
        }
        // Search events using category and date.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedCategory =
                cmbCategory.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedCategory))
            {
                MessageBox.Show(
                    "Please select an event category.",
                    "Category Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategory.Focus();
                return;
            }

            DateTime selectedDate = dtpDate.Value.Date;

            List<MunicipalEvent> results =
                eventManager.SearchEvents(
                    selectedCategory,
                    selectedDate);

            // Record the user's category search.
            if (selectedCategory != "All Categories")
            {
                eventManager.RecordSearch(selectedCategory, selectedDate);
            }

            lstEvents.Items.Clear();

            if (results.Count == 0)
            {
                lstEvents.Items.Add(
                    "No events were found for the selected category and date.");

                LoadRecommendations();
                return;
            }

            foreach (MunicipalEvent municipalEvent in results)
            {
                lstEvents.Items.Add(FormatEvent(municipalEvent));
            }

            LoadRecommendations();
        }

        // Display recommendations based on search history.
        private void LoadRecommendations()
        {
            lstRecommendations.Items.Clear();

            List<MunicipalEvent> recommendations =
                eventManager.GetRecommendations();

            if (recommendations.Count == 0)
            {
                lstRecommendations.Items.Add(
                    "Search for events to receive recommendations.");
                return;
            }

            foreach (MunicipalEvent municipalEvent in recommendations)
            {
                lstRecommendations.Items.Add(
                    FormatEvent(municipalEvent));
            }
        }

        // Formats event information for display.
        private string FormatEvent(MunicipalEvent municipalEvent)
        {
            return municipalEvent.Name
                + " | "
                + municipalEvent.Date.ToString("dd/MM/yyyy")
                + " | "
                + municipalEvent.Category
                + " | "
                + municipalEvent.Location;
        }

        // Clear the search and restore upcoming events.

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset the search filters.
            cmbCategory.SelectedIndex = 0;
            dtpDate.Value = DateTime.Today;

            // Clear previous search results.
            lstEvents.Items.Clear();
            lstRecommendations.Items.Clear();

            // Restore the upcoming events.
            LoadUpcomingEvents();

            // Reset the recommendations message.
            lstRecommendations.Items.Add(
                "Search for events to receive recommendations.");

            // Clear the priority display.
            lstPriority.Items.Clear();
        }


        // Existing category event.
        private void cmbCategory_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // The actual search is performed using the Search Events button.
        }

        // Return to the main menu.

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProcessPriority_Click(object sender, EventArgs e)
        {
            MunicipalEvent nextEvent =
        eventManager.DequeueHighestPriority();

            lstPriority.Items.Clear();

            if (nextEvent == null)
            {
                lstPriority.Items.Add(
                    "No more priority events are available.");
                return;
            }

            lstPriority.Items.Add(
                FormatEvent(nextEvent)
                + " | Priority: "
                + nextEvent.Priority);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblResults_Click(object sender, EventArgs e)
        {

        }

        private void lblPriority_Click(object sender, EventArgs e)
        {

        }
    }
}