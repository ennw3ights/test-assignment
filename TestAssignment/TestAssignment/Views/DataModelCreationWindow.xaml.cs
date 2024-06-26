using System.Windows;
using TestAssignment.Models;

namespace TestAssignment.Views
{
    /// <summary>
    /// Логика взаимодействия для DataModelCreationWindow.xaml
    /// </summary>
    public partial class DataModelCreationWindow : Window
    {
        public DataModel _dataModel { get; private set; }
        public DataModelCreationWindow(DataModel dataModel)
        {
            InitializeComponent();
            _dataModel = dataModel;
            DataContext = _dataModel;
        }

        void AcceptClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
