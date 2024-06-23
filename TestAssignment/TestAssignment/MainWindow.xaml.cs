using System.Windows;
using TestAssignment.Services;

namespace TestAssignment
{
    public partial class MainWindow : Window
    {
        DbClient client = new DbClient();

        public MainWindow()
        {
            InitializeComponent();

            dataTable.ItemsSource = client.LoadContext();
        }
    }
}
