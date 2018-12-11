using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentidaCar2
{
    public partial class FormLayout : Form
    {
        public FormLayout()
        {
            InitializeComponent();
        }
        public String closeButtonTxt
        {
            get
            {
                return Sair.Text;

            }
            set
            {
                Sair.Text = value;
            }
        }

        private void FormLayout_Load(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
