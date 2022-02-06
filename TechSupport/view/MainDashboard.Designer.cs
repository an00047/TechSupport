
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
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.AllIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchIncidentTabPage = new System.Windows.Forms.TabPage();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchIncidentTextbox = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.SearchIncidentDataGridView = new System.Windows.Forms.DataGridView();
            this.MainDashboardTabControl.SuspendLayout();
            this.AddIncidentTabPage.SuspendLayout();
            this.AllIncidentsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            this.SearchIncidentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIncidentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDashboardTabControl
            // 
            this.MainDashboardTabControl.Controls.Add(this.AddIncidentTabPage);
            this.MainDashboardTabControl.Controls.Add(this.AllIncidentsTabPage);
            this.MainDashboardTabControl.Controls.Add(this.SearchIncidentTabPage);
            this.MainDashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainDashboardTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainDashboardTabControl.Name = "MainDashboardTabControl";
            this.MainDashboardTabControl.SelectedIndex = 0;
            this.MainDashboardTabControl.Size = new System.Drawing.Size(801, 470);
            this.MainDashboardTabControl.TabIndex = 0;
            // 
            // AddIncidentTabPage
            // 
            this.AddIncidentTabPage.Controls.Add(this.addIncidentUserControl1);
            this.AddIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.AddIncidentTabPage.Name = "AddIncidentTabPage";
            this.AddIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddIncidentTabPage.Size = new System.Drawing.Size(793, 437);
            this.AddIncidentTabPage.TabIndex = 0;
            this.AddIncidentTabPage.Text = "Add Incident";
            this.AddIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Location = new System.Drawing.Point(-143, 8);
            this.addIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(940, 397);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // AllIncidentsTabPage
            // 
            this.AllIncidentsTabPage.Controls.Add(this.incidentDataGridView);
            this.AllIncidentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.AllIncidentsTabPage.Name = "AllIncidentsTabPage";
            this.AllIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AllIncidentsTabPage.Size = new System.Drawing.Size(793, 437);
            this.AllIncidentsTabPage.TabIndex = 1;
            this.AllIncidentsTabPage.Text = "All Incidents";
            this.AllIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentDataGridView.Location = new System.Drawing.Point(7, 69);
            this.incidentDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.Size = new System.Drawing.Size(561, 240);
            this.incidentDataGridView.TabIndex = 3;
            // 
            // SearchIncidentTabPage
            // 
            this.SearchIncidentTabPage.Controls.Add(this.CancelButton);
            this.SearchIncidentTabPage.Controls.Add(this.SearchButton);
            this.SearchIncidentTabPage.Controls.Add(this.SearchIncidentTextbox);
            this.SearchIncidentTabPage.Controls.Add(this.CustomerIDLabel);
            this.SearchIncidentTabPage.Controls.Add(this.SearchIncidentDataGridView);
            this.SearchIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.SearchIncidentTabPage.Name = "SearchIncidentTabPage";
            this.SearchIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchIncidentTabPage.Size = new System.Drawing.Size(793, 437);
            this.SearchIncidentTabPage.TabIndex = 2;
            this.SearchIncidentTabPage.Text = "Search Incident";
            this.SearchIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CancelButton.Location = new System.Drawing.Point(419, 327);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 37);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchButton.Location = new System.Drawing.Point(419, 11);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 37);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchIncidentTextbox
            // 
            this.SearchIncidentTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchIncidentTextbox.Location = new System.Drawing.Point(174, 14);
            this.SearchIncidentTextbox.Name = "SearchIncidentTextbox";
            this.SearchIncidentTextbox.Size = new System.Drawing.Size(227, 30);
            this.SearchIncidentTextbox.TabIndex = 10;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CustomerIDLabel.Location = new System.Drawing.Point(47, 19);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(121, 25);
            this.CustomerIDLabel.TabIndex = 11;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // SearchIncidentDataGridView
            // 
            this.SearchIncidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchIncidentDataGridView.Location = new System.Drawing.Point(47, 56);
            this.SearchIncidentDataGridView.Name = "SearchIncidentDataGridView";
            this.SearchIncidentDataGridView.Size = new System.Drawing.Size(483, 263);
            this.SearchIncidentDataGridView.TabIndex = 9;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 505);
            this.Controls.Add(this.MainDashboardTabControl);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ApplicationClose);
            this.MainDashboardTabControl.ResumeLayout(false);
            this.AddIncidentTabPage.ResumeLayout(false);
            this.AllIncidentsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            this.SearchIncidentTabPage.ResumeLayout(false);
            this.SearchIncidentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIncidentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainDashboardTabControl;
        private System.Windows.Forms.TabPage AddIncidentTabPage;
        private System.Windows.Forms.TabPage AllIncidentsTabPage;
        private System.Windows.Forms.TabPage SearchIncidentTabPage;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchIncidentTextbox;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.DataGridView SearchIncidentDataGridView;
        private System.Windows.Forms.DataGridView incidentDataGridView;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
    }
}