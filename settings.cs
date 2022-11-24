using IWshRuntimeLibrary;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using File = System.Net.WebRequestMethods.File;

namespace The_Christie_NHS___Stock_control_program
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();

            // Set label4 to saved directory path
            // Pull directory path from settings
            string directory_path;
            using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
            {
                directory_path = streamReader.ReadToEnd();
            }
            label4.Text = directory_path;

            // Set logo_location variable to text in logolink.txt located in the same directory as the executable
            string logo_location = System.IO.File.ReadAllText("logolink.txt");

            // set 'currentlogolabel' to the logo_location variable
            if (logo_location == "https://github.com/MitchStreet/Stock-Management-Program/blob/main/NHS_logo.png?raw=true")
            {
                currentlogolabel.Text = "NHS Logo";
            }
            else if (logo_location == "https://github.com/MitchStreet/Stock-Management-Program/blob/main/stock_logo.png?raw=true")
            {
                currentlogolabel.Text = "Generic Logo";
            }
            else if (logo_location == "")
            {
                currentlogolabel.Text = "Blank";
            }
            else
            {
                currentlogolabel.Text = "Custom";
            }
        }

        // Script runs on button press


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void database_dir_button_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            // Set label4 to path selected
            label4.Text = folderBrowserDialog1.SelectedPath;

            // With directory replace all database_dir.txt text
            System.IO.File.WriteAllText("database_dir.txt", folderBrowserDialog1.SelectedPath);
            Console.WriteLine("Database directory set to: " + folderBrowserDialog1.SelectedPath);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Declare variable credit
        public static bool credit;

        // Return to main menu button
        private void return_to_main_menu_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
            Environment.Exit(0);
        }

        // Reset button
        private void button1_Click(object sender, EventArgs e)
        {
            // Set the databse directory to null
            System.IO.File.WriteAllText("database_dir.txt", "");

            // Reset the directory label
            label4.Text = "No directory selected";
        }

        private void nhs_logo_Click(object sender, EventArgs e)
        {
            // Overwrite text in 'logolink.txt' with nhs logo link
            System.IO.File.WriteAllText("logolink.txt", "https://github.com/MitchStreet/Stock-Management-Program/blob/main/NHS_logo.png?raw=true");

            // Change status label to new logo
            currentlogolabel.Text = "NHS Logo";

            // Disable logo switch buttons
            nhs_logo.Enabled = false;
            generic_logo.Enabled = false;
            blank_logo.Enabled = false;
        }

        private void generic_logo_Click(object sender, EventArgs e)
        {
            // Overwrite text in 'logolink.txt' with generic logo link
            System.IO.File.WriteAllText("logolink.txt", "https://github.com/MitchStreet/Stock-Management-Program/blob/main/stock_logo.png?raw=true");

            // Change status label to new logo
            currentlogolabel.Text = "Generic Logo";

            // Disable logo switch buttons
            nhs_logo.Enabled = false;
            generic_logo.Enabled = false;
            blank_logo.Enabled = false;
        }

        private void blank_logo_Click(object sender, EventArgs e)
        {
            // Overwrite text in 'logolink.txt' with no logo
            System.IO.File.WriteAllText("logolink.txt", "");

            // Change status label to new logo
            currentlogolabel.Text = "Blank";

            // Disable logo switch buttons
            nhs_logo.Enabled = false;
            generic_logo.Enabled = false;
            blank_logo.Enabled = false;
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void currentlogolabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createdatabasedialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void makedatabasebutton_Click(object sender, EventArgs e)
        {
            // Allow user to select directory
            createdatabasedialog.ShowDialog();
            // Create .csv file in selected directory
            System.IO.File.Create(@$"{createdatabasedialog.SelectedPath}\catagories.csv");

            // Confirm database has been made
            makedatabasebutton.Enabled = false;
            makedatabasebutton.Text = "Database created";
            makedatabasebutton.ForeColor = Color.Green;

        }

        private void makeshortcut_Click(object sender, EventArgs e)
        {
            // Select downloaded program location
            programlocation.ShowDialog();
            // Set variable to selected folder
            string program_location = programlocation.SelectedPath;
            // If user doesn't select a file
            if (programlocation.SelectedPath == "")
            {
                statusmessage.Text = "No file selected";
                statusmessage.ForeColor = Color.Red;
            }
            // If Program.cs is in folder

            else if (System.IO.File.Exists(@$"{program_location}\Program.cs"))
            {
                // Select shortcut location
                shortcutlocation.ShowDialog();
                if (shortcutlocation.SelectedPath == "")
                {
                    statusmessage.Text = "Destination not selected";
                    statusmessage.ForeColor = Color.Red;
                }
                else
                {
                    // Set variable to selected folder
                    string shortcut_location = shortcutlocation.SelectedPath;

                    // Make shortcut
                    string shortcutName = "Stock Management Program";
                    string shortcutPath = shortcut_location;
                    string targetPath = (@$"{program_location}\bin\Debug\net6.0-windows");
                    string targetFile = "Stock Management Program.exe";
                    string workingDirectory = program_location;
                    string iconLocation = program_location + "\\icon.ico";

                    // Create the shortcut
                    WshShell shell = new WshShell();
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath + "\\" + shortcutName + ".lnk");
                    shortcut.Description = "System designed for managing stock";   // The description of the shortcut
                    shortcut.IconLocation = iconLocation;           // The icon of the shortcut
                    shortcut.TargetPath = targetPath + "\\" + targetFile;                 // The path of the file that will launch when the shortcut is run
                    shortcut.WorkingDirectory = ($@"{workingDirectory}\bin\Debug\net6.0-windows");
                    shortcut.Save();                                    // Save the shortcut

                    statusmessage.Text = "Shortcut created";
                    statusmessage.ForeColor = Color.Green;
                }

            }
            else
            {
                statusmessage.Text = "No file selected";
                statusmessage.ForeColor = Color.Red;
            }
        }

        private void shortcutlocation_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void programlocation_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
