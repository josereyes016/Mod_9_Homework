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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
            students.Add(stu);
        }
    }
}
