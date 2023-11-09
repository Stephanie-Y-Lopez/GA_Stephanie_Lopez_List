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

namespace GA_Stephanie_Lopez_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> studentNames = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            studentNames.Add("Yolis");
            studentNames.Add("Luna");
            studentNames.Add("Nelly");
            studentNames.Add("Benny");
            studentNames.Add("Diana");

            DisplayStudents();
        }
        private void DisplayStudents()
        {
            rtbDisplay1.Text = "";

            for (int i = 0; i < studentNames.Count; i++)
            {

                rtbDisplay1.Text += $"{i} - {studentNames[i]}\n";
            }

            lblCount.Content = $"Student Count: {studentNames.Count}";
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            studentNames.Add(txtStudentName.Text);
            DisplayStudents();
        }

        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
        {
            int index = -1;
            bool isANumber = int.TryParse(txtIndex.Text, out index);

            if (isANumber && index >= 0 && index < studentNames.Count)
            {
                MessageBox.Show(studentNames[index]);
            }
            else
            {
                MessageBox.Show("Invalid index");
            }
        }

        private void btnRemoveByIndex_Click(object sender, RoutedEventArgs e)
        {
            int index = -1;
            bool isANumber = int.TryParse(txtIndex.Text, out index);

            if (isANumber && index >= 0 && index < studentNames.Count)
            {
                studentNames.RemoveAt(index);
                DisplayStudents();
            }
            else
            {
                MessageBox.Show("Invalid index");
            }
        }
    }
}
