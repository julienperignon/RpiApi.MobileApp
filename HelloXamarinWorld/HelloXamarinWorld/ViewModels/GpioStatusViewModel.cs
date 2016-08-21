using RpiApi.MobileApp.Enums;
using RpiApi.MobileApp.EventHandlers;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RpiApi.MobileApp.ViewModels
{
    public class GpioStatusViewModel : INotifyPropertyChanged
    {
        [JsonIgnore]
        GpioPin selectedGpioPin;

        [JsonIgnore]
        public GpioPin SelectedGpioPin
        {
            get
            {
                return selectedGpioPin;
            }

            set
            {
                var oldValue = selectedGpioPin;
                selectedGpioPin = value;
                OnSelectedGpioPinChanged(oldValue, value);
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsGpioPinSelected));
                OnPropertyChanged(nameof(DisplayGpioDetails));
            }
        }


        GpioStatus gpioStatus;
        public GpioStatus GpioStatus
        {
            get
            {
                return gpioStatus;
            }
            set
            {
                gpioStatus = value;
                OnPropertyChanged();
            }
        }


        bool isRefreshing;
        public bool IsRefreshing
        {
            get
            {
                return isRefreshing;
            }
            set
            {
                isRefreshing = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayGpioDetails));
            }
        }

        public bool IsGpioPinSelected
        {
            get
            {
                return SelectedGpioPin != GpioPin.NONE;
            }

        }


        public bool DisplayGpioDetails
        {
            get
            {
                return !IsRefreshing && IsGpioPinSelected;
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static event SelectedGpioPinChangedHandler SelectedGpioPinChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public static void OnSelectedGpioPinChanged(GpioPin oldValue, GpioPin newValue) =>
            SelectedGpioPinChanged(null, new SelectedGpioPinChangedArgs(oldValue, newValue));





    }


}
