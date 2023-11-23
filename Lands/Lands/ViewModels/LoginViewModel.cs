namespace Lands.ViewModels
{
    using System;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isRunning { get; set; }
        public bool isRemembered { get; set; }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.isRemembered = true;
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Your must enter an email.",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Your must enter a password.",
                    "Accept");
                return;
            }
        }
        #endregion
    }
}