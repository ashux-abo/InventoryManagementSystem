namespace InventoryManagementSystem.Forms
{
    partial class MainPage
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
            System.Windows.Forms.Panel topPanel;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.displayEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboardHeader = new System.Windows.Forms.Label();
            this.transactionHeader = new System.Windows.Forms.Label();
            this.productsBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.transactionsBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.Panel();
            topPanel = new System.Windows.Forms.Panel();
            topPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            topPanel.Controls.Add(this.flowLayoutPanel1);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(159, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(1089, 50);
            topPanel.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.displayEmail);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(846, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(137, 48);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // displayEmail
            // 
            this.displayEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.displayEmail.AutoSize = true;
            this.displayEmail.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.displayEmail.Location = new System.Drawing.Point(8, 16);
            this.displayEmail.Name = "displayEmail";
            this.displayEmail.Size = new System.Drawing.Size(47, 15);
            this.displayEmail.TabIndex = 0;
            this.displayEmail.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources.Four_Ways_to_Put_Internet_Profiles_to_Good_Use;
            this.pictureBox1.Location = new System.Drawing.Point(61, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.panel2.Controls.Add(this.dashboardHeader);
            this.panel2.Controls.Add(this.transactionHeader);
            this.panel2.Location = new System.Drawing.Point(168, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 606);
            this.panel2.TabIndex = 6;
            // 
            // dashboardHeader
            // 
            this.dashboardHeader.AutoSize = true;
            this.dashboardHeader.Font = new System.Drawing.Font("Felix Titling", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardHeader.Location = new System.Drawing.Point(32, 29);
            this.dashboardHeader.Name = "dashboardHeader";
            this.dashboardHeader.Size = new System.Drawing.Size(202, 34);
            this.dashboardHeader.TabIndex = 3;
            this.dashboardHeader.Text = "DASHBOARD";
            // 
            // transactionHeader
            // 
            this.transactionHeader.AutoSize = true;
            this.transactionHeader.Font = new System.Drawing.Font("Felix Titling", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionHeader.Location = new System.Drawing.Point(430, 295);
            this.transactionHeader.Name = "transactionHeader";
            this.transactionHeader.Size = new System.Drawing.Size(239, 34);
            this.transactionHeader.TabIndex = 2;
            this.transactionHeader.Text = "TRANSACTION";
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.Color.Transparent;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.productsBtn.Location = new System.Drawing.Point(8, 214);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(142, 43);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.dashboardBtn.Location = new System.Drawing.Point(8, 161);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(142, 43);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.reportsBtn.Location = new System.Drawing.Point(8, 373);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(142, 43);
            this.reportsBtn.TabIndex = 4;
            this.reportsBtn.Text = "Report";
            this.reportsBtn.UseVisualStyleBackColor = false;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // transactionsBtn
            // 
            this.transactionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.transactionsBtn.FlatAppearance.BorderSize = 0;
            this.transactionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.transactionsBtn.Location = new System.Drawing.Point(8, 320);
            this.transactionsBtn.Name = "transactionsBtn";
            this.transactionsBtn.Size = new System.Drawing.Size(142, 43);
            this.transactionsBtn.TabIndex = 3;
            this.transactionsBtn.Text = "Transactions";
            this.transactionsBtn.UseVisualStyleBackColor = false;
            this.transactionsBtn.Click += new System.EventHandler(this.transactionsBtn_Click);
            // 
            // supplierBtn
            // 
            this.supplierBtn.BackColor = System.Drawing.Color.Transparent;
            this.supplierBtn.FlatAppearance.BorderSize = 0;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierBtn.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.supplierBtn.Location = new System.Drawing.Point(8, 267);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(142, 43);
            this.supplierBtn.TabIndex = 2;
            this.supplierBtn.Text = "Supplier";
            this.supplierBtn.UseVisualStyleBackColor = false;
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
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
            this.sideBar.Size = new System.Drawing.Size(159, 642);
            this.sideBar.TabIndex = 4;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 642);
            this.Controls.Add(this.panel2);
            this.Controls.Add(topPanel);
            this.Controls.Add(this.sideBar);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dashboardHeader;
        private System.Windows.Forms.Label transactionHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label displayEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button transactionsBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Panel sideBar;
    }
}