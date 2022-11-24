using Microsoft.VisualBasic.Logging;
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
    public partial class scanstock : Form
    {
        public scanstock()
        {
            InitializeComponent();

            // Set logo_location variable to text in logolink.txt located in the same directory as the executable
            string logo_location = System.IO.File.ReadAllText("logolink.txt");

            // Set logo image location to 'logo.png'
            logo.ImageLocation = logo_location;
        }

        private void NHSlogo_Click(object sender, EventArgs e)
        {

        }

        // Return to main menu button
        private void return_to_main_menu_Click(object sender, EventArgs e)
        {
            // Open 'landingpage' form
            landingpage landingpage = new landingpage();
            landingpage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open 'Add new catagory' form
            addnewcat addnewcat = new addnewcat();
            addnewcat.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open 'Add to catagory' form
            addtocat addtocat = new addtocat();
            addtocat.Show();
            this.Hide();
        }

        private void scanstock_Load(object sender, EventArgs e)
        {

        }
    }
}
