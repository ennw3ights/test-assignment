using System.Windows;
using TestAssignment.ViewModels;
using TestAssignment.Views;

namespace TestAssignment
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();

            DataModelLineChart dataModelLineChart = new DataModelLineChart();
            dataModelLineChart.ShowDialog();
        }
    }
}
