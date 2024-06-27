using System.Windows;
using TestAssignment.ViewModels;

namespace TestAssignment
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();
        }
    }
}
