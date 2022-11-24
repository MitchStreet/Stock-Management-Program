namespace The_Christie_NHS___Stock_control_program
{
    partial class addnewcat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addnewcat));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.catagorynamebox = new System.Windows.Forms.TextBox();
            this.modelbox = new System.Windows.Forms.TextBox();
            this.descriptionbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.return_to_main_menu = new System.Windows.Forms.Button();
            this.validate_buttton = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.name_validate = new System.Windows.Forms.Label();
            this.model_validate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.createdmessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // catagorynamebox
            // 
            this.catagorynamebox.Location = new System.Drawing.Point(64, 124);
            this.catagorynamebox.Name = "catagorynamebox";
            this.catagorynamebox.Size = new System.Drawing.Size(317, 23);
            this.catagorynamebox.TabIndex = 4;
            this.catagorynamebox.TextChanged += new System.EventHandler(this.catagorynamebox_TextChanged);
            // 
            // modelbox
            // 
            this.modelbox.Location = new System.Drawing.Point(64, 194);
            this.modelbox.Name = "modelbox";
            this.modelbox.Size = new System.Drawing.Size(317, 23);
            this.modelbox.TabIndex = 5;
            this.modelbox.TextChanged += new System.EventHandler(this.modelbox_TextChanged);
            // 
            // descriptionbox
            // 
            this.descriptionbox.Location = new System.Drawing.Point(64, 267);
            this.descriptionbox.Multiline = true;
            this.descriptionbox.Name = "descriptionbox";
            this.descriptionbox.Size = new System.Drawing.Size(317, 129);
            this.descriptionbox.TabIndex = 6;
            this.descriptionbox.TextChanged += new System.EventHandler(this.descriptionbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(113, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter the details below:";
            // 
            // return_to_main_menu
            // 
            this.return_to_main_menu.Location = new System.Drawing.Point(695, 415);
            this.return_to_main_menu.Name = "return_to_main_menu";
            this.return_to_main_menu.Size = new System.Drawing.Size(93, 23);
            this.return_to_main_menu.TabIndex = 8;
            this.return_to_main_menu.Text = "Main menu";
            this.return_to_main_menu.UseVisualStyleBackColor = true;
            this.return_to_main_menu.Click += new System.EventHandler(this.return_to_main_menu_Click);
            // 
            // validate_buttton
            // 
            this.validate_buttton.Location = new System.Drawing.Point(421, 307);
            this.validate_buttton.Name = "validate_buttton";
            this.validate_buttton.Size = new System.Drawing.Size(148, 49);
            this.validate_buttton.TabIndex = 9;
            this.validate_buttton.Text = "Validate";
            this.validate_buttton.UseVisualStyleBackColor = true;
            this.validate_buttton.Click += new System.EventHandler(this.button1_Click);
            // 
            // create_button
            // 
            this.create_button.Enabled = false;
            this.create_button.Location = new System.Drawing.Point(593, 307);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(148, 49);
            this.create_button.TabIndex = 10;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // name_validate
            // 
            this.name_validate.AutoSize = true;
            this.name_validate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_validate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.name_validate.Location = new System.Drawing.Point(421, 125);
            this.name_validate.Name = "name_validate";
            this.name_validate.Size = new System.Drawing.Size(148, 21);
            this.name_validate.TabIndex = 11;
            this.name_validate.Text = "Waiting to validate...";
            this.name_validate.Click += new System.EventHandler(this.name_validate_Click);
            // 
            // model_validate
            // 
            this.model_validate.AutoSize = true;
            this.model_validate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.model_validate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.model_validate.Location = new System.Drawing.Point(421, 195);
            this.model_validate.Name = "model_validate";
            this.model_validate.Size = new System.Drawing.Size(148, 21);
            this.model_validate.TabIndex = 12;
            this.model_validate.Text = "Waiting to validate...";
            this.model_validate.Click += new System.EventHandler(this.model_validate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(421, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "You need to validate before creating.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(320, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "(Optional)";
            // 
            // createdmessage
            // 
            this.createdmessage.AutoSize = true;
            this.createdmessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createdmessage.ForeColor = System.Drawing.Color.Green;
            this.createdmessage.Location = new System.Drawing.Point(421, 371);
            this.createdmessage.Name = "createdmessage";
            this.createdmessage.Size = new System.Drawing.Size(0, 21);
            this.createdmessage.TabIndex = 15;
            // 
            // addnewcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createdmessage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.model_validate);
            this.Controls.Add(this.name_validate);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.validate_buttton);
            this.Controls.Add(this.return_to_main_menu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionbox);
            this.Controls.Add(this.modelbox);
            this.Controls.Add(this.catagorynamebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "addnewcat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Management System";
            this.Load += new System.EventHandler(this.addnewcat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox catagorynamebox;
        private TextBox modelbox;
        private TextBox descriptionbox;
        private Label label5;
        private Button return_to_main_menu;
        private Button validate_buttton;
        private Button create_button;
        private Label name_validate;
        private Label model_validate;
        private Label label6;
        private Label label7;
        private Label createdmessage;
    }
}