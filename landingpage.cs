using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_Christie_NHS___Stock_control_program
{
    public partial class landingpage : Form
    {
        public landingpage()
        {
            InitializeComponent();

            // Set logo_location variable to text in logolink.txt located in the same directory as the executable
            string logo_location = System.IO.File.ReadAllText("logolink.txt");

            // Set logo image location to 'logo.png'
            logo.ImageLocation = logo_location;

            // Pull directory path from settings
            string directory_path;
            using (var streamReader = new StreamReader(@"database_dir.txt", Encoding.UTF8))
            {
                directory_path = streamReader.ReadToEnd();
            }

            // Does 'catagories.csv' exist?
            if (File.Exists(directory_path + @"\catagories.csv"))
            {
                databasestatuslabel.Text = "Database found!";
                databasestatuslabel.ForeColor = Color.Green;
            }
            else
            {
                databasestatuslabel.Text = "Database couldn't be found, go to settings for more info.";
                databasestatuslabel.ForeColor = Color.Red;

                // Disable menu buttons
                scaninstock.Enabled = false;
                managestock.Enabled = false;
                managecategories.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void creditLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            creditLabel.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            Process openlink = new Process();
            openlink.StartInfo.UseShellExecute = true;
            openlink.StartInfo.FileName = "https://github.com/MitchStreet";
            openlink.Start();
        }

        private void scaninstock_Click(object sender, EventArgs e)
        {
            // Open 'scanstock' form
            scanstock scanstock = new scanstock();
            scanstock.Show();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void managestock_Click(object sender, EventArgs e)
        {
            // Open 'scanstock' form
            managestock managestock = new managestock();
            managestock.Show();
            this.Hide();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            // Open 'settings' form
            settings settings = new settings();
            settings.Show();
            this.Hide();
        }

        private void databasestatuslabel_Click(object sender, EventArgs e)
        {

        }

        private void managecategories_Click(object sender, EventArgs e)
        {
            // Open 'managecategories' form
            managecategories managecategories = new managecategories();
            managecategories.Show();
            this.Hide();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            // Exit the program
            Application.Exit();
        }

        private void landingpage_Load(object sender, EventArgs e)
        {
            // If another instance of the program is running, close this one
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                // Message box with error symbol
                MessageBox.Show("Another instance of the program is already running! Closing this one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}

