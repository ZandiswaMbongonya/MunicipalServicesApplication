using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesApplication
{
    public partial class LocalEvents : Form
    {
        private Dictionary<string, List<string>> events =
            new Dictionary<string, List<string>>();

        public LocalEvents()
        {
            InitializeComponent();

            LoadEvents();
            LoadCategories();
        }

        private void LoadEvents()
        {
            events.Add("Community", new List<string>
            {
                "Community Clean-Up Day - Saturday at 09:00",
                "Community Meeting - Monday at 18:00"
            });

            events.Add("Sports", new List<string>
            {
                "Local Soccer Tournament - Saturday at 10:00",
                "Community Fun Run - Sunday at 07:00"
            });

            events.Add("Health", new List<string>
            {
                "Free Health Screening - Friday from 09:00",
                "Blood Donation Drive - Wednesday from 10:00"
            });
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Add("Community");
            cmbCategory.Items.Add("Sports");
            cmbCategory.Items.Add("Health");
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstEvents.Items.Clear();

            string selectedCategory = cmbCategory.SelectedItem.ToString();

            if (events.ContainsKey(selectedCategory))
            {
                foreach (string eventItem in events[selectedCategory])
                {
                    lstEvents.Items.Add(eventItem);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}