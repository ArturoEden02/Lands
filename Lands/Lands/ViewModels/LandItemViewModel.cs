﻿namespace Lands.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Lands.Views;
    using Models;
    using Xamarin.Forms;

    public class LandItemViewModel : Land
    {
        #region Commands

        public ICommand SelectLandCommand
        {
            get
            {
                return new RelayCommand(SelectLand);
            }
        }

        #endregion

        #region Methods

        private async void SelectLand()
        {
            MainViewModel.GetInstance().Land = new LandViewModel(this);

            await Application.Current.MainPage.Navigation.PushAsync(new LandTabbedPage());
        }

        #endregion
    }
}