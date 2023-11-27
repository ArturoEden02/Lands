using Lands.Models;

namespace Lands.ViewModels
{
    public class LandViewModel : BaseViewModel
    {
        #region Properties

        public Land Land { get; set; }

        #endregion

        #region Constructor

        public LandViewModel(Land land)
        {
            this.Land = land;
        }

        #endregion
    }
}