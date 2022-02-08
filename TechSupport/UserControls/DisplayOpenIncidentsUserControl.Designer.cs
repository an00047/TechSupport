
namespace TechSupport.UserControls
{
    partial class DisplayOpenIncidentsUserControl
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
            this.openIncidentsListView = new System.Windows.Forms.ListView();
            this.productCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOpened = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.technician = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // openIncidentsListView
            // 
            this.openIncidentsListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openIncidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productCode,
            this.dateOpened,
            this.customer,
            this.technician,
            this.title});
            this.openIncidentsListView.HideSelection = false;
            this.openIncidentsListView.Location = new System.Drawing.Point(120, 88);
            this.openIncidentsListView.Name = "openIncidentsListView";
            this.openIncidentsListView.Size = new System.Drawing.Size(535, 265);
            this.openIncidentsListView.TabIndex = 0;
            this.openIncidentsListView.UseCompatibleStateImageBehavior = false;
            this.openIncidentsListView.View = System.Windows.Forms.View.Details;
            // 
            // productCode
            // 
            this.productCode.Text = "Product Code";
            this.productCode.Width = 83;
            // 
            // dateOpened
            // 
            this.dateOpened.Text = "Date Opened";
            this.dateOpened.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateOpened.Width = 80;
            // 
            // customer
            // 
            this.customer.Text = "Customer";
            this.customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customer.Width = 85;
            // 
            // technician
            // 
            this.technician.Text = "Technician";
            this.technician.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.technician.Width = 82;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 194;
            // 
            // DisplayOpenIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openIncidentsListView);
            this.Name = "DisplayOpenIncidentsUserControl";
            this.Size = new System.Drawing.Size(751, 473);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView openIncidentsListView;
        private System.Windows.Forms.ColumnHeader productCode;
        private System.Windows.Forms.ColumnHeader dateOpened;
        private System.Windows.Forms.ColumnHeader customer;
        private System.Windows.Forms.ColumnHeader technician;
        private System.Windows.Forms.ColumnHeader title;
    }
}
