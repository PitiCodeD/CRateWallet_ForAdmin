using CRateWallet_ForAdmin.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CRateWallet_ForAdmin.ViewModels
{
    public class PaymentViewModels : INotifyPropertyChanged
    {
        public PaymentViewModels()
        {
            GoToInPutTopUpPage = new Command(InPutTopUpPageMethod);
            GoBackPage = new Command(BackPageMethod);
            topUp = 0.00m;
        }

        private decimal topUp;

        public decimal TopUP
        {
            get
            {
                return topUp;
            }
            set
            {
                topUp = value;
                OnPropertyChanged(nameof(TopUP));
            }
        }


        public ICommand GoToInPutTopUpPage { get; set; }
        private async void InPutTopUpPageMethod()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InputTopUp());
        }

        public ICommand GoBackPage { get; set; }
        private async void BackPageMethod()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
