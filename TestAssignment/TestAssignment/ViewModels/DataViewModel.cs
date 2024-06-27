using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TestAssignment.Models;

namespace TestAssignment.ViewModels
{
    public class DataViewModel : INotifyPropertyChanged
    {
        public DataModel DataModel;

        public DataViewModel(DataModel dataModel)
        {
            DataModel = dataModel;
        }

        public int Id 
        { 
            get { return DataModel.Id; }
            set 
            { 
                DataModel.Id = value;
                OnPropertyChanged("Id");
            }
        }

        public string MachineNumber
        {
            get { return DataModel.MachineNumber; }
            set 
            {
                DataModel.MachineNumber = value; 
                OnPropertyChanged("MachineId");
            } 
        }

        public double GrossWeight
        {
            get { return DataModel.GrossWeight; }
            set 
            {
                DataModel.GrossWeight = value;
                OnPropertyChanged("GrossWeight");
            }
        }

        public double TareWeight
        {
            get { return DataModel.TareWeight; }
            set 
            { 
                DataModel.TareWeight = value; 
                OnPropertyChanged("TareWeight");
            }
        }

        public DateTimeOffset TareDate
        {
            get { return DataModel.TareDate; }
            set
            {
                DataModel.TareDate = value;
                OnPropertyChanged("TareDate");
            }
        }

        public double NetWeight
        {
            get { return DataModel.NetWeight; }
            set 
            { 
                DataModel.NetWeight = value;
                OnPropertyChanged("NetWeight"); 
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
