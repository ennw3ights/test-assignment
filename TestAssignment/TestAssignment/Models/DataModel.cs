using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace TestAssignment.Models
{
    public sealed class DataModel : INotifyPropertyChanged
    {
        private int _id;
        private string _machineNumber;
        private double _grossWeight;
        private DateTimeOffset _grossDate;
        private double _tareWeight;
        private DateTimeOffset _tareDate;
        private double _netWeight;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id 
        { 
            get { return _id; } 
            set 
            { 
                _id = value; 
                OnPropertyChanged("Id");
            }
        }
        
        public string MachineNumber 
        { 
            get { return _machineNumber; }
            set 
            {
                _machineNumber = value;
                OnPropertyChanged("MachineNumber");
            }
        }

        public double GrossWeight
        {
            get { return _grossWeight;  }
            set
            {
                _grossWeight = value;
                OnPropertyChanged("GrossWeight");
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

        public double TareWeight 
        { 
            get { return _tareWeight; }
            set 
            { 
                _tareWeight = value; 
                OnPropertyChanged("TareWeight"); 
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

        public double NetWeight 
        { 
            get { return _netWeight; }
            set 
            { 
                _netWeight = value; 
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
