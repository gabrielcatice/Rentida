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
    public partial class Veiculos : Form
    {
        public Veiculos()
        {
            InitializeComponent();
        }

        private void Veiculos_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Home formAberto in Application.OpenForms)
                {
                    if (formAberto is Home)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                Home home = new Home();
                home.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroVeiculo registerCar = new CadastroVeiculo();
            registerCar.Show();
            Hide();
        }

        private void carUpdate_Click(object sender, EventArgs e)
        {
            CadastroVeiculo registerCar = new CadastroVeiculo();
            registerCar.Show();
            Hide();
        }

        private void carFilter_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carDetail_Click(object sender, EventArgs e)
        {

        }
    }
}
