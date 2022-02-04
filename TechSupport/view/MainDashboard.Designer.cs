
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchIncidentTextbox = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.SearchIncidentDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.incidentDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.incidentTitleLabel = new System.Windows.Forms.Label();
            this.incidentDescriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.incidentTitleTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            this.MainDashboardTabControl.SuspendLayout();
            this.AddIncidentTabPage.SuspendLayout();
            this.AllIncidentsTabPage.SuspendLayout();
            this.SearchIncidentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIncidentDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
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
            this.MainDashboardTabControl.Size = new System.Drawing.Size(585, 407);
            this.MainDashboardTabControl.TabIndex = 0;
            // 
            // AddIncidentTabPage
            // 
            this.AddIncidentTabPage.Controls.Add(this.tableLayoutPanel1);
            this.AddIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.AddIncidentTabPage.Name = "AddIncidentTabPage";
            this.AddIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddIncidentTabPage.Size = new System.Drawing.Size(577, 374);
            this.AddIncidentTabPage.TabIndex = 0;
            this.AddIncidentTabPage.Text = "Add Incident";
            this.AddIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // AllIncidentsTabPage
            // 
            this.AllIncidentsTabPage.Controls.Add(this.incidentDataGridView);
            this.AllIncidentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.AllIncidentsTabPage.Name = "AllIncidentsTabPage";
            this.AllIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AllIncidentsTabPage.Size = new System.Drawing.Size(577, 374);
            this.AllIncidentsTabPage.TabIndex = 1;
            this.AllIncidentsTabPage.Text = "All Incidents";
            this.AllIncidentsTabPage.UseVisualStyleBackColor = true;
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
            this.SearchIncidentTabPage.Size = new System.Drawing.Size(577, 374);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.18228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.81772F));
            this.tableLayoutPanel1.Controls.Add(this.customerIDTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.incidentDescriptionTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.incidentTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.incidentDescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.incidentTitleTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-5, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.53764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.46236F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 246);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.customerIDTextBox.Location = new System.Drawing.Point(229, 106);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(347, 30);
            this.customerIDTextBox.TabIndex = 3;
            // 
            // incidentDescriptionTextBox
            // 
            this.incidentDescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidentDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.incidentDescriptionTextBox.Location = new System.Drawing.Point(229, 58);
            this.incidentDescriptionTextBox.Name = "incidentDescriptionTextBox";
            this.incidentDescriptionTextBox.Size = new System.Drawing.Size(347, 30);
            this.incidentDescriptionTextBox.TabIndex = 2;
            // 
            // incidentTitleLabel
            // 
            this.incidentTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.incidentTitleLabel.AutoSize = true;
            this.incidentTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.incidentTitleLabel.Location = new System.Drawing.Point(101, 12);
            this.incidentTitleLabel.Name = "incidentTitleLabel";
            this.incidentTitleLabel.Size = new System.Drawing.Size(122, 25);
            this.incidentTitleLabel.TabIndex = 0;
            this.incidentTitleLabel.Text = "Incident Title";
            // 
            // incidentDescriptionLabel
            // 
            this.incidentDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.incidentDescriptionLabel.AutoSize = true;
            this.incidentDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.incidentDescriptionLabel.Location = new System.Drawing.Point(41, 60);
            this.incidentDescriptionLabel.Name = "incidentDescriptionLabel";
            this.incidentDescriptionLabel.Size = new System.Drawing.Size(182, 25);
            this.incidentDescriptionLabel.TabIndex = 1;
            this.incidentDescriptionLabel.Text = "Incident Description";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(102, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // incidentTitleTextBox
            // 
            this.incidentTitleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidentTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.incidentTitleTextBox.Location = new System.Drawing.Point(229, 9);
            this.incidentTitleTextBox.Name = "incidentTitleTextBox";
            this.incidentTitleTextBox.Size = new System.Drawing.Size(347, 30);
            this.incidentTitleTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(93, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddButton.Location = new System.Drawing.Point(229, 170);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(130, 50);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
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
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 431);
            this.Controls.Add(this.MainDashboardTabControl);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.MainDashboardTabControl.ResumeLayout(false);
            this.AddIncidentTabPage.ResumeLayout(false);
            this.AllIncidentsTabPage.ResumeLayout(false);
            this.SearchIncidentTabPage.ResumeLayout(false);
            this.SearchIncidentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIncidentDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox incidentDescriptionTextBox;
        private System.Windows.Forms.Label incidentTitleLabel;
        private System.Windows.Forms.Label incidentDescriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox incidentTitleTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView incidentDataGridView;
    }
}