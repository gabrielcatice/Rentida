namespace RentidaCar2
{
    partial class RentReportcs
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
            this.addClient = new System.Windows.Forms.Button();
            this.searchReport = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.Label();
            this.clientStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRentCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // carFilter
            // 
            this.carFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.carFilter.Location = new System.Drawing.Point(133, 60);
            this.carFilter.Name = "carFilter";
            this.carFilter.Size = new System.Drawing.Size(605, 27);
            this.carFilter.TabIndex = 22;
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
            this.lastRentCli,
            this.clientStatus});
            this.dataGridView1.Location = new System.Drawing.Point(19, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 194);
            this.dataGridView1.TabIndex = 21;
            // 
            // backHome
            // 
            this.backHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backHome.Location = new System.Drawing.Point(652, 293);
            this.backHome.Name = "backHome";
            this.backHome.Size = new System.Drawing.Size(86, 23);
            this.backHome.TabIndex = 20;
            this.backHome.Text = "Voltar";
            this.backHome.UseVisualStyleBackColor = true;
            // 
            // addClient
            // 
            this.addClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addClient.Location = new System.Drawing.Point(525, 293);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(121, 23);
            this.addClient.TabIndex = 17;
            this.addClient.Text = "Adicionar Cliente";
            this.addClient.UseVisualStyleBackColor = true;
            // 
            // searchReport
            // 
            this.searchReport.AutoSize = true;
            this.searchReport.Location = new System.Drawing.Point(29, 60);
            this.searchReport.Name = "searchReport";
            this.searchReport.Size = new System.Drawing.Size(98, 13);
            this.searchReport.TabIndex = 16;
            this.searchReport.Text = "Pesquisar Relatório";
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.Location = new System.Drawing.Point(327, 9);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(63, 16);
            this.Report.TabIndex = 23;
            this.Report.Text = "Relatório";
            // 
            // clientStatus
            // 
            this.clientStatus.HeaderText = "Data_Fim_Aluguel";
            this.clientStatus.Name = "clientStatus";
            // 
            // lastRentCli
            // 
            this.lastRentCli.HeaderText = "Data_Inicio_Aluguel";
            this.lastRentCli.Name = "lastRentCli";
            // 
            // idCli
            // 
            this.idCli.HeaderText = "CPF";
            this.idCli.Name = "idCli";
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Cliente";
            this.fullName.Name = "fullName";
            // 
            // RentReportcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 328);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.carFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backHome);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.searchReport);
            this.Name = "RentReportcs";
            this.Text = "RentReportcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView carFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backHome;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Label searchReport;
        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRentCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientStatus;
    }
}