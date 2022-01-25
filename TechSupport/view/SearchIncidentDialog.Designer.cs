
namespace TechSupport.view
{
    partial class SearchIncidentDialog
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
            this.SearchIncidentDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.SearchIncidentTextbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIncidentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchIncidentDataGridView
            // 
            this.SearchIncidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchIncidentDataGridView.Location = new System.Drawing.Point(12, 57);
            this.SearchIncidentDataGridView.Name = "SearchIncidentDataGridView";
            this.SearchIncidentDataGridView.Size = new System.Drawing.Size(483, 263);
            this.SearchIncidentDataGridView.TabIndex = 0;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CustomerIDLabel.Location = new System.Drawing.Point(12, 20);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(121, 25);
            this.CustomerIDLabel.TabIndex = 1;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // SearchIncidentTextbox
            // 
            this.SearchIncidentTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchIncidentTextbox.Location = new System.Drawing.Point(139, 15);
            this.SearchIncidentTextbox.Name = "SearchIncidentTextbox";
            this.SearchIncidentTextbox.Size = new System.Drawing.Size(227, 30);
            this.SearchIncidentTextbox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchButton.Location = new System.Drawing.Point(384, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 37);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CancelButton.Location = new System.Drawing.Point(384, 328);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 37);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SearchIncidentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 377);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchIncidentTextbox);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.SearchIncidentDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchIncidentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchIncidentDialog";
            ((System.ComponentModel.ISupportInitialize)(this.SearchIncidentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchIncidentDataGridView;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.TextBox SearchIncidentTextbox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CancelButton;
    }
}