namespace MunicipalServicesApplication
{
    partial class LocalEvents
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRecommendations = new System.Windows.Forms.ListBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lstPriority = new System.Windows.Forms.ListBox();
            this.btnProcessPriority = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(150, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(456, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Local Events and Announcements";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(27, 120);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(134, 21);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Select Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(197, 120);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(224, 29);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lstEvents
            // 
            this.lstEvents.BackColor = System.Drawing.Color.White;
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 21;
            this.lstEvents.Location = new System.Drawing.Point(31, 344);
            this.lstEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(444, 88);
            this.lstEvents.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(279, 575);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(247, 33);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(197, 172);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(221, 29);
            this.dtpDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(27, 180);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 21);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Select Date:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(197, 248);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 38);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Events";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Navy;
            this.btnClear.Location = new System.Drawing.Point(370, 248);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 38);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.Navy;
            this.lblResults.Location = new System.Drawing.Point(31, 314);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(444, 30);
            this.lblResults.TabIndex = 9;
            this.lblResults.Text = "Search Results";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResults.Click += new System.EventHandler(this.lblResults_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(512, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recommended For You";
            // 
            // lstRecommendations
            // 
            this.lstRecommendations.BackColor = System.Drawing.Color.White;
            this.lstRecommendations.FormattingEnabled = true;
            this.lstRecommendations.ItemHeight = 21;
            this.lstRecommendations.Location = new System.Drawing.Point(512, 344);
            this.lstRecommendations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstRecommendations.Name = "lstRecommendations";
            this.lstRecommendations.Size = new System.Drawing.Size(389, 88);
            this.lstRecommendations.TabIndex = 11;
            // 
            // lblPriority
            // 
            this.lblPriority.BackColor = System.Drawing.Color.Gold;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.ForeColor = System.Drawing.Color.Black;
            this.lblPriority.Location = new System.Drawing.Point(26, 455);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(870, 30);
            this.lblPriority.TabIndex = 12;
            this.lblPriority.Text = "Next Priority Event:";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPriority.Click += new System.EventHandler(this.lblPriority_Click);
            // 
            // lstPriority
            // 
            this.lstPriority.BackColor = System.Drawing.Color.Cornsilk;
            this.lstPriority.ForeColor = System.Drawing.Color.Black;
            this.lstPriority.FormattingEnabled = true;
            this.lstPriority.ItemHeight = 21;
            this.lstPriority.Location = new System.Drawing.Point(26, 489);
            this.lstPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstPriority.Name = "lstPriority";
            this.lstPriority.Size = new System.Drawing.Size(870, 67);
            this.lstPriority.TabIndex = 13;
            this.lstPriority.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnProcessPriority
            // 
            this.btnProcessPriority.BackColor = System.Drawing.Color.Goldenrod;
            this.btnProcessPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPriority.ForeColor = System.Drawing.Color.Black;
            this.btnProcessPriority.Location = new System.Drawing.Point(26, 575);
            this.btnProcessPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProcessPriority.Name = "btnProcessPriority";
            this.btnProcessPriority.Size = new System.Drawing.Size(247, 33);
            this.btnProcessPriority.TabIndex = 14;
            this.btnProcessPriority.Text = "Process Next Priority Event";
            this.btnProcessPriority.UseVisualStyleBackColor = false;
            this.btnProcessPriority.Click += new System.EventHandler(this.btnProcessPriority_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 55);
            this.pnlHeader.TabIndex = 15;
            // 
            // LocalEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(953, 631);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnProcessPriority);
            this.Controls.Add(this.lstPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lstRecommendations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "LocalEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Events and Announcements";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRecommendations;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ListBox lstPriority;
        private System.Windows.Forms.Button btnProcessPriority;
        private System.Windows.Forms.Panel pnlHeader;
    }
}