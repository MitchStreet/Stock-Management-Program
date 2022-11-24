using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Christie_NHS___Stock_control_program
{
    public partial class managecategories : Form
    {
        public managecategories()
        {
            InitializeComponent();
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

        private void selectcatagorybutton_Click(object sender, EventArgs e)
        {
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
                string csvpath = (@$"{directory_path}\catagories.csv");
                string[] csvlines = System.IO.File.ReadAllLines(csvpath);

                // Disable the button
                load_catagories.Enabled = false;
                // Change text to "Loaded"
                load_catagories.Text = "Loaded";
                // Enable delete button
                deletecategorybutton.Enabled = true;
                // Enable input boxes
                category_name_box.Enabled = true;
                model_box.Enabled = true;
                description_box.Enabled = true;
                // Enable save button
                save_button.Enabled = true;

                // Select row 1, column 2 of csv file

                // Display 1st column of csv in textbox
                foreach (string csvline in csvlines)
                {
                    string[] csvvalues = csvline.Split(',');
                    if (csvvalues[0] == catagory_name_box.Text)
                    {
                        // Category name box
                        if (csvvalues[0] != "")
                        {
                            category_name_box.Text = csvvalues[0];
                        }
                        else
                        {
                            category_name_box.Text = "";
                        }
                        // Model box
                        if (csvvalues[2] != "")
                        {
                            model_box.Text = csvvalues[2];
                        }
                        else
                        {
                            model_box.Text = "";
                        }
                        // Description box
                        if (csvvalues[1] != "")
                        {
                            description_box.Text = csvvalues[1];
                        }
                        else
                        {
                            description_box.Text = "";
                        }
                    }
                }

            }
        }

        private void csvlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deletecategorybutton_Click(object sender, EventArgs e)
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

                // Remove whitespaces from selected category
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

                // Disable delete button
                deletecategorybutton.Enabled = false;

                // Clear boxes
                category_name_box.Text = "";
                model_box.Text = "";
                description_box.Text = "";

                // Disable boxes
                category_name_box.Enabled = false;
                model_box.Enabled = false;
                description_box.Enabled = false;

                // Disable save buttomn
                save_button.Enabled = false;
                
                

            }
        }

        private void catagory_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void return_to_main_menu_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
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
            string csvpath = (@$"{directory_path}\catagories.csv");
            string[] csvlines = System.IO.File.ReadAllLines(csvpath);

            // Delete row containing selected category
            string[] lines = System.IO.File.ReadAllLines(csvpath);
            string[] newlines = lines.Where(line => !line.Contains(csvlistbox.SelectedItem.ToString())).ToArray();
            System.IO.File.WriteAllLines(csvpath, newlines);

            // Recieve updated information
            // Make new csv file name
            string new_csv_file_name = category_name_box.Text.Replace(" ", string.Empty);

            // Write new line with updated information
            System.IO.File.AppendAllText(@$"{directory_path}\catagories.csv", category_name_box.Text + "," + description_box.Text + "," + model_box.Text + "," + new_csv_file_name + "," + Environment.NewLine);
            // Rename csv file
            File.Move(@$"{directory_path}\{selected_catagory.ToString()}.csv", @$"{directory_path}\{new_csv_file_name.ToString()}.csv");

            // Clear csvlistbox
            csvlistbox.Items.Clear();
            
            // Clear boxes
            catagory_name_box.Text = "";
            category_name_box.Text = "";
            model_box.Text = "";
            description_box.Text = "";

            // Enable load categories button
            load_catagories.Enabled = true;
            // Disable select button
            selectcatagorybutton.Enabled = false;
            // Disable delete buttom
            deletecategorybutton.Enabled = false;

            // Disable boxes
            category_name_box.Enabled = false;
            model_box.Enabled = false;
            description_box.Enabled = false;

            // Disable save button
            save_button.Enabled = false;

            // Change load categories button
            load_catagories.Text = "Load categories";
        }
    }
}
