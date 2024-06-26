using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using TestAssignment.Models;
using TestAssignment.Common;
using Microsoft.EntityFrameworkCore;
using TestAssignment.Views;
using TestAssignment.Services;

namespace TestAssignment.ViewModels
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private ApplicationDbContext dbContext = new ApplicationDbContext();

        private DbClient dbClient = new DbClient();

        public ObservableCollection<DataModel> dataModels { get; set; }

        public ApplicationViewModel()
        {
            dataModels = dbClient.LoadContext();
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get 
            {
                return addCommand ?? 
                    (addCommand = new RelayCommand(obj => 
                    {
                        DataModelCreationWindow dataModelCreationWindow = new DataModelCreationWindow(new DataModel());
                        if(dataModelCreationWindow.ShowDialog() == true)
                        {
                            DataModel dataModel = dataModelCreationWindow._dataModel;

                            dbClient.AddDataModel(dataModel);
                        }
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
