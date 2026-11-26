using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Submission_of_Applications_Bushuev.Pages
{
    public partial class Statement : Page
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (okoncil.Text == "")
                MessageBox.Show("Поле Окончил: пустое", "Ошибка");
            else if (God.Text == "" || !int.TryParse(God.Text, out _))
                MessageBox.Show("Поле Год окончания: пустое или не число", "Ошибка");
            else
                NavigationService.Navigate(new Status());
        }
    }
}
