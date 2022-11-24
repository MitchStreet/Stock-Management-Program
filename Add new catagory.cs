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

namespace The_Christie_NHS___Stock_control_program
{
    public partial class addnewcat : Form
    {
        // Check if file is locked
        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }

        public addnewcat()
        {
            InitializeComponent();
        }

        // Return to main menu button
        private void return_to_main_menu_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        // Validate button
        private void button1_Click(object sender, EventArgs e)
        {
            // Non-validated as default
            bool model_validated = false;
            bool name_validated = false;

            // if catagory name and model number are empty, display error
            if (modelbox.Text == "")
            {
                model_validate.Text = "Please enter or scan a model number.";
                model_validate.ForeColor = Color.Red;
                model_validated = false;
            }

            if (modelbox.Text.Length > 0)
            {
                model_validate.Text = "Valid model.";
                model_validate.ForeColor = Color.Green;
                model_validated = true;
            }

            if (catagorynamebox.Text == "")
            {
                name_validate.Text = "Please enter a category name.";
                name_validate.ForeColor = Color.Red;
                name_validated = false;
            }

            if (catagorynamebox.Text.Length > 0)
            {
                name_validate.Text = "Valid category name.";
                name_validate.ForeColor = Color.Green;
                name_validated = true;
            }

            // After successful validation, allow the creation of the category
            if (name_validated == true && model_validated == true)
            {
                validate_buttton.Text = "Validated";
                validate_buttton.ForeColor = Color.Green;
                // Set validate_button font to bold
                validate_buttton.Font = new Font(validate_buttton.Font, FontStyle.Bold);
                create_button.Enabled = true;
                create_button.Text = "Create";
                label6.Text = "Please click 'Create' to create the new category.";
            }
        }

        // Create category button
        private void button2_Click(object sender, EventArgs e)
        {
            // Gather data from text boxes
            var catagoryname = catagorynamebox.Text;
            var modelnumber = modelbox.Text;
            var description = descriptionbox.Text;

            // Pull directory path from settings
            string directory_path;
            using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
            {
                directory_path = streamReader.ReadToEnd();
            }

            // Append data to 'catagories.csv'
            System.IO.File.AppendAllText(@$"{directory_path}\catagories.csv", catagoryname + "," + description + "," + modelnumber + ",");

            // Make new .csv file to contain categories' serial numbers and add to csv
            string cat_csv_file = catagoryname.Replace(" ", string.Empty);
            System.IO.File.AppendAllText(@$"{directory_path}\catagories.csv", cat_csv_file + Environment.NewLine);
            // Make new .csv file with the name of the string "cat_csv_file"
            File.Create(@$"{directory_path}\{cat_csv_file}.csv");

            // Reset page
            // Remove cat name box text
            catagorynamebox.Text = "";
            // Remove model number box text
            modelbox.Text = "";
            // Remove description box text
            descriptionbox.Text = "";
            // Reset validation text
            model_validate.Text = "Waiting to validate...";
            name_validate.Text = "Waiting to validate...";
            // Reset validation text colour
            model_validate.ForeColor = SystemColors.ControlDark;
            name_validate.ForeColor = SystemColors.ControlDark;
            // Set create button to green and "Created" + disable
            create_button.Text = "Created";
            create_button.Enabled = false;
            // Reset validate button
            validate_buttton.Text = "Validate";
            validate_buttton.ForeColor = SystemColors.ControlText;
            validate_buttton.Font = new Font(validate_buttton.Font, FontStyle.Regular);
            // Reset label
            label6.Text = "You need to validate before creating.";

            createdmessage.Text = ($"The '{catagoryname}' catagory was created.");

        }

        private void catagorynamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_validate_Click(object sender, EventArgs e)
        {

        }

        private void model_validate_Click(object sender, EventArgs e)
        {

        }

        private void modelbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void descriptionbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addnewcat_Load(object sender, EventArgs e)
        {

        }
    }
}
