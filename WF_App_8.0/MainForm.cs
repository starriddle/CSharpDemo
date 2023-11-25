namespace WF_App_8._0
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
