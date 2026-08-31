namespace MunicipalServicesApplication
{
    partial class ServiceRequestStatus
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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(250, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Service Request Status";

            // lblRequestID
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Location = new System.Drawing.Point(250, 130);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(110, 20);
            this.lblRequestID.TabIndex = 1;
            this.lblRequestID.Text = "Enter Request ID:";

            // txtRequestID
            this.txtRequestID.Location = new System.Drawing.Point(430, 125);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(150, 27);
            this.txtRequestID.TabIndex = 2;

            // btnCheckStatus
            this.btnCheckStatus.Location = new System.Drawing.Point(350, 190);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(130, 40);
            this.btnCheckStatus.TabIndex = 3;
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(250, 270);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";

            // btnBack
            this.btnBack.Location = new System.Drawing.Point(350, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // ServiceRequestStatus
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);

            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.txtRequestID);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.lblTitle);

            this.Name = "ServiceRequestStatus";
            this.Text = "Service Request Status";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnBack;
    }
}