namespace RentidaCar2
{
    partial class Veiculos1
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
            this.carDetail = new System.Windows.Forms.Button();
            this.carFilter = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeCar = new System.Windows.Forms.Button();
            this.carUpdate = new System.Windows.Forms.Button();
            this.addCar = new System.Windows.Forms.Button();
            this.carSearch = new System.Windows.Forms.Label();
            this.carRegister = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(192, 545);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(777, 10);
            // 
            // carDetail
            // 
            this.carDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carDetail.Font = new System.Drawing.Font("Cambria", 12.25F, System.Drawing.FontStyle.Bold);
            this.carDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.carDetail.Location = new System.Drawing.Point(814, 480);
            this.carDetail.Name = "carDetail";
            this.carDetail.Size = new System.Drawing.Size(134, 52);
            this.carDetail.TabIndex = 19;
            this.carDetail.Text = "Detalhar";
            this.carDetail.UseVisualStyleBackColor = true;
            // 
            // carFilter
            // 
            this.carFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.carFilter.Location = new System.Drawing.Point(342, 75);
            this.carFilter.Name = "carFilter";
            this.carFilter.Size = new System.Drawing.Size(493, 27);
            this.carFilter.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand,
            this.modelName,
            this.releaseYear,
            this.kmAmount,
            this.carType,
            this.isRent,
            this.lastRent,
            this.idCar});
            this.dataGridView1.Location = new System.Drawing.Point(200, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 321);
            this.dataGridView1.TabIndex = 17;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Marca";
            this.Brand.Name = "Brand";
            // 
            // modelName
            // 
            this.modelName.HeaderText = "Modelo";
            this.modelName.Name = "modelName";
            // 
            // releaseYear
            // 
            this.releaseYear.HeaderText = "Ano de Fabricação";
            this.releaseYear.Name = "releaseYear";
            // 
            // kmAmount
            // 
            this.kmAmount.HeaderText = "Quilometragem";
            this.kmAmount.Name = "kmAmount";
            // 
            // carType
            // 
            this.carType.HeaderText = "Tipo do carro";
            this.carType.Name = "carType";
            // 
            // isRent
            // 
            this.isRent.HeaderText = "Alugado";
            this.isRent.Name = "isRent";
            // 
            // lastRent
            // 
            this.lastRent.HeaderText = "Último Aluguel";
            this.lastRent.Name = "lastRent";
            // 
            // idCar
            // 
            this.idCar.HeaderText = "Placa";
            this.idCar.Name = "idCar";
            // 
            // removeCar
            // 
            this.removeCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeCar.Font = new System.Drawing.Font("Cambria", 12.25F, System.Drawing.FontStyle.Bold);
            this.removeCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.removeCar.Location = new System.Drawing.Point(401, 483);
            this.removeCar.Name = "removeCar";
            this.removeCar.Size = new System.Drawing.Size(134, 52);
            this.removeCar.TabIndex = 15;
            this.removeCar.Text = "Remover Veículo";
            this.removeCar.UseVisualStyleBackColor = true;
            // 
            // carUpdate
            // 
            this.carUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carUpdate.Font = new System.Drawing.Font("Cambria", 12.25F, System.Drawing.FontStyle.Bold);
            this.carUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.carUpdate.Location = new System.Drawing.Point(608, 480);
            this.carUpdate.Name = "carUpdate";
            this.carUpdate.Size = new System.Drawing.Size(134, 53);
            this.carUpdate.TabIndex = 14;
            this.carUpdate.Text = "Atualizar Veículo";
            this.carUpdate.UseVisualStyleBackColor = true;
            // 
            // addCar
            // 
            this.addCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCar.Font = new System.Drawing.Font("Cambria", 12.25F, System.Drawing.FontStyle.Bold);
            this.addCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.addCar.Location = new System.Drawing.Point(213, 480);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(134, 53);
            this.addCar.TabIndex = 13;
            this.addCar.Text = "Adicionar Veículo";
            this.addCar.UseVisualStyleBackColor = true;
            this.addCar.Click += new System.EventHandler(this.addCar_Click);
            // 
            // carSearch
            // 
            this.carSearch.AutoSize = true;
            this.carSearch.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.carSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.carSearch.Location = new System.Drawing.Point(198, 75);
            this.carSearch.Name = "carSearch";
            this.carSearch.Size = new System.Drawing.Size(138, 22);
            this.carSearch.TabIndex = 12;
            this.carSearch.Text = "Buscar Veículo";
            // 
            // carRegister
            // 
            this.carRegister.AutoSize = true;
            this.carRegister.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold);
            this.carRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(114)))), ((int)(((byte)(155)))));
            this.carRegister.Location = new System.Drawing.Point(501, 13);
            this.carRegister.Name = "carRegister";
            this.carRegister.Size = new System.Drawing.Size(116, 32);
            this.carRegister.TabIndex = 21;
            this.carRegister.Text = "Veículos";
            this.carRegister.Click += new System.EventHandler(this.carRegister_Click);
            // 
            // Veiculos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 555);
            this.Controls.Add(this.carRegister);
            this.Controls.Add(this.carDetail);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.carFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeCar);
            this.Controls.Add(this.carUpdate);
            this.Controls.Add(this.carSearch);
            this.Name = "Veiculos1";
            this.Text = "Veiculos1";
            this.Load += new System.EventHandler(this.Veiculos1_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.carSearch, 0);
            this.Controls.SetChildIndex(this.carUpdate, 0);
            this.Controls.SetChildIndex(this.removeCar, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.carFilter, 0);
            this.Controls.SetChildIndex(this.addCar, 0);
            this.Controls.SetChildIndex(this.carDetail, 0);
            this.Controls.SetChildIndex(this.carRegister, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button carDetail;
        private System.Windows.Forms.TreeView carFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn carType;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCar;
        private System.Windows.Forms.Button removeCar;
        private System.Windows.Forms.Button carUpdate;
        private System.Windows.Forms.Button addCar;
        private System.Windows.Forms.Label carSearch;
        private System.Windows.Forms.Label carRegister;
    }
}