using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestAssignment.ViewModels
{
    public class LineChartViewModel : INotifyPropertyChanged
    {
        private List<DateTimeOffset> _grossDates = new List<DateTimeOffset>();
        private List<double> _grossWeights = new List<double>();

        public List<DateTimeOffset> GrossDates
        { 
            get { return _grossDates; } 
            set 
            { 
                _grossDates = value; 
                OnPropertyChanged("GrossDates");
            } 
        }

        public List<double> GrossWeights
        {
            get { return _grossWeights; }
            set 
            {
                _grossWeights = value;
                OnPropertyChanged("GrossWeights");
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
