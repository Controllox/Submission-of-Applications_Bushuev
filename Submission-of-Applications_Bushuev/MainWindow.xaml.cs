using System.Windows;

namespace Submission_of_Applications_Bushuev
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(new Pages.Statement());
        }
    }
}