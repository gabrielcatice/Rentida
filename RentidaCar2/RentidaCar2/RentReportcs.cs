using System;
using System.Windows.Forms;

namespace RentidaCar2
{
    public partial class RentReportcs : FormLayout
    {
        public RentReportcs()
        {
            InitializeComponent();
        }

        private void backHome_Click(object sender, EventArgs e)
        {
            Home1 home = new Home1();
            home.Show();
            this.Hide();
        }
    }
}
