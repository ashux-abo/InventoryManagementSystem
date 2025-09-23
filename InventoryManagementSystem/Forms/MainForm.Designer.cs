namespace InventoryManagementSystem.Forms
{
    partial class MainForm
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
            System.Windows.Forms.Panel mainPanel;
            System.Windows.Forms.Panel topPanel;
            this.sideBar = new System.Windows.Forms.Panel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.transactionsBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.dashboardHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            mainPanel = new System.Windows.Forms.Panel();
            topPanel = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.sideBar.Controls.Add(this.reportsBtn);
            this.sideBar.Controls.Add(this.transactionsBtn);
            this.sideBar.Controls.Add(this.supplierBtn);
            this.sideBar.Controls.Add(this.productsBtn);
            this.sideBar.Controls.Add(this.dashboardBtn);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(159, 681);
            this.sideBar.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(this.label2);
            mainPanel.Controls.Add(this.dashboardHeader);
            mainPanel.Location = new System.Drawing.Point(165, 56);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(1099, 625);
            mainPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(159, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1105, 50);
            topPanel.TabIndex = 1;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.dashboardBtn.Location = new System.Drawing.Point(8, 161);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(142, 43);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.Color.Transparent;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.productsBtn.Location = new System.Drawing.Point(8, 214);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(142, 43);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = false;
            // 
            // supplierBtn
            // 
            this.supplierBtn.BackColor = System.Drawing.Color.Transparent;
            this.supplierBtn.FlatAppearance.BorderSize = 0;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.supplierBtn.Location = new System.Drawing.Point(8, 267);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(142, 43);
            this.supplierBtn.TabIndex = 2;
            this.supplierBtn.Text = "Supplier";
            this.supplierBtn.UseVisualStyleBackColor = false;
            // 
            // transactionsBtn
            // 
            this.transactionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.transactionsBtn.FlatAppearance.BorderSize = 0;
            this.transactionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.transactionsBtn.Location = new System.Drawing.Point(8, 320);
            this.transactionsBtn.Name = "transactionsBtn";
            this.transactionsBtn.Size = new System.Drawing.Size(142, 43);
            this.transactionsBtn.TabIndex = 3;
            this.transactionsBtn.Text = "Transactions";
            this.transactionsBtn.UseVisualStyleBackColor = false;
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(9)))));
            this.reportsBtn.Location = new System.Drawing.Point(8, 373);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(142, 43);
            this.reportsBtn.TabIndex = 4;
            this.reportsBtn.Text = "Report";
            this.reportsBtn.UseVisualStyleBackColor = false;
            // 
            // dashboardHeader
            // 
            this.dashboardHeader.AutoSize = true;
            this.dashboardHeader.Font = new System.Drawing.Font("Felix Titling", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardHeader.Location = new System.Drawing.Point(29, 34);
            this.dashboardHeader.Name = "dashboardHeader";
            this.dashboardHeader.Size = new System.Drawing.Size(211, 34);
            this.dashboardHeader.TabIndex = 0;
            this.dashboardHeader.Text = "DASHBOARD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Track products, Manage stocks, and Monitor transactions";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(topPanel);
            this.Controls.Add(mainPanel);
            this.Controls.Add(this.sideBar);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.sideBar.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button transactionsBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dashboardHeader;
    }
}