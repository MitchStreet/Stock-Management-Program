using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace The_Christie_NHS___Stock_control_program
{
    public partial class addtocat : Form
    {
        public addtocat()
        {
            InitializeComponent();
        }

        private void addtocat_Load(object sender, EventArgs e)
        {
            
        }

        private void assignedcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stockedcheckBox.Checked)
            {
                assignedcheckBox.Checked = false;
            }
        }

        private void stockedcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (assignedcheckBox.Checked)
            {
                stockedcheckBox.Checked = false;
            }
        }

        // Return to main menu button
        private void return_to_main_menu_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void csvlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void loadbutton_Click(object sender, EventArgs e)
        {
            // Pull directory path from settings
            string directory_path;
            using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
            {
                directory_path = streamReader.ReadToEnd();
            }

            // Open csv file
            string csvpath = (@$"{directory_path}\catagories.csv");
            string[] csvlines = System.IO.File.ReadAllLines(csvpath);

            // Display 1st column of csv in textbox
            foreach (string csvline in csvlines)
            {
                string[] csvvalues = csvline.Split(',');
                csvlistbox.Items.Add(csvvalues[0]);
            }

            // Disable the button
            loadbutton.Enabled = false;
            // Change text to "Loaded"
            loadbutton.Text = "Loaded";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // If no selection has been made on the listbox, display error message
            if (csvlistbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a catagory from the list");
            }
            else
            {
                selectedcatagorybox.Text = csvlistbox.SelectedItem.ToString();

                // Unlock / enable input boxes
                serialnumberbox.Enabled = true;
                assignedcheckBox.Enabled = true;
                stockedcheckBox.Enabled = true;
                ticketnumberbox.Enabled = true;
                ordernumberbox.Enabled = true;
                commentbox.Enabled = true;
                bulkmodecheckbox.Enabled = true;
                altkeyenter.Enabled = true;

                // Change label colours
                label6.ForeColor = SystemColors.Highlight;
                label5.ForeColor = SystemColors.Highlight;
                assignedcheckBox.ForeColor = SystemColors.Highlight;
                stockedcheckBox.ForeColor = SystemColors.Highlight;
                label9.ForeColor = SystemColors.Highlight;
                label10.ForeColor = SystemColors.Highlight;
                label7.ForeColor = SystemColors.Highlight;
                
            }
        }

        private void storebutton_Click(object sender, EventArgs e)
        {
            // Adds the serial number to the selected model's .csv file
            // Pull directory path from settings
            string directory_path;
            using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
            {
                directory_path = streamReader.ReadToEnd();
            }

            // Acquire catagory .csv file name
            string selected_catagory = selectedcatagorybox.Text.Replace(" ", string.Empty);

            // Assigned or stocked decider
            string assignedorstocked;
            // If assigned checkbox is checked, assignedorstocked = "Assigned"
            if (assignedcheckBox.Checked)
            {
                assignedorstocked = "Assigned";
            }
            // If stocked checkbox is checked, assignedorstocked = "Stocked"
            else if (stockedcheckBox.Checked)
            {
                assignedorstocked = "Stocked";
            }
            // If neither are checked, assignedorstocked == ""
            else
            {
                assignedorstocked = "";
            }

            // Set variable 'dateandtime' to current date and time
            string dateandtime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");



            // Append data to the .csv
            System.IO.File.AppendAllText(@$"{directory_path}\{selected_catagory}.csv", serialnumberbox.Text + "," + assignedorstocked + "," + ticketnumberbox.Text + "," + ordernumberbox.Text + "," + commentbox.Text + "," + dateandtime + "," + Environment.NewLine);

            // Set button text to "Stored" and coloured green
            storebutton.Text = "Stored";
            storebutton.ForeColor = Color.Green;

            // Change stockedstatus label
            stockedstatus.Text = (serialnumberbox.Text + " stocked.");

            // Clear input boxes after submit
            serialnumberbox.Text = "";
            if (bulkmodecheckbox.Checked == false)
            {
                ticketnumberbox.Text = "";
                ordernumberbox.Text = "";
                commentbox.Text = "";
                stockedcheckBox.Checked = false;
                assignedcheckBox.Checked = false;
            }
            else
            {
                
            }
        }

        private void storebutton_KeyDown(object sender, KeyEventArgs e)
        {
            // Allows the user to use the 'enter' key to press the button
            if (e.KeyCode == Keys.Enter)
                storebutton.PerformClick();
        }

        private void serialnumberbox_TextChanged(object sender, EventArgs e)
        {
            // If serialnumberbox contains text, enable store button
            if (serialnumberbox.Text.Length > 0 && selectedcatagorybox.Text.Length > 0)
            {
                storebutton.Enabled = true;
                storebutton.Text = "Store";
                storebutton.ForeColor = Color.Black;
            }
            else
            {
                storebutton.Enabled = false;
            }
        }

        private void selectedcatagorybox_TextChanged(object sender, EventArgs e)
        {
            // If selectedcatagorybox contains text, enable store button
            if (serialnumberbox.Text.Length > 0 && selectedcatagorybox.Text.Length > 0)
            {
                storebutton.Enabled = true;
                storebutton.Text = "Store";
                storebutton.ForeColor = Color.Black;
            }
            else
            {
                storebutton.Enabled = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ordernumberbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bulkmodecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (bulkmodecheckbox.Checked == true)
            {
                // Change text colours
                label5.ForeColor = SystemColors.ControlText;
                assignedcheckBox.ForeColor = SystemColors.ControlText;
                stockedcheckBox.ForeColor = SystemColors.ControlText;
                label7.ForeColor = SystemColors.ControlText;
                label9.ForeColor = SystemColors.ControlText;
                label10.ForeColor = SystemColors.ControlText;
                
                // Change optional text
                label6.ForeColor = SystemColors.ControlText;
                label6.Text = "(Bulk mode enabled)";
                label6.Location = new Point(524, 174);
            }
            if (bulkmodecheckbox.Checked == false)
            {
                // Change text colours
                label5.ForeColor = SystemColors.Highlight;
                assignedcheckBox.ForeColor = SystemColors.Highlight;
                stockedcheckBox.ForeColor = SystemColors.Highlight;
                label7.ForeColor = SystemColors.Highlight;
                label9.ForeColor = SystemColors.Highlight;
                label10.ForeColor = SystemColors.Highlight;

                // Change optional text
                label6.ForeColor = SystemColors.Highlight;
                label6.Text = "(Optional)";
                label6.Location = new Point(552, 174);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void altkeyenter_CheckedChanged(object sender, EventArgs e)
        {
            if (altkeyenter.Checked == true)
            {
                // When the 'Enter' key is pressed, the 'Store' button is pressed
                this.AcceptButton = storebutton;
            }
        }

        private void stockedstatus_Click(object sender, EventArgs e)
        {

        }
    }
}
