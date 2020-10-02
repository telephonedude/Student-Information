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

namespace Midterm_Act
{
	/// <summary>
	/// Interaction logic for viewwindow.xaml
	/// </summary>
	public partial class viewwindow : Window
	{
		public int retval=0;
		public int exitnum=0;
		public viewwindow()
		{
			InitializeComponent();
		}
		void back_Click(object sender, RoutedEventArgs e)
		{
			retval=1;
			Close();
		}
		void next_Click(object sender, RoutedEventArgs e)
		{
			retval=2;
			Close();
		}
		void exit_Click(object sender, RoutedEventArgs e)
		{
			exitnum=1;
			Close();
		}
		}
	}