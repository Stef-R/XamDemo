using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Runtime.CompilerServices;

namespace SliderBinding 
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private double myValue = 1;

        public double MyValue
        {
            get
            {
                return myValue;
            }

            set
            {
                myValue = value;
                OnPropertyChangedEvent();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //    var handler = PropertyChanged;
        //    if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        //}

        private void OnPropertyChangedEvent([CallerMemberName] string propertyName="")
        {
            var ev = PropertyChanged;

            if (ev !=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
