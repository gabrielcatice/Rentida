namespace RentidaCar2
{
    partial class FormLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLayout));
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.Sair = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.Panelx = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonPanel.Location = new System.Drawing.Point(192, 539);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(784, 10);
            this.buttonPanel.TabIndex = 7;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Controls.Add(this.Sair);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(192, 549);
            this.leftPanel.TabIndex = 10;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.White;
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Location = new System.Drawing.Point(28, 10);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(132, 87);
            this.logoPanel.TabIndex = 12;
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.White;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.Sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.Sair.Location = new System.Drawing.Point(10, 481);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(168, 52);
            this.Sair.TabIndex = 10;
            this.Sair.Text = "Voltar";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rightPanel.Location = new System.Drawing.Point(966, 10);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 529);
            this.rightPanel.TabIndex = 11;
            // 
            // Panelx
            // 
            this.Panelx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.Panelx.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelx.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Panelx.Location = new System.Drawing.Point(192, 0);
            this.Panelx.Name = "Panelx";
            this.Panelx.Size = new System.Drawing.Size(784, 10);
            this.Panelx.TabIndex = 9;
            // 
            // FormLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 549);
            this.ControlBox = false;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.Panelx);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLayout";
            this.Load += new System.EventHandler(this.FormLayout_Load);
            this.leftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel rightPanel;
        public System.Windows.Forms.Panel leftPanel;
        public System.Windows.Forms.Panel logoPanel;
        public System.Windows.Forms.Panel Panelx;
        private System.Windows.Forms.Button Sair;
    }
}