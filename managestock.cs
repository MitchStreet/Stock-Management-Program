using Microsoft.VisualBasic;
using System.Data;
using System.Drawing;
using System.Text;

namespace The_Christie_NHS___Stock_control_program
{
    public partial class managestock : Form
    {
        public managestock()
        {
            InitializeComponent();
        }

        // Return to main menu button
        private void return_to_main_menu_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }


        private void load_catagories_Click(object sender, EventArgs e)
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
            load_catagories.Enabled = false;
            // Change text to "Loaded"
            load_catagories.Text = "Loaded";

            // Enable select button
            selectcatagorybutton.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void catagory_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void csvlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectcatagorybutton_Click(object sender, EventArgs e)
        {
            // Clear list box
            serialnumlistbox.Items.Clear();

            // If no selection has been made on the listbox, display error message
            if (csvlistbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
            }
            else
            {
                catagory_name_box.Text = csvlistbox.SelectedItem.ToString();

                // Pull directory path from settings
                string directory_path;
                using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
                {
                    directory_path = streamReader.ReadToEnd();
                }

                // Select catagory selected to show serial numbers
                string selected_catagory = catagory_name_box.Text.Replace(" ", string.Empty);

                // Open csv file
                string csvpath = (@$"{directory_path}\{selected_catagory}.csv");
                string[] csvlines = System.IO.File.ReadAllLines(csvpath);

                // Display 1st column of csv in textbox
                foreach (string csvline in csvlines)
                {
                    string[] csvvalues = csvline.Split(',');
                    serialnumlistbox.Items.Add(csvvalues[0]);
                }
                
                // Disable the button
                load_catagories.Enabled = false;
                // Change text to "Loaded"
                load_catagories.Text = "Loaded";
                // Enable serial number selection
                selectserialnum.Enabled = true;

                // Disable text boxes
                ordernumberbox.Enabled = false;
                ticketnumberbox.Enabled = false;
                commentbox.Enabled = false;
                // Disable checkboxes
                assignedcheckbox.Enabled = false;
                stockedcheckbox.Enabled = false;
                // Disable buttons
                delete_button.Enabled = false;
                savebutton.Enabled = false;

                // Clear text boxes
                selectedserialtextbox.Text = "";
                ordernumberbox.Text = "";
                ticketnumberbox.Text = "";
                commentbox.Text = "";
                // Clear checkboxes
                assignedcheckbox.Checked = false;
                stockedcheckbox.Checked = false;

                // Set 'quantity_count' to number of items in listbox
                string count = serialnumlistbox.Items.Count.ToString();
                // Display quantity count
                quantity_count.Text = count.ToString();

                // Enable selected serial num box
                selectedserialtextbox.Enabled = true;

                // Enable serialnumlistbox
                serialnumlistbox.Enabled = true;
            }
        }

        private void catagorylistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Select serial number button
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedserialtextbox.Text == "")
            {
                if (serialnumlistbox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a serial number.");
                }
                else
                {
                    // Disable serialnumlistbox
                    serialnumlistbox.Enabled = false;

                    // Set 'selectedserialtextbox' to 'serialnumlistbox' selection
                    selectedserialtextbox.Text = serialnumlistbox.SelectedItem.ToString();

                    // Pull directory path from settings
                    string directory_path;
                    using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
                    {
                        directory_path = streamReader.ReadToEnd();
                    }

                    // Select row 1, column 2 of csv file
                    // Select catagory selected to show serial numbers
                    string selected_catagory = catagory_name_box.Text.Replace(" ", string.Empty);

                    // Open csv file
                    string csvpath = (@$"{directory_path}\{selected_catagory}.csv");
                    string[] csvlines = System.IO.File.ReadAllLines(csvpath);

                    // Display 1st column of csv in textbox
                    foreach (string csvline in csvlines)
                    {
                        string[] csvvalues = csvline.Split(',');
                        if (csvvalues[0] == selectedserialtextbox.Text)
                        {
                            // Order number box
                            if (csvvalues[3] != "")
                            {
                                ordernumberbox.Text = csvvalues[3];
                            }
                            else
                            {
                                ordernumberbox.Text = "";
                            }
                            // Ticket number box
                            if (csvvalues[2] != "")
                            {
                                ticketnumberbox.Text = csvvalues[2];
                            }
                            else
                            {
                                ticketnumberbox.Text = "";
                            }
                            // Comment box
                            if (csvvalues[4] != "")
                            {
                                commentbox.Text = csvvalues[4];
                            }
                            else
                            {
                                commentbox.Text = "";
                            }
                            // Assigned checkbox
                            if (csvvalues[1] == "Stocked")
                            {
                                stockedcheckbox.Checked = true;
                                assignedcheckbox.Checked = false;
                            }
                            else if (csvvalues[1] == "Assigned")
                            {
                                stockedcheckbox.Checked = false;
                                assignedcheckbox.Checked = true;
                            }
                            else
                            {
                                stockedcheckbox.Checked = false;
                                assignedcheckbox.Checked = false;
                            }
                            // Date and time label
                            dateedited.Text = ($"Last edited: {csvvalues[5]}");
                        }
                    }

                    // Enable text boxes
                    ordernumberbox.Enabled = true;
                    ticketnumberbox.Enabled = true;
                    commentbox.Enabled = true;
                    // Enabled checkboxes
                    assignedcheckbox.Enabled = true;
                    stockedcheckbox.Enabled = true;
                    // Enable buttons
                    delete_button.Enabled = true;
                    savebutton.Enabled = true;
                    // Enable labels
                    label4.ForeColor = SystemColors.ControlText;
                    label5.ForeColor = SystemColors.ControlText;
                    label6.ForeColor = SystemColors.ControlText;
                    label7.ForeColor = SystemColors.ControlText;
                    dateedited.ForeColor = SystemColors.ControlText;

                    // Enable deselect button
                    deselectserialnumbutton.Enabled = true;

                }
            }
            else
            {
                if (serialnumlistbox.Items.Contains(selectedserialtextbox.Text.ToString()))
                {
                    // Disable serialnumlistbox
                    serialnumlistbox.Enabled = false;

                    // Pull directory path from settings
                    string directory_path;
                    using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
                    {
                        directory_path = streamReader.ReadToEnd();
                    }

                    // Select row 1, column 2 of csv file
                    // Select catagory selected to show serial numbers
                    string selected_catagory = catagory_name_box.Text.Replace(" ", string.Empty);

                    // Open csv file
                    string csvpath = (@$"{directory_path}\{selected_catagory}.csv");
                    string[] csvlines = System.IO.File.ReadAllLines(csvpath);

                    // Display 1st column of csv in textbox
                    foreach (string csvline in csvlines)
                    {
                        string[] csvvalues = csvline.Split(',');
                        if (csvvalues[0] == selectedserialtextbox.Text)
                        {
                            // Order number box
                            if (csvvalues[3] != "")
                            {
                                ordernumberbox.Text = csvvalues[3];
                            }
                            else
                            {
                                ordernumberbox.Text = "";
                            }
                            // Ticket number box
                            if (csvvalues[2] != "")
                            {
                                ticketnumberbox.Text = csvvalues[2];
                            }
                            else
                            {
                                ticketnumberbox.Text = "";
                            }
                            // Comment box
                            if (csvvalues[4] != "")
                            {
                                commentbox.Text = csvvalues[4];
                            }
                            else
                            {
                                commentbox.Text = "";
                            }
                            // Assigned checkbox
                            if (csvvalues[1] == "Stocked")
                            {
                                stockedcheckbox.Checked = true;
                                assignedcheckbox.Checked = false;
                            }
                            else if (csvvalues[1] == "Assigned")
                            {
                                stockedcheckbox.Checked = false;
                                assignedcheckbox.Checked = true;
                            }
                            else
                            {
                                stockedcheckbox.Checked = false;
                                assignedcheckbox.Checked = false;
                            }
                            // Date and time label
                            dateedited.Text = ($"Last edited: {csvvalues[5]}");
                        }
                    }

                    // Enable text boxes
                    ordernumberbox.Enabled = true;
                    ticketnumberbox.Enabled = true;
                    commentbox.Enabled = true;
                    // Enabled checkboxes
                    assignedcheckbox.Enabled = true;
                    stockedcheckbox.Enabled = true;
                    // Enable buttons
                    delete_button.Enabled = true;
                    savebutton.Enabled = true;
                    // Enable labels
                    label4.ForeColor = SystemColors.ControlText;
                    label5.ForeColor = SystemColors.ControlText;
                    label6.ForeColor = SystemColors.ControlText;
                    label7.ForeColor = SystemColors.ControlText;
                    dateedited.ForeColor = SystemColors.ControlText;

                    // Enable deselect button
                    deselectserialnumbutton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Serial num not found!.");
                }
            }
        }

        // Delete category button
        private void button2_Click(object sender, EventArgs e)
        {
            // Pull directory path from settings
            string directory_path;
            using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
            {
                directory_path = streamReader.ReadToEnd();
            }

            // If no selection has been made on the listbox, display error message
            if (csvlistbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
            }
            else
            {
                // Show selected category
                catagory_name_box.Text = csvlistbox.SelectedItem.ToString();

                // Remove white spaces from 'catagory_name_box'
                string selected_catagory = catagory_name_box.Text.Replace(" ", string.Empty);

                // Directory path
                string csvpath = (@$"{directory_path}\catagories.csv");
                string[] csvlines = System.IO.File.ReadAllLines(csvpath);

                // Delete row containing selected category
                string[] lines = System.IO.File.ReadAllLines(csvpath);
                string[] newlines = lines.Where(line => !line.Contains(csvlistbox.SelectedItem.ToString())).ToArray();
                System.IO.File.WriteAllLines(csvpath, newlines);

                // Delete csv file
                File.Delete(@$"{directory_path}\{selected_catagory.ToString()}.csv");

                // Delete selected line from text box
                csvlistbox.Items.Remove(csvlistbox.SelectedItem);

                // Clear selected catagories box
                catagory_name_box.Text = "";

                // Disable deselect button
                deselectserialnumbutton.Enabled = false;

            }
        }

        // Selected Serial Number Textbox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void stockedcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (assignedcheckbox.Checked)
            {
                stockedcheckbox.Checked = false;
            }
        }

        private void assignedcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (stockedcheckbox.Checked)
            {
                assignedcheckbox.Checked = false;
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            // Save order number changes
            // Pull directory path from settings
            string directory_path;
            using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
            {
                directory_path = streamReader.ReadToEnd();
            }

            // Delete row containing selected serial number
            // Selected catagory, without the whitespaces
            string selected_catagory = catagory_name_box.Text.Replace(" ", string.Empty);

            // Directory path
            string csvpath = (@$"{directory_path}\{selected_catagory}.csv");
            string[] csvlines = System.IO.File.ReadAllLines(csvpath);

            // Delete row containing selected category
            string[] lines = System.IO.File.ReadAllLines(csvpath);
            string[] newlines = lines.Where(line => !line.Contains(selectedserialtextbox.Text.ToString())).ToArray();
            System.IO.File.WriteAllLines(csvpath, newlines);

            // Set variable 'dateandtime' to current date and time
            string dateandtime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");



            // Recieve updated information
            // Assigned or stocked checkboxes
            string assignedorstocked;
            if (assignedcheckbox.Checked == true)
            {
                assignedorstocked = "Assigned";
            }
            else if (stockedcheckbox.Checked == true)
            {
                assignedorstocked = "Stocked";
            }
            else
            {
                assignedorstocked = "";
            }

            // Write new line with updated information
            System.IO.File.AppendAllText(@$"{directory_path}\{selected_catagory}.csv", selectedserialtextbox.Text + "," + assignedorstocked + "," + ticketnumberbox.Text + "," + ordernumberbox.Text + "," + commentbox.Text + "," + dateandtime + "," + Environment.NewLine);

            // Save message
            statusmessage.Text = "Changes Saved";
            statusmessage.ForeColor = Color.Green;

            // Press select button
            selectcatagorybutton.PerformClick();

            // Enable serialnumlistbox
            serialnumlistbox.Enabled = true;

            // Disable deselect button
            deselectserialnumbutton.Enabled = false;
        }

        private void managestock_Load(object sender, EventArgs e)
        {

        }

        private void managestock_Load_1(object sender, EventArgs e)
        {

        }

        private void managestock_Load_2(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            // Pull directory path from settings
            string directory_path;
            using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
            {
                directory_path = streamReader.ReadToEnd();
            }

            // If no selection has been made on the listbox, display error message
            if (serialnumlistbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a serial number.");
            }
            else
            {
                // Show selected category
                catagory_name_box.Text = csvlistbox.SelectedItem.ToString();
                // Remove whitespaces from variable
                string selected_catagory = catagory_name_box.Text.Replace(" ", string.Empty);

                // Directory path
                string csvpath = (@$"{directory_path}\{selected_catagory}.csv");
                string[] csvlines = System.IO.File.ReadAllLines(csvpath);

                // Delete row containing selected category
                string[] lines = System.IO.File.ReadAllLines(csvpath);
                string[] newlines = lines.Where(line => !line.Contains(selectedserialtextbox.Text.ToString())).ToArray();
                System.IO.File.WriteAllLines(csvpath, newlines);

                // Delete selected line from text box
                serialnumlistbox.Items.Remove(serialnumlistbox.SelectedItem);

                // Delete message
                statusmessage.Text = "Serial number deleted";
                statusmessage.ForeColor = Color.Red;

                // Clear selected serial number box
                selectedserialtextbox.Text = "";

                // Enable serialnumlistbox
                serialnumlistbox.Enabled = true;

                // Press select category button
                selectcatagorybutton.PerformClick();

                // Disable deselect button
                deselectserialnumbutton.Enabled = false;

            }

        }

        private void dateedited_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void deselectserialnumbutton_Click(object sender, EventArgs e)
        {
            // Press select category button
            selectcatagorybutton.PerformClick();
        }
    }
}
