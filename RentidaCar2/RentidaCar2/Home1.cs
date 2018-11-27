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
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
           // base.closeButtonTxt = "Voltar";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void alugarUmCarro_Click(object sender, EventArgs e)
        {
            RentCar alugar = new RentCar();
            this.Hide();
            alugar.ShowDialog();
            this.Show();
            
        }

        private void Veiculos_Click(object sender, EventArgs e)
        {
            Veiculos1 Veiculo = new Veiculos1();
            Veiculo.Show();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            Cliente Cliente = new Cliente();
            Cliente.Show();
        }


        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Alugados_Click(object sender, EventArgs e)
        {
            RentReportcs relatorio = new RentReportcs();
            relatorio.Show();
            this.Hide();
        }

        private void Home1_Load(object sender, EventArgs e)
        {

        }
    }
}
