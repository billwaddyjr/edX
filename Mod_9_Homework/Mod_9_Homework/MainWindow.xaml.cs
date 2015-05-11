using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{

	public class Person{
		public string firstName {get; set;}
		public string lastName {get; set;}
		public DateTime birthdate {get; set;}
		public string add1 {get; set;}
		public string add2 {get; set;}
		public string city {get; set;}
		public string state {get; set;}
		public int zip {get; set;}
		public string country {get; set;}
	}

	public class Student : Person{
		public decimal GPA {get; set;}
		public Stack<int> grades = new Stack<int>();
		public int year {get; set;}
		public void TakeTest(){
			var ex = new NotImplementedException();
			throw ex;
		}
	}

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
			var students = new List<Student>();
            InitializeComponent();
        }
    }
}
