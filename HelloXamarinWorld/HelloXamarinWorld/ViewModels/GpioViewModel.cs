using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloXamarinWorld
{
    public class GpioViewModel : INotifyPropertyChanged
    {
        


        //public static List<ListViewItem> GpioPinList = new List<ListViewItem>
        //{
        //        new ListViewItem() { Title = "GPIO 11", Details = "Retrieve the state of GPIO 11", ApiUrl = string.Format(baseApiUrl, "gpio/11") },
        //        new ListViewItem() { Title = "GPIO 15", Details = "Retrieve the state of GPIO 15", ApiUrl = string.Format(baseApiUrl, "gpio/15") }
        //};


        private string pin;
        private string direction;
        private string val;
        private string edge;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Pin
        {
            get
            {
                return pin;
            }
            set
            {
                pin = value;
                OnPropertyChanged(nameof(Pin));
            }
        }

        public string Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
                OnPropertyChanged(nameof(Direction));
            }
        }

        public string Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public string Edge
        {
            get
            {
                return edge;
            }
            set
            {
                edge = value;
                OnPropertyChanged(nameof(Edge));
            }
        }


    }
}
