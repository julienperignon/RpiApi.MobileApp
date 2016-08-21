using Xamarin.Forms;
using RpiApi.MobileApp.ViewModels;
using RpiApi.MobileApp.Services;
using RpiApi.MobileApp.EventHandlers;

namespace RpiApi.MobileApp.Views
{
    public partial class GpioStatus : ContentPage
    {

        GpioService GpioService = new GpioService();

        public GpioStatus()
        {
            InitializeComponent();


            var vm = new GpioStatusViewModel();

            GpioStatusViewModel.SelectedGpioPinChanged += SelectedGpioPinChanged;

            BindingContext = vm;
          
        }


        private async void SelectedGpioPinChanged(object sender, SelectedGpioPinChangedArgs e)
        {
            if (e.ValueHasntChanged) return;
            ToggleLoading();
            
            (this.BindingContext as GpioStatusViewModel).GpioStatus= await GpioService.FetchGpioStatusAsync(e.NewValue);
            ToggleLoading();

        }

        private void ToggleLoading()
        {
            (this.BindingContext as GpioStatusViewModel).IsRefreshing = !(this.BindingContext as GpioStatusViewModel).IsRefreshing;
        }

      
    }
}
