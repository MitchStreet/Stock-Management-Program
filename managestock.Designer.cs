namespace The_Christie_NHS___Stock_control_program
{
    partial class managestock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managestock));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.load_catagories = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.catagory_name_box = new System.Windows.Forms.TextBox();
            this.return_to_main_menu = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ordernumberbox = new System.Windows.Forms.TextBox();
            this.ticketnumberbox = new System.Windows.Forms.TextBox();
            this.commentbox = new System.Windows.Forms.TextBox();
            this.csvlistbox = new System.Windows.Forms.ListBox();
            this.selectcatagorybutton = new System.Windows.Forms.Button();
            this.serialnumlistbox = new System.Windows.Forms.ListBox();
            this.selectserialnum = new System.Windows.Forms.Button();
            this.assignedcheckbox = new System.Windows.Forms.CheckBox();
            this.stockedcheckbox = new System.Windows.Forms.CheckBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.selectedserialtextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quantity_count = new System.Windows.Forms.Label();
            this.dateedited = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select category:";
            // 
            // load_catagories
            // 
            this.load_catagories.Location = new System.Drawing.Point(10, 62);
            this.load_catagories.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.load_catagories.Name = "load_catagories";
            this.load_catagories.Size = new System.Drawing.Size(139, 23);
            this.load_catagories.TabIndex = 3;
            this.load_catagories.Text = "Load categories";
            this.load_catagories.UseVisualStyleBackColor = true;
            this.load_catagories.Click += new System.EventHandler(this.load_catagories_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(276, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category selected:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // catagory_name_box
            // 
            this.catagory_name_box.Location = new System.Drawing.Point(276, 63);
            this.catagory_name_box.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.catagory_name_box.Name = "catagory_name_box";
            this.catagory_name_box.ReadOnly = true;
            this.catagory_name_box.Size = new System.Drawing.Size(210, 23);
            this.catagory_name_box.TabIndex = 5;
            this.catagory_name_box.TextChanged += new System.EventHandler(this.catagory_name_box_TextChanged);
            // 
            // return_to_main_menu
            // 
            this.return_to_main_menu.Location = new System.Drawing.Point(695, 415);
            this.return_to_main_menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.return_to_main_menu.Name = "return_to_main_menu";
            this.return_to_main_menu.Size = new System.Drawing.Size(93, 23);
            this.return_to_main_menu.TabIndex = 6;
            this.return_to_main_menu.Text = "Main menu";
            this.return_to_main_menu.UseVisualStyleBackColor = true;
            this.return_to_main_menu.Click += new System.EventHandler(this.return_to_main_menu_Click_1);
            // 
            // delete_button
            // 
            this.delete_button.Enabled = false;
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_button.ForeColor = System.Drawing.Color.Red;
            this.delete_button.Location = new System.Drawing.Point(514, 370);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(135, 38);
            this.delete_button.TabIndex = 7;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(514, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(514, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ticket number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(514, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Comments";
            // 
            // ordernumberbox
            // 
            this.ordernumberbox.Enabled = false;
            this.ordernumberbox.Location = new System.Drawing.Point(514, 112);
            this.ordernumberbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ordernumberbox.Name = "ordernumberbox";
            this.ordernumberbox.Size = new System.Drawing.Size(274, 23);
            this.ordernumberbox.TabIndex = 14;
            // 
            // ticketnumberbox
            // 
            this.ticketnumberbox.Enabled = false;
            this.ticketnumberbox.Location = new System.Drawing.Point(514, 167);
            this.ticketnumberbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ticketnumberbox.Name = "ticketnumberbox";
            this.ticketnumberbox.Size = new System.Drawing.Size(274, 23);
            this.ticketnumberbox.TabIndex = 15;
            this.ticketnumberbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // commentbox
            // 
            this.commentbox.Enabled = false;
            this.commentbox.Location = new System.Drawing.Point(514, 222);
            this.commentbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.commentbox.Multiline = true;
            this.commentbox.Name = "commentbox";
            this.commentbox.Size = new System.Drawing.Size(274, 89);
            this.commentbox.TabIndex = 16;
            this.commentbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // csvlistbox
            // 
            this.csvlistbox.FormattingEnabled = true;
            this.csvlistbox.ItemHeight = 15;
            this.csvlistbox.Location = new System.Drawing.Point(10, 89);
            this.csvlistbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.csvlistbox.Name = "csvlistbox";
            this.csvlistbox.Size = new System.Drawing.Size(242, 349);
            this.csvlistbox.TabIndex = 17;
            this.csvlistbox.SelectedIndexChanged += new System.EventHandler(this.csvlistbox_SelectedIndexChanged);
            // 
            // selectcatagorybutton
            // 
            this.selectcatagorybutton.Enabled = false;
            this.selectcatagorybutton.Location = new System.Drawing.Point(155, 62);
            this.selectcatagorybutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectcatagorybutton.Name = "selectcatagorybutton";
            this.selectcatagorybutton.Size = new System.Drawing.Size(97, 23);
            this.selectcatagorybutton.TabIndex = 18;
            this.selectcatagorybutton.Text = "Select";
            this.selectcatagorybutton.UseVisualStyleBackColor = true;
            this.selectcatagorybutton.Click += new System.EventHandler(this.selectcatagorybutton_Click);
            // 
            // serialnumlistbox
            // 
            this.serialnumlistbox.FormattingEnabled = true;
            this.serialnumlistbox.ItemHeight = 15;
            this.serialnumlistbox.Location = new System.Drawing.Point(276, 89);
            this.serialnumlistbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.serialnumlistbox.Name = "serialnumlistbox";
            this.serialnumlistbox.Size = new System.Drawing.Size(210, 319);
            this.serialnumlistbox.TabIndex = 19;
            this.serialnumlistbox.SelectedIndexChanged += new System.EventHandler(this.catagorylistbox_SelectedIndexChanged);
            // 
            // selectserialnum
            // 
            this.selectserialnum.Enabled = false;
            this.selectserialnum.Location = new System.Drawing.Point(699, 62);
            this.selectserialnum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectserialnum.Name = "selectserialnum";
            this.selectserialnum.Size = new System.Drawing.Size(89, 24);
            this.selectserialnum.TabIndex = 20;
            this.selectserialnum.Text = "Select";
            this.selectserialnum.UseVisualStyleBackColor = true;
            this.selectserialnum.Click += new System.EventHandler(this.button1_Click);
            // 
            // assignedcheckbox
            // 
            this.assignedcheckbox.AutoSize = true;
            this.assignedcheckbox.Enabled = false;
            this.assignedcheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.assignedcheckbox.Location = new System.Drawing.Point(536, 317);
            this.assignedcheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.assignedcheckbox.Name = "assignedcheckbox";
            this.assignedcheckbox.Size = new System.Drawing.Size(92, 25);
            this.assignedcheckbox.TabIndex = 21;
            this.assignedcheckbox.Text = "Assigned";
            this.assignedcheckbox.UseVisualStyleBackColor = true;
            this.assignedcheckbox.CheckedChanged += new System.EventHandler(this.assignedcheckbox_CheckedChanged);
            // 
            // stockedcheckbox
            // 
            this.stockedcheckbox.AutoSize = true;
            this.stockedcheckbox.Enabled = false;
            this.stockedcheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stockedcheckbox.Location = new System.Drawing.Point(680, 317);
            this.stockedcheckbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stockedcheckbox.Name = "stockedcheckbox";
            this.stockedcheckbox.Size = new System.Drawing.Size(83, 25);
            this.stockedcheckbox.TabIndex = 22;
            this.stockedcheckbox.Text = "Stocked";
            this.stockedcheckbox.UseVisualStyleBackColor = true;
            this.stockedcheckbox.CheckedChanged += new System.EventHandler(this.stockedcheckbox_CheckedChanged);
            // 
            // savebutton
            // 
            this.savebutton.Enabled = false;
            this.savebutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savebutton.Location = new System.Drawing.Point(654, 370);
            this.savebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(133, 38);
            this.savebutton.TabIndex = 23;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // selectedserialtextbox
            // 
            this.selectedserialtextbox.Enabled = false;
            this.selectedserialtextbox.Location = new System.Drawing.Point(514, 63);
            this.selectedserialtextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectedserialtextbox.Name = "selectedserialtextbox";
            this.selectedserialtextbox.Size = new System.Drawing.Size(179, 23);
            this.selectedserialtextbox.TabIndex = 25;
            this.selectedserialtextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(514, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Serial number selected:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(276, 411);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Quantity:";
            // 
            // quantity_count
            // 
            this.quantity_count.AutoSize = true;
            this.quantity_count.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantity_count.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.quantity_count.Location = new System.Drawing.Point(346, 411);
            this.quantity_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantity_count.Name = "quantity_count";
            this.quantity_count.Size = new System.Drawing.Size(0, 21);
            this.quantity_count.TabIndex = 28;
            // 
            // dateedited
            // 
            this.dateedited.AutoSize = true;
            this.dateedited.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateedited.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateedited.Location = new System.Drawing.Point(514, 342);
            this.dateedited.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateedited.Name = "dateedited";
            this.dateedited.Size = new System.Drawing.Size(270, 21);
            this.dateedited.TabIndex = 29;
            this.dateedited.Text = "Last updated: dd/MM/yyyy HH:mm:ss";
            this.dateedited.Click += new System.EventHandler(this.dateedited_Click);
            // 
            // managestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateedited);
            this.Controls.Add(this.quantity_count);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectedserialtextbox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.stockedcheckbox);
            this.Controls.Add(this.assignedcheckbox);
            this.Controls.Add(this.selectserialnum);
            this.Controls.Add(this.serialnumlistbox);
            this.Controls.Add(this.selectcatagorybutton);
            this.Controls.Add(this.csvlistbox);
            this.Controls.Add(this.commentbox);
            this.Controls.Add(this.ticketnumberbox);
            this.Controls.Add(this.ordernumberbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.return_to_main_menu);
            this.Controls.Add(this.catagory_name_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.load_catagories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "managestock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Management System";
            this.Load += new System.EventHandler(this.managestock_Load_2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button selectcatagorybutton;
        private Label label3;
        private TextBox textBox1;
        private Button savebutton;
        private Button load_catagories;
        private TextBox catagory_name_box;
        private Button return_to_main_menu;
        private Button delete_button;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ordernumberbox;
        private TextBox ticketnumberbox;
        private TextBox commentbox;
        private ListBox csvlistbox;
        private ListBox serialnumlistbox;
        private Button selectserialnum;
        private CheckBox assignedcheckbox;
        private CheckBox stockedcheckbox;
        private TextBox selectedserialtextbox;
        private ListBox catagorylistbox;
        private Label label7;
        private Label label8;
        private Label quantity_count;
        private Label dateedited;
    }
}