using System.Windows;

namespace WPF_App_4._7._2
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string name = NameTextBox.Text;
			name = string.IsNullOrWhiteSpace(name) ? "World" : name.Trim();
			MsgLebal.Content = "Hello " + name + " !";
			NameTextBox.Text = "";
		}
	}
}
