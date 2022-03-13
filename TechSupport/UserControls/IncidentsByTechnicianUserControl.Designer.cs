
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
            System.Windows.Forms.Label emailLabel1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel1;
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.technicianProductDataGridView = new System.Windows.Forms.DataGridView();
            this.dBIncidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.dBTechnicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOpenedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            emailLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.technicianProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIncidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTechnicianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel1
            // 
            emailLabel1.AutoSize = true;
            emailLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            emailLabel1.Location = new System.Drawing.Point(134, 139);
            emailLabel1.Name = "emailLabel1";
            emailLabel1.Size = new System.Drawing.Size(52, 20);
            emailLabel1.TabIndex = 9;
            emailLabel1.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nameLabel.Location = new System.Drawing.Point(131, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name:";
            // 
            // phoneLabel1
            // 
            phoneLabel1.AutoSize = true;
            phoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            phoneLabel1.Location = new System.Drawing.Point(134, 192);
            phoneLabel1.Name = "phoneLabel1";
            phoneLabel1.Size = new System.Drawing.Size(59, 20);
            phoneLabel1.TabIndex = 13;
            phoneLabel1.Text = "Phone:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // technicianProductDataGridView
            // 
            this.technicianProductDataGridView.AutoGenerateColumns = false;
            this.technicianProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.technicianProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.dateOpenedDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.technicianProductDataGridView.DataSource = this.dBIncidentBindingSource;
            this.technicianProductDataGridView.Location = new System.Drawing.Point(135, 234);
            this.technicianProductDataGridView.Name = "technicianProductDataGridView";
            this.technicianProductDataGridView.Size = new System.Drawing.Size(521, 232);
            this.technicianProductDataGridView.TabIndex = 4;
            // 
            // dBIncidentBindingSource
            // 
            this.dBIncidentBindingSource.DataSource = typeof(TechSupport.model.DBIncident);
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBTechnicianBindingSource, "Email", true));
            this.emailTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTextBox1.Location = new System.Drawing.Point(199, 136);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.ReadOnly = true;
            this.emailTextBox1.Size = new System.Drawing.Size(294, 26);
            this.emailTextBox1.TabIndex = 10;
            // 
            // dBTechnicianBindingSource
            // 
            this.dBTechnicianBindingSource.DataSource = typeof(TechSupport.model.DBTechnician);
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBTechnicianBindingSource, "Name", true));
            this.nameComboBox.DataSource = this.dBTechnicianBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(199, 88);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(294, 28);
            this.nameComboBox.TabIndex = 12;
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.NameComboBox_SelectedIndexChanged);
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBTechnicianBindingSource, "Phone", true));
            this.phoneTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneTextBox1.Location = new System.Drawing.Point(199, 189);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.ReadOnly = true;
            this.phoneTextBox1.Size = new System.Drawing.Size(206, 26);
            this.phoneTextBox1.TabIndex = 14;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 200;
            // 
            // dateOpenedDataGridViewTextBoxColumn
            // 
            this.dateOpenedDataGridViewTextBoxColumn.DataPropertyName = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.HeaderText = "DateOpened";
            this.dateOpenedDataGridViewTextBoxColumn.Name = "dateOpenedDataGridViewTextBoxColumn";
            this.dateOpenedDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 150;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // IncidentsByTechnicianUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(phoneLabel1);
            this.Controls.Add(this.phoneTextBox1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(emailLabel1);
            this.Controls.Add(this.emailTextBox1);
            this.Controls.Add(this.technicianProductDataGridView);
            this.Name = "IncidentsByTechnicianUserControl";
            this.Size = new System.Drawing.Size(835, 588);
            this.Load += new System.EventHandler(this.IncidentsByTechnicianUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicianProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIncidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTechnicianBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView technicianProductDataGridView;
        private System.Windows.Forms.BindingSource dBTechnicianBindingSource;
        private System.Windows.Forms.TextBox emailTextBox1;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private System.Windows.Forms.BindingSource dBIncidentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOpenedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}
