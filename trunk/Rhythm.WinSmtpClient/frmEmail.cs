namespace Rhythm.WinSmtpClient
{

	// Namespaces.
	using System;
	using System.Net;
	using System.Net.Mail;
	using System.Threading;
	using System.Windows.Forms;


	/// <summary>
	/// Main email form.
	/// </summary>
	public partial class frmEmail : Form
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public frmEmail()
		{
			InitializeComponent();
			cboDelivery.SelectedIndex = 0;
		}

		#endregion


		#region Event Handlers

		/// <summary>
		/// "Send" clicked.
		/// </summary>
		private void btnSend_Click(object sender, EventArgs e)
		{
			try
			{
				var message = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtMessage.Text);
				message.IsBodyHtml = false;
				var client = new SmtpClient(txtHost.Text);
				int port;
				if (int.TryParse(txtPort.Text, out port))
				{
					client.Port = port;
				}
				client.UseDefaultCredentials = chkCredentials.Checked;
				if (!string.IsNullOrWhiteSpace(txtUser.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
				{
					client.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
				}
				if (cboDelivery.Text == "Network")
				{
					client.DeliveryMethod = SmtpDeliveryMethod.Network;
				}
				else if (cboDelivery.Text == "IIS Directory")
				{
					client.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;
				}
				else
				{
					client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
					client.PickupDirectoryLocation = cboDelivery.Text;
				}
				client.EnableSsl = chkSsl.Checked;
				txtResult.Text = null;
				tableMain.Enabled = false;
				var t = new Thread(new ThreadStart(() =>
				{
					try
					{
						client.Send(message);
						DoInvoke(new Action(() =>
						{
							txtResult.Text = "Success!";
						}));
					}
					catch (Exception mailEx)
					{
						DoInvoke(new Action(() =>
						{
							txtResult.Text = GetExceptionDetails(mailEx);
						}));
					}
					finally
					{
						DoInvoke(new Action(() =>
						{
							tableMain.Enabled = true;
						}));
					}
				}));
				t.Start();
				
			}
			catch (Exception ex)
			{
				txtResult.Text = GetExceptionDetails(ex);
			}
		}

		#endregion


		#region Helper Methods

		/// <summary>
		/// Gets the details of an exception.
		/// </summary>
		/// <param name="ex">The exception.</param>
		/// <returns>The exception details.</returns>
		private string GetExceptionDetails(Exception ex)
		{
			if (ex == null)
			{
				return string.Empty;
			}
			else
			{
				var primary = ex.Message + Environment.NewLine + ex.StackTrace;
				var inner = GetExceptionDetails(ex.InnerException);
				if (string.IsNullOrWhiteSpace(inner))
				{
					return primary;
				}
				else
				{
					return primary + Environment.NewLine + Environment.NewLine + inner;
				}
			}
		}


		/// <summary>
		/// Invokes an action (using this control to invoke it if necessary).
		/// </summary>
		/// <param name="action">The action to invoke.</param>
		private void DoInvoke(Action action)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(action);
			}
			else
			{
				action();
			}
		}

		#endregion

	}

}