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
            this.carFilter = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backHome = new System.Windows.Forms.Button();
            this.removeClient = new System.Windows.Forms.Button();
            this.clientUpdate = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.clientSearch = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRentCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // carFilter
            // 
            this.carFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.carFilter.Location = new System.Drawing.Point(114, 9);
            this.carFilter.Name = "carFilter";
            this.carFilter.Size = new System.Drawing.Size(570, 27);
            this.carFilter.TabIndex = 14;
            this.carFilter.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.carFilter_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(50, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 227);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // backHome
            // 
            this.backHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backHome.Location = new System.Drawing.Point(583, 287);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(101, 23);
            this.backHome.TabIndex = 12;
            this.backHome.Text = "Voltar";
            this.backHome.UseVisualStyleBackColor = true;
            this.backHome.Click += new System.EventHandler(this.button4_Click);
            // 
            // removeClient
            // 
            this.removeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeClient.Location = new System.Drawing.Point(170, 287);
            this.removeClient.Name = "removeClient";
            this.removeClient.Size = new System.Drawing.Size(105, 23);
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
            this.clientUpdate.Location = new System.Drawing.Point(306, 287);
            this.clientUpdate.Name = "clientUpdate";
            this.clientUpdate.Size = new System.Drawing.Size(103, 23);
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
            this.addClient.Location = new System.Drawing.Point(39, 287);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(107, 23);
            this.addClient.TabIndex = 9;
            this.addClient.Text = "Adicionar Cliente";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientSearch
            // 
            this.clientSearch.AutoSize = true;
            this.clientSearch.Location = new System.Drawing.Point(18, 9);
            this.clientSearch.Name = "clientSearch";
            this.clientSearch.Size = new System.Drawing.Size(75, 13);
            this.clientSearch.TabIndex = 8;
            this.clientSearch.Text = "Buscar Cliente";
            this.clientSearch.Click += new System.EventHandler(this.carSearch_Click);
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
            // cliDetail
            // 
            this.cliDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cliDetail.Location = new System.Drawing.Point(444, 287);
            this.cliDetail.Name = "cliDetail";
            this.cliDetail.Size = new System.Drawing.Size(101, 23);
            this.cliDetail.TabIndex = 15;
            this.cliDetail.Text = "Detalhar";
            this.cliDetail.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 318);
            this.Controls.Add(this.cliDetail);
            this.Controls.Add(this.carFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.removeClient);
            this.Controls.Add(this.clientUpdate);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.clientSearch);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView carFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backHome;
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