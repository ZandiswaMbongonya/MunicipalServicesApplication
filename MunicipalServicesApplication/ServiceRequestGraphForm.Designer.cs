namespace MunicipalServicesApplication
{
    partial class ServiceRequestGraphForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGraphTitle = new System.Windows.Forms.Label();
            this.lblLocation1 = new System.Windows.Forms.Label();
            this.lblLocation2 = new System.Windows.Forms.Label();
            this.txtLocation1 = new System.Windows.Forms.TextBox();
            this.txtLocation2 = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnMST = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lstGraphResults = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGraphTitle
            // 
            this.lblGraphTitle.AutoSize = true;
            this.lblGraphTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblGraphTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphTitle.ForeColor = System.Drawing.Color.White;
            this.lblGraphTitle.Location = new System.Drawing.Point(12, 23);
            this.lblGraphTitle.Name = "lblGraphTitle";
            this.lblGraphTitle.Size = new System.Drawing.Size(650, 46);
            this.lblGraphTitle.TabIndex = 0;
            this.lblGraphTitle.Text = "Municipal Service Location Graph";
            this.lblGraphTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLocation1
            // 
            this.lblLocation1.AutoSize = true;
            this.lblLocation1.Location = new System.Drawing.Point(15, 102);
            this.lblLocation1.Name = "lblLocation1";
            this.lblLocation1.Size = new System.Drawing.Size(87, 20);
            this.lblLocation1.TabIndex = 1;
            this.lblLocation1.Text = "Location 1:";
            // 
            // lblLocation2
            // 
            this.lblLocation2.AutoSize = true;
            this.lblLocation2.Location = new System.Drawing.Point(15, 161);
            this.lblLocation2.Name = "lblLocation2";
            this.lblLocation2.Size = new System.Drawing.Size(87, 20);
            this.lblLocation2.TabIndex = 2;
            this.lblLocation2.Text = "Location 2:";
            // 
            // txtLocation1
            // 
            this.txtLocation1.Location = new System.Drawing.Point(225, 99);
            this.txtLocation1.Name = "txtLocation1";
            this.txtLocation1.Size = new System.Drawing.Size(258, 26);
            this.txtLocation1.TabIndex = 3;
            // 
            // txtLocation2
            // 
            this.txtLocation2.Location = new System.Drawing.Point(225, 161);
            this.txtLocation2.Name = "txtLocation2";
            this.txtLocation2.Size = new System.Drawing.Size(258, 26);
            this.txtLocation2.TabIndex = 4;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 229);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(148, 20);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Connection Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(225, 215);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(258, 26);
            this.txtWeight.TabIndex = 6;
            this.txtWeight.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(16, 271);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(754, 47);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect Locations";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Location = new System.Drawing.Point(12, 363);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(134, 20);
            this.lblStartLocation.TabIndex = 8;
            this.lblStartLocation.Text = "Starting Location:";
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Location = new System.Drawing.Point(225, 357);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(258, 26);
            this.txtStartLocation.TabIndex = 9;
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFS.ForeColor = System.Drawing.Color.White;
            this.btnBFS.Location = new System.Drawing.Point(16, 407);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(240, 64);
            this.btnBFS.TabIndex = 10;
            this.btnBFS.Text = "Breadth-First Search";
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFS.ForeColor = System.Drawing.Color.White;
            this.btnDFS.Location = new System.Drawing.Point(279, 407);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(237, 64);
            this.btnDFS.TabIndex = 11;
            this.btnDFS.Text = "Depth-First Search";
            this.btnDFS.UseVisualStyleBackColor = false;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnMST
            // 
            this.btnMST.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMST.ForeColor = System.Drawing.Color.White;
            this.btnMST.Location = new System.Drawing.Point(535, 407);
            this.btnMST.Name = "btnMST";
            this.btnMST.Size = new System.Drawing.Size(264, 64);
            this.btnMST.TabIndex = 12;
            this.btnMST.Text = "Minimum Spanning Tree";
            this.btnMST.UseVisualStyleBackColor = false;
            this.btnMST.Click += new System.EventHandler(this.btnMST_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(12, 526);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(116, 20);
            this.lblResults.TabIndex = 13;
            this.lblResults.Text = "Graph Results:";
            // 
            // lstGraphResults
            // 
            this.lstGraphResults.FormattingEnabled = true;
            this.lstGraphResults.ItemHeight = 20;
            this.lstGraphResults.Location = new System.Drawing.Point(151, 495);
            this.lstGraphResults.Name = "lstGraphResults";
            this.lstGraphResults.Size = new System.Drawing.Size(619, 84);
            this.lstGraphResults.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 605);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(758, 57);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ServiceRequestGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstGraphResults);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnMST);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.lblStartLocation);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtLocation2);
            this.Controls.Add(this.txtLocation1);
            this.Controls.Add(this.lblLocation2);
            this.Controls.Add(this.lblLocation1);
            this.Controls.Add(this.lblGraphTitle);
            this.Name = "ServiceRequestGraphForm";
            this.Text = "ServiceRequestGraphForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGraphTitle;
        private System.Windows.Forms.Label lblLocation1;
        private System.Windows.Forms.Label lblLocation2;
        private System.Windows.Forms.TextBox txtLocation1;
        private System.Windows.Forms.TextBox txtLocation2;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnMST;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.ListBox lstGraphResults;
        private System.Windows.Forms.Button btnBack;
    }
}