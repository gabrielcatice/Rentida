﻿using System;
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
    public partial class Veiculos1 : FormLayout
    {
        public Veiculos1()
        {
            InitializeComponent();
        }

        private void Veiculos1_Load(object sender, EventArgs e)
        {

        }

        private void carRegister_Click(object sender, EventArgs e)
        {

        }

        private void addCar_Click(object sender, EventArgs e)
        {
            CadastroVeiculo1 registerCar = new CadastroVeiculo1();
            registerCar.Show();
            this.Close();
        }
    }
}
