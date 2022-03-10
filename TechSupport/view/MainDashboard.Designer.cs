﻿
namespace TechSupport.view
{
    partial class MainDashboard
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
            this.MainDashboardTabControl = new System.Windows.Forms.TabControl();
            this.AddIncidentTabPage = new System.Windows.Forms.TabPage();
            this.DisplayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.incidentsByTechnician = new System.Windows.Forms.TabPage();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addIncidentUserControl3 = new TechSupport.UserControls.AddIncidentUserControl();
            this.displayOpenIncidentsUserControl = new TechSupport.UserControls.DisplayOpenIncidentsUserControl();
            this.updateIncidentUserControl1 = new TechSupport.UserControls.UpdateIncidentUserControl();
            this.incidentsByTechnician1 = new TechSupport.UserControls.IncidentsByTechnicianUserControl();
            this.MainDashboardTabControl.SuspendLayout();
            this.AddIncidentTabPage.SuspendLayout();
            this.DisplayOpenIncidentsTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.incidentsByTechnician.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDashboardTabControl
            // 
            this.MainDashboardTabControl.Controls.Add(this.AddIncidentTabPage);
            this.MainDashboardTabControl.Controls.Add(this.DisplayOpenIncidentsTabPage);
            this.MainDashboardTabControl.Controls.Add(this.tabPage1);
            this.MainDashboardTabControl.Controls.Add(this.incidentsByTechnician);
            this.MainDashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainDashboardTabControl.Location = new System.Drawing.Point(1, 12);
            this.MainDashboardTabControl.Name = "MainDashboardTabControl";
            this.MainDashboardTabControl.SelectedIndex = 0;
            this.MainDashboardTabControl.Size = new System.Drawing.Size(909, 965);
            this.MainDashboardTabControl.TabIndex = 0;
            this.MainDashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.LoadIncidents);
            this.MainDashboardTabControl.TabIndexChanged += new System.EventHandler(this.LoadIncidents);
            // 
            // AddIncidentTabPage
            // 
            this.AddIncidentTabPage.Controls.Add(this.addIncidentUserControl3);
            this.AddIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.AddIncidentTabPage.Name = "AddIncidentTabPage";
            this.AddIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddIncidentTabPage.Size = new System.Drawing.Size(901, 932);
            this.AddIncidentTabPage.TabIndex = 0;
            this.AddIncidentTabPage.Text = "Add Incident";
            this.AddIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // DisplayOpenIncidentsTabPage
            // 
            this.DisplayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentsUserControl);
            this.DisplayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.DisplayOpenIncidentsTabPage.Name = "DisplayOpenIncidentsTabPage";
            this.DisplayOpenIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DisplayOpenIncidentsTabPage.Size = new System.Drawing.Size(901, 932);
            this.DisplayOpenIncidentsTabPage.TabIndex = 3;
            this.DisplayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.DisplayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.updateIncidentUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 932);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Update Incident";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // incidentsByTechnician
            // 
            this.incidentsByTechnician.Controls.Add(this.incidentsByTechnician1);
            this.incidentsByTechnician.Location = new System.Drawing.Point(4, 29);
            this.incidentsByTechnician.Name = "incidentsByTechnician";
            this.incidentsByTechnician.Padding = new System.Windows.Forms.Padding(3);
            this.incidentsByTechnician.Size = new System.Drawing.Size(901, 932);
            this.incidentsByTechnician.TabIndex = 5;
            this.incidentsByTechnician.Text = "View Incidents by Technician";
            this.incidentsByTechnician.UseVisualStyleBackColor = true;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.logoutLabel.Location = new System.Drawing.Point(828, 9);
            this.logoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(82, 25);
            this.logoutLabel.TabIndex = 3;
            this.logoutLabel.TabStop = true;
            this.logoutLabel.Text = "Log Out";
            this.logoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameLabel.Location = new System.Drawing.Point(753, 9);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 25);
            this.usernameLabel.TabIndex = 2;
            // 
            // addIncidentUserControl3
            // 
            this.addIncidentUserControl3.Location = new System.Drawing.Point(-33, 138);
            this.addIncidentUserControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addIncidentUserControl3.Name = "addIncidentUserControl3";
            this.addIncidentUserControl3.Size = new System.Drawing.Size(886, 707);
            this.addIncidentUserControl3.TabIndex = 0;
            // 
            // displayOpenIncidentsUserControl
            // 
            this.displayOpenIncidentsUserControl.Location = new System.Drawing.Point(77, 189);
            this.displayOpenIncidentsUserControl.Name = "displayOpenIncidentsUserControl";
            this.displayOpenIncidentsUserControl.Size = new System.Drawing.Size(754, 480);
            this.displayOpenIncidentsUserControl.TabIndex = 0;
            // 
            // updateIncidentUserControl1
            // 
            this.updateIncidentUserControl1.Location = new System.Drawing.Point(10, -24);
            this.updateIncidentUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.updateIncidentUserControl1.Name = "updateIncidentUserControl1";
            this.updateIncidentUserControl1.Size = new System.Drawing.Size(1246, 1511);
            this.updateIncidentUserControl1.TabIndex = 1;
            // 
            // incidentsByTechnician1
            // 
            this.incidentsByTechnician1.Location = new System.Drawing.Point(-136, 24);
            this.incidentsByTechnician1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incidentsByTechnician1.Name = "incidentsByTechnician1";
            this.incidentsByTechnician1.Size = new System.Drawing.Size(1052, 890);
            this.incidentsByTechnician1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 1013);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.MainDashboardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApplicationClose);
            this.MainDashboardTabControl.ResumeLayout(false);
            this.AddIncidentTabPage.ResumeLayout(false);
            this.DisplayOpenIncidentsTabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.incidentsByTechnician.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainDashboardTabControl;
        private System.Windows.Forms.TabPage AddIncidentTabPage;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TabPage DisplayOpenIncidentsTabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControls.AddIncidentUserControl addIncidentUserControl3;
        private UserControls.DisplayOpenIncidentsUserControl displayOpenIncidentsUserControl;
        private UserControls.UpdateIncidentUserControl updateIncidentUserControl1;
        private System.Windows.Forms.TabPage incidentsByTechnician;
        private UserControls.IncidentsByTechnicianUserControl incidentsByTechnician1;
    }
}