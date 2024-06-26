using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TestAssignment.Models;

namespace TestAssignment.ViewModels
{
    public class DataViewModel : INotifyPropertyChanged
    {
        DataModel DataModel;

        public DataViewModel(DataModel dataModel)
        {
            DataModel = dataModel;
        }

        public int MachineId
        {
            get { return DataModel.MachineId; }
            set 
            {
                DataModel.MachineId = value; 
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

        public double NetWeight
        {
            get { return DataModel.NetWeight; }
            set 
            { 
                DataModel.NetWeight = value;
                OnPropertyChanged("NetWeight"); 
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

        public DateTimeOffset GrossDate
        {
            get { return DataModel.GrossDate; }
            set 
            { 
                DataModel.GrossDate = value;
                OnPropertyChanged("GrossDate");
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
