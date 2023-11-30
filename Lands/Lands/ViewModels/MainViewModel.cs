namespace Lands.ViewModels
{
    using Lands.Models;
    using System.Collections.Generic;

    public class MainViewModel
    {
        #region ViewModels

        public LandViewModel Land { get; set; }
        public LandsViewModel Lands { get; set; }
        public LoginViewModel Login { get; set; }
        public TranslationsViewModel Translations { get; set; }

        #endregion

        #region Properties

        public List<Land> LandsList;

        #endregion

        #region Constructors

        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }

        #endregion

        #region Singleton

        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance.Equals(null))
            {
                return new MainViewModel();
            }
            return instance;
        }

        #endregion
    }
}