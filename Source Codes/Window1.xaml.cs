/*
 * Created by SharpDevelop.
 * User: telephonedude
 * Date: 09/08/2018
 * Time: 2:52 AM
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
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public IList<student>studentlist = new List<student>();
		public int studentindex;
		public string idnumber;
		public string lastname;
		public string firstname;
		public string middlename;
		public string course;
		public string yearlvl;
		public string birthdatemonth;
		public string birthdateday;
		public string birthdateyear;
		public string age;
		public int indexnum;
		public int currentnum;	
		public Window1()
		{
			InitializeComponent();
			
		}
		void addstudent_Click(object sender, RoutedEventArgs e)
		{
			addwindow addwin = new addwindow();
			addwin.ShowDialog();
			studentlist.Add(new student(){idnumber = addwin.idnum, lastname = addwin.lastname, firstname = addwin.firstname, middlename = addwin.midname, course = addwin.course , yearlvl = addwin.yearlevel, birthdatemonth = addwin.birthdatemonth, birthdateday = addwin.birthdateday, birthdateyear = addwin.birthdateyear, age =addwin.age});
			indexnum++;
			if(addwin.idbox.Text == "" ||addwin.fambox.Text == ""|| addwin.firstbox.Text == ""|| addwin.midbox.Text == ""|| addwin.coursebox.Text == "" || addwin.lvlbox.Text == "" || addwin.monthbox.Text == "" || addwin.daybox.Text == "" || addwin.yearbox.Text == "")
			{
				indexnum--;
				studentlist.RemoveAt(indexnum);
			}
		}
		void viewstudent_Click(object sender, RoutedEventArgs e)
		{	
			if(indexnum==0)
			{
				MessageBox.Show("Sorry, there are no students at the moment, please add a student, thank you!","Error!",MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			for(;;)
			{
			viewwindow viewwin = new viewwindow();
			idnumber=studentlist[currentnum].idnumber;
			lastname= studentlist[currentnum].lastname;
			firstname = studentlist[currentnum].firstname;
			middlename = studentlist[currentnum].middlename;
			course =studentlist[currentnum].course;
			yearlvl= studentlist[currentnum].yearlvl;
			birthdatemonth = studentlist[currentnum].birthdatemonth;
			birthdateday = studentlist[currentnum].birthdateday;
			birthdateyear = studentlist[currentnum].birthdateyear;
			age = studentlist[currentnum].age;
			viewwin.idbox.Text = idnumber.ToString();
			viewwin.lastbox.Text = lastname.ToString();
			viewwin.firstbox.Text = firstname.ToString();
			viewwin.midbox.Text = middlename.ToString();
			viewwin.coursebox.Text = course.ToString();
			viewwin.lvlbox.Text = yearlvl.ToString();
			viewwin.monthbox.Text = birthdatemonth.ToString();
			viewwin.daybox.Text = birthdateday.ToString();
			viewwin.yearbox.Text = birthdateyear.ToString();
			viewwin.agebox.Text = age.ToString();
			viewwin.ShowDialog();
			if(viewwin.exitnum==1)
			{
				currentnum=0;
				break;
			}
			if(viewwin.retval==1)
			{
				if(currentnum==0)
				{
					currentnum++;
				}
				currentnum--;
				
			}
			if(viewwin.retval==2)
			{
				currentnum++;
				if(currentnum > studentlist.Count - 1) currentnum=studentlist.Count-1;
			}
			}
		}
		void editstudent_Click(object sender, RoutedEventArgs e)
		{
			if(indexnum==0)
			{
				MessageBox.Show("Sorry, there are no students at the moment, please add a student, thank you!","Error!",MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			editwindow editwin = new editwindow();
			editwin.ShowDialog();
			for(;;)
			{
				if(editwin.idnum == studentlist[currentnum].idnumber)
				{
				editwindow editwin1 = new editwindow();
				idnumber=studentlist[currentnum].idnumber;
				lastname= studentlist[currentnum].lastname;
				firstname = studentlist[currentnum].firstname;
				middlename = studentlist[currentnum].middlename;
				course =studentlist[currentnum].course;
				yearlvl= studentlist[currentnum].yearlvl;
				birthdatemonth = studentlist[currentnum].birthdatemonth;
				birthdateday = studentlist[currentnum].birthdateday;
				birthdateyear = studentlist[currentnum].birthdateyear;
				age = studentlist[currentnum].age;
				editwin1.idbox.Text = idnumber.ToString();
				editwin1.lastbox.Text = lastname.ToString();
				editwin1.firstbox.Text = firstname.ToString();
				editwin1.midbox.Text = middlename.ToString();
				editwin1.coursebox.Text = course.ToString();
				editwin1.lvlbox.Text = yearlvl.ToString();
				editwin1.monthbox.Text = birthdatemonth.ToString();
				editwin1.daybox.Text = birthdateday.ToString();
				editwin1.yearbox.Text = birthdateyear.ToString();
				editwin1.agebox.Text = age.ToString();
				editwin1.searchbox.IsEnabled=false;
				editwin1.button1.IsEnabled=false;
				editwin1.idbox.IsEnabled=true;
				editwin1.lastbox.IsEnabled=true;
				editwin1.firstbox.IsEnabled=true;
				editwin1.midbox.IsEnabled=true;
				editwin1.coursebox.IsEnabled=true;
				editwin1.lvlbox.IsEnabled=true;
				editwin1.monthbox.IsEnabled=true;
				editwin1.agebox.IsEnabled=true;
				editwin1.submit.IsEnabled=true;
				editwin1.daybox.IsEnabled=true;
				editwin1.yearbox.IsEnabled=true;
				editwin1.reset.IsEnabled=true;
				editwin1.ShowDialog();
				if(editwin1.can==1)
				{
					break;
				}
				studentlist[currentnum].idnumber = editwin1.idnum1;
				studentlist[currentnum].lastname = editwin1.lastname;
				studentlist[currentnum].firstname = editwin1.firstname;
				studentlist[currentnum].middlename = editwin1.midname;
				studentlist[currentnum].course = editwin1.course;
				studentlist[currentnum].yearlvl = editwin1.yearlevel;
				studentlist[currentnum].birthdatemonth = editwin1.birthdatemonth;
				studentlist[currentnum].birthdateday = editwin1.birthdateday;
				studentlist[currentnum].birthdateyear = editwin1.birthdateyear;
				studentlist[currentnum].age = editwin1.age;
				MessageBox.Show("You have successfully changed this student's information","Success!",MessageBoxButton.OK ,MessageBoxImage.Exclamation);
				currentnum = 0;
				break;
				}
				if(currentnum==indexnum-1)
				{
					
					MessageBox.Show("That student's information does not exist yet","Error!",MessageBoxButton.OK, MessageBoxImage.Error);
					currentnum=0;
					break;
				}
				currentnum++;
		}
		}
		void delstudent_Click(object sender, RoutedEventArgs e)
		{
			
			if(indexnum==0)
			{
				MessageBox.Show("Sorry, there are no students at the moment, please add a student, thank you!","Error!",MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			delwindow delwin = new delwindow();
			delwin.ShowDialog();
			for(;;)
			{
				if(delwin.idnum == studentlist[currentnum].idnumber)
				{
					var result = MessageBox.Show("You are about to delete "+studentlist[currentnum].firstname+" "+studentlist[currentnum].lastname+"'s account, are you sure about this?","Confirmation",MessageBoxButton.YesNo, MessageBoxImage.Information);
					switch(result)
					{
					case MessageBoxResult.Yes:
							MessageBox.Show("You have deleted the student information","Success!",MessageBoxButton.OK, MessageBoxImage.Information);
					studentlist.RemoveAt(currentnum);
					currentnum=0;
					indexnum--;
					break;
					case MessageBoxResult.No:
					MessageBox.Show("You have chosen not to delete the student's information","Information!",MessageBoxButton.OK, MessageBoxImage.Information);
					currentnum=0;
					break;
					}
					break;
				}
				if(currentnum==indexnum-1)
				{
					MessageBox.Show("That student's information does not exist yet","Error!",MessageBoxButton.OK, MessageBoxImage.Error);
					currentnum=0;
					break;
				}
				currentnum++;
			}
		}
	}
}