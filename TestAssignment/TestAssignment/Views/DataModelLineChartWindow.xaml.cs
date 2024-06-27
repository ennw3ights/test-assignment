using System.Windows;
using TestAssignment.ViewModels;

namespace TestAssignment.Views
{
    public partial class DataModelLineChart : Window
    {
        public DataModelLineChart(LineChartViewModel lineChartViewModel)
        {
            InitializeComponent();

            Chart1.Series[0].Points.Clear();

            for (int i = 0; i < lineChartViewModel.GrossWeights.Count; i++) 
            {
                Chart1.Series[0].Points.Add(lineChartViewModel.GrossWeights[i]).AxisLabel = lineChartViewModel.GrossDates[i].ToString();
            }
        }
    }
}
