using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TestAssignment.Common;
using TestAssignment.Models;
using TestAssignment.Services;
using TestAssignment.Views;

namespace TestAssignment.ViewModels
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private DbClient dbClient = new DbClient();

        BackgroundWorker worker = new BackgroundWorker();

        private DataModel _selectedModel;
        public ObservableCollection<DataModel> dataModels { get; set; }

        public DataModel SelectedModel
        {
            get { return _selectedModel; }
            set 
            { 
                _selectedModel = value; 
                OnPropertyChanged("SelectedModel");
            }
        }

        public ApplicationViewModel()
        {
            worker.DoWork += Worker_LoadDataContext;

            worker.RunWorkerAsync();
        }

        private void Worker_LoadDataContext(object sender, DoWorkEventArgs e)
        {
            dataModels = dbClient.LoadContext();
        }

        private RelayCommand _addCommand;
        public RelayCommand AddCommand
        {
            get 
            {
                return _addCommand ?? 
                    (_addCommand = new RelayCommand(obj => 
                    {
                        DataModelCreationWindow dataModelCreationWindow = new DataModelCreationWindow(new DataViewModel(new DataModel()));
                        if(dataModelCreationWindow.ShowDialog() == true)
                        {
                            DataModel dataModel = dataModelCreationWindow.DataModel;
                            dbClient.AddDataModel(dataModel);
                        }
                    }));
            }
        }

        private RelayCommand _openLineChart;
        public RelayCommand OpenLineChart
        {
            get 
            {
                return _openLineChart ?? 
                    (_openLineChart = new RelayCommand(obj => 
                    {
                        DataModel selectedModel = obj as DataModel;

                        LineChartViewModel lineChartViewModel = new LineChartViewModel();

                        for (int i = 0; i < dataModels.Count; i++) 
                        {
                            if (dataModels[i].MachineNumber == selectedModel.MachineNumber)
                            {
                                lineChartViewModel.GrossDates.Add(dataModels[i].GrossDate);
                                lineChartViewModel.GrossDates.Sort();
                                lineChartViewModel.GrossWeights.Add(dataModels[i].GrossWeight);
                            }
                        }

                        DataModelLineChart dataModelLineChartWindow = new DataModelLineChart(lineChartViewModel);
                        dataModelLineChartWindow.ShowDialog();
                    }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
