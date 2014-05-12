namespace Rhythm.WinSmtpClient
{
	partial class frmEmail
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
			this.btnSend = new System.Windows.Forms.Button();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtHost = new System.Windows.Forms.TextBox();
			this.lblDelivery = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblHost = new System.Windows.Forms.Label();
			this.chkSsl = new System.Windows.Forms.CheckBox();
			this.tableMain = new System.Windows.Forms.TableLayoutPanel();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.chkCredentials = new System.Windows.Forms.CheckBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.lblSubject = new System.Windows.Forms.Label();
			this.lblPort = new System.Windows.Forms.Label();
			this.lblSsl = new System.Windows.Forms.Label();
			this.lblCredentials = new System.Windows.Forms.Label();
			this.lblFrom = new System.Windows.Forms.Label();
			this.txtFrom = new System.Windows.Forms.TextBox();
			this.lblTo = new System.Windows.Forms.Label();
			this.txtTo = new System.Windows.Forms.TextBox();
			this.cboDelivery = new System.Windows.Forms.ComboBox();
			this.tableMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSend
			// 
			this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnSend.AutoSize = true;
			this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableMain.SetColumnSpan(this.btnSend, 2);
			this.btnSend.Location = new System.Drawing.Point(479, 382);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(70, 23);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send Email";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtUser
			// 
			this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUser.Location = new System.Drawing.Point(153, 56);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(396, 20);
			this.txtUser.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Location = new System.Drawing.Point(153, 82);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(396, 20);
			this.txtPassword.TabIndex = 2;
			// 
			// txtHost
			// 
			this.txtHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHost.Location = new System.Drawing.Point(153, 30);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new System.Drawing.Size(396, 20);
			this.txtHost.TabIndex = 3;
			// 
			// lblDelivery
			// 
			this.lblDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDelivery.Location = new System.Drawing.Point(3, 7);
			this.lblDelivery.Name = "lblDelivery";
			this.lblDelivery.Size = new System.Drawing.Size(144, 13);
			this.lblDelivery.TabIndex = 5;
			this.lblDelivery.Text = "Delivery Method";
			// 
			// lblPassword
			// 
			this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(3, 85);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(144, 13);
			this.lblPassword.TabIndex = 6;
			this.lblPassword.Text = "Password";
			// 
			// lblUser
			// 
			this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(3, 59);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(144, 13);
			this.lblUser.TabIndex = 7;
			this.lblUser.Text = "Username";
			// 
			// lblHost
			// 
			this.lblHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblHost.AutoSize = true;
			this.lblHost.Location = new System.Drawing.Point(3, 33);
			this.lblHost.Name = "lblHost";
			this.lblHost.Size = new System.Drawing.Size(144, 13);
			this.lblHost.TabIndex = 8;
			this.lblHost.Text = "Host";
			// 
			// chkSsl
			// 
			this.chkSsl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.chkSsl.AutoSize = true;
			this.chkSsl.Checked = true;
			this.chkSsl.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSsl.Location = new System.Drawing.Point(534, 154);
			this.chkSsl.Name = "chkSsl";
			this.chkSsl.Size = new System.Drawing.Size(15, 14);
			this.chkSsl.TabIndex = 9;
			this.chkSsl.UseVisualStyleBackColor = true;
			// 
			// tableMain
			// 
			this.tableMain.ColumnCount = 2;
			this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableMain.Controls.Add(this.txtResult, 1, 12);
			this.tableMain.Controls.Add(this.lblResult, 0, 12);
			this.tableMain.Controls.Add(this.txtMessage, 1, 10);
			this.tableMain.Controls.Add(this.txtSubject, 1, 9);
			this.tableMain.Controls.Add(this.txtPort, 1, 4);
			this.tableMain.Controls.Add(this.chkCredentials, 1, 5);
			this.tableMain.Controls.Add(this.lblMessage, 0, 10);
			this.tableMain.Controls.Add(this.lblSubject, 0, 9);
			this.tableMain.Controls.Add(this.lblPort, 0, 4);
			this.tableMain.Controls.Add(this.txtPassword, 1, 3);
			this.tableMain.Controls.Add(this.txtHost, 1, 1);
			this.tableMain.Controls.Add(this.txtUser, 1, 2);
			this.tableMain.Controls.Add(this.lblHost, 0, 1);
			this.tableMain.Controls.Add(this.lblPassword, 0, 3);
			this.tableMain.Controls.Add(this.lblUser, 0, 2);
			this.tableMain.Controls.Add(this.chkSsl, 1, 6);
			this.tableMain.Controls.Add(this.lblSsl, 0, 6);
			this.tableMain.Controls.Add(this.lblDelivery, 0, 0);
			this.tableMain.Controls.Add(this.lblCredentials, 0, 5);
			this.tableMain.Controls.Add(this.btnSend, 0, 11);
			this.tableMain.Controls.Add(this.lblFrom, 0, 7);
			this.tableMain.Controls.Add(this.txtFrom, 1, 7);
			this.tableMain.Controls.Add(this.lblTo, 0, 8);
			this.tableMain.Controls.Add(this.txtTo, 1, 8);
			this.tableMain.Controls.Add(this.cboDelivery, 1, 0);
			this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableMain.Location = new System.Drawing.Point(0, 0);
			this.tableMain.Name = "tableMain";
			this.tableMain.RowCount = 13;
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableMain.Size = new System.Drawing.Size(552, 538);
			this.tableMain.TabIndex = 10;
			// 
			// txtResult
			// 
			this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtResult.Location = new System.Drawing.Point(153, 411);
			this.txtResult.MaxLength = 0;
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtResult.Size = new System.Drawing.Size(396, 124);
			this.txtResult.TabIndex = 11;
			this.txtResult.WordWrap = false;
			// 
			// lblResult
			// 
			this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(3, 466);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(144, 13);
			this.lblResult.TabIndex = 12;
			this.lblResult.Text = "Result";
			// 
			// txtMessage
			// 
			this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMessage.Location = new System.Drawing.Point(153, 252);
			this.txtMessage.MaxLength = 0;
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(396, 124);
			this.txtMessage.TabIndex = 11;
			this.txtMessage.WordWrap = false;
			// 
			// txtSubject
			// 
			this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSubject.Location = new System.Drawing.Point(153, 226);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(396, 20);
			this.txtSubject.TabIndex = 12;
			// 
			// txtPort
			// 
			this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPort.Location = new System.Drawing.Point(153, 108);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(396, 20);
			this.txtPort.TabIndex = 11;
			this.txtPort.Text = "587";
			// 
			// chkCredentials
			// 
			this.chkCredentials.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.chkCredentials.AutoSize = true;
			this.chkCredentials.Location = new System.Drawing.Point(534, 134);
			this.chkCredentials.Name = "chkCredentials";
			this.chkCredentials.Size = new System.Drawing.Size(15, 14);
			this.chkCredentials.TabIndex = 11;
			this.chkCredentials.UseVisualStyleBackColor = true;
			// 
			// lblMessage
			// 
			this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(3, 307);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(144, 13);
			this.lblMessage.TabIndex = 11;
			this.lblMessage.Text = "Message";
			// 
			// lblSubject
			// 
			this.lblSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSubject.AutoSize = true;
			this.lblSubject.Location = new System.Drawing.Point(3, 229);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(144, 13);
			this.lblSubject.TabIndex = 12;
			this.lblSubject.Text = "Subject";
			// 
			// lblPort
			// 
			this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(3, 111);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(144, 13);
			this.lblPort.TabIndex = 11;
			this.lblPort.Text = "Port";
			// 
			// lblSsl
			// 
			this.lblSsl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSsl.AutoSize = true;
			this.lblSsl.Location = new System.Drawing.Point(3, 154);
			this.lblSsl.Name = "lblSsl";
			this.lblSsl.Size = new System.Drawing.Size(144, 13);
			this.lblSsl.TabIndex = 13;
			this.lblSsl.Text = "Enable SSL?";
			// 
			// lblCredentials
			// 
			this.lblCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCredentials.AutoSize = true;
			this.lblCredentials.Location = new System.Drawing.Point(3, 134);
			this.lblCredentials.Name = "lblCredentials";
			this.lblCredentials.Size = new System.Drawing.Size(144, 13);
			this.lblCredentials.TabIndex = 12;
			this.lblCredentials.Text = "Default Credentials?";
			// 
			// lblFrom
			// 
			this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFrom.AutoSize = true;
			this.lblFrom.Location = new System.Drawing.Point(3, 177);
			this.lblFrom.Name = "lblFrom";
			this.lblFrom.Size = new System.Drawing.Size(30, 13);
			this.lblFrom.TabIndex = 14;
			this.lblFrom.Text = "From";
			// 
			// txtFrom
			// 
			this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFrom.Location = new System.Drawing.Point(153, 174);
			this.txtFrom.Name = "txtFrom";
			this.txtFrom.Size = new System.Drawing.Size(396, 20);
			this.txtFrom.TabIndex = 15;
			// 
			// lblTo
			// 
			this.lblTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTo.AutoSize = true;
			this.lblTo.Location = new System.Drawing.Point(3, 203);
			this.lblTo.Name = "lblTo";
			this.lblTo.Size = new System.Drawing.Size(20, 13);
			this.lblTo.TabIndex = 16;
			this.lblTo.Text = "To";
			// 
			// txtTo
			// 
			this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTo.Location = new System.Drawing.Point(153, 200);
			this.txtTo.Name = "txtTo";
			this.txtTo.Size = new System.Drawing.Size(396, 20);
			this.txtTo.TabIndex = 17;
			// 
			// cboDelivery
			// 
			this.cboDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cboDelivery.FormattingEnabled = true;
			this.cboDelivery.Items.AddRange(new object[] {
            "Network",
            "IIS Directory",
            "Specified Directory (Type Path Here)"});
			this.cboDelivery.Location = new System.Drawing.Point(153, 3);
			this.cboDelivery.Name = "cboDelivery";
			this.cboDelivery.Size = new System.Drawing.Size(396, 21);
			this.cboDelivery.TabIndex = 18;
			// 
			// frmEmail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 538);
			this.Controls.Add(this.tableMain);
			this.Name = "frmEmail";
			this.Text = "Send Email";
			this.tableMain.ResumeLayout(false);
			this.tableMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtHost;
		private System.Windows.Forms.Label lblDelivery;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblHost;
		private System.Windows.Forms.CheckBox chkSsl;
		private System.Windows.Forms.TableLayoutPanel tableMain;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.Label lblSsl;
		private System.Windows.Forms.Label lblCredentials;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.CheckBox chkCredentials;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label lblFrom;
		private System.Windows.Forms.TextBox txtFrom;
		private System.Windows.Forms.Label lblTo;
		private System.Windows.Forms.TextBox txtTo;
		private System.Windows.Forms.ComboBox cboDelivery;
	}
}

