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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Sair = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Location = new System.Drawing.Point(192, 539);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(784, 10);
            this.panel5.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.Sair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 549);
            this.panel1.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(28, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(132, 87);
            this.panel6.TabIndex = 12;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Location = new System.Drawing.Point(966, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 529);
            this.panel4.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(192, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 10);
            this.panel2.TabIndex = 9;
            // 
            // FormLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 549);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLayout";
            this.Load += new System.EventHandler(this.FormLayout_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sair;
    }
}