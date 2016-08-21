using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloXamarinWorld.ViewModels
{
    public class GpioStatus : INotifyPropertyChanged
    {

        private const string IN = "in";
        private const string OUT = "out";

        private string pin;
        private string direction;
        private string val;
        private string edge;

        public bool DirectionBool
        {
            get
            {
                return Direction == IN;
            }
            set
            {
                if (value)
                    Direction = IN;
                else
                    Direction = OUT;

                OnPropertyChanged();
            }
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
