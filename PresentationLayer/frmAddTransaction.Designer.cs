namespace PresentationLayer
{
	partial class frmAddTransaction
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
			this.label4 = new System.Windows.Forms.Label();
			this.txtTransactionName = new System.Windows.Forms.TextBox();
			this.cmbTransactionType = new System.Windows.Forms.ComboBox();
			this.cmbTransactionCatagory = new System.Windows.Forms.ComboBox();
			this.numAmount = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(370, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Transaction Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(538, 270);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Type";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(503, 522);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Amount";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(486, 390);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 32);
			this.label4.TabIndex = 3;
			this.label4.Text = "Catagory";
			// 
			// txtTransactionName
			// 
			this.txtTransactionName.Location = new System.Drawing.Point(697, 144);
			this.txtTransactionName.Name = "txtTransactionName";
			this.txtTransactionName.Size = new System.Drawing.Size(410, 38);
			this.txtTransactionName.TabIndex = 4;
			// 
			// cmbTransactionType
			// 
			this.cmbTransactionType.FormattingEnabled = true;
			this.cmbTransactionType.Items.AddRange(new object[] {
            "Income",
            "Expenses"});
			this.cmbTransactionType.Location = new System.Drawing.Point(697, 270);
			this.cmbTransactionType.Name = "cmbTransactionType";
			this.cmbTransactionType.Size = new System.Drawing.Size(410, 39);
			this.cmbTransactionType.TabIndex = 6;
			// 
			// cmbTransactionCatagory
			// 
			this.cmbTransactionCatagory.FormattingEnabled = true;
			this.cmbTransactionCatagory.Location = new System.Drawing.Point(697, 390);
			this.cmbTransactionCatagory.Name = "cmbTransactionCatagory";
			this.cmbTransactionCatagory.Size = new System.Drawing.Size(410, 39);
			this.cmbTransactionCatagory.TabIndex = 7;
			// 
			// numAmount
			// 
			this.numAmount.Location = new System.Drawing.Point(697, 522);
			this.numAmount.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
			this.numAmount.Name = "numAmount";
			this.numAmount.Size = new System.Drawing.Size(410, 38);
			this.numAmount.TabIndex = 8;
			// 
			// frmAddTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1691, 975);
			this.Controls.Add(this.numAmount);
			this.Controls.Add(this.cmbTransactionCatagory);
			this.Controls.Add(this.cmbTransactionType);
			this.Controls.Add(this.txtTransactionName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmAddTransaction";
			this.Text = "frmAddTransaction";
			((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTransactionName;
		private System.Windows.Forms.ComboBox cmbTransactionType;
		private System.Windows.Forms.ComboBox cmbTransactionCatagory;
		private System.Windows.Forms.NumericUpDown numAmount;
	}
}