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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> students = new List<Student>();
        private int currentStudent = 0;
        private static int numStudents = 0;       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
            students.Add(stu);

            txtCity.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();

            foreach( var student in students)
            {
                Console.WriteLine(student.ToString());
            }

            numStudents++;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

            if (numStudents > 0)
            {
                txtFirstName.Text = students[currentStudent].FirstName;
                txtLastName.Text = students[currentStudent].LastName;
                txtCity.Text = students[currentStudent].City;
                currentStudent = (currentStudent + 1) % numStudents;
            }

            
          
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (numStudents > 0)
            {
                txtFirstName.Text = students[currentStudent].FirstName;
                txtLastName.Text = students[currentStudent].LastName;
                txtCity.Text = students[currentStudent].City;
                currentStudent = (currentStudent - 1);
                if( currentStudent < 0)
                {
                    currentStudent = numStudents - 1;
                }
            }
        }
    }
}
