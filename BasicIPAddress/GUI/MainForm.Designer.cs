namespace BasicIPAddress.GUI
{
	partial class MainForm
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
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnResolve = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxResolveTo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtHostname = new System.Windows.Forms.TextBox();
			this.lblIPs = new System.Windows.Forms.Label();
			this.lblAliases = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(94, 18);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(292, 20);
			this.txtInput.TabIndex = 0;
			// 
			// btnResolve
			// 
			this.btnResolve.Location = new System.Drawing.Point(392, 12);
			this.btnResolve.Name = "btnResolve";
			this.btnResolve.Size = new System.Drawing.Size(69, 30);
			this.btnResolve.TabIndex = 1;
			this.btnResolve.Text = "Resolve";
			this.btnResolve.UseVisualStyleBackColor = true;
			this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Resolve from: ";
			// 
			// cbxResolveTo
			// 
			this.cbxResolveTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxResolveTo.FormattingEnabled = true;
			this.cbxResolveTo.Items.AddRange(new object[] {
            "To Host Name",
            "To IP Adresses"});
			this.cbxResolveTo.Location = new System.Drawing.Point(94, 44);
			this.cbxResolveTo.Name = "cbxResolveTo";
			this.cbxResolveTo.Size = new System.Drawing.Size(292, 21);
			this.cbxResolveTo.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "IPs:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(261, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Aliases: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 286);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Hostname: ";
			// 
			// txtHostname
			// 
			this.txtHostname.Location = new System.Drawing.Point(76, 283);
			this.txtHostname.Name = "txtHostname";
			this.txtHostname.ReadOnly = true;
			this.txtHostname.Size = new System.Drawing.Size(426, 20);
			this.txtHostname.TabIndex = 8;
			// 
			// lblIPs
			// 
			this.lblIPs.Location = new System.Drawing.Point(12, 93);
			this.lblIPs.Name = "lblIPs";
			this.lblIPs.Size = new System.Drawing.Size(243, 187);
			this.lblIPs.TabIndex = 10;
			// 
			// lblAliases
			// 
			this.lblAliases.Location = new System.Drawing.Point(261, 93);
			this.lblAliases.Name = "lblAliases";
			this.lblAliases.Size = new System.Drawing.Size(243, 187);
			this.lblAliases.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 327);
			this.Controls.Add(this.lblAliases);
			this.Controls.Add(this.lblIPs);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtHostname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbxResolveTo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnResolve);
			this.Controls.Add(this.txtInput);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnResolve;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxResolveTo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtHostname;
		private System.Windows.Forms.Label lblIPs;
		private System.Windows.Forms.Label lblAliases;
	}
}