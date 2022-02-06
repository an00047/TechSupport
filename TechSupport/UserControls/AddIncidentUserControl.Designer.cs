
namespace TechSupport.UserControls
{
    partial class AddIncidentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.incidentDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.incidentTitleLabel = new System.Windows.Forms.Label();
            this.incidentDescriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.incidentTitleTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.customerIDTextBox.Location = new System.Drawing.Point(229, 101);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(347, 30);
            this.customerIDTextBox.TabIndex = 3;
            // 
            // incidentDescriptionTextBox
            // 
            this.incidentDescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidentDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.incidentDescriptionTextBox.Location = new System.Drawing.Point(229, 57);
            this.incidentDescriptionTextBox.Name = "incidentDescriptionTextBox";
            this.incidentDescriptionTextBox.Size = new System.Drawing.Size(347, 30);
            this.incidentDescriptionTextBox.TabIndex = 2;
            // 
            // incidentTitleLabel
            // 
            this.incidentTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.incidentTitleLabel.AutoSize = true;
            this.incidentTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.incidentTitleLabel.Location = new System.Drawing.Point(101, 14);
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
            this.label1.Location = new System.Drawing.Point(102, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // incidentTitleTextBox
            // 
            this.incidentTitleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.incidentTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.incidentTitleTextBox.Location = new System.Drawing.Point(229, 11);
            this.incidentTitleTextBox.Name = "incidentTitleTextBox";
            this.incidentTitleTextBox.Size = new System.Drawing.Size(347, 30);
            this.incidentTitleTextBox.TabIndex = 1;
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
            this.tableLayoutPanel1.Controls.Add(this.ClearButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.79816F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.20184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 210);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ClearButton.Location = new System.Drawing.Point(93, 150);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(130, 50);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddButton.Location = new System.Drawing.Point(229, 150);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(130, 50);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.ForeColor = System.Drawing.Color.Red;
            this.SuccessLabel.Location = new System.Drawing.Point(293, 229);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(0, 25);
            this.SuccessLabel.TabIndex = 3;
            // 
            // AddIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddIncidentUserControl";
            this.Size = new System.Drawing.Size(641, 300);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox incidentDescriptionTextBox;
        private System.Windows.Forms.Label incidentTitleLabel;
        private System.Windows.Forms.Label incidentDescriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox incidentTitleTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label SuccessLabel;
    }
}
