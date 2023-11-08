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
            rtbDisplay.Text = "";

            for (int i = 0; i < studentNames.Count; i++)
            {

                rtbDisplay.Text += $"{i} - {studentNames[i]}\n";
            }

            lblCount.Content = $"Student Count: {studentNames.Count}";
        }
    }
}
