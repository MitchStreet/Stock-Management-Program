namespace The_Christie_NHS___Stock_control_program
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.database_dir_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.return_to_main_menu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nhs_logo = new System.Windows.Forms.Button();
            this.generic_logo = new System.Windows.Forms.Button();
            this.blank_logo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.currentlogolabel = new System.Windows.Forms.Label();
            this.makedatabasebutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.createdatabasedialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.makeshortcut = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.shortcutlocation = new System.Windows.Forms.FolderBrowserDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.programlocation = new System.Windows.Forms.FolderBrowserDialog();
            this.statusmessage = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database directory:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Settings";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // database_dir_button
            // 
            this.database_dir_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.database_dir_button.Location = new System.Drawing.Point(12, 81);
            this.database_dir_button.Name = "database_dir_button";
            this.database_dir_button.Size = new System.Drawing.Size(143, 29);
            this.database_dir_button.TabIndex = 2;
            this.database_dir_button.Text = "Browse";
            this.database_dir_button.UseVisualStyleBackColor = true;
            this.database_dir_button.Click += new System.EventHandler(this.database_dir_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Currently selected:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(133, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "none";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(12, 413);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 25);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Disable credit link";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Main menu logo:";
            // 
            // nhs_logo
            // 
            this.nhs_logo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nhs_logo.Location = new System.Drawing.Point(12, 210);
            this.nhs_logo.Name = "nhs_logo";
            this.nhs_logo.Size = new System.Drawing.Size(143, 29);
            this.nhs_logo.TabIndex = 13;
            this.nhs_logo.Text = "NHS Logo";
            this.nhs_logo.UseVisualStyleBackColor = true;
            this.nhs_logo.Click += new System.EventHandler(this.nhs_logo_Click);
            // 
            // generic_logo
            // 
            this.generic_logo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generic_logo.Location = new System.Drawing.Point(12, 245);
            this.generic_logo.Name = "generic_logo";
            this.generic_logo.Size = new System.Drawing.Size(143, 29);
            this.generic_logo.TabIndex = 14;
            this.generic_logo.Text = "Generic";
            this.generic_logo.UseVisualStyleBackColor = true;
            this.generic_logo.Click += new System.EventHandler(this.generic_logo_Click);
            // 
            // blank_logo
            // 
            this.blank_logo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blank_logo.Location = new System.Drawing.Point(12, 280);
            this.blank_logo.Name = "blank_logo";
            this.blank_logo.Size = new System.Drawing.Size(143, 29);
            this.blank_logo.TabIndex = 15;
            this.blank_logo.Text = "Blank";
            this.blank_logo.UseVisualStyleBackColor = true;
            this.blank_logo.Click += new System.EventHandler(this.blank_logo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Currently selected:";
            // 
            // currentlogolabel
            // 
            this.currentlogolabel.AutoSize = true;
            this.currentlogolabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentlogolabel.Location = new System.Drawing.Point(133, 312);
            this.currentlogolabel.Name = "currentlogolabel";
            this.currentlogolabel.Size = new System.Drawing.Size(61, 17);
            this.currentlogolabel.TabIndex = 17;
            this.currentlogolabel.Text = "loading...";
            this.currentlogolabel.Click += new System.EventHandler(this.currentlogolabel_Click);
            // 
            // makedatabasebutton
            // 
            this.makedatabasebutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makedatabasebutton.Location = new System.Drawing.Point(161, 81);
            this.makedatabasebutton.Name = "makedatabasebutton";
            this.makedatabasebutton.Size = new System.Drawing.Size(130, 29);
            this.makedatabasebutton.TabIndex = 18;
            this.makedatabasebutton.Text = "Make database";
            this.makedatabasebutton.UseVisualStyleBackColor = true;
            this.makedatabasebutton.Click += new System.EventHandler(this.makedatabasebutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "To make your first database, click the \'Make database\' button.";
            // 
            // createdatabasedialog
            // 
            this.createdatabasedialog.HelpRequest += new System.EventHandler(this.createdatabasedialog_HelpRequest);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(593, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Create program shortcut:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // makeshortcut
            // 
            this.makeshortcut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeshortcut.Location = new System.Drawing.Point(601, 64);
            this.makeshortcut.Name = "makeshortcut";
            this.makeshortcut.Size = new System.Drawing.Size(187, 29);
            this.makeshortcut.TabIndex = 21;
            this.makeshortcut.Text = "Create shortcut";
            this.makeshortcut.UseVisualStyleBackColor = true;
            this.makeshortcut.Click += new System.EventHandler(this.makeshortcut_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(491, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 34);
            this.label9.TabIndex = 22;
            this.label9.Text = "An easy way to create a shortcut to streamline your access to the program.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // shortcutlocation
            // 
            this.shortcutlocation.Description = "Select location for the shortcut";
            this.shortcutlocation.HelpRequest += new System.EventHandler(this.shortcutlocation_HelpRequest);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(491, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(297, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "1st - You will be asked for the downloaded program file.\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(491, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 37);
            this.label11.TabIndex = 24;
            this.label11.Text = "2nd - You\'ll be asked where you would like the shortcut.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // programlocation
            // 
            this.programlocation.Description = "Select downloaded program location";
            this.programlocation.HelpRequest += new System.EventHandler(this.programlocation_HelpRequest);
            // 
            // statusmessage
            // 
            this.statusmessage.Location = new System.Drawing.Point(521, 21);
            this.statusmessage.Name = "statusmessage";
            this.statusmessage.Size = new System.Drawing.Size(267, 23);
            this.statusmessage.TabIndex = 25;
            this.statusmessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(724, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "Version";
            // 
            // version_label
            // 
            this.version_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.version_label.Location = new System.Drawing.Point(534, 231);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(254, 43);
            this.version_label.TabIndex = 27;
            this.version_label.Text = "Current version:\r\nv.1.2.0\r\n";
            this.version_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.version_label.Click += new System.EventHandler(this.version_label_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.statusmessage);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.makeshortcut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.makedatabasebutton);
            this.Controls.Add(this.currentlogolabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.blank_logo);
            this.Controls.Add(this.generic_logo);
            this.Controls.Add(this.nhs_logo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.return_to_main_menu);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.database_dir_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Management System";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button database_dir_button;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private Button return_to_main_menu;
        private Button button1;
        private Label label5;
        private Button nhs_logo;
        private Button generic_logo;
        private Button blank_logo;
        private Label label6;
        private Label currentlogolabel;
        private Button makedatabasebutton;
        private Label label7;
        private FolderBrowserDialog createdatabasedialog;
        private Label label8;
        private Button makeshortcut;
        private Label label9;
        private FolderBrowserDialog shortcutlocation;
        private Label label10;
        private Label label11;
        private FolderBrowserDialog programlocation;
        private Label statusmessage;
        private Label label12;
        private Label version_label;
    }
}