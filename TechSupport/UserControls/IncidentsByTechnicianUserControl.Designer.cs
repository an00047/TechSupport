
namespace TechSupport.UserControls
{
    partial class IncidentsByTechnicianUserControl
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
            this.components = new System.ComponentModel.Container();
            this.techComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.technicianProductDataGridView = new System.Windows.Forms.DataGridView();
            this.techNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.technicianProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // techComboBox
            // 
            this.techComboBox.Enabled = false;
            this.techComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.techComboBox.FormattingEnabled = true;
            this.techComboBox.Location = new System.Drawing.Point(235, 92);
            this.techComboBox.Name = "techComboBox";
            this.techComboBox.Size = new System.Drawing.Size(266, 28);
            this.techComboBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextBox.Location = new System.Drawing.Point(235, 141);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(266, 26);
            this.emailTextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneTextBox.Location = new System.Drawing.Point(235, 189);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(138, 26);
            this.phoneTextBox.TabIndex = 3;
            // 
            // technicianProductDataGridView
            // 
            this.technicianProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.technicianProductDataGridView.Location = new System.Drawing.Point(134, 235);
            this.technicianProductDataGridView.Name = "technicianProductDataGridView";
            this.technicianProductDataGridView.Size = new System.Drawing.Size(521, 232);
            this.technicianProductDataGridView.TabIndex = 4;
            // 
            // techNameLabel
            // 
            this.techNameLabel.AutoSize = true;
            this.techNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.techNameLabel.Location = new System.Drawing.Point(130, 92);
            this.techNameLabel.Name = "techNameLabel";
            this.techNameLabel.Size = new System.Drawing.Size(51, 20);
            this.techNameLabel.TabIndex = 5;
            this.techNameLabel.Text = "Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailLabel.Location = new System.Drawing.Point(130, 141);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 20);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneLabel.Location = new System.Drawing.Point(130, 189);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(55, 20);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "Phone";
            // 
            // IncidentsByTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.techNameLabel);
            this.Controls.Add(this.technicianProductDataGridView);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.techComboBox);
            this.Name = "IncidentsByTechnician";
            this.Size = new System.Drawing.Size(835, 588);
            ((System.ComponentModel.ISupportInitialize)(this.technicianProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox techComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.DataGridView technicianProductDataGridView;
        private System.Windows.Forms.Label techNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
    }
}
