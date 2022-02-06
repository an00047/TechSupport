
namespace TechSupport.UserControls
{
    partial class SearchIncidentUserControl
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchIncidentTextbox = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.SearchIncidentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIncidentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CancelButton.Location = new System.Drawing.Point(537, 352);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 37);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchButton.Location = new System.Drawing.Point(537, 115);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(111, 37);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchIncidentTextbox
            // 
            this.SearchIncidentTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SearchIncidentTextbox.Location = new System.Drawing.Point(292, 118);
            this.SearchIncidentTextbox.Name = "SearchIncidentTextbox";
            this.SearchIncidentTextbox.Size = new System.Drawing.Size(227, 30);
            this.SearchIncidentTextbox.TabIndex = 15;
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CustomerIDLabel.Location = new System.Drawing.Point(165, 123);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(121, 25);
            this.CustomerIDLabel.TabIndex = 16;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // SearchIncidentDataGridView
            // 
            this.SearchIncidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchIncidentDataGridView.Location = new System.Drawing.Point(165, 160);
            this.SearchIncidentDataGridView.Name = "SearchIncidentDataGridView";
            this.SearchIncidentDataGridView.Size = new System.Drawing.Size(483, 186);
            this.SearchIncidentDataGridView.TabIndex = 14;
            // 
            // SearchIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchIncidentTextbox);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.SearchIncidentDataGridView);
            this.Name = "SearchIncidentUserControl";
            this.Size = new System.Drawing.Size(818, 573);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIncidentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchIncidentTextbox;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.DataGridView SearchIncidentDataGridView;
    }
}
