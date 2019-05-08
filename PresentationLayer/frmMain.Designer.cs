namespace PresentationLayer
{
	partial class frmMain
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblIncome = new System.Windows.Forms.Label();
			this.lblExpenses = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnAddTransaction = new System.Windows.Forms.Button();
			this.dgvTransactions = new System.Windows.Forms.DataGridView();
			this.chName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Catagory = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(93, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Income";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(295, 24);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Expenses";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(504, 24);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total";
			// 
			// lblIncome
			// 
			this.lblIncome.AutoSize = true;
			this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIncome.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblIncome.Location = new System.Drawing.Point(67, 65);
			this.lblIncome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblIncome.Name = "lblIncome";
			this.lblIncome.Size = new System.Drawing.Size(97, 31);
			this.lblIncome.TabIndex = 3;
			this.lblIncome.Text = "$00.00";
			// 
			// lblExpenses
			// 
			this.lblExpenses.AutoSize = true;
			this.lblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExpenses.ForeColor = System.Drawing.Color.Red;
			this.lblExpenses.Location = new System.Drawing.Point(281, 65);
			this.lblExpenses.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblExpenses.Name = "lblExpenses";
			this.lblExpenses.Size = new System.Drawing.Size(97, 31);
			this.lblExpenses.TabIndex = 4;
			this.lblExpenses.Text = "$00.00";
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(479, 65);
			this.lblTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(148, 32);
			this.lblTotal.TabIndex = 5;
			this.lblTotal.Text = "$00.00";
			// 
			// btnAddTransaction
			// 
			this.btnAddTransaction.Location = new System.Drawing.Point(246, 329);
			this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(1);
			this.btnAddTransaction.Name = "btnAddTransaction";
			this.btnAddTransaction.Size = new System.Drawing.Size(152, 52);
			this.btnAddTransaction.TabIndex = 7;
			this.btnAddTransaction.Text = "Add Transaction";
			this.btnAddTransaction.UseVisualStyleBackColor = true;
			this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
			// 
			// dgvTransactions
			// 
			this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chName,
            this.Date,
            this.Type,
            this.Catagory,
            this.Amount});
			this.dgvTransactions.Location = new System.Drawing.Point(12, 154);
			this.dgvTransactions.Name = "dgvTransactions";
			this.dgvTransactions.RowHeadersVisible = false;
			this.dgvTransactions.RowTemplate.ReadOnly = true;
			this.dgvTransactions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvTransactions.Size = new System.Drawing.Size(633, 150);
			this.dgvTransactions.TabIndex = 8;
			// 
			// chName
			// 
			this.chName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.chName.HeaderText = "Name";
			this.chName.Name = "chName";
			this.chName.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			// 
			// Type
			// 
			this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Type.HeaderText = "Type";
			this.Type.Name = "Type";
			this.Type.ReadOnly = true;
			// 
			// Catagory
			// 
			this.Catagory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Catagory.HeaderText = "Catagory";
			this.Catagory.Name = "Catagory";
			this.Catagory.ReadOnly = true;
			// 
			// Amount
			// 
			this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Amount.HeaderText = "Amount";
			this.Amount.Name = "Amount";
			this.Amount.ReadOnly = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(657, 408);
			this.Controls.Add(this.dgvTransactions);
			this.Controls.Add(this.btnAddTransaction);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblExpenses);
			this.Controls.Add(this.lblIncome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Overview";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblExpenses;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblIncome;
		private System.Windows.Forms.Button btnAddTransaction;
		private System.Windows.Forms.DataGridView dgvTransactions;
		private System.Windows.Forms.DataGridViewTextBoxColumn chName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewComboBoxColumn Type;
		private System.Windows.Forms.DataGridViewComboBoxColumn Catagory;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
	}
}

