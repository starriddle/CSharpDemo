using System;
using System.Windows.Forms;

namespace WF_App_4._7._2
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			string name = textBoxName.Text;
			name = string.IsNullOrWhiteSpace(name) ? "World" : name.Trim();
			labelMsg.Text = "Hello " + name + " !";
			textBoxName.Text = "";
		}
	}
}
