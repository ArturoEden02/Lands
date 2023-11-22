namespace Lands.ViewModels
{
    using System;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;

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

        private void Login()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}