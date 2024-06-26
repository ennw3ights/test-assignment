using System.Windows;

using DataVisualization = System.Windows.Forms.DataVisualization;

namespace TestAssignment.Views
{
    /// <summary>
    /// Логика взаимодействия для DataModelLineChart.xaml
    /// </summary>
    public partial class DataModelLineChart : Window
    {
        public DataModelLineChart()
        {
            InitializeComponent();

            Chart1.Series[0].Points.Clear();

            string label1 = "22.5.10";
            double value1 = 1.2;

            string label2 = "22.3.12";
            double value2 = 1.5;

            Chart1.Series[0].Points.Add(value1).AxisLabel = label1;
            Chart1.Series[0].Points.Add(value2).AxisLabel = label2;
        }
    }
}
