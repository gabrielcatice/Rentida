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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alugarUmCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentCar alugar = new RentCar();
            alugar.Show();
            this.Hide();
        }

        private void gestãoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente Cliente = new Cliente();
            Cliente.Show();
            this.Hide();
        }

        private void gestãoDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Veiculos Veiculo = new Veiculos();
            Veiculo.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
