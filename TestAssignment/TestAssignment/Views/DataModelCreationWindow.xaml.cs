using System.Windows;
using TestAssignment.Models;
using TestAssignment.ViewModels;

namespace TestAssignment.Views
{
    public partial class DataModelCreationWindow : Window
    {
        public DataModel DataModel { get; private set; }
        public DataModelCreationWindow(DataViewModel dataViewModel)
        {
            InitializeComponent();
            DataModel = dataViewModel.DataModel;
            DataContext = DataModel;
        }

        void AcceptClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
