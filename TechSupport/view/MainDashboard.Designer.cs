
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
            this.AllIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.SearchIncidentTabPage = new System.Windows.Forms.TabPage();
            this.DisplayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.logoutLabel = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addIncidentUserControl2 = new TechSupport.UserControls.AddIncidentUserControl();
            this.allIncidentsUserControl1 = new TechSupport.UserControls.AllIncidentsUserControl();
            this.searchIncidentUserControl1 = new TechSupport.UserControls.SearchIncidentUserControl();
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.displayOpenIncidentsUserControl1 = new TechSupport.UserControls.DisplayOpenIncidentsUserControl();
            this.MainDashboardTabControl.SuspendLayout();
            this.AddIncidentTabPage.SuspendLayout();
            this.AllIncidentsTabPage.SuspendLayout();
            this.SearchIncidentTabPage.SuspendLayout();
            this.DisplayOpenIncidentsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDashboardTabControl
            // 
            this.MainDashboardTabControl.Controls.Add(this.AddIncidentTabPage);
            this.MainDashboardTabControl.Controls.Add(this.AllIncidentsTabPage);
            this.MainDashboardTabControl.Controls.Add(this.SearchIncidentTabPage);
            this.MainDashboardTabControl.Controls.Add(this.DisplayOpenIncidentsTabPage);
            this.MainDashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainDashboardTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainDashboardTabControl.Name = "MainDashboardTabControl";
            this.MainDashboardTabControl.SelectedIndex = 0;
            this.MainDashboardTabControl.Size = new System.Drawing.Size(801, 470);
            this.MainDashboardTabControl.TabIndex = 0;
            this.MainDashboardTabControl.SelectedIndexChanged += new System.EventHandler(this.LoadIncidents);
            // 
            // AddIncidentTabPage
            // 
            this.AddIncidentTabPage.Controls.Add(this.addIncidentUserControl2);
            this.AddIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.AddIncidentTabPage.Name = "AddIncidentTabPage";
            this.AddIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddIncidentTabPage.Size = new System.Drawing.Size(793, 437);
            this.AddIncidentTabPage.TabIndex = 0;
            this.AddIncidentTabPage.Text = "Add Incident";
            this.AddIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // AllIncidentsTabPage
            // 
            this.AllIncidentsTabPage.Controls.Add(this.allIncidentsUserControl1);
            this.AllIncidentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.AllIncidentsTabPage.Name = "AllIncidentsTabPage";
            this.AllIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AllIncidentsTabPage.Size = new System.Drawing.Size(793, 437);
            this.AllIncidentsTabPage.TabIndex = 1;
            this.AllIncidentsTabPage.Text = "All Incidents";
            this.AllIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchIncidentTabPage
            // 
            this.SearchIncidentTabPage.Controls.Add(this.searchIncidentUserControl1);
            this.SearchIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.SearchIncidentTabPage.Name = "SearchIncidentTabPage";
            this.SearchIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchIncidentTabPage.Size = new System.Drawing.Size(793, 437);
            this.SearchIncidentTabPage.TabIndex = 2;
            this.SearchIncidentTabPage.Text = "Search Incident";
            this.SearchIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // DisplayOpenIncidentsTabPage
            // 
            this.DisplayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentsUserControl1);
            this.DisplayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.DisplayOpenIncidentsTabPage.Name = "DisplayOpenIncidentsTabPage";
            this.DisplayOpenIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DisplayOpenIncidentsTabPage.Size = new System.Drawing.Size(793, 437);
            this.DisplayOpenIncidentsTabPage.TabIndex = 3;
            this.DisplayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.DisplayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.logoutLabel.Location = new System.Drawing.Point(694, 9);
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
            this.usernameLabel.Location = new System.Drawing.Point(619, 9);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 25);
            this.usernameLabel.TabIndex = 2;
            // 
            // addIncidentUserControl2
            // 
            this.addIncidentUserControl2.Location = new System.Drawing.Point(-138, 8);
            this.addIncidentUserControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addIncidentUserControl2.Name = "addIncidentUserControl2";
            this.addIncidentUserControl2.Size = new System.Drawing.Size(906, 425);
            this.addIncidentUserControl2.TabIndex = 0;
            // 
            // allIncidentsUserControl1
            // 
            this.allIncidentsUserControl1.Location = new System.Drawing.Point(-83, -51);
            this.allIncidentsUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allIncidentsUserControl1.Name = "allIncidentsUserControl1";
            this.allIncidentsUserControl1.Size = new System.Drawing.Size(880, 501);
            this.allIncidentsUserControl1.TabIndex = 0;
            // 
            // searchIncidentUserControl1
            // 
            this.searchIncidentUserControl1.Location = new System.Drawing.Point(-224, -168);
            this.searchIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchIncidentUserControl1.Name = "searchIncidentUserControl1";
            this.searchIncidentUserControl1.Size = new System.Drawing.Size(1020, 609);
            this.searchIncidentUserControl1.TabIndex = 0;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Location = new System.Drawing.Point(-143, 8);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(940, 397);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // displayOpenIncidentsUserControl1
            // 
            this.displayOpenIncidentsUserControl1.Location = new System.Drawing.Point(15, 18);
            this.displayOpenIncidentsUserControl1.Name = "displayOpenIncidentsUserControl1";
            this.displayOpenIncidentsUserControl1.Size = new System.Drawing.Size(754, 413);
            this.displayOpenIncidentsUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 509);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.MainDashboardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApplicationClose);
            this.MainDashboardTabControl.ResumeLayout(false);
            this.AddIncidentTabPage.ResumeLayout(false);
            this.AllIncidentsTabPage.ResumeLayout(false);
            this.SearchIncidentTabPage.ResumeLayout(false);
            this.DisplayOpenIncidentsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainDashboardTabControl;
        private System.Windows.Forms.TabPage AddIncidentTabPage;
        private System.Windows.Forms.TabPage AllIncidentsTabPage;
        private System.Windows.Forms.TabPage SearchIncidentTabPage;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
        private UserControls.AddIncidentUserControl addIncidentUserControl2;
        private UserControls.AllIncidentsUserControl allIncidentsUserControl1;
        private UserControls.SearchIncidentUserControl searchIncidentUserControl1;
        private System.Windows.Forms.LinkLabel logoutLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TabPage DisplayOpenIncidentsTabPage;
        private UserControls.DisplayOpenIncidentsUserControl displayOpenIncidentsUserControl1;
    }
}