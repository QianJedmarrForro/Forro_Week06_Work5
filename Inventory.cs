using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forro_Week06_Work5
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void ShowPage(UserControl page)
        {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }
        

        private void mnuHome_Click(object sender, EventArgs e)
        {
            ShowPage(new ucHomePage());
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuInventory_Click(object sender, EventArgs e)
        {

        }

        private void mnuAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void mnuProductList_Click(object sender, EventArgs e)
        {
            ShowPage(new ucProductListing());
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userResponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
