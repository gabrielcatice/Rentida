namespace RentidaCar2
{
    partial class Veiculos
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
            this.carSearch = new System.Windows.Forms.Label();
            this.addCar = new System.Windows.Forms.Button();
            this.carUpdate = new System.Windows.Forms.Button();
            this.removeCar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carFilter = new System.Windows.Forms.TreeView();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // carSearch
            // 
            this.carSearch.AutoSize = true;
            this.carSearch.Location = new System.Drawing.Point(2, 9);
            this.carSearch.Name = "carSearch";
            this.carSearch.Size = new System.Drawing.Size(80, 13);
            this.carSearch.TabIndex = 0;
            this.carSearch.Text = "Buscar Veículo";
            this.carSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // addCar
            // 
            this.addCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCar.Location = new System.Drawing.Point(34, 287);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(112, 23);
            this.addCar.TabIndex = 2;
            this.addCar.Text = "Adicionar Veículo";
            this.addCar.UseVisualStyleBackColor = true;
            this.addCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // carUpdate
            // 
            this.carUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carUpdate.Location = new System.Drawing.Point(298, 287);
            this.carUpdate.Name = "carUpdate";
            this.carUpdate.Size = new System.Drawing.Size(103, 23);
            this.carUpdate.TabIndex = 3;
            this.carUpdate.Text = "Atualizar Veículo";
            this.carUpdate.UseVisualStyleBackColor = true;
            this.carUpdate.Click += new System.EventHandler(this.carUpdate_Click);
            // 
            // removeCar
            // 
            this.removeCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeCar.Location = new System.Drawing.Point(172, 287);
            this.removeCar.Name = "removeCar";
            this.removeCar.Size = new System.Drawing.Size(102, 23);
            this.removeCar.TabIndex = 4;
            this.removeCar.Text = "Remover Veículo";
            this.removeCar.UseVisualStyleBackColor = true;
            this.removeCar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(567, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(34, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 227);
            this.dataGridView1.TabIndex = 6;
            // 
            // carFilter
            // 
            this.carFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.carFilter.Location = new System.Drawing.Point(98, 9);
            this.carFilter.Name = "carFilter";
            this.carFilter.Size = new System.Drawing.Size(570, 27);
            this.carFilter.TabIndex = 7;
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
            // carDetail
            // 
            this.carDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carDetail.Location = new System.Drawing.Point(429, 287);
            this.carDetail.Name = "carDetail";
            this.carDetail.Size = new System.Drawing.Size(101, 23);
            this.carDetail.TabIndex = 8;
            this.carDetail.Text = "Detalhar";
            this.carDetail.UseVisualStyleBackColor = true;
            // 
            // Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 322);
            this.Controls.Add(this.carDetail);
            this.Controls.Add(this.carFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.removeCar);
            this.Controls.Add(this.carUpdate);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.carSearch);
            this.Name = "Veiculos";
            this.Text = "Veiculos";
            this.Load += new System.EventHandler(this.Veiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carSearch;
        private System.Windows.Forms.Button addCar;
        private System.Windows.Forms.Button carUpdate;
        private System.Windows.Forms.Button removeCar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView carFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn carType;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCar;
        private System.Windows.Forms.Button carDetail;
    }
}