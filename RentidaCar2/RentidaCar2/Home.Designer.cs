﻿namespace RentidaCar2
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alugarUmCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAluguéisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alugarUmCarroToolStripMenuItem,
            this.gestãoDeClientesToolStripMenuItem,
            this.gestãoDeVeículosToolStripMenuItem,
            this.consultarAluguéisToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alugarUmCarroToolStripMenuItem
            // 
            this.alugarUmCarroToolStripMenuItem.Name = "alugarUmCarroToolStripMenuItem";
            this.alugarUmCarroToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.alugarUmCarroToolStripMenuItem.Text = "Alugar um carro";
            this.alugarUmCarroToolStripMenuItem.Click += new System.EventHandler(this.alugarUmCarroToolStripMenuItem_Click);
            // 
            // gestãoDeClientesToolStripMenuItem
            // 
            this.gestãoDeClientesToolStripMenuItem.Name = "gestãoDeClientesToolStripMenuItem";
            this.gestãoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.gestãoDeClientesToolStripMenuItem.Text = "Gestão de Clientes";
            this.gestãoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeClientesToolStripMenuItem_Click);
            // 
            // gestãoDeVeículosToolStripMenuItem
            // 
            this.gestãoDeVeículosToolStripMenuItem.Name = "gestãoDeVeículosToolStripMenuItem";
            this.gestãoDeVeículosToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.gestãoDeVeículosToolStripMenuItem.Text = "Gestão de Veículos";
            this.gestãoDeVeículosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeVeículosToolStripMenuItem_Click);
            // 
            // consultarAluguéisToolStripMenuItem
            // 
            this.consultarAluguéisToolStripMenuItem.Name = "consultarAluguéisToolStripMenuItem";
            this.consultarAluguéisToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.consultarAluguéisToolStripMenuItem.Text = "Consultar Aluguéis ";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 323);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alugarUmCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeVeículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAluguéisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}