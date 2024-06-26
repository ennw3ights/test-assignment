using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TestAssignment.Models
{
    public sealed class DataModel : INotifyPropertyChanged
    {
        private int _machineId;
        private double _grossWeight;
        private double _tareWeight;
        private double _netWeight;
        private DateTimeOffset _tareDate;
        private DateTimeOffset _grossDate;

        [Key]
        public int MachineId 
        { 
            get { return _machineId; }
            set 
            {
                _machineId = value;
                OnPropertyChanged("MachineId");
            }
        }

        public double GrossWeight 
        { 
            get { return _grossWeight; }
            set 
            { 
                _grossWeight = value; 
                OnPropertyChanged("GrossWeight"); 
            }
        }

        public double TareWeight 
        { 
            get { return _tareWeight; }
            set 
            { 
                _tareWeight = value; 
                OnPropertyChanged("TareWeight"); 
            }
        }

        public double NetWeight 
        { 
            get { return _netWeight; }
            set 
            { 
                _netWeight = value; 
                OnPropertyChanged("NetWeight"); 
            }
        }

        public DateTimeOffset TareDate 
        { 
            get { return _tareDate; } 
            set 
            { 
                _tareDate = value; 
                OnPropertyChanged("TareDate"); 
            }
        }

        public DateTimeOffset GrossDate 
        { 
            get { return _grossDate; } 
            set 
            { 
                _grossDate = value;
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
