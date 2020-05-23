namespace TlsExploration4._7
{
	partial class Form1
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
			this.chkTls10 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkSsl = new System.Windows.Forms.CheckBox();
			this.chkTls1pt2 = new System.Windows.Forms.CheckBox();
			this.chkTls11 = new System.Windows.Forms.CheckBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkProd = new System.Windows.Forms.CheckBox();
			this.chkDev = new System.Windows.Forms.CheckBox();
			this.chkStaging = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkTls10
			// 
			this.chkTls10.AutoSize = true;
			this.chkTls10.Location = new System.Drawing.Point(106, 29);
			this.chkTls10.Name = "chkTls10";
			this.chkTls10.Size = new System.Drawing.Size(61, 17);
			this.chkTls10.TabIndex = 2;
			this.chkTls10.Text = "TLS1.0";
			this.chkTls10.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkSsl);
			this.groupBox1.Controls.Add(this.chkTls1pt2);
			this.groupBox1.Controls.Add(this.chkTls11);
			this.groupBox1.Controls.Add(this.chkTls10);
			this.groupBox1.Location = new System.Drawing.Point(22, 135);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(345, 81);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TLS Options";
			// 
			// chkSsl
			// 
			this.chkSsl.AutoSize = true;
			this.chkSsl.Location = new System.Drawing.Point(45, 29);
			this.chkSsl.Name = "chkSsl";
			this.chkSsl.Size = new System.Drawing.Size(46, 17);
			this.chkSsl.TabIndex = 6;
			this.chkSsl.Text = "SSL";
			this.chkSsl.UseVisualStyleBackColor = true;
			// 
			// chkTls1pt2
			// 
			this.chkTls1pt2.AutoSize = true;
			this.chkTls1pt2.Location = new System.Drawing.Point(263, 29);
			this.chkTls1pt2.Name = "chkTls1pt2";
			this.chkTls1pt2.Size = new System.Drawing.Size(61, 17);
			this.chkTls1pt2.TabIndex = 4;
			this.chkTls1pt2.Text = "TLS1.2";
			this.chkTls1pt2.UseVisualStyleBackColor = true;
			// 
			// chkTls11
			// 
			this.chkTls11.AutoSize = true;
			this.chkTls11.Location = new System.Drawing.Point(180, 29);
			this.chkTls11.Name = "chkTls11";
			this.chkTls11.Size = new System.Drawing.Size(61, 17);
			this.chkTls11.TabIndex = 3;
			this.chkTls11.Text = "TLS1.1";
			this.chkTls11.UseVisualStyleBackColor = true;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(150, 234);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 11;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkProd);
			this.groupBox2.Controls.Add(this.chkDev);
			this.groupBox2.Controls.Add(this.chkStaging);
			this.groupBox2.Location = new System.Drawing.Point(22, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(384, 100);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ePrescription Servers:";
			// 
			// chkProd
			// 
			this.chkProd.AutoSize = true;
			this.chkProd.Location = new System.Drawing.Point(6, 24);
			this.chkProd.Name = "chkProd";
			this.chkProd.Size = new System.Drawing.Size(345, 17);
			this.chkProd.TabIndex = 7;
			this.chkProd.Text = "PROD=  https://erx.elektacloud.com/ePrescription3_0/Service.svc";
			this.chkProd.UseVisualStyleBackColor = true;
			// 
			// chkDev
			// 
			this.chkDev.AutoSize = true;
			this.chkDev.Checked = true;
			this.chkDev.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDev.Location = new System.Drawing.Point(6, 47);
			this.chkDev.Name = "chkDev";
			this.chkDev.Size = new System.Drawing.Size(333, 17);
			this.chkDev.TabIndex = 8;
			this.chkDev.Text = "DEV =  https://erx-dev.impac.com/ePrescription3_0/Service.svc";
			this.chkDev.UseVisualStyleBackColor = true;
			// 
			// chkStaging
			// 
			this.chkStaging.AutoSize = true;
			this.chkStaging.Location = new System.Drawing.Point(6, 70);
			this.chkStaging.Name = "chkStaging";
			this.chkStaging.Size = new System.Drawing.Size(372, 17);
			this.chkStaging.TabIndex = 11;
			this.chkStaging.Text = "QE =   https://erx-staging.elektacloud.com/ePrescription3_0/Service.svc";
			this.chkStaging.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 310);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnConnect);
			this.Name = "Form1";
			this.Text = "TLS Exploration 4.7";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox chkTls10;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkSsl;
		private System.Windows.Forms.CheckBox chkTls1pt2;
		private System.Windows.Forms.CheckBox chkTls11;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkProd;
		private System.Windows.Forms.CheckBox chkDev;
		private System.Windows.Forms.CheckBox chkStaging;
	}
}

