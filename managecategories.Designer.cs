namespace The_Christie_NHS___Stock_control_program
{
    partial class managecategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managecategories));
            this.csvlistbox = new System.Windows.Forms.ListBox();
            this.load_catagories = new System.Windows.Forms.Button();
            this.selectcatagorybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deletecategorybutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.catagory_name_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.return_to_main_menu = new System.Windows.Forms.Button();
            this.category_name_box = new System.Windows.Forms.TextBox();
            this.model_box = new System.Windows.Forms.TextBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.statusmessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // csvlistbox
            // 
            this.csvlistbox.FormattingEnabled = true;
            this.csvlistbox.ItemHeight = 15;
            this.csvlistbox.Location = new System.Drawing.Point(114, 89);
            this.csvlistbox.Name = "csvlistbox";
            this.csvlistbox.Size = new System.Drawing.Size(235, 304);
            this.csvlistbox.TabIndex = 0;
            this.csvlistbox.SelectedIndexChanged += new System.EventHandler(this.csvlistbox_SelectedIndexChanged);
            // 
            // load_catagories
            // 
            this.load_catagories.Location = new System.Drawing.Point(114, 60);
            this.load_catagories.Name = "load_catagories";
            this.load_catagories.Size = new System.Drawing.Size(132, 23);
            this.load_catagories.TabIndex = 1;
            this.load_catagories.Text = "Load categories";
            this.load_catagories.UseVisualStyleBackColor = true;
            this.load_catagories.Click += new System.EventHandler(this.load_catagories_Click);
            // 
            // selectcatagorybutton
            // 
            this.selectcatagorybutton.Location = new System.Drawing.Point(252, 60);
            this.selectcatagorybutton.Name = "selectcatagorybutton";
            this.selectcatagorybutton.Size = new System.Drawing.Size(97, 23);
            this.selectcatagorybutton.TabIndex = 2;
            this.selectcatagorybutton.Text = "Select";
            this.selectcatagorybutton.UseVisualStyleBackColor = true;
            this.selectcatagorybutton.Click += new System.EventHandler(this.selectcatagorybutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage categories";
            // 
            // deletecategorybutton
            // 
            this.deletecategorybutton.Enabled = false;
            this.deletecategorybutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletecategorybutton.ForeColor = System.Drawing.Color.Red;
            this.deletecategorybutton.Location = new System.Drawing.Point(114, 399);
            this.deletecategorybutton.Name = "deletecategorybutton";
            this.deletecategorybutton.Size = new System.Drawing.Size(235, 38);
            this.deletecategorybutton.TabIndex = 4;
            this.deletecategorybutton.Text = "Delete Category";
            this.deletecategorybutton.UseVisualStyleBackColor = true;
            this.deletecategorybutton.Click += new System.EventHandler(this.deletecategorybutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select category:";
            // 
            // catagory_name_box
            // 
            this.catagory_name_box.Location = new System.Drawing.Point(386, 61);
            this.catagory_name_box.Name = "catagory_name_box";
            this.catagory_name_box.ReadOnly = true;
            this.catagory_name_box.Size = new System.Drawing.Size(301, 23);
            this.catagory_name_box.TabIndex = 7;
            this.catagory_name_box.TextChanged += new System.EventHandler(this.catagory_name_box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(386, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category selected:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // return_to_main_menu
            // 
            this.return_to_main_menu.Location = new System.Drawing.Point(695, 414);
            this.return_to_main_menu.Name = "return_to_main_menu";
            this.return_to_main_menu.Size = new System.Drawing.Size(93, 23);
            this.return_to_main_menu.TabIndex = 8;
            this.return_to_main_menu.Text = "Main menu";
            this.return_to_main_menu.UseVisualStyleBackColor = true;
            this.return_to_main_menu.Click += new System.EventHandler(this.return_to_main_menu_Click);
            // 
            // category_name_box
            // 
            this.category_name_box.Enabled = false;
            this.category_name_box.Location = new System.Drawing.Point(386, 115);
            this.category_name_box.Name = "category_name_box";
            this.category_name_box.Size = new System.Drawing.Size(301, 23);
            this.category_name_box.TabIndex = 9;
            // 
            // model_box
            // 
            this.model_box.Enabled = false;
            this.model_box.Location = new System.Drawing.Point(386, 169);
            this.model_box.Name = "model_box";
            this.model_box.Size = new System.Drawing.Size(301, 23);
            this.model_box.TabIndex = 10;
            // 
            // description_box
            // 
            this.description_box.Enabled = false;
            this.description_box.Location = new System.Drawing.Point(386, 223);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(301, 170);
            this.description_box.TabIndex = 11;
            this.description_box.TextChanged += new System.EventHandler(this.description_box_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(386, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Category name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(386, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Model:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(386, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Description:";
            // 
            // save_button
            // 
            this.save_button.Enabled = false;
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_button.Location = new System.Drawing.Point(386, 399);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(301, 38);
            this.save_button.TabIndex = 15;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // statusmessage
            // 
            this.statusmessage.Location = new System.Drawing.Point(532, 9);
            this.statusmessage.Name = "statusmessage";
            this.statusmessage.Size = new System.Drawing.Size(256, 23);
            this.statusmessage.TabIndex = 16;
            this.statusmessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // managecategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusmessage);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.model_box);
            this.Controls.Add(this.category_name_box);
            this.Controls.Add(this.return_to_main_menu);
            this.Controls.Add(this.catagory_name_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deletecategorybutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectcatagorybutton);
            this.Controls.Add(this.load_catagories);
            this.Controls.Add(this.csvlistbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "managecategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox csvlistbox;
        private Button load_catagories;
        private Button selectcatagorybutton;
        private Label label1;
        private Button deletecategorybutton;
        private Label label2;
        private TextBox catagory_name_box;
        private Label label3;
        private Button return_to_main_menu;
        private TextBox category_name_box;
        private TextBox model_box;
        private TextBox description_box;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button save_button;
        private Label statusmessage;
    }
}