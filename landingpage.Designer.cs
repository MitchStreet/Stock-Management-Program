namespace The_Christie_NHS___Stock_control_program
{
    partial class landingpage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landingpage));
            this.logo = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.LinkLabel();
            this.scaninstock = new System.Windows.Forms.Button();
            this.managestock = new System.Windows.Forms.Button();
            this.pagename = new System.Windows.Forms.Label();
            this.settings_button = new System.Windows.Forms.Button();
            this.databasestatuslabel = new System.Windows.Forms.Label();
            this.managecategories = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.ErrorImage = null;
            this.logo.ImageLocation = "";
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(299, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 82);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(262, 97);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(278, 30);
            this.Title.TabIndex = 1;
            this.Title.Text = "Stock Management System";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditLabel.LinkColor = System.Drawing.Color.Gray;
            this.creditLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.creditLabel.Location = new System.Drawing.Point(611, 426);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(177, 15);
            this.creditLabel.TabIndex = 2;
            this.creditLabel.TabStop = true;
            this.creditLabel.Text = "Developed by Mitchell Jay Street";
            this.creditLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditLabel_LinkClicked);
            // 
            // scaninstock
            // 
            this.scaninstock.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scaninstock.Location = new System.Drawing.Point(84, 195);
            this.scaninstock.Name = "scaninstock";
            this.scaninstock.Size = new System.Drawing.Size(192, 61);
            this.scaninstock.TabIndex = 3;
            this.scaninstock.Text = "Add stock or Categories";
            this.scaninstock.UseVisualStyleBackColor = true;
            this.scaninstock.Click += new System.EventHandler(this.scaninstock_Click);
            // 
            // managestock
            // 
            this.managestock.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.managestock.Location = new System.Drawing.Point(524, 203);
            this.managestock.Name = "managestock";
            this.managestock.Size = new System.Drawing.Size(192, 45);
            this.managestock.TabIndex = 4;
            this.managestock.Text = "Manage stock";
            this.managestock.UseVisualStyleBackColor = true;
            this.managestock.Click += new System.EventHandler(this.managestock_Click);
            // 
            // pagename
            // 
            this.pagename.AutoSize = true;
            this.pagename.Location = new System.Drawing.Point(365, 127);
            this.pagename.Name = "pagename";
            this.pagename.Size = new System.Drawing.Size(68, 15);
            this.pagename.TabIndex = 5;
            this.pagename.Text = "Main menu";
            // 
            // settings_button
            // 
            this.settings_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settings_button.Location = new System.Drawing.Point(250, 270);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(131, 45);
            this.settings_button.TabIndex = 6;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_Click);
            // 
            // databasestatuslabel
            // 
            this.databasestatuslabel.AutoSize = true;
            this.databasestatuslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.databasestatuslabel.Location = new System.Drawing.Point(12, 426);
            this.databasestatuslabel.Name = "databasestatuslabel";
            this.databasestatuslabel.Size = new System.Drawing.Size(117, 15);
            this.databasestatuslabel.TabIndex = 7;
            this.databasestatuslabel.Text = "Checking Database...";
            this.databasestatuslabel.Click += new System.EventHandler(this.databasestatuslabel_Click);
            // 
            // managecategories
            // 
            this.managecategories.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.managecategories.Location = new System.Drawing.Point(304, 203);
            this.managecategories.Name = "managecategories";
            this.managecategories.Size = new System.Drawing.Size(192, 45);
            this.managecategories.TabIndex = 8;
            this.managecategories.Text = "Manage categories";
            this.managecategories.UseVisualStyleBackColor = true;
            this.managecategories.Click += new System.EventHandler(this.managecategories_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitbutton.Location = new System.Drawing.Point(419, 270);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(131, 45);
            this.exitbutton.TabIndex = 9;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // landingpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.managecategories);
            this.Controls.Add(this.databasestatuslabel);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.pagename);
            this.Controls.Add(this.managestock);
            this.Controls.Add(this.scaninstock);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "landingpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Management System";
            this.Load += new System.EventHandler(this.landingpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logo;
        private Label Title;
        private LinkLabel creditLabel;
        private Button scaninstock;
        private Button managestock;
        private Label pagename;
        private Button settings_button;
        private Label databasestatuslabel;
        private Button managecategories;
        private Button exitbutton;
    }
}