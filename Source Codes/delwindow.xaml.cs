/*
 * Created by SharpDevelop.
 * User: telephonedude
 * Date: 08/09/2018
 * Time: 02:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Text.RegularExpressions;
namespace Midterm_Act
{
	/// <summary>
	/// Interaction logic for delwindow.xaml
	/// </summary>
	public partial class delwindow : Window
	{
		public string idnum;
		public delwindow()
		{
			InitializeComponent();
		}
		void searchbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
		}
		void button1_Click(object sender, RoutedEventArgs e)
		{
			idnum = searchbox.Text;
			Close();
		}
		void cancel_Click(object sender, RoutedEventArgs e)
		{
			var result = MessageBox.Show("You are about to go back to the Menu, are you sure about this?","Confirmation",MessageBoxButton.YesNo,MessageBoxImage.Exclamation);
					switch(result)
					{
					case MessageBoxResult.Yes:
					break;
					case MessageBoxResult.No:
					return;
					default:
					return;
					}
					Close();
		}
	}
}