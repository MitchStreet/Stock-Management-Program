namespace The_Christie_NHS___Stock_control_program
{
    partial class addtocat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addtocat));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadbutton = new System.Windows.Forms.Button();
            this.selectedcatagorybox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.assignedcheckBox = new System.Windows.Forms.CheckBox();
            this.stockedcheckBox = new System.Windows.Forms.CheckBox();
            this.serialnumberbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.return_to_main_menu = new System.Windows.Forms.Button();
            this.storebutton = new System.Windows.Forms.Button();
            this.csvlistbox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ticketnumberbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ordernumberbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.commentbox = new System.Windows.Forms.TextBox();
            this.bulkmodecheckbox = new System.Windows.Forms.CheckBox();
            this.altkeyenter = new System.Windows.Forms.CheckBox();
            this.stockedstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add to category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select category:";
            // 
            // loadbutton
            // 
            this.loadbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadbutton.Location = new System.Drawing.Point(12, 71);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(216, 36);
            this.loadbutton.TabIndex = 3;
            this.loadbutton.Text = "Load";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // selectedcatagorybox
            // 
            this.selectedcatagorybox.Location = new System.Drawing.Point(390, 84);
            this.selectedcatagorybox.Name = "selectedcatagorybox";
            this.selectedcatagorybox.ReadOnly = true;
            this.selectedcatagorybox.Size = new System.Drawing.Size(384, 23);
            this.selectedcatagorybox.TabIndex = 4;
            this.selectedcatagorybox.TextChanged += new System.EventHandler(this.selectedcatagorybox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(390, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selected category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(390, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Serial number:";
            // 
            // assignedcheckBox
            // 
            this.assignedcheckBox.AutoSize = true;
            this.assignedcheckBox.Enabled = false;
            this.assignedcheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.assignedcheckBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.assignedcheckBox.Location = new System.Drawing.Point(467, 213);
            this.assignedcheckBox.Name = "assignedcheckBox";
            this.assignedcheckBox.Size = new System.Drawing.Size(92, 25);
            this.assignedcheckBox.TabIndex = 7;
            this.assignedcheckBox.Text = "Assigned";
            this.assignedcheckBox.UseVisualStyleBackColor = true;
            this.assignedcheckBox.CheckedChanged += new System.EventHandler(this.assignedcheckBox_CheckedChanged);
            // 
            // stockedcheckBox
            // 
            this.stockedcheckBox.AutoSize = true;
            this.stockedcheckBox.Enabled = false;
            this.stockedcheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stockedcheckBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.stockedcheckBox.Location = new System.Drawing.Point(609, 213);
            this.stockedcheckBox.Name = "stockedcheckBox";
            this.stockedcheckBox.Size = new System.Drawing.Size(83, 25);
            this.stockedcheckBox.TabIndex = 8;
            this.stockedcheckBox.Text = "Stocked";
            this.stockedcheckBox.UseVisualStyleBackColor = true;
            this.stockedcheckBox.CheckedChanged += new System.EventHandler(this.stockedcheckBox_CheckedChanged);
            // 
            // serialnumberbox
            // 
            this.serialnumberbox.Enabled = false;
            this.serialnumberbox.Location = new System.Drawing.Point(390, 148);
            this.serialnumberbox.Name = "serialnumberbox";
            this.serialnumberbox.Size = new System.Drawing.Size(384, 23);
            this.serialnumberbox.TabIndex = 9;
            this.serialnumberbox.TextChanged += new System.EventHandler(this.serialnumberbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(389, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mark as:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(552, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "(Optional)";
            // 
            // return_to_main_menu
            // 
            this.return_to_main_menu.Location = new System.Drawing.Point(695, 415);
            this.return_to_main_menu.Name = "return_to_main_menu";
            this.return_to_main_menu.Size = new System.Drawing.Size(93, 23);
            this.return_to_main_menu.TabIndex = 12;
            this.return_to_main_menu.Text = "Main menu";
            this.return_to_main_menu.UseVisualStyleBackColor = true;
            this.return_to_main_menu.Click += new System.EventHandler(this.return_to_main_menu_Click);
            // 
            // storebutton
            // 
            this.storebutton.Enabled = false;
            this.storebutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.storebutton.Location = new System.Drawing.Point(486, 369);
            this.storebutton.Name = "storebutton";
            this.storebutton.Size = new System.Drawing.Size(192, 49);
            this.storebutton.TabIndex = 14;
            this.storebutton.Text = "Store";
            this.storebutton.UseVisualStyleBackColor = true;
            this.storebutton.Click += new System.EventHandler(this.storebutton_Click);
            // 
            // csvlistbox
            // 
            this.csvlistbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.csvlistbox.FormattingEnabled = true;
            this.csvlistbox.ItemHeight = 20;
            this.csvlistbox.Location = new System.Drawing.Point(12, 113);
            this.csvlistbox.Name = "csvlistbox";
            this.csvlistbox.Size = new System.Drawing.Size(352, 324);
            this.csvlistbox.TabIndex = 16;
            this.csvlistbox.SelectedIndexChanged += new System.EventHandler(this.csvlistbox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(234, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ticketnumberbox
            // 
            this.ticketnumberbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ticketnumberbox.Enabled = false;
            this.ticketnumberbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ticketnumberbox.Location = new System.Drawing.Point(389, 266);
            this.ticketnumberbox.Name = "ticketnumberbox";
            this.ticketnumberbox.Size = new System.Drawing.Size(175, 23);
            this.ticketnumberbox.TabIndex = 18;
            this.ticketnumberbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(389, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ticket number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(599, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Order number:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ordernumberbox
            // 
            this.ordernumberbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ordernumberbox.Enabled = false;
            this.ordernumberbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ordernumberbox.Location = new System.Drawing.Point(599, 266);
            this.ordernumberbox.Name = "ordernumberbox";
            this.ordernumberbox.Size = new System.Drawing.Size(175, 23);
            this.ordernumberbox.TabIndex = 21;
            this.ordernumberbox.TextChanged += new System.EventHandler(this.ordernumberbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(389, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Comments:";
            // 
            // commentbox
            // 
            this.commentbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commentbox.Enabled = false;
            this.commentbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.commentbox.Location = new System.Drawing.Point(390, 316);
            this.commentbox.Multiline = true;
            this.commentbox.Name = "commentbox";
            this.commentbox.Size = new System.Drawing.Size(384, 47);
            this.commentbox.TabIndex = 23;
            this.commentbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // bulkmodecheckbox
            // 
            this.bulkmodecheckbox.AutoSize = true;
            this.bulkmodecheckbox.Enabled = false;
            this.bulkmodecheckbox.Location = new System.Drawing.Point(390, 384);
            this.bulkmodecheckbox.Name = "bulkmodecheckbox";
            this.bulkmodecheckbox.Size = new System.Drawing.Size(83, 19);
            this.bulkmodecheckbox.TabIndex = 24;
            this.bulkmodecheckbox.Text = "Bulk mode";
            this.bulkmodecheckbox.UseVisualStyleBackColor = true;
            this.bulkmodecheckbox.CheckedChanged += new System.EventHandler(this.bulkmodecheckbox_CheckedChanged);
            // 
            // altkeyenter
            // 
            this.altkeyenter.AutoSize = true;
            this.altkeyenter.Enabled = false;
            this.altkeyenter.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.altkeyenter.Location = new System.Drawing.Point(531, 419);
            this.altkeyenter.Name = "altkeyenter";
            this.altkeyenter.Size = new System.Drawing.Size(102, 19);
            this.altkeyenter.TabIndex = 25;
            this.altkeyenter.Text = "Alt key: ENTER";
            this.altkeyenter.UseVisualStyleBackColor = true;
            this.altkeyenter.CheckedChanged += new System.EventHandler(this.altkeyenter_CheckedChanged);
            // 
            // stockedstatus
            // 
            this.stockedstatus.AutoSize = true;
            this.stockedstatus.ForeColor = System.Drawing.Color.Green;
            this.stockedstatus.Location = new System.Drawing.Point(493, 36);
            this.stockedstatus.Name = "stockedstatus";
            this.stockedstatus.Size = new System.Drawing.Size(0, 15);
            this.stockedstatus.TabIndex = 26;
            this.stockedstatus.Click += new System.EventHandler(this.stockedstatus_Click);
            // 
            // addtocat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stockedstatus);
            this.Controls.Add(this.altkeyenter);
            this.Controls.Add(this.bulkmodecheckbox);
            this.Controls.Add(this.commentbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ordernumberbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ticketnumberbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.csvlistbox);
            this.Controls.Add(this.storebutton);
            this.Controls.Add(this.return_to_main_menu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.serialnumberbox);
            this.Controls.Add(this.stockedcheckBox);
            this.Controls.Add(this.assignedcheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedcatagorybox);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "addtocat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Management System";
            this.Load += new System.EventHandler(this.addtocat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button loadbutton;
        private TextBox selectedcatagorybox;
        private Label label3;
        private Label label4;
        private CheckBox assignedcheckBox;
        private CheckBox stockedcheckBox;
        private TextBox serialnumberbox;
        private Label label5;
        private Label label6;
        private Button return_to_main_menu;
        private Label label7;
        private Button button1;
        private Button storebutton;
        private ListBox csvlistbox;
        private Button button2;
        private TextBox ticketnumberbox;
        private Label label9;
        private Label label10;
        private TextBox ordernumberbox;
        private TextBox commentbox;
        private CheckBox bulkmodecheckbox;
        private CheckBox altkeyenter;
        private Label stockedstatus;
    }
}