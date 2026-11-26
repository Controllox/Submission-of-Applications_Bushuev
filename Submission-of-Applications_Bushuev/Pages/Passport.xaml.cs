using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Submission_of_Applications_Bushuev.Pages
{
    public partial class Passport : Page
    {
        public Passport()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Contacts());
        }
    }
}
