using System;
using System.Windows.Forms;

namespace RentidaCar2
{
    public partial class CadastroVeiculo : Form

    {
        public CadastroVeiculo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Veiculos carro = new Veiculos();
            carro.Show();
            this.Hide();
        }

        private void addCar_Click(object sender, EventArgs e)
        {

        }

        private void CadastroVeiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
