using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarinWorld
{
    public class ListViewItem : INotifyPropertyChanged
    {

        private string title;

        private string details;

        private string apiUrl;



        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        
        public string Details
        {
            get
            {
                return details;
            }
            set
            {
                details = value;
                OnPropertyChanged(nameof(Details));
            }
        }

        public string ApiUrl
        {
            get
            {
                return apiUrl;
            }
            set
            {
                apiUrl = value;
                OnPropertyChanged(nameof(ApiUrl));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return Title;
        }

    }
}
