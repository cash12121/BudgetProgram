namespace PresentationLayer
{
	partial class frmAddEditTransaction
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
			this.txtTransactionName = new System.Windows.Forms.TextBox();
			this.cmbTransactionType = new System.Windows.Forms.ComboBox();
			this.numAmount = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(139, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Transaction Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(202, 113);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Type";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(190, 163);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Amount";
			// 
			// txtTransactionName
			// 
			this.txtTransactionName.Location = new System.Drawing.Point(261, 42);
			this.txtTransactionName.Margin = new System.Windows.Forms.Padding(1);
			this.txtTransactionName.Name = "txtTransactionName";
			this.txtTransactionName.Size = new System.Drawing.Size(156, 20);
			this.txtTransactionName.TabIndex = 4;
			// 
			// cmbTransactionType
			// 
			this.cmbTransactionType.FormattingEnabled = true;
			this.cmbTransactionType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
			this.cmbTransactionType.Location = new System.Drawing.Point(261, 113);
			this.cmbTransactionType.Margin = new System.Windows.Forms.Padding(1);
			this.cmbTransactionType.Name = "cmbTransactionType";
			this.cmbTransactionType.Size = new System.Drawing.Size(156, 21);
			this.cmbTransactionType.TabIndex = 6;
			// 
			// numAmount
			// 
			this.numAmount.DecimalPlaces = 2;
			this.numAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numAmount.Location = new System.Drawing.Point(263, 163);
			this.numAmount.Margin = new System.Windows.Forms.Padding(1);
			this.numAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numAmount.Name = "numAmount";
			this.numAmount.Size = new System.Drawing.Size(154, 20);
			this.numAmount.TabIndex = 8;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(282, 214);
			this.btnSave.Margin = new System.Windows.Forms.Padding(1);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(101, 55);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(261, 78);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 20);
			this.dtpDate.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(202, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Date";
			// 
			// frmAddEditTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 317);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.numAmount);
			this.Controls.Add(this.cmbTransactionType);
			this.Controls.Add(this.txtTransactionName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "frmAddEditTransaction";
			this.Text = "frmAddTransaction";
			this.Load += new System.EventHandler(this.FrmAddEditTransaction_Load);
			((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTransactionName;
		private System.Windows.Forms.ComboBox cmbTransactionType;
		private System.Windows.Forms.NumericUpDown numAmount;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label label4;
	}
}