namespace RentidaCar2
{
    partial class Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.carFilter = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRentCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeClient = new System.Windows.Forms.Button();
            this.clientUpdate = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.clientSearch = new System.Windows.Forms.Label();
            this.cliDetail = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.Panelx.Size = new System.Drawing.Size(774, 10);
            // 
            // carFilter
            // 
            this.carFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.carFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carFilter.Location = new System.Drawing.Point(332, 32);
            this.carFilter.Name = "carFilter";
            this.carFilter.Size = new System.Drawing.Size(628, 27);
            this.carFilter.TabIndex = 14;
            this.carFilter.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.carFilter_AfterSelect);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.idCli,
            this.document,
            this.phoneNumber,
            this.gender,
            this.birthDate,
            this.lastRentCli,
            this.clientStatus});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(202, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(758, 349);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Nome";
            this.fullName.Name = "fullName";
            // 
            // idCli
            // 
            this.idCli.HeaderText = "CPF";
            this.idCli.Name = "idCli";
            // 
            // document
            // 
            this.document.HeaderText = "RG";
            this.document.Name = "document";
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Fone";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // gender
            // 
            this.gender.HeaderText = "Sexo";
            this.gender.Name = "gender";
            // 
            // birthDate
            // 
            this.birthDate.HeaderText = "Data Nascimento";
            this.birthDate.Name = "birthDate";
            // 
            // lastRentCli
            // 
            this.lastRentCli.HeaderText = "Último Aluguel";
            this.lastRentCli.Name = "lastRentCli";
            // 
            // clientStatus
            // 
            this.clientStatus.HeaderText = "Situação";
            this.clientStatus.Name = "clientStatus";
            // 
            // removeClient
            // 
            this.removeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeClient.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.removeClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.removeClient.Location = new System.Drawing.Point(427, 468);
            this.removeClient.Name = "removeClient";
            this.removeClient.Size = new System.Drawing.Size(118, 60);
            this.removeClient.TabIndex = 11;
            this.removeClient.Text = "Remover Cliente";
            this.removeClient.UseVisualStyleBackColor = true;
            this.removeClient.Click += new System.EventHandler(this.button3_Click);
            // 
            // clientUpdate
            // 
            this.clientUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientUpdate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.clientUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.clientUpdate.Location = new System.Drawing.Point(610, 468);
            this.clientUpdate.Name = "clientUpdate";
            this.clientUpdate.Size = new System.Drawing.Size(122, 60);
            this.clientUpdate.TabIndex = 10;
            this.clientUpdate.Text = "Atualizar Cliente";
            this.clientUpdate.UseVisualStyleBackColor = true;
            this.clientUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // addClient
            // 
            this.addClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addClient.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.addClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.addClient.Location = new System.Drawing.Point(248, 468);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(109, 60);
            this.addClient.TabIndex = 9;
            this.addClient.Text = "Adicionar Cliente";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientSearch
            // 
            this.clientSearch.AutoSize = true;
            this.clientSearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.clientSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.clientSearch.Location = new System.Drawing.Point(192, 32);
            this.clientSearch.Name = "clientSearch";
            this.clientSearch.Size = new System.Drawing.Size(135, 22);
            this.clientSearch.TabIndex = 8;
            this.clientSearch.Text = "Buscar Cliente";
            this.clientSearch.Click += new System.EventHandler(this.carSearch_Click);
            // 
            // cliDetail
            // 
            this.cliDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cliDetail.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.cliDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.cliDetail.Location = new System.Drawing.Point(786, 468);
            this.cliDetail.Name = "cliDetail";
            this.cliDetail.Size = new System.Drawing.Size(124, 60);
            this.cliDetail.TabIndex = 15;
            this.cliDetail.Text = "Detalhar";
            this.cliDetail.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 559);
            this.Controls.Add(this.cliDetail);
            this.Controls.Add(this.carFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeClient);
            this.Controls.Add(this.clientUpdate);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.clientSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(939, 496);
            this.Name = "Cliente";
            this.Text = "RENTIDA";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.Controls.SetChildIndex(this.leftPanel, 0);
            this.Controls.SetChildIndex(this.Panelx, 0);
            this.Controls.SetChildIndex(this.clientSearch, 0);
            this.Controls.SetChildIndex(this.addClient, 0);
            this.Controls.SetChildIndex(this.clientUpdate, 0);
            this.Controls.SetChildIndex(this.removeClient, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.carFilter, 0);
            this.Controls.SetChildIndex(this.cliDetail, 0);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView carFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button removeClient;
        private System.Windows.Forms.Button clientUpdate;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Label clientSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn document;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRentCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientStatus;
        private System.Windows.Forms.Button cliDetail;
    }
}