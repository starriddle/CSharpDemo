﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_App_8._0
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void SubmitButton_Click(object sender, RoutedEventArgs e)
		{
			string name = NameTextBox.Text;
			name = string.IsNullOrWhiteSpace(name) ? "World" : name.Trim();
			MsgLebal.Content = "Hello " + name + " !";
			NameTextBox.Text = "";
		}
	}
}