namespace InventoryManagementSystem.UserControl
{
    partial class TransactionPage
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
            this.transactionHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transactionHeader
            // 
            this.transactionHeader.AutoSize = true;
            this.transactionHeader.Font = new System.Drawing.Font("Felix Titling", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionHeader.Location = new System.Drawing.Point(436, 276);
            this.transactionHeader.Name = "transactionHeader";
            this.transactionHeader.Size = new System.Drawing.Size(239, 34);
            this.transactionHeader.TabIndex = 1;
            this.transactionHeader.Text = "TRANSACTION";
            // 
            // TransactionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 586);
            this.Controls.Add(this.transactionHeader);
            this.Name = "TransactionPage";
            this.Text = "TransactionPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label transactionHeader;
    }
}