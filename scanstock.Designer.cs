namespace The_Christie_NHS___Stock_control_program
{
    partial class scanstock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scanstock));
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pagename = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.return_to_main_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AccessibleDescription = "";
            this.logo.AccessibleName = "NHS Logo";
            this.logo.ImageLocation = "https://github.com/MitchStreet/The-Christie-NHS-Stock-Control-Program/blob/main/N" +
    "HS_logo.png?raw=true";
            this.logo.Location = new System.Drawing.Point(299, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 82);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.NHSlogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Management System";
            // 
            // pagename
            // 
            this.pagename.AutoSize = true;
            this.pagename.Location = new System.Drawing.Point(362, 127);
            this.pagename.Name = "pagename";
            this.pagename.Size = new System.Drawing.Size(76, 15);
            this.pagename.TabIndex = 2;
            this.pagename.Text = "Scan in stock";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(444, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add to existing category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(105, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add new category";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // return_to_main_menu
            // 
            this.return_to_main_menu.Location = new System.Drawing.Point(695, 415);
            this.return_to_main_menu.Name = "return_to_main_menu";
            this.return_to_main_menu.Size = new System.Drawing.Size(93, 23);
            this.return_to_main_menu.TabIndex = 7;
            this.return_to_main_menu.Text = "Main menu";
            this.return_to_main_menu.UseVisualStyleBackColor = true;
            this.return_to_main_menu.Click += new System.EventHandler(this.return_to_main_menu_Click);
            // 
            // scanstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return_to_main_menu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pagename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "scanstock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Management System";
            this.Load += new System.EventHandler(this.scanstock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logo;
        private Label label1;
        private Label pagename;
        private Button button1;
        private Button button2;
        private Button return_to_main_menu;
    }
}