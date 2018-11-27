using System;
using System.Windows.Forms;

namespace RentidaCar2
{
    public partial class RentReportcs : Form
    {
        public RentReportcs()
        {
            InitializeComponent();
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
