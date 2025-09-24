namespace InventoryManagementSystem.UserControl
{
    partial class SupplierPage
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
            this.supplierHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supplierHeader
            // 
            this.supplierHeader.AutoSize = true;
            this.supplierHeader.Font = new System.Drawing.Font("Felix Titling", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierHeader.Location = new System.Drawing.Point(436, 276);
            this.supplierHeader.Name = "supplierHeader";
            this.supplierHeader.Size = new System.Drawing.Size(152, 34);
            this.supplierHeader.TabIndex = 1;
            this.supplierHeader.Text = "SUPPLIER";
            // 
            // SupplierPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 586);
            this.Controls.Add(this.supplierHeader);
            this.Name = "SupplierPage";
            this.Text = "SupplierPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label supplierHeader;
    }
}