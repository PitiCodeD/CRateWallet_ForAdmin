using CRateWallet_ForAdmin.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CRateWallet_ForAdmin.ViewModels
{
    public class UserViewModels : INotifyPropertyChanged
    {
        public UserViewModels()
        {
            GoToHomePage = new Command(HomePageMethod);
        }

        public ICommand GoToHomePage { get; set; }
        private async void HomePageMethod()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TabbHome());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
