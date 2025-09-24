namespace InventoryManagementSystem.UserControl
{
    partial class ProductsPage
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
            this.productHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productHeader
            // 
            this.productHeader.AutoSize = true;
            this.productHeader.Font = new System.Drawing.Font("Felix Titling", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productHeader.Location = new System.Drawing.Point(281, 208);
            this.productHeader.Name = "productHeader";
            this.productHeader.Size = new System.Drawing.Size(185, 34);
            this.productHeader.TabIndex = 2;
            this.productHeader.Text = "PRODUCTS";
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productHeader);
            this.Name = "ProductsPage";
            this.Text = "ProductsPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productHeader;
    }
}