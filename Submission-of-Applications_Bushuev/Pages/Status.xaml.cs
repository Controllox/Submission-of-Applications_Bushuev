using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Submission_of_Applications_Bushuev.Pages
{
    public partial class Status : Page
    {
        public Status()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Passport());
        }
    }
}
