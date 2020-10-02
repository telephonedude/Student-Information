﻿/*
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
	/// Interaction logic for editwindow.xaml
	/// </summary>
	public partial class editwindow : Window
	{
		public string idnum{get; set;}
		public string idnum1{get; set;}
		public string lastname{get; set;}
		public string firstname{get; set;}
		public string midname{get; set;}
		public string course{get; set;}
		public string yearlevel{get;set;}
		public string birthdatemonth{get; set;}
		public string birthdateday{get; set;}
		public string birthdateyear{get; set;}
		public string age{get; set;}
		public int can =0;
		public editwindow()
		{
			InitializeComponent();
		}
		void searchbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
		}
		void idbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
		}
		void lvlbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
		}
		void yearbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
		}
		void daybox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
		}
		void agebox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
		}
		void lastbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("^[0-9]+$").IsMatch(e.Text);
		}
		void firstbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("^[0-9]+$").IsMatch(e.Text);
		}
		void midbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("^[0-9]+$").IsMatch(e.Text);
		}
		void coursebox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("^[0-9]+$").IsMatch(e.Text);
		}
		void monthbox_preview(object sender, TextCompositionEventArgs e)
		{
			e.Handled = new Regex("^[0-9]+$").IsMatch(e.Text);
		}
		void button1_Click(object sender, RoutedEventArgs e)
		{
			idnum = searchbox.Text;
			Close();
		}
		void submit_Click(object sender, RoutedEventArgs e)
		{
			
			if(yearbox.Text=="" ||daybox.Text== ""||idbox.Text == ""|| lastbox.Text == "" || firstbox.Text == "" || midbox.Text == "" || coursebox.Text == ""  || lvlbox.Text == "" || monthbox.Text == "" || agebox.Text == "")
		{
			MessageBox.Show("Error!, please fill up all the boxes, thank you!","Error!",MessageBoxButton.OK, MessageBoxImage.Error);
				return;
		}
		idnum1 = idbox.Text;
		lastname = lastbox.Text;
		firstname = firstbox.Text;
		midname = midbox.Text;
		course = coursebox.Text;
		yearlevel = lvlbox.Text;
		birthdatemonth = monthbox.Text;
		birthdateday = daybox.Text;
		birthdateyear = yearbox.Text;
		age = agebox.Text;
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
			can = 1;
			Close();
		}
		void reset_Click(object sender, RoutedEventArgs e)
		{
			var result = MessageBox.Show("You are about to reset all input data, are you sure about this?","Confirmation",MessageBoxButton.YesNo,MessageBoxImage.Exclamation);
					switch(result)
					{
					case MessageBoxResult.Yes:
					break;
					case MessageBoxResult.No:
					return;
					default:
					return;
					}
			idbox.Text = string.Empty;
			lastbox.Text = string.Empty;
			firstbox.Text = string.Empty;
			midbox.Text = string.Empty;
			coursebox.Text = string.Empty;
			lvlbox.Text = string.Empty;
			monthbox.Text = string.Empty;
			daybox.Text = string.Empty;
			yearbox.Text = string.Empty;
			agebox.Text = string.Empty;
		}
	}
}